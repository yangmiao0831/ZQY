using System.Runtime.InteropServices;

namespace ZafTools;

public struct MsgData
{
	public int Size;

	[MarshalAs(UnmanagedType.LPStr)]
	public string taskCmd;
}
