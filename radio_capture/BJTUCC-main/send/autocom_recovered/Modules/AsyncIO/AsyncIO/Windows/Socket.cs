using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;

namespace AsyncIO.Windows;

internal sealed class Socket : AsyncSocket
{
	private sealed class Connector
	{
		internal readonly ConnectExDelegate m_connectEx;

		public Connector(Socket socket)
		{
			m_connectEx = (ConnectExDelegate)socket.LoadDynamicMethod<ConnectExDelegate>(UnsafeMethods.WSAID_CONNECTEX);
		}
	}

	private sealed class Listener : IDisposable
	{
		private readonly Socket m_socket;

		internal readonly AcceptExDelegate m_acceptEx;

		private IntPtr m_acceptSocketBufferAddress;

		private int m_acceptSocketBufferSize;

		internal Socket m_acceptSocket;

		public Listener(Socket socket)
		{
			m_socket = socket;
			m_acceptEx = (AcceptExDelegate)m_socket.LoadDynamicMethod<AcceptExDelegate>(UnsafeMethods.WSAID_ACCEPT_EX);
		}

		~Listener()
		{
			Dispose(disposing: false);
		}

		public Socket GetAcceptedSocket()
		{
			return Interlocked.Exchange(ref m_acceptSocket, null);
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		public void AcceptInternal(AsyncSocket socket)
		{
			if (m_acceptSocketBufferAddress == IntPtr.Zero)
			{
				m_acceptSocketBufferSize = m_socket.m_boundAddress.Size + 16;
				m_acceptSocketBufferAddress = Marshal.AllocHGlobal(m_acceptSocketBufferSize << 1);
			}
			m_acceptSocket = socket as Socket;
			m_socket.m_inOverlapped.StartOperation(OperationType.Accept);
			if (!m_acceptEx(m_socket.Handle, m_acceptSocket.Handle, m_acceptSocketBufferAddress, 0, m_acceptSocketBufferSize, m_acceptSocketBufferSize, out var _, m_socket.m_inOverlapped.Address))
			{
				SocketError lastWin32Error = (SocketError)Marshal.GetLastWin32Error();
				if (lastWin32Error != SocketError.IOPending)
				{
					throw new SocketException((int)lastWin32Error);
				}
			}
			else
			{
				m_socket.CompletionPort.PostCompletionStatus(m_socket.m_inOverlapped.Address);
			}
		}

		private void Dispose(bool disposing)
		{
			if (m_acceptSocketBufferAddress != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(m_acceptSocketBufferAddress);
				m_acceptSocketBufferAddress = IntPtr.Zero;
			}
			if (m_acceptSocket != null)
			{
				m_acceptSocket.Dispose(disposing);
				m_acceptSocket = null;
			}
		}
	}

	private Overlapped m_inOverlapped;

	private Overlapped m_outOverlapped;

	private Connector m_connector;

	private Listener m_listener;

	private bool m_disposed;

	private SocketAddress m_boundAddress;

	private SocketAddress m_remoteAddress;

	public IntPtr Handle { get; private set; }

	public CompletionPort CompletionPort { get; private set; }

	public override IPEndPoint RemoteEndPoint
	{
		get
		{
			using SocketAddress socketAddress = new SocketAddress(base.AddressFamily, (base.AddressFamily == AddressFamily.InterNetwork) ? 16 : 28);
			int socketAddressSize = socketAddress.Size;
			if (UnsafeMethods.getpeername(Handle, socketAddress.Buffer, ref socketAddressSize) != SocketError.Success)
			{
				throw new SocketException();
			}
			return socketAddress.GetEndPoint();
		}
	}

	public override IPEndPoint LocalEndPoint
	{
		get
		{
			using SocketAddress socketAddress = new SocketAddress(base.AddressFamily, (base.AddressFamily == AddressFamily.InterNetwork) ? 16 : 28);
			int socketAddressSize = socketAddress.Size;
			if (UnsafeMethods.getsockname(Handle, socketAddress.Buffer, ref socketAddressSize) != SocketError.Success)
			{
				throw new SocketException();
			}
			return socketAddress.GetEndPoint();
		}
	}

	public Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
		: base(addressFamily, socketType, protocolType)
	{
		m_disposed = false;
		m_inOverlapped = new Overlapped(this);
		m_outOverlapped = new Overlapped(this);
		InitSocket();
	}

