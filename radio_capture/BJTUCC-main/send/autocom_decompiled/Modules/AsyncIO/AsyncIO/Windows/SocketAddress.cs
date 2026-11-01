using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace AsyncIO.Windows;

internal class SocketAddress : IDisposable
{
	private byte[] m_buffer;

	private AddressFamily m_addressFamily;

	private bool m_disposed;

	private GCHandle m_bufferHandle;

	private IntPtr m_bufferAddress;

	public int Size { get; private set; }

	public IntPtr PinnedAddressBuffer => m_bufferAddress;

	public byte[] Buffer => m_buffer;

	public SocketAddress(AddressFamily addressFamily, int size)
	{
		Size = size;
		m_addressFamily = addressFamily;
		m_buffer = new byte[size];
		m_buffer = new byte[(size / IntPtr.Size + 2) * IntPtr.Size];
		m_buffer[0] = (byte)addressFamily;
		m_buffer[1] = (byte)((uint)addressFamily >> 8);
		m_bufferHandle = GCHandle.Alloc(m_buffer, GCHandleType.Pinned);
		m_bufferAddress = Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_buffer, 0);
	}

	public SocketAddress(IPAddress ipAddress)
		: this(ipAddress.AddressFamily, (ipAddress.AddressFamily == AddressFamily.InterNetwork) ? 16 : 28)
	{
		m_buffer[2] = 0;
		m_buffer[3] = 0;
		if (ipAddress.AddressFamily == AddressFamily.InterNetworkV6)
		{
			m_buffer[4] = 0;
			m_buffer[5] = 0;
			m_buffer[6] = 0;
			m_buffer[7] = 0;
			long scopeId = ipAddress.ScopeId;
			m_buffer[24] = (byte)scopeId;
			m_buffer[25] = (byte)(scopeId >> 8);
			m_buffer[26] = (byte)(scopeId >> 16);
			m_buffer[27] = (byte)(scopeId >> 24);
			byte[] addressBytes = ipAddress.GetAddressBytes();
			for (int i = 0; i < addressBytes.Length; i++)
			{
				m_buffer[8 + i] = addressBytes[i];
			}
		}
		else
		{
			System.Buffer.BlockCopy(ipAddress.GetAddressBytes(), 0, m_buffer, 4, 4);
		}
	}

	public IPEndPoint GetEndPoint()
	{
		return new IPEndPoint(GetIPAddress(), ((Buffer[2] << 8) & 0xFF00) | Buffer[3]);
	}

	internal IPAddress GetIPAddress()
	{
		if (m_addressFamily == AddressFamily.InterNetworkV6)
		{
			byte[] array = new byte[16];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Buffer[i + 8];
			}
			long scopeid = (Buffer[27] << 24) + (Buffer[26] << 16) + (Buffer[25] << 8) + Buffer[24];
			return new IPAddress(array, scopeid);
		}
		if (m_addressFamily == AddressFamily.InterNetwork)
		{
			return new IPAddress(((Buffer[4] & 0xFF) | ((Buffer[5] << 8) & 0xFF00) | ((Buffer[6] << 16) & 0xFF0000) | (Buffer[7] << 24)) & 0xFFFFFFFFu);
		}
		throw new SocketException(10047);
	}

	public SocketAddress(IPAddress ipAddress, int port)
		: this(ipAddress)
	{
		m_buffer[2] = (byte)(port >> 8);
		m_buffer[3] = (byte)port;
	}

	public void Dispose()
	{
		if (!m_disposed)
		{
			m_disposed = true;
			m_bufferHandle.Free();
		}
	}
}
