using System;
using System.Runtime.InteropServices;

namespace LibUtils;

public class POLQAInterface_Org
{
	private const string DLLName = "PolqaOem.dll";

	private const int POLQA_DEF = 0;

	private const int POLQA_RLEVEL1 = 256;

	private const int POLQA_RLEVEL2 = 512;

	private const int POLQA_RLEVEL3 = 1024;

	private const int POLQA_RLEVEL_ALL = 1792;

	private const int POLQA_LEVEL_ALIGN = 4096;

	private const int POLQA_AUTO_SR_CONVERSION_OFF = 8192;

	private const int POLQA_LC_STANDARD_IRS = 2;

	private const int POLQA_LC_SWIDE_H = 3;

	private const int POLQA_HA_MODE = 16384;

	private const int POLQA_HA_OMP = 32768;

	private const int POLQA_V1_1 = 65536;

	private const int POLQA_V2_4 = 131072;

	private const int POLQA_V3 = 196608;

	public static uint InitPOLQA(string licenseFile, POLQASWBENUM polqaSWB)
	{
		uint num = 0u;
		num |= 0x100;
		num |= 0x2000;
		num = ((polqaSWB != POLQASWBENUM.NB) ? (num | 3) : (num | 2));
		num |= 0x20000;
		uint PolqaHandle = 0u;
		PolqaLibInit(ref PolqaHandle, licenseFile, num);
		return PolqaHandle;
	}

	[DllImport("PolqaOem.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int PolqaLibInit(ref uint PolqaHandle, string LicenseFilename, uint ulMode);

	[DllImport("PolqaOem.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int PolqaLibRun(uint PolqaHandle, int mRefSamples, ref float RefData, uint ulRefSampleRate, int mDegSamples, ref float DegData, uint ulDegSampleRate);

	[DllImport("PolqaOem.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern IntPtr PolqaLibGetResultsPointer(uint PolqaHandle);

	[DllImport("PolqaOem.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern double PolqaLibGetSecondsToWait(uint PolqaHandle);

	[DllImport("PolqaOem.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int PolqaLibFree(ref uint PolqaHandle);
}
