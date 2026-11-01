using System.Runtime.InteropServices;

namespace AsyncIO.Windows;

internal struct IPv6MulticastRequest
{
	internal static readonly int Size;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	internal byte[] MulticastAddress;

	internal int InterfaceIndex;

	static IPv6MulticastRequest()
	{
		Size = Marshal.SizeOf(typeof(IPv6MulticastRequest));
	}
}
