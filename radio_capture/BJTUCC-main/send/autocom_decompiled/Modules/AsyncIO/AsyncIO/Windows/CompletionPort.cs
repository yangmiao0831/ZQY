using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace AsyncIO.Windows;

internal class CompletionPort : AsyncIO.CompletionPort
{
	private readonly IntPtr m_completionPortHandle;

	private readonly IntPtr InvalidCompletionPort = IntPtr.Zero;

	private readonly IntPtr InvalidCompletionPortMinusOne = new IntPtr(-1);

	private readonly IntPtr SignalPostCompletionKey = new IntPtr(1);

	private readonly IntPtr SocketCompletionKey = new IntPtr(2);

	private readonly IntPtr SocketManualCompletionKey = new IntPtr(3);

	private const int WaitTimeoutError = 258;

	private const SocketError ConnectionAborted = (SocketError)1236;

	private const SocketError NetworkNameDeleted = (SocketError)64;

	private bool m_disposed;

	private ConcurrentQueue<object> m_signalQueue;

	private OverlappedEntry[] m_overlappedEntries;

	private GCHandle m_overlappedEntriesHandle;

	private IntPtr m_overlappedEntriesAddress;

	public CompletionPort()
	{
		m_completionPortHandle = UnsafeMethods.CreateIoCompletionPort(UnsafeMethods.INVALID_HANDLE_VALUE, InvalidCompletionPort, IntPtr.Zero, 1u);
		if (m_completionPortHandle == InvalidCompletionPort || m_completionPortHandle == InvalidCompletionPortMinusOne)
		{
			throw new Win32Exception();
		}
		m_signalQueue = new ConcurrentQueue<object>();
	}

	~CompletionPort()
	{
		Dispose();
	}

	public override void AssociateSocket(AsyncSocket socket, object state)
	{
		if (!(socket is Socket))
		{
			throw new ArgumentException("socket must be of type Windows.Socket", "socket");
		}
		Socket socket2 = socket as Socket;
		if (socket2.CompletionPort != this)
		{
			IntPtr intPtr = UnsafeMethods.CreateIoCompletionPort(socket2.Handle, m_completionPortHandle, SocketCompletionKey, 0u);
			if (intPtr == InvalidCompletionPort || intPtr == InvalidCompletionPortMinusOne)
			{
				throw new Win32Exception();
			}
		}
		socket2.SetCompletionPort(this, state);
	}

	internal void PostCompletionStatus(IntPtr overlapped)
	{
		UnsafeMethods.PostQueuedCompletionStatus(m_completionPortHandle, 0, SocketManualCompletionKey, overlapped);
	}

	public override bool GetMultipleQueuedCompletionStatus(int timeout, CompletionStatus[] completionStatuses, out int removed)
	{
		if (Environment.OSVersion.Version.Major == 5)
		{
			removed = 0;
			CompletionStatus completionStatus;
			bool queuedCompletionStatus = GetQueuedCompletionStatus(timeout, out completionStatus);
			if (queuedCompletionStatus)
			{
				completionStatuses[0] = completionStatus;
				removed = 1;
			}
			return queuedCompletionStatus;
		}
		if (m_overlappedEntries == null || m_overlappedEntries.Length < completionStatuses.Length)
		{
			if (m_overlappedEntries != null)
			{
				m_overlappedEntriesHandle.Free();
			}
			m_overlappedEntries = new OverlappedEntry[completionStatuses.Length];
			m_overlappedEntriesHandle = GCHandle.Alloc(m_overlappedEntries, GCHandleType.Pinned);
			m_overlappedEntriesAddress = Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_overlappedEntries, 0);
		}
		if (!UnsafeMethods.GetQueuedCompletionStatusEx(m_completionPortHandle, m_overlappedEntriesAddress, completionStatuses.Length, out removed, timeout, alertable: false))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error == 258)
			{
				removed = 0;
				return false;
			}
			throw new Win32Exception(lastWin32Error);
		}
		for (int i = 0; i < removed; i++)
		{
			HandleCompletionStatus(out completionStatuses[i], m_overlappedEntries[i].Overlapped, m_overlappedEntries[i].CompletionKey, m_overlappedEntries[i].BytesTransferred);
		}
		return true;
	}

	public override bool GetQueuedCompletionStatus(int timeout, out CompletionStatus completionStatus)
	{
		if (!UnsafeMethods.GetQueuedCompletionStatus(m_completionPortHandle, out var numberOfBytes, out var completionKey, out var overlapped, timeout) && overlapped == IntPtr.Zero)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error == 258)
			{
				completionStatus = default(CompletionStatus);
				return false;
			}
			throw new Win32Exception(lastWin32Error);
		}
		HandleCompletionStatus(out completionStatus, overlapped, completionKey, numberOfBytes);
		return true;
	}

	private void HandleCompletionStatus(out CompletionStatus completionStatus, IntPtr overlappedAddress, IntPtr completionKey, int bytesTransferred)
	{
		if (completionKey.Equals((object?)(nint)SignalPostCompletionKey))
		{
			m_signalQueue.TryDequeue(out var result);
			completionStatus = new CompletionStatus(null, result, OperationType.Signal, SocketError.Success, 0);
			return;
		}
		Overlapped overlapped = Overlapped.CompleteOperation(overlappedAddress);
		if (completionKey.Equals((object?)(nint)SocketCompletionKey))
		{
			if (overlapped.Success)
			{
				SocketError socketError = SocketError.Success;
				try
				{
					if (overlapped.OperationType == OperationType.Accept)
					{
						overlapped.AsyncSocket.UpdateAccept();
					}
					else if (overlapped.OperationType == OperationType.Connect)
					{
						overlapped.AsyncSocket.UpdateConnect();
					}
				}
				catch (SocketException ex)
				{
					socketError = ex.SocketErrorCode;
				}
				completionStatus = new CompletionStatus(overlapped.AsyncSocket, overlapped.State, overlapped.OperationType, socketError, bytesTransferred);
			}
			else
			{
				SocketError socketError2 = SocketError.Success;
				SocketFlags socketFlags;
				if (overlapped.Disposed)
				{
					socketError2 = SocketError.OperationAborted;
				}
				else if (!UnsafeMethods.WSAGetOverlappedResult(overlapped.AsyncSocket.Handle, overlappedAddress, out bytesTransferred, wait: false, out socketFlags))
				{
					socketError2 = (SocketError)Marshal.GetLastWin32Error();
				}
				completionStatus = new CompletionStatus(overlapped.AsyncSocket, overlapped.State, overlapped.OperationType, socketError2, bytesTransferred);
			}
		}
		else
		{
			completionStatus = new CompletionStatus(overlapped.AsyncSocket, overlapped.State, overlapped.OperationType, SocketError.Success, 0);
		}
	}

	public override void Signal(object state)
	{
		m_signalQueue.Enqueue(state);
		UnsafeMethods.PostQueuedCompletionStatus(m_completionPortHandle, 0, SignalPostCompletionKey, IntPtr.Zero);
	}

	public override void Dispose()
	{
		if (!m_disposed)
		{
			m_disposed = true;
			if (m_overlappedEntries != null)
			{
				m_overlappedEntries = null;
				m_overlappedEntriesHandle.Free();
			}
			UnsafeMethods.CloseHandle(m_completionPortHandle);
			GC.SuppressFinalize(this);
		}
	}
}
