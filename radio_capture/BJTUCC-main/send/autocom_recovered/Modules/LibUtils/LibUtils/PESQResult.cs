using System.Runtime.InteropServices;

namespace LibUtils;

public struct PESQResult
{
	public int Nutterances;

	public int Largest_uttsize;

	public int Nsurf_samples;

	public int Crude_DelayEst;

	public float Crude_DelayConf;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
	public int[] UttSearch_Start;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
	public int[] UttSearch_End;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
	public int[] Utt_DelayEst;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
	public int[] Utt_Delay;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
	public float[] Utt_DelayConf;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
	public int[] Utt_Start;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
	public int[] Utt_End;

	public float pesq_mos;

	public float mapped_mos;

	public short mode;

	public int Result;
}
