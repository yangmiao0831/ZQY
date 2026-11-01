using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using BrightIdeasSoftware;
using LibBase;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace Spark.Utils;

public class SigmaDownloadWin : UserControl
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLogin_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public SigmaDownloadWin _003C_003E4__this;

		public bool _003CloginSucc_003E5__1;

		private TaskAwaiter<bool> _003C_003Eu___0024awaiter2;

		private object _003C_003Et__stack;

		internal static object yn1IU1qHv2ayra8wsEdv;

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
		static _003CLogin_003Ed__0()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			yw2fn8qHUahHQkpEEHhs();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Ns3Bx3qHIgIlifIOMSNv(object P_0)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KQdQdIqHXblEZncrx10i(int P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool C6q1L8qHSREi27T0FivQ()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PhKU8pqHmaZyMYUHfZS5()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yw2fn8qHUahHQkpEEHhs()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CrefreshTokenTimer_Elapsed_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SigmaDownloadWin _003C_003E4__this;

		private TaskAwaiter _003C_003Eu___0024awaiter5;

		private object _003C_003Et__stack;

		private static object HBModhqHOiOmPjamSurf;

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
		static _003CrefreshTokenTimer_Elapsed_003Ed__4()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			xDN6BEqsLk3RvL5QckEV();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter YpNfDuqHz3bvg2y7Mjo3(object P_0)
		{
			return (TaskAwaiter)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool jrqhJXqH5B8X29Kswgfl()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rS60IiqHiebmhr9NsuYs()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void xDN6BEqsLk3RvL5QckEV()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadData_003Ed__b : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public SigmaDownloadWin _003C_003E4__this;

		public bool _003CloginSucc_003E5__c;

		public SigmaQueryFileListResponse _003Cresponse_003E5__d;

		public SigmaQueryFileListRequest _003C_003Eg__initLocal7;

		public TableConfig _003C_003Eg__initLocal8;

		public List<ColunmSort> _003C_003Eg__initLocal9;

		public ColunmSort _003C_003Eg__initLocala;

		private TaskAwaiter<bool> _003C_003Eu___0024awaitere;

		private object _003C_003Et__stack;

		private TaskAwaiter<SigmaQueryFileListResponse> _003C_003Eu___0024awaiterf;

		internal static object wTw3NKqsyr9pqXTjXT88;

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
		static _003CLoadData_003Ed__b()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oY9YseqsJf7PIMllDuMA(object P_0)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XORsn6qsMMGbJWlGuuJv(int P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void hIweMWqsKYJQUXdxSWrZ(object P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Q3nELlqsZISdIXT03hSD(object P_0, object P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MpdoCLqso9fwGaL8bRG8(object P_0, object P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BXw4Qsqs6Cue5iETNeQy()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BQHZIQqs2n6JEZZ0Ffit()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class qeX6mUTkIoCQybmeByQ
	{
		public List<int> Gw4Ec8DXLVa;

		public SigmaDownloadWin IDuEcU8NK4g;

		private static qeX6mUTkIoCQybmeByQ HSsmTQqsxRDCdgvwa1dK;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public qeX6mUTkIoCQybmeByQ()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void F0tEc9WGy60()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static qeX6mUTkIoCQybmeByQ()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			wBXiZpqsqmHhtNIyXKR4();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void zfAxRZqsWut0QyRJpjtM()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool e9NZLvqsAsXgeqQay2yV()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static qeX6mUTkIoCQybmeByQ TDRo3oqstnIkpUihV3r2()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Ko1ONlqsBMa03XM9kymV(object P_0, object P_1, object P_2)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void wBXiZpqsqmHhtNIyXKR4()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CfbRefresh_Click_003Ed__1d : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SigmaDownloadWin _003C_003E4__this;

		private TaskAwaiter _003C_003Eu___0024awaiter1e;

		private object _003C_003Et__stack;

		internal static object Jp7Q1KqsEYp3yuFOd9Hw;

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
		static _003CfbRefresh_Click_003Ed__1d()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kGrCotqspxoU1tLEbQWb(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ftmGhHqsV2JM0WS2JOJ4()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RNbCafqsT7WdfJTD81Ia()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CfbNext_Click_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SigmaDownloadWin _003C_003E4__this;

		private TaskAwaiter _003C_003Eu___0024awaiter21;

		private object _003C_003Et__stack;

		internal static object eqeQldqsQTDaFbCSjgIn;

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
		static _003CfbNext_Click_003Ed__20()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			A5GSR5qsFQ0inWEYEnpX();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ojIuQQqs3Ly2yqw27j7X(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool WSjC23qsRB8ggQQ2Ptiy()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GahiI6qsGLAuiIWPEpD4()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void A5GSR5qsFQ0inWEYEnpX()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CfbPrev_Click_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SigmaDownloadWin _003C_003E4__this;

		private TaskAwaiter _003C_003Eu___0024awaiter24;

		private object _003C_003Et__stack;

		private static object nh6niOqs7Of01N6FIjCA;

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
		static _003CfbPrev_Click_003Ed__23()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			Xo9iTdqseZ4Cwt3nrfJU();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GpVNvKqsfHV3SmfprgHZ(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaskAwaiter Coc6XAqsjMoPUe0jU9If(object P_0)
		{
			return (TaskAwaiter)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool cZZFYVqsbeIuCMPel4jS()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object eDhovCqsgs50H4rucSCH()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Xo9iTdqseZ4Cwt3nrfJU()
		{
		}
	}

	private FastObjectListView ncPeQIlpRF4;

	private List<SigmaDownloadFile> rD3eQQQPpLO;

	private Sigma_FileDownloadService AZgeQlnu0go;

	private int EnceQwWBsLf;

	private int SJ1eQp9Zr7o;

	private int W2eeQa8AMhL;

	private SigmaUserOBj X1TeQkX3eMM;

	private Timer AT0eQ06n1Fp;

	private IContainer zBWeQZcZvgk;

	private Panel MPjeQzMVnMh;

	private FlatButton ASfelC58SOp;

	private FlatButton p9velGKbrxo;

	private FlatButton MI5elRUrs9B;

	private FlatButton vXuelnCkYCO;

	private Label H7YelgYTqcr;

	[CompilerGenerated]
	private static AspectGetterDelegate dDXeleOvgCr;

	[CompilerGenerated]
	private static AspectGetterDelegate rIeelPPkEnT;

	[CompilerGenerated]
	private static AspectGetterDelegate h5EelE77G3D;

	internal static SigmaDownloadWin lUOu90tEB4w6h1NBaCx8;

	public bool IsLogin
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SigmaDownloadWin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLogin_003Ed__0))]
	[DebuggerStepThrough]
	private Task<bool> Login()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoginAndLoadData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void x1heQ3aXwxL()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CrefreshTokenTimer_Elapsed_003Ed__4))]
	private void X5DeQJT9bOR(object P_0, ElapsedEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoadData_003Ed__b))]
	[DebuggerStepThrough]
	private Task Vh3eQrIqsSD()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zfgeQ9PExwB(SigmaQueryFileListResponse P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void baHeQ8ZhiNC()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private double JvBeQUCUnu6(long P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FSoeQKOpalq(object P_0, PaintEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void wZieQtbnYCZ(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CfbRefresh_Click_003Ed__1d))]
	[DebuggerStepThrough]
	private void owHeQuZoqP7(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CfbNext_Click_003Ed__20))]
	private void GdEeQo7ISlp(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CfbPrev_Click_003Ed__23))]
	private void FoaeQjyJpHq(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void B5SeQ7RDD8h()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static object ClneQfZcyKl(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private object kWeeQDPfn58(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static object o2neQBHnLgk(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static object NNOeQSKsjPp(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void EEUeQmLiAAn(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SigmaDownloadWin()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		ARUcmTtV4VwbN9PKckDS();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool pcjrwMtEVyX8xUexIGsT(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jixFxttEqVtZPFUnc0Wl()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SigmaDownloadWin ujZ01etEEDcGWawKRrJI()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xV9vWGtETKWdrmpJajsa()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Prh1BDtEppp39K5eixZq(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uqDUGctEQLGTUo9iJGf0(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dgwbiOtERdK7lC09iLVS(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncVoidMethodBuilder ELHMM1tEGpyLFxsImkLZ()
	{
		return (AsyncVoidMethodBuilder)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder NxoXUbtE3FA55keb3BCF()
	{
		return (AsyncTaskMethodBuilder)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ocxnMgtEFLuDZQVh6BHB(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int QgTUQqtE7r7biDF5CP0Z(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object GO52SptEbvZVRgi75Q6d(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object khSmq3tEgKScfd472bHR(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GBD7aatEfkL2BN90Qi3y(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void asJUottEjxMhjXsDFO2L(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qxARuntEetjPH6eWb14H(object P_0, BorderStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rFkQADtE0SPklq400eEb(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fYmHSFtEPOqta7GvsbnT(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FuQdYDtEcpuxr4s9yvrO(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UvwP0RtE8fVfffKkGCgX(object P_0, ColumnHeaderStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void P997XRtEwqiYtlnVGRmP(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void quTnG8tEhtXOATat4WES(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color VK6YSdtE4cShkn5Y7MuW()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Tp6AMEtEryB9X3YUt57x(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ibirAQtEDrG8ydnIbdbK(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nGjLlptEdFDUbHSrZd6k(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KaWwP8tECCQD18HoCAis(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FTlJdBtEnUMmyf09vc90(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void znaYITtEaFqeC90a7ytQ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int OSYTtftEHSpD92KFKc4J(int P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eyvAZHtEsXoNCW5RHr2j(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WhS7kDtEluDdQkE4oUU1(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object HuK1EptE9jMDGDXh8f68(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HL7f5XtEkGh0opxSuS1S(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MnHpFTtE1wHrjgTFlohu(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SoTYewtEvZnMS2PnElyx(object P_0, object P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Hl6ZbdtESqtpV0HUr5Tu(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CEmnIVtEmZpchsVgQRWT(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O7YvJPtEIFNPkjwHvgXF(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void S0VX7ftEXHGXxkrBAr6J(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ipS9YjtEUd3v6LthhpAd(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vWe4SvtEO9nrWWLsb2HX(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CXZLLFtE5HOn3XNcO07F(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Lg11ZetEigGMj9NVivs0(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QOr88otEzDa414YXtRvP(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NJY65BtVLUQNdLjMwDyF(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yASLgPtVN0lsj8XvkC1e(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iEwB6ftVYT2Gh2vp082D(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EWBTomtVuqEdeFgW34Q1(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hKjI6ttVyCAQG22ZeGS2(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color gp97tQtV6VVd9ieEgH4p(int P_0, int P_1, int P_2)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SxS6oRtV2QcWAqI81Wvo(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Wa95nBtVJfFXuydmyAPn(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PlWLxgtVMKdsk7blWEik(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JiCdEbtVKV0wQLwX9RK3()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oj4Tn2tVZbxuZWcAXMiJ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TPuAd9tVov2rAM3G8oty(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HJ7JlStVxXsHQ3qcbafb(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pGy3OttVAXdqLAnT44u9(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rpyl0FtVtB7jxWjtFjLc(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Mv4JHqtVWZfyK3Q56SWF(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SiGJBstVBAca7LlZnr3u(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qVYrDBtVqnsgexF93faL(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MX1miftVETxvVhcwAXwp(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void E8bnLbtVVcOsGDG6W34I(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uc4UE0tVTsaj0jaRoLFj(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color Agqae4tVpB4e91WqAxah()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ARwKqEtVQ1f9A3FShjrW(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xkIXHgtVRKqfFaSToCqe(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qyHOgRtVGMQUJHIRYvgw(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vEfuPttV36AITtRNVjjn()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Sb4cjttVF9kDPuY2Hbyn(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Rj97xUtV7SH774OMIkbf(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JdVdKftVbdHclGMFxtAq(object P_0, ContentAlignment P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ep4SlVtVga6H52LIiheM(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void q6N8QQtVfigrhsFtYxRG(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Uvc8wltVj7YRZlwtbx3J(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MZmSxStVesOGSH4LYlXa(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HbPRRMtV00he7hA88Dce(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TimeSpan xvCJd1tVPPR5Lyw8xDgu(double P_0)
	{
		return (TimeSpan)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTimeOffset pSkadRtVcO8HkrmdBvim(long P_0)
	{
		return (DateTimeOffset)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DialogResult h6qFcjtV8JVHE6OJXoCb(object P_0, MessageBoxButtons btns)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (DialogResult)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Loq1QdtVw1nwUZWvNGyG(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void R7Y22CtVhxSV40spjLbO(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ARUcmTtV4VwbN9PKckDS()
	{
	}
}