	static Socket()
	{
		using (new System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
		{
		}
	}

	~Socket()
	{
		Dispose(disposing: false);
	}

	private void Dispose(bool disposing)
	{
		if (!m_disposed)
		{
			m_disposed = true;
			m_inOverlapped.Dispose();
			m_outOverlapped.Dispose();
			if (Environment.OSVersion.Version.Major == 5)
			{
				UnsafeMethods.CancelIo(Handle);
			}
			else
			{
				UnsafeMethods.CancelIoEx(Handle, IntPtr.Zero);
			}
			if (UnsafeMethods.closesocket(Handle) != 0)
			{
				Marshal.GetLastWin32Error();
			}
			if (m_remoteAddress != null)
			{
				m_remoteAddress.Dispose();
				m_remoteAddress = null;
			}
			if (m_boundAddress != null)
			{
				m_boundAddress.Dispose();
				m_boundAddress = null;
			}
			if (m_listener != null)
			{
				m_listener.Dispose();
			}
		}
	}

	public override void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void InitSocket()
	{
		Handle = UnsafeMethods.WSASocket(base.AddressFamily, base.SocketType, base.ProtocolType, IntPtr.Zero, 0u, SocketConstructorFlags.WSA_FLAG_OVERLAPPED);
		if (Handle == UnsafeMethods.INVALID_HANDLE_VALUE)
		{
			throw new SocketException();
		}
	}

	private Delegate LoadDynamicMethod<T>(Guid guid)
	{
		IntPtr lpvOutBuffer = IntPtr.Zero;
		int lpcbBytesReturned = 0;
		if (UnsafeMethods.WSAIoctl(Handle, -939524090, ref guid, Marshal.SizeOf((object)guid), ref lpvOutBuffer, IntPtr.Size, ref lpcbBytesReturned, IntPtr.Zero, IntPtr.Zero) != 0)
		{
			throw new SocketException();
		}
		return Marshal.GetDelegateForFunctionPointer(lpvOutBuffer, typeof(T));
	}

	internal void SetCompletionPort(CompletionPort completionPort, object state)
	{
		CompletionPort = completionPort;
		m_inOverlapped.State = state;
		m_outOverlapped.State = state;
	}

	public override void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)
	{
		if (UnsafeMethods.setsockopt(Handle, optionLevel, optionName, optionValue, (optionValue != null) ? optionValue.Length : 0) == SocketError.SocketError)
		{
			throw new SocketException();
		}
	}

	public override void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue)
	{
		if (UnsafeMethods.setsockopt(Handle, optionLevel, optionName, ref optionValue, 4) == SocketError.SocketError)
		{
			throw new SocketException();
		}
	}

