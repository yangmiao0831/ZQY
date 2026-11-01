using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using tcEeYRHYMSOOr5xhr11;

namespace Spark.Utils;

public class Sigma_FileDownloadService
{
	public delegate void Log(string debugFile, string logContent);

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoginAsync_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public Sigma_FileDownloadService _003C_003E4__this;

		public string username;

		public string password;

		public string _003CreqJson_003E5__1;

		public SigmaResponse _003Cres_003E5__2;

		private TaskAwaiter<SigmaResponse> _003C_003Eu___0024awaiter3;

		private object _003C_003Et__stack;

		private static object IPMOQOqs85MXKkwNEUVF;

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
		static _003CLoginAsync_003Ed__0()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void i1bZsyqs4wl0iGNIM4bh(object P_0, object P_1, object P_2)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object p1YKdDqsrSTQ40CAiCes(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object U45PliqsDKT88OGJfjVS(object P_0, object P_1)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool h19YbSqswu423ygcJ2lo()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nwsouZqshWahp6NQQn4A()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CRefreshToken_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Sigma_FileDownloadService _003C_003E4__this;

		public HttpClient _003Cclient_003E5__6;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu___0024awaiter7;

		private object _003C_003Et__stack;

		private static object K97F6vqsdXjooOMTk5oy;

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
		static _003CRefreshToken_003Ed__5()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object sGdSEkqsa9yYA6rhWJJL(int P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kVl9iKqsHbQC04oGL1IV(object P_0, object P_1)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void gKv6c2qssXrBoHJxUDqv(object P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool oqcLYdqsC2uDokLvO2rg()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BRYQiHqsnCvxcHdDN5Yk()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CQueryFileListAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<SigmaQueryFileListResponse> _003C_003Et__builder;

		public Sigma_FileDownloadService _003C_003E4__this;

		public SigmaQueryFileListRequest req;

		public SigmaQueryFileListResponse _003Cres_003E5__a;

		public string _003CreqJson_003E5__b;

		public SigmaResponse _003Cresponse_003E5__c;

		private TaskAwaiter<SigmaResponse> _003C_003Eu___0024awaiterd;

		private object _003C_003Et__stack;

		internal static object fFIrDTqslbfM70LgP2KM;

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
		static _003CQueryFileListAsync_003Ed__9()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			vvPhQNqsSniDVCX1KeJO();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tG08oNqs1qh5Tsg7QJpe(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iMleldqsvgW9PeC7nZhI(object P_0, object P_1)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool xqoo81qs9RGepBi9LoH5()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tmI9stqsk30e6scdpUF7()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void vvPhQNqsSniDVCX1KeJO()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDownloadFilesAsync_003Ed__f : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Sigma_FileDownloadService _003C_003E4__this;

		public SigmaDownloadFileRequest req;

		public string dirPath;

		public string _003CreqJson_003E5__10;

		public StringContent _003CjsonContent_003E5__11;

		public HttpClient _003Cclient_003E5__12;

		public HttpResponseMessage _003Cresponse_003E5__13;

		public string _003CfileName_003E5__14;

		public IEnumerable<string> _003CheaderValues_003E5__15;

		public string _003CfullFileName_003E5__16;

		public Stream _003ChttpStream_003E5__17;

		public FileStream _003CfileStream_003E5__18;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu___0024awaiter19;

		private object _003C_003Et__stack;

		private TaskAwaiter<Stream> _003C_003Eu___0024awaiter1a;

		private TaskAwaiter _003C_003Eu___0024awaiter1b;

		private static object PlkxFPqsmrEmuwbGaHEm;

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
		static _003CDownloadFilesAsync_003Ed__f()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			ITSrH5ql6I9BENCY1ow3();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uJ2UxIqsUgedg1Mh36bx(object P_0)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void kxtuUkqsOVkBTah19kXb(object P_0, object P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void t2ylrQqs5MyV2WpuBBrN(object P_0, object P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bL5mkqqsiVSAYCjrIG0N(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object k0HnTJqszlbM6xJrJNt3(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object NjLkAaqlLq9aeArIfBDq(object P_0, object P_1)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tmbu9UqlNS5jWT1Ln0Xr(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rhNCpOqlY2uXb1p82APy(object P_0, object P_1)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void YgN2Kcqlur3aOTK17hUj(object P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object uMsP5qqly3GIcQjoEOtN(int P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XtbXItqsIkoSLW7uyP9s()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kYnSrQqsX0J0MdE0tGm6()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ITSrH5ql6I9BENCY1ow3()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendHttpsPostAsync_003Ed__1e<T> : IAsyncStateMachine where T : SigmaResponse
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<SigmaResponse> _003C_003Et__builder;

		public Sigma_FileDownloadService _003C_003E4__this;

		public string url;

		public string reqJson;

		public bool useToken;

		public SigmaResponse _003Cresponse_003E5__1f;

		public string _003CresJson_003E5__20;

		public HttpClient _003Cclient_003E5__21;

		public StringContent _003CjsonContent_003E5__22;

		public HttpResponseMessage _003ChttpResponse_003E5__23;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu___0024awaiter24;

		private object _003C_003Et__stack;

		private TaskAwaiter<string> _003C_003Eu___0024awaiter25;

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
		static _003CSendHttpsPostAsync_003Ed__1e()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool o4gfuJqlJVu5GQXmDUQ0()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object h4g1lAqlMAH56agkKsut()
		{
			return null;
		}
	}

	private string I1kelvXJ5iI;

	private string T2RelsecIk8;

	private SigmaResponse Sknel6Pd52f;

	private EventHandler UeVelh7RI3j;

	private EventHandler s2Nel1Sj87V;

	public Log DebugLog;

	private string NTJeldrex9R;

	private string LYvelWZPqne;

	private string Rldel4Gtu9M;

	private string i1RelNvDqZs;

	public string ServerAddress;

	public bool DownloadSuccess;

	private static Sigma_FileDownloadService p7xZx8tVrPQQjSylIGto;

	public bool IsLogin
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public event EventHandler OnLogin
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

	public event EventHandler OnLogging
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
	private string PsWelyMpEZJ(string P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CLoginAsync_003Ed__0))]
	public Task<bool> LoginAsync(string username, string password)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CRefreshToken_003Ed__5))]
	[DebuggerStepThrough]
	public Task RefreshToken()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CQueryFileListAsync_003Ed__9))]
	[DebuggerStepThrough]
	public Task<SigmaQueryFileListResponse> QueryFileListAsync(SigmaQueryFileListRequest req)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDownloadFilesAsync_003Ed__f))]
	[DebuggerStepThrough]
	public Task DownloadFilesAsync(SigmaDownloadFileRequest req, string dirPath)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DownloadFiles(SigmaDownloadFileRequest req, string dirPath)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CSendHttpsPostAsync_003Ed__1e<>))]
	public Task<SigmaResponse> SendHttpsPostAsync<T>(string url, string reqJson, bool useToken = false) where T : SigmaResponse
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NMjelcdpfK1(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string qTAelLETqlE()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sigma_FileDownloadService()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Sigma_FileDownloadService()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		qRdtMItT6abn5RpcD6wk();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ewmYugtVCmFXTl6Y8uUv(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool OwQAcktVDT9vsFKZWVva()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Sigma_FileDownloadService s1Mlo1tVdnHehjsgsBeh()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Q60MCCtVnBGZu4FvuSVA(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CdQST1tVaSiqgkunCK5b(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object bkqo7btVHLeuxL8onJre(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool QFPVL7tVslefhbc0RWXp(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IOJUCBtVlJuno5F8eabe(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BOyvp0tV9qNfyVEvZaCQ(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object egVALEtVkxSFj71pGlag(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rjvEdAtV1OG9pxtZOc4X(object P_0, object P_1, object P_2, object P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AsyncTaskMethodBuilder omQKgStVvNs5klZsyYoD()
	{
		return (AsyncTaskMethodBuilder)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vNDTo7tVSkQNA5hq9lLh(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Vj5QRjtVmR0AXNGIyibK(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Nmj2aWtVI81hm0j3ihd3(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JCqqYptVX8C9BkRZD0bJ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xW7X5atVUTq6QYLQGaFc(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YNencEtVOhsV8VVaR2NT(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object OwR3N7tV58u0Gjymxxrg(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ST7dfCtViZynn1rrc2Rd(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void um7rOvtVzKScO133kUcP(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Eiht8ktTLrsZKiXWhECS(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HQY55TtTNoh5MU2lCOZR(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DateTime YVoC7LtTYSPAn0m9JWb6()
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object KmxGKvtTu3NWqDR0wpm3(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aGV5b2tTyg4uMlIAk2Wt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qRdtMItT6abn5RpcD6wk()
	{
	}
}
