using System;
using System.Net;
using System.Net.Sockets;
using AsyncIO.DotNet;
using AsyncIO.Windows;

namespace AsyncIO;

public abstract class AsyncSocket : IDisposable
{
	private SocketOptionName IPv6Only = SocketOptionName.IPv6Only;

	public AddressFamily AddressFamily { get; private set; }

	public SocketType SocketType { get; private set; }

	public ProtocolType ProtocolType { get; private set; }

	public abstract IPEndPoint LocalEndPoint { get; }

	public abstract IPEndPoint RemoteEndPoint { get; }

	public bool NoDelay
	{
		get
		{
			return (int)GetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.Debug) != 0;
		}
		set
		{
			SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.Debug, value ? 1 : 0);
		}
	}

	public bool ExclusiveAddressUse
	{
		get
		{
			return (int)GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ExclusiveAddressUse) != 0;
		}
		set
		{
			SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ExclusiveAddressUse, value ? 1 : 0);
		}
	}

	public bool DualMode
	{
		get
		{
			if (AddressFamily != AddressFamily.InterNetworkV6)
			{
				throw new NotSupportedException("invalid version");
			}
			return (int)GetSocketOption(SocketOptionLevel.IPv6, IPv6Only) == 0;
		}
		set
		{
			if (AddressFamily != AddressFamily.InterNetworkV6)
			{
				throw new NotSupportedException("invalid version");
			}
			SetSocketOption(SocketOptionLevel.IPv6, IPv6Only, (!value) ? 1 : 0);
		}
	}

	public int ReceiveBufferSize
	{
		get
		{
			return (int)GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveBuffer);
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveBuffer, value);
		}
	}

	public int SendBufferSize
	{
		get
		{
			return (int)GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendBuffer);
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendBuffer, value);
		}
	}

	public LingerOption LingerState
	{
		get
		{
			return (LingerOption)GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger);
		}
		set
		{
			SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger, value);
		}
	}

	public bool EnableBroadcast
	{
		get
		{
			return (int)GetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast) != 0;
		}
		set
		{
			SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, value ? 1 : 0);
		}
	}

	public bool MulticastLoopback
	{
		get
		{
			if (AddressFamily == AddressFamily.InterNetwork)
			{
				return (int)GetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastLoopback) != 0;
			}
			if (AddressFamily != AddressFamily.InterNetworkV6)
			{
				throw new NotSupportedException("invalid version");
			}
			return (int)GetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.MulticastLoopback) != 0;
		}
		set
		{
			if (AddressFamily == AddressFamily.InterNetwork)
			{
				SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastLoopback, value ? 1 : 0);
				return;
			}
			if (AddressFamily != AddressFamily.InterNetworkV6)
			{
				throw new NotSupportedException("invalid version");
			}
			SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.MulticastLoopback, value ? 1 : 0);
		}
	}

	public short Ttl
	{
		get
		{
			if (AddressFamily == AddressFamily.InterNetwork)
			{
				return (short)(int)GetSocketOption(SocketOptionLevel.IP, SocketOptionName.ReuseAddress);
			}
			if (AddressFamily == AddressFamily.InterNetworkV6)
			{
				return (short)(int)GetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.ReuseAddress);
			}
			throw new NotSupportedException("invalid version");
		}
		set
		{
			if (value < 0 || value > 255)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (AddressFamily == AddressFamily.InterNetwork)
			{
				SetSocketOption(SocketOptionLevel.IP, SocketOptionName.ReuseAddress, value);
				return;
			}
			if (AddressFamily != AddressFamily.InterNetworkV6)
			{
				throw new NotSupportedException("invalid version");
			}
			SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.ReuseAddress, value);
		}
	}

	internal AsyncSocket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
	{
		AddressFamily = addressFamily;
		SocketType = socketType;
		ProtocolType = protocolType;
	}

	public static AsyncSocket Create(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
	{
		if (Environment.OSVersion.Platform != PlatformID.Win32NT || ForceDotNet.Forced)
		{
			return new NativeSocket(addressFamily, socketType, protocolType);
		}
		return new AsyncIO.Windows.Socket(addressFamily, socketType, protocolType);
	}

	public static AsyncSocket CreateIPv4Tcp()
	{
		return Create(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
	}

	public static AsyncSocket CreateIPv6Tcp()
	{
		return Create(AddressFamily.InterNetworkV6, SocketType.Stream, ProtocolType.Tcp);
	}

	public abstract void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue);

	public abstract void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue);

	public abstract void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, object optionValue);

	public abstract void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue);

	public abstract object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName);

	public abstract void GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, byte[] optionValue);

	public abstract byte[] GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionLength);

	public abstract int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue);

	public abstract void Dispose();

	public abstract void Bind(IPEndPoint localEndPoint);

	public abstract void Listen(int backlog);

	public abstract void Connect(IPEndPoint endPoint);

	[Obsolete("Use Accept without parameter and GetAcceptedSocket")]
	public abstract void Accept(AsyncSocket socket);

	public abstract void Accept();

	public abstract AsyncSocket GetAcceptedSocket();

	public abstract void Send(byte[] buffer, int offset, int count, SocketFlags flags);

	public abstract void Receive(byte[] buffer, int offset, int count, SocketFlags flags);
}
