using System;

namespace AsyncIO.Windows;

internal struct WSABuffer
{
	internal int Length;

	internal IntPtr Pointer;
}
