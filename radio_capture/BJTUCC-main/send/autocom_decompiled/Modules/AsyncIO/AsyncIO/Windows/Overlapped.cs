using System;
using System.Runtime.InteropServices;

namespace AsyncIO.Windows;

internal class Overlapped : IDisposable
{
	private static readonly int Size = IntPtr.Size * 4 + 8;

	private static readonly int BytesTransferredOffset = IntPtr.Size;

	private static readonly int OffsetOffset = IntPtr.Size * 2;

	private static readonly int EventOffset = IntPtr.Size * 2 + 8;

	private static readonly int ManagedOverlappedOffset = IntPtr.Size * 3 + 8;

	private IntPtr m_address;

	private GCHandle m_handle;

	private PinnedBuffer m_pinnedBuffer;

	public IntPtr Address => m_address;

	public long BufferAddress
	{
		get
		{
			if (m_pinnedBuffer == null)
			{
				return 0L;
			}
			return m_pinnedBuffer.Address;
		}
	}

	public OperationType OperationType { get; private set; }

	public Socket AsyncSocket { get; private set; }

	public bool Success { get; private set; }

	public bool InProgress { get; private set; }

	public bool Disposed { get; private set; }

	public object State { get; set; }

	public Overlapped(Socket asyncSocket)
	{
		Disposed = false;
		InProgress = false;
		AsyncSocket = asyncSocket;
		m_address = Marshal.AllocHGlobal(Size);
		Marshal.WriteIntPtr(m_address, IntPtr.Zero);
		Marshal.WriteIntPtr(m_address, BytesTransferredOffset, IntPtr.Zero);
		Marshal.WriteInt64(m_address, OffsetOffset, 0L);
		Marshal.WriteIntPtr(m_address, EventOffset, IntPtr.Zero);
		m_handle = GCHandle.Alloc(this, GCHandleType.Normal);
		Marshal.WriteIntPtr(m_address, ManagedOverlappedOffset, GCHandle.ToIntPtr(m_handle));
	}

	public void Dispose()
	{
		if (!InProgress)
		{
			Free();
		}
		Disposed = true;
	}

	private void Free()
	{
		Marshal.FreeHGlobal(m_address);
		if (m_handle.IsAllocated)
		{
			m_handle.Free();
		}
		if (m_pinnedBuffer != null)
		{
			m_pinnedBuffer.Dispose();
			m_pinnedBuffer = null;
		}
	}

	public void StartOperation(OperationType operationType)
	{
		StartOperation(operationType, null);
	}

	public void StartOperation(OperationType operationType, byte[] buffer)
	{
		InProgress = true;
		Success = false;
		OperationType = operationType;
		if (buffer != null)
		{
			if (m_pinnedBuffer == null)
			{
				m_pinnedBuffer = new PinnedBuffer(buffer);
			}
			else if (m_pinnedBuffer.Buffer != buffer)
			{
				m_pinnedBuffer.Switch(buffer);
			}
		}
	}

	public static Overlapped CompleteOperation(IntPtr overlappedAddress)
	{
		Overlapped overlapped = (Overlapped)GCHandle.FromIntPtr(Marshal.ReadIntPtr(overlappedAddress, ManagedOverlappedOffset)).Target;
		overlapped.InProgress = false;
		if (overlapped.Disposed)
		{
			overlapped.Free();
			overlapped.Success = false;
		}
		else
		{
			overlapped.Success = Marshal.ReadIntPtr(overlapped.m_address).Equals((object?)(nint)IntPtr.Zero);
		}
		return overlapped;
	}
}