	public override void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue)
	{
		SetSocketOption(optionLevel, optionName, optionValue ? 1 : 0);
	}

	public override void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, object optionValue)
	{
		if (optionValue == null)
		{
			throw new ArgumentNullException("optionValue");
		}
		if (optionLevel == SocketOptionLevel.Socket && optionName == SocketOptionName.Linger)
		{
			if (!(optionValue is LingerOption lingerOption))
			{
				throw new ArgumentException("invalid option value", "optionValue");
			}
			if (lingerOption.LingerTime < 0 || lingerOption.LingerTime > 65535)
			{
				throw new ArgumentOutOfRangeException("optionValue.LingerTime");
			}
			SetLingerOption(lingerOption);
		}
		else if (optionLevel == SocketOptionLevel.IP && (optionName == SocketOptionName.AddMembership || optionName == SocketOptionName.DropMembership))
		{
			if (!(optionValue is MulticastOption mr))
			{
				throw new ArgumentException("optionValue");
			}
			SetMulticastOption(optionName, mr);
		}
		else
		{
			if (optionLevel != SocketOptionLevel.IPv6 || (optionName != SocketOptionName.AddMembership && optionName != SocketOptionName.DropMembership))
			{
				throw new ArgumentException("optionValue");
			}
			if (!(optionValue is IPv6MulticastOption mr2))
			{
				throw new ArgumentException("optionValue");
			}
			SetIPv6MulticastOption(optionName, mr2);
		}
	}

	private void SetIPv6MulticastOption(SocketOptionName optionName, IPv6MulticastOption mr)
	{
		IPv6MulticastRequest mreq = new IPv6MulticastRequest
		{
			MulticastAddress = mr.Group.GetAddressBytes(),
			InterfaceIndex = (int)mr.InterfaceIndex
		};
		if (UnsafeMethods.setsockopt(Handle, SocketOptionLevel.IPv6, optionName, ref mreq, IPv6MulticastRequest.Size) == SocketError.SocketError)
		{
			throw new SocketException();
		}
	}

	private int GetIP4Address(IPAddress ipAddress)
	{
		byte[] addressBytes = ipAddress.GetAddressBytes();
		return addressBytes[0] | (addressBytes[1] << 8) | (addressBytes[2] << 16) | (addressBytes[3] << 24);
	}

	private void SetMulticastOption(SocketOptionName optionName, MulticastOption mr)
	{
		IPMulticastRequest mreq = new IPMulticastRequest
		{
			MulticastAddress = GetIP4Address(mr.Group)
		};
		if (mr.LocalAddress != null)
		{
			mreq.InterfaceAddress = GetIP4Address(mr.LocalAddress);
		}
		else
		{
			int interfaceAddress = IPAddress.HostToNetworkOrder(mr.InterfaceIndex);
			mreq.InterfaceAddress = interfaceAddress;
		}
		if (UnsafeMethods.setsockopt(Handle, SocketOptionLevel.IPv6, optionName, ref mreq, IPv6MulticastRequest.Size) == SocketError.SocketError)
		{
			throw new SocketException();
		}
	}

	private void SetLingerOption(LingerOption lref)
	{
		Linger linger = new Linger
		{
			OnOff = (ushort)(lref.Enabled ? 1 : 0),
			Time = (ushort)lref.LingerTime
		};
		if (UnsafeMethods.setsockopt(Handle, SocketOptionLevel.Socket, SocketOptionName.Linger, ref linger, 4) == SocketError.SocketError)
		{
			throw new SocketException();
		}
	}

	public override void GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue)
	{
		int optionLength = ((optionValue != null) ? optionValue.Length : 0);
		if (UnsafeMethods.getsockopt(Handle, optionLevel, optionName, optionValue, ref optionLength) == SocketError.SocketError)
		{
			throw new SocketException();
		}
	}

	public override byte[] GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionLength)
	{
		byte[] array = new byte[optionLength];
		int optionLength2 = optionLength;
		if (UnsafeMethods.getsockopt(Handle, optionLevel, optionName, array, ref optionLength2) != SocketError.SocketError)
		{
			if (optionLength != optionLength2)
			{
				byte[] array2 = new byte[optionLength2];
				Buffer.BlockCopy(array, 0, array2, 0, optionLength2);
				array = array2;
			}
			return array;
		}
		throw new SocketException();
	}

	public override object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName)
	{
		if (optionLevel == SocketOptionLevel.Socket && optionName == SocketOptionName.Linger)
		{
			return GetLingerOpt();
		}
		if (optionLevel == SocketOptionLevel.IP && (optionName == SocketOptionName.AddMembership || optionName == SocketOptionName.DropMembership))
		{
			return GetMulticastOpt(optionName);
		}
		if (optionLevel == SocketOptionLevel.IPv6 && (optionName == SocketOptionName.AddMembership || optionName == SocketOptionName.DropMembership))
		{
			return GetIPv6MulticastOpt(optionName);
		}
		int optionValue = 0;
		int optionLength = 4;
		if (UnsafeMethods.getsockopt(Handle, optionLevel, optionName, out optionValue, ref optionLength) != SocketError.SocketError)
		{
			return optionValue;
		}
		throw new SocketException();
	}

	private object GetIPv6MulticastOpt(SocketOptionName optionName)
	{
		throw new NotImplementedException();
	}

	private object GetMulticastOpt(SocketOptionName optionName)
	{
		throw new NotImplementedException();
	}

	private object GetLingerOpt()
	{
		throw new NotImplementedException();
	}

	public override int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue)
	{
		int bytesTransferred = 0;
		if (UnsafeMethods.WSAIoctl_Blocking(Handle, (int)ioControlCode, optionInValue, (optionInValue != null) ? optionInValue.Length : 0, optionOutValue, (optionOutValue != null) ? optionOutValue.Length : 0, out bytesTransferred, IntPtr.Zero, IntPtr.Zero) != SocketError.SocketError)
		{
			return bytesTransferred;
		}
		throw new SocketException();
	}

	public override void Bind(IPEndPoint localEndPoint)
	{
		if (m_boundAddress != null)
		{
			m_boundAddress.Dispose();
			m_boundAddress = null;
		}
		m_boundAddress = new SocketAddress(localEndPoint.Address, localEndPoint.Port);
		if (UnsafeMethods.bind(Handle, m_boundAddress.Buffer, m_boundAddress.Size) != 0)
		{
			throw new SocketException();
		}
	}

	public override void Listen(int backlog)
	{
		if (UnsafeMethods.listen(Handle, backlog) != 0)
		{
			throw new SocketException();
		}
		m_listener = new Listener(this);
	}

	public override void Connect(IPEndPoint endPoint)
	{
		if (m_remoteAddress != null)
		{
			m_remoteAddress.Dispose();
			m_remoteAddress = null;
		}
		m_remoteAddress = new SocketAddress(endPoint.Address, endPoint.Port);
		if (m_boundAddress == null)
		{
			if (endPoint.AddressFamily == AddressFamily.InterNetwork)
			{
				Bind(new IPEndPoint(IPAddress.Any, 0));
			}
			else
			{
				Bind(new IPEndPoint(IPAddress.IPv6Any, 0));
			}
		}
		m_outOverlapped.StartOperation(OperationType.Connect);
		if ((m_connector ?? (m_connector = new Connector(this))).m_connectEx(Handle, m_remoteAddress.Buffer, m_remoteAddress.Size, IntPtr.Zero, 0, out var _, m_outOverlapped.Address))
		{
			CompletionPort.PostCompletionStatus(m_outOverlapped.Address);
			return;
		}
		SocketError lastWin32Error = (SocketError)Marshal.GetLastWin32Error();
		if (lastWin32Error == SocketError.IOPending)
		{
			return;
		}
		throw new SocketException((int)lastWin32Error);
	}

	internal void UpdateConnect()
	{
		SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.UpdateConnectContext, null);
	}

	public override AsyncSocket GetAcceptedSocket()
	{
		return m_listener.GetAcceptedSocket();
	}

	public override void Accept()
	{
		m_listener.AcceptInternal(new Socket(base.AddressFamily, base.SocketType, base.ProtocolType));
	}

	public override void Accept(AsyncSocket socket)
	{
		m_listener.AcceptInternal(socket);
	}

	internal void UpdateAccept()
	{
		byte[] optionValue = ((IntPtr.Size != 4) ? BitConverter.GetBytes(Handle.ToInt64()) : BitConverter.GetBytes(Handle.ToInt32()));
		m_listener.m_acceptSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.UpdateAcceptContext, optionValue);
	}

	public override void Send(byte[] buffer, int offset, int count, SocketFlags flags)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		m_outOverlapped.StartOperation(OperationType.Send, buffer);
		WSABuffer buffer2 = new WSABuffer
		{
			Pointer = new IntPtr(m_outOverlapped.BufferAddress + offset),
			Length = count
		};
		if (UnsafeMethods.WSASend(Handle, ref buffer2, 1, out var _, flags, m_outOverlapped.Address, IntPtr.Zero) != SocketError.Success)
		{
			SocketError lastWin32Error = (SocketError)Marshal.GetLastWin32Error();
			if (lastWin32Error != SocketError.IOPending)
			{
				throw new SocketException((int)lastWin32Error);
			}
		}
	}

	public override void Receive(byte[] buffer, int offset, int count, SocketFlags flags)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		m_inOverlapped.StartOperation(OperationType.Receive, buffer);
		WSABuffer buffer2 = new WSABuffer
		{
			Pointer = new IntPtr(m_inOverlapped.BufferAddress + offset),
			Length = count
		};
		if (UnsafeMethods.WSARecv(Handle, ref buffer2, 1, out var _, ref flags, m_inOverlapped.Address, IntPtr.Zero) != SocketError.Success)
		{
			SocketError lastWin32Error = (SocketError)Marshal.GetLastWin32Error();
			if (lastWin32Error != SocketError.IOPending)
			{
				throw new SocketException((int)lastWin32Error);
			}
		}
	}
}
