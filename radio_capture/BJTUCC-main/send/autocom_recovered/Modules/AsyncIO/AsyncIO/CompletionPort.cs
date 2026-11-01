using System;
using AsyncIO.DotNet;
using AsyncIO.Windows;

namespace AsyncIO;

public abstract class CompletionPort : IDisposable
{
	public static CompletionPort Create()
	{
		if (Environment.OSVersion.Platform != PlatformID.Win32NT || ForceDotNet.Forced)
		{
			return new AsyncIO.DotNet.CompletionPort();
		}
		return new AsyncIO.Windows.CompletionPort();
	}

	public abstract void Dispose();

	public abstract bool GetQueuedCompletionStatus(int timeout, out CompletionStatus completionStatus);

	public abstract bool GetMultipleQueuedCompletionStatus(int timeout, CompletionStatus[] completionStatuses, out int removed);

	public abstract void AssociateSocket(AsyncSocket socket, object state = null);

	public abstract void Signal(object state);
}
