using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class FileDownloadProgress : BaseWin
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDownloadFileAsync_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FileDownloadProgress _003C_003E4__this;

		public string url;

		public string destinationPath;

		public HttpClient _003Cclient_003E5__1;

		public HttpResponseMessage _003Cresponse_003E5__2;

		public long? _003CcontentLength_003E5__3;

		public Stream _003CcontentStream_003E5__4;

		public Stream _003CfileStream_003E5__5;

		public byte[] _003Cbuffer_003E5__6;

		public long _003CtotalBytesRead_003E5__7;

		public int _003CbytesRead_003E5__8;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu___0024awaiter9;

		private object _003C_003Et__stack;

		private TaskAwaiter<Stream> _003C_003Eu___0024awaitera;

		private TaskAwaiter _003C_003Eu___0024awaiterb;

		private TaskAwaiter<int> _003C_003Eu___0024awaiterc;

		internal static object Up2xO5BSNnbvs4KMYlZb;

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
		static _003CDownloadFileAsync_003Ed__0()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			vEu19nBSt8usgrw554IT();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PkaJqlBSyqZX3d4SJDfX(object P_0)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object vCOcFfBS6wjiqbSHGMKp(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CPKlQxBS2QE5cCtqiP3W(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object thBC6vBSJKON0IbvfDPG(int P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object O1pru5BSMly5GaeHoiyf(object P_0, object P_1)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void poZpKeBSKCeGcPPFocop(object P_0, object P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void QAryovBSZObIS4URkUSl(object P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HttpStatusCode jrUK1kBSoNxb08jMmCGH(object P_0)
		{
			return (HttpStatusCode)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wXEtB2BSxBnYLe4JvJks()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kTiOArBSAFiSbd3pxZxI(object P_0, object P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool m1SuAJBSYrFTyrfLWwGw()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nSV01qBSuAbsnih445qj()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vEu19nBSt8usgrw554IT()
		{
		}
	}

	private string b0jGNMoykY7;

	public int HttpErrorStatusCode;

	private IContainer JORGN5cti6D;

	private ProgressBar ygfGNT73Msr;

	private Label qh4GNxMVB6c;

	public Label lblTotal;

	internal static FileDownloadProgress c216Q9uW1JPOOPJ6Pm8k;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FileDownloadProgress(string title)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AF4GNVreNMG(object P_0, FormClosingEventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fZHGNXAD4je(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void K2FGN2reRsy(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDownloadFileAsync_003Ed__0))]
	[DebuggerStepThrough]
	public Task DownloadFileAsync(string url, string destinationPath)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WnmGNOJ9lkq()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static FileDownloadProgress()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		NgkGCSuBAn3hTpuM7vXC();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hM9T8LuWmfiuFaNgWYRf()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool uBmFMLuWI88EK5BwBb7E()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AKOofkuWXIL5URxuwjht(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yb886fuWU3UMif2eYZSk(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fmnsuuuWOMrAHyl7BTd0(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qgyClluWvcS1GFookctN()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FileDownloadProgress RAP1DQuWStepfvIF6oEZ()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void z0FR9QuW5e7Y5CMBU6Zg(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ckGdpNuWiEybVTgZjaWy(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QwkhdWuWzK8EuASFWbFm(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void H3S0d7uBLnjhG5t92c7F(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void STlAjYuBNIMBTGdvR2Ef(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CV6eG3uBY3MrrLwpIGbV(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sw35NquBuMKTK7kLHf72(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BxIRBnuBys5k1KM7WfQP(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gds9euuB6v1qkWCV9m3v(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void C29DwfuB2UuSaZZeK9PE(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void I5Tl1suBJBHNPKX8vrD1(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bSZmkBuBMmS2tbcI7ACM(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SJ9tgfuBKYdxj4Gjs8KF(object P_0, SizeF P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PpQJl2uBZwfSZCLokixi(object P_0, AutoScaleMode P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PBaQWSuBo6rIooGqqtRh(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FfDhc6uBxcXyI3vHOlyb(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NgkGCSuBAn3hTpuM7vXC()
	{
	}
}
