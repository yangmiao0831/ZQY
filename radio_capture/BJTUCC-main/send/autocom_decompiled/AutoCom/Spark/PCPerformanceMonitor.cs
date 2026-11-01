using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using LibreHardwareMonitor.Hardware;
using tcEeYRHYMSOOr5xhr11;

namespace Spark;

public class PCPerformanceMonitor
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CStartMonitoringAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PCPerformanceMonitor _003C_003E4__this;

		public float[] _003CnetInitialValues_003E5__4;

		public float _003CcpuPercent_003E5__5;

		public float _003CinterruptPercent_003E5__6;

		public float _003CdpcPercent_003E5__7;

		public float _003CdiskTimePercent_003E5__8;

		public double _003CtotalBytes_003E5__9;

		public double _003CintervalMs_003E5__a;

		public double _003CinterruptMs_003E5__b;

		public double _003CdpcMs_003E5__c;

		public double _003CdiskTimeMs_003E5__d;

		public double _003CusedMem_003E5__e;

		private TaskAwaiter _003C_003Eu___0024awaiterf;

		private object _003C_003Et__stack;

		internal static object UdmN80qHexyJ8JdBqaXm;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine param0)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine param0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(param0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _003CStartMonitoringAsync_003Ed__3()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			M4Z9hEqHnII82o1vSJs7();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int oO9xHJqHcsIe1cDu7U3b(object P_0)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static float SrqIgaqH8Tg53gDE8RfR(object P_0)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static double qLrgHOqHwfCbyldifByw(double P_0, int P_1)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HardwareType gG02wDqHhNDkcRVFlQax(object P_0)
		{
			return (HardwareType)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SensorType zCct5tqH4tKrDplMO5i8(object P_0)
		{
			return (SensorType)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IHS7dAqHrD7LGxCOuaXm(object P_0)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TimeSpan NKpeO5qHDOJXObdvOqfS(double P_0)
		{
			return (TimeSpan)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XhErJYqHdNZNfDXOwudn(TimeSpan P_0, CancellationToken P_1)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter d2LOudqHCbCt6vlWpu5m(object P_0)
		{
			return (TaskAwaiter)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TCHg0nqH0b8ZHpNRTKlE()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mWAFOTqHPr2N3n0XTRO9()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void M4Z9hEqHnII82o1vSJs7()
		{
		}
	}

	private PerformanceMonitorInfo_OneMinitue XOdeIa61Nh2;

	private CancellationTokenSource ChneIkhc92I;

	private PerformanceCounter X5ceI0GwgCi;

	private PerformanceCounter xpWeIZ7PxZO;

	private PerformanceCounter ym0eIz5sTnN;

	private PerformanceCounter qD7eQCuuCQg;

	private List<PerformanceCounter> aReeQGCrqSG;

	private Computer wSPeQRN7Cd7;

	private bool VdjeQnB79Dn;

	internal static PCPerformanceMonitor vAnpL1tBk5kuJ2LnoXid;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PCPerformanceMonitor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void reCeIQ1ChGq()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Stop()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CStartMonitoringAsync_003Ed__3))]
	[DebuggerStepThrough]
	public Task StartMonitoringAsync()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string nkXeIlPeio1(double P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private double VHSeIwcNeNl()
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private double VyfeIpGgLZy()
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static PCPerformanceMonitor()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		Oas0hTtqKLPnmff7RAUk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pO7p5ItBSPunqXwLQCQJ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w3RohJtBmeoRkwibe849(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GCpsFftBIwkRTRQFBwoi(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int WCE5eetBX9Lw9x0OCK3x()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uTdsYYtBU66iv708KVL3(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object VWm9EitBOLYS0Fcggvon(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static float cxLE01tB5GroOG0QdhQh(object P_0)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool sgp4GDtB1AMH3bXl1gNi()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PCPerformanceMonitor gGQyY9tBvrdTa7p2uF7j()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SXahSbtBi9BxgBYKXMsL(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GBShKitBzwRCQvjNyVAd(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lNk1NLtqLlfZvyJ8uPjJ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object M7jWiYtqNq3UgYpIxt5a(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NP5p9ItqYxChylKj6yOY(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool vmkLEPtquXHfn9NQ8aQA(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool x1KjJAtqyXle4tWiQUk1(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GuKqiPtq6SAEXij2JsIn(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OCaNPKtq2NReJgQnafvT(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder CuwKDBtqJY39Pg2L5b1c()
	{
		return (AsyncTaskMethodBuilder)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rChmyFtqMLhiAuHTg4Gx(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Oas0hTtqKLPnmff7RAUk()
	{
	}
}
