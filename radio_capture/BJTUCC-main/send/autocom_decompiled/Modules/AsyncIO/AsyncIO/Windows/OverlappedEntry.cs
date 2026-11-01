using System;

namespace AsyncIO.Windows;

internal struct OverlappedEntry
{
	public IntPtr CompletionKey;

	public IntPtr Overlapped;

	public IntPtr Internal;

	public int BytesTransferred;
}
