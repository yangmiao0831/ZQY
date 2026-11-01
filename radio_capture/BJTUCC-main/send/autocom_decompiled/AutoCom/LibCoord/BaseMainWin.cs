using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Spark;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class BaseMainWin : BaseWin
{
	private EventHandler FKNRcmM0dc0;

	public ProgressInfo CurProgressInfo;

	public OpenLogfileWin openLogfileWin;

	public EQConfig eqConfig;

	internal static BaseMainWin bna13w6ode0b6gWZXwLA;

	public event EventHandler OnDisconnect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateProgress(ProgressInfo progress)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DoAutoTestCmd(AutoTestCmdEnum cmdEnum, int? eqIndex = null, AutoTestCmd cmd = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DoLoggingSwitchByScript(IntPtr socketHandle, string sName, string sPath = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DoOnlyStartLog(bool isDTLog, string sName, string sDesc, string sPath = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DoOnlyStartTemp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DoOnlyStopLog()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DoAutoTestStartOneLog(EQObj eq, string sName, string sPath = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DoAutoTestStopOneLog(EQObj eq)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DoRefreshCurTasks(int eqIdx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DoPadStartLog(string sDesc)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Point GetShowAreaLocationWithScale1()
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Point GetShowAreaLocationWithScale1_BeforeMainWinShown()
	{
		return (Point)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Size GetShowAreaSizeWithScale1()
	{
		return (Size)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Size GetShowAreaSizeWithScale1_BeforeMainWinShown()
	{
		return (Size)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void RaiseOnDisconnect()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BaseMainWin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseMainWin()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YBGXh56oayckBhCjIou6(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool z3eZgl6oCr5dh38fNYu0()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BaseMainWin Fjqlo96onFRtGqbbTR9t()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MbSgF06oHkhW32ZUUQQI()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Rectangle VM3b3I6osM22NAGrlPUU(object P_0)
	{
		return (Rectangle)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void u6M7Gv6olbwPOap5fa68(object P_0, object P_1, object P_2)
	{
	}
}
