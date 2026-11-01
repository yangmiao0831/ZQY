using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class MOSPortInterface
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int MosLib_CallBack(int pParam, int DataType, string LogBuffer, int LogLen, ulong CuTime);

	public bool IsPortLost;

	private int KNpngkuTbpn;

	private byte[] C7Nng0puPPJ;

	public IntPtr Handle;

	private MosLib_CallBack MchngZf7tRE;

	private int hqMngzvSvwb;

	private int rMCneCM0Wtw;

	private int TTlneGR62qK;

	private int yNSneRlLTGY;

	private int jZBneniSsYH;

	private int Xt1negVoOFZ;

	private int EF5neeWjvCc;

	private int HC8nePwOEsd;

	private int gUXneEqhkLT;

	private static MOSPortInterface IExx0uJN70q9lK5snsoG;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string yXNngmQxUZe()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool InitPort(int channel, bool boundRate5299200)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ReOpenPort()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool UnInit()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool StartPlay(int vol, byte sampleIndex = 1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopPlay()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartRecord(string sFullFileName, int recSecond, int sampleRate)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopRecord(bool bFinish)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LineCtrl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int MosLibCallBack(int pParam, int DataType, string LogBuffer, int LogLen, ulong CuTime)
	{
		return 0;
	}

	[DllImport("libMOS.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "CreateMOSHandle")]
	private static extern IntPtr g2YngIXcGO2();

	[DllImport("libMOS.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "SetConfig")]
	private static extern int ntIngQ2IIqS(IntPtr P_0, int P_1, string P_2, int P_3);

	[DllImport("libMOS.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "OpenMOSPort")]
	private static extern int dVKnglcpXNS(IntPtr P_0);

	[DllImport("libMOS.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "SetMOSCallBack")]
	private static extern int h5Nngwipqn1(IntPtr P_0, MosLib_CallBack P_1, int P_2);

	[DllImport("libMOS.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "SendMOSCmd")]
	private static extern int IuFngpx0cyD(IntPtr P_0, int P_1, byte[] P_2, int P_3, byte[] P_4, ref int P_5);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	public int SendMOSCmd(IntPtr DeviceHandle, int CmdID, byte[] aCommandStr, int CmdLength, byte[] aCommandResponseStr, ref int pCmdResponseLength)
	{
		return 0;
	}

	[DllImport("libMOS.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	public static extern int CloseMOSPort(IntPtr DeviceHandle);

	[DllImport("libMOS.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "FreeMOSHandle")]
	private static extern int aEqngagymf1(IntPtr P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MOSPortInterface()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MOSPortInterface()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		XgGR6fJNnoUXGE2HMN6H();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qcg4QOJNfN54OZLDDe9l(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime q0pNkFJNjPI8ymWxgCFp()
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VYh4MHJNbqOF5EpRZm5K()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MOSPortInterface m4bmcSJNgGP1mtQUysaJ()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool BooxyyJNefDeZp6qIkxX(IntPtr P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HfbheEJN0V731RO4MHcH(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YXt2GcJNPqeG7BxsUiJr(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int jCZdWFJNcBDk2aHjru2B(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BDj2LLJN8sdjShkcTbj0(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object U1p1NXJNwBIfKFTchJkC()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aIJRDsJNhgjR0UjAUA53(object P_0, object P_1, int P_2, int P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rThiSOJN4Je7eDTX1C4W(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qIg3ObJNr5yxuMr5UbpE(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qHkdVYJNDcDjW8RSj8YL(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AEMbB4JNdsrsT8BFMxps(object P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AH0tb6JNC2iqHfdZFWZq()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void XgGR6fJNnoUXGE2HMN6H()
	{
	}
}
