using System.Runtime.InteropServices;

namespace LibUtils;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct TDCCommandInfo
{
	public uint Type;

	public uint Len;

	public byte[] Value;
}
