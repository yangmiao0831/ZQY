using System.Runtime.InteropServices;

namespace AsyncIO.Windows;

internal struct IPMulticastRequest
{
	internal static readonly int Size;

	internal int MulticastAddress;

	internal int InterfaceAddress;

	static IPMulticastRequest()
	{
		Size = Marshal.SizeOf(typeof(IPMulticastRequest));
	}
}
