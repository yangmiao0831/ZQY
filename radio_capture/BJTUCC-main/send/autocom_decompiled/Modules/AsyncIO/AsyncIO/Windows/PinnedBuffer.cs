using System;
using System.Runtime.InteropServices;

namespace AsyncIO.Windows;

internal class PinnedBuffer : IDisposable
{
	private GCHandle m_handle;

	public byte[] Buffer { get; private set; }

	public long Address { get; private set; }

	public PinnedBuffer(byte[] buffer)
	{
		SetBuffer(buffer);
	}

	public void Switch(byte[] buffer)
	{
		m_handle.Free();
		SetBuffer(buffer);
	}

	private void SetBuffer(byte[] buffer)
	{
		Buffer = buffer;
		m_handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
		Address = Marshal.UnsafeAddrOfPinnedArrayElement((Array)Buffer, 0).ToInt64();
	}

	public void Dispose()
	{
		m_handle.Free();
		Buffer = null;
		Address = 0L;
	}
}
