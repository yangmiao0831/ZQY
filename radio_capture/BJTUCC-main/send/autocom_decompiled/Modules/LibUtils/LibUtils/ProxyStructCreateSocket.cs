using System.Runtime.InteropServices;

namespace LibUtils;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct ProxyStructCreateSocket
{
	public int Flag;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
	public string Address;

	public int Port;

	public int Type;
}
