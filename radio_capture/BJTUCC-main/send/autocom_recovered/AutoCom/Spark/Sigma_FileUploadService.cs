using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using tcEeYRHYMSOOr5xhr11;

namespace Spark;

public class Sigma_FileUploadService
{
	public delegate void Log(string debugFile, string logContent);

	public delegate void OnUploading(string fullFileName, int uploadStatus, double progress);

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoginAsync_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public Sigma_FileUploadService _003C_003E4__this;

		public Sigma_FileUploadConfig config;

		public Sigma_LoginRequest _003Creq_003E5__2;

		public string _003Curl_003E5__3;

		public string _003CreqJsno_003E5__4;

		public Sigma_LoginRequest _003C_003Eg__initLocal0;

		private TaskAwaiter<Sigma_FileUploadResponse> _003C_003Eu___0024awaiter5;

		private object _003C_003Et__stack;

		private static object vK9KDeq3Gy45ZRjaTsXu;

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
		static _003CLoginAsync_003Ed__1()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BDn8piq37QwsfCb2xk3Q(object P_0, object P_1, object P_2)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object sBZDIUq3bOUGbAnn4fn3(int P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object U6UtkCq3gH1x5pecYU4a(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object kCuUGeq3f9KEbaLbaVSo(object P_0, object P_1)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iatyBgq33bvVbx4JCRwC()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XmjEyuq3FC2jsdwPURUT()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendHttpsPostAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Sigma_FileUploadResponse> _003C_003Et__builder;

		public Sigma_FileUploadService _003C_003E4__this;

		public string url;

		public string reqJson;

		public bool useToken;

		public HttpClient _003Cclient_003E5__9;

		public StringContent _003CjsonContent_003E5__a;

		public HttpResponseMessage _003ChttpResponse_003E5__b;

		public string _003CresJson_003E5__c;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu___0024awaiterd;

		private object _003C_003Et__stack;

		private TaskAwaiter<string> _003C_003Eu___0024awaitere;

		internal static object DnrSv0q3jfasP3WGPydu;

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
		static _003CSendHttpsPostAsync_003Ed__8()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			ib4uH0q3dsdD00RG3ehS();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void JUijiPq3PSao0mQw2eeo(SecurityProtocolType P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object CHSJNxq3cX3W8L1VdJOr(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object GEt4uDq38g4ZsJgXlqCQ(int P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void t8v30nq3wZH9W1nCX9qX(object P_0, object P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ucKGkHq3hPT3GnEfSgCr(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool l5FFyTq34fHsib23qqSO(object P_0)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Ng0PySq3rjwsQ5xir9MC(object P_0, object P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Vg7rQqq3D13DXjYj0uvw(object P_0, object P_1)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool F5snCMq3etcXivOcaayw()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ptUhIsq30QuQUu7BCgHm()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ib4uH0q3dsdD00RG3ehS()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUploadFile_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public Sigma_FileUploadService _003C_003E4__this;

		public string fullFileName;

		public Sigma_UploadFileInfo _003CuploadFile_003E5__12;

		public bool _003Csetp1Rst_003E5__13;

		public Sigma_UploadStep2ResponseData _003Cstep2Data_003E5__14;

		public int _003Ci_003E5__15;

		public byte[] _003Cbytes_003E5__16;

		public bool _003Csetp3Rst_003E5__17;

		private TaskAwaiter<bool> _003C_003Eu___0024awaiter18;

		private object _003C_003Et__stack;

		private TaskAwaiter<Sigma_UploadStep2ResponseData> _003C_003Eu___0024awaiter19;

		private static object q3r5xsq3CNCDYrfDsYyM;

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
		static _003CUploadFile_003Ed__11()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			MZi0QSq3XIYdBmU00Rgm();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XZpbZ7q3H71YtWwnpIQP(object P_0)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object B3kN6yq3soQi1akaovCa(int P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Wupjb8q3lx12T52tqpo0(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static long uGE1kRq39fk0cCPqKsrD(object P_0)
		{
			return 0L;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void tY0082q3kP0tQgbWChlZ(object P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IiDDuSq31bmtVjmDsVli(object P_0, object P_1)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SHbqoPq3vm9KQSr9KJ2J(object P_0, object P_1, int P_2, long P_3)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object YhcWljq3SiA44vSsJHoY(object P_0, object P_1)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void eCn0Zeq3mMqap0v5nkE3(object P_0, object P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Y5JcGZq3ICa61LKZ1MQK(object P_0, object P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool U1L24vq3nFu94ySue6Ip()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object D8bQgcq3aCcXA1CmQvjc()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MZi0QSq3XIYdBmU00Rgm()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUploadFileShard_003Ed__1c : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Sigma_FileUploadResponse> _003C_003Et__builder;

		public Sigma_FileUploadService _003C_003E4__this;

		public string url;

		public string reqJson;

		public byte[] fileBytes;

		public string fileName;

		public HttpClient _003Cclient_003E5__1d;

		public ByteArrayContent _003CfileContent_003E5__1e;

		public MultipartFormDataContent _003CformData_003E5__1f;

		public HttpResponseMessage _003ChttpResponse_003E5__20;

		public string _003CresJson_003E5__21;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu___0024awaiter22;

		private object _003C_003Et__stack;

		private TaskAwaiter<string> _003C_003Eu___0024awaiter23;

		private static object j5F3UQq3Ud2nFfKIjJsJ;

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
		static _003CUploadFileShard_003Ed__1c()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			thfKVEqFWimu65ujuqpS();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UqoY8Tq3iilbyVait9qU(SecurityProtocolType P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IIOXrxq3zMKbeLEPcCLG(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EJhQH7qFLP56iPWg8QSn(int P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void lCkj9pqFN4KgX1AwKUgi(object P_0, object P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dv8deOqFYIwGID4urdSs(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void IMxbYfqFufRP0kWuCT3e(object P_0, object P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object aTZ85QqFyyAbluIppVSj()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yYUFf0qF6dcrAoJJCXKq(object P_0, object P_1, object P_2)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void xYU1uqqF2RHsMV3TxRrW(object P_0, object P_1, object P_2, object P_3)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object PVRHXJqFJ6Gva2T0Xe9p(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object v5YRJyqFMUB8KPFCXupy(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XgIujxqFKLHgtukKeE9Z(object P_0)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ijidZRqFZs75mHXBwpBV(object P_0, object P_1, object P_2, object P_3)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void BNhXG1qFoxbJIF9sDFJd(object P_0, object P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EIRLlRqFxYoIbAbLqLmI(object P_0, object P_1)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Me1QlTqFAuSR1PA4c38Y(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void HrF4acqFt5KVe7PMboiL(object P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool anVqXuq3OUp9JuQ0iY7Q()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object MPZu3bq35tJa9bth9u4Q()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void thfKVEqFWimu65ujuqpS()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDoUploadStep3_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public Sigma_FileUploadService _003C_003E4__this;

		public Sigma_UploadFileInfo file;

		public int shardIndex;

		public byte[] fileBytes;

		public Sigma_UploadStep3Request_shardInfo _003Creq_003E5__27;

		public string _003CreqJson_003E5__28;

		public Sigma_UploadStep3Request_shardInfo _003C_003Eg__initLocal25;

		private TaskAwaiter<Sigma_FileUploadResponse> _003C_003Eu___0024awaiter29;

		private object _003C_003Et__stack;

		internal static object PT9BoSqFBqM6aeQkY2vH;

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
		static _003CDoUploadStep3_003Ed__26()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object U7RP5cqFV3JdyRLQPTYE(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object tDkyfvqFTW9clsxJqubO(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object KRisb6qFpEjaDj1PGKli(object P_0, object P_1)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HgCikLqFqhrSE8tP1ajy()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object nmv7dfqFER8XxVvRUjKq()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDoUploadStep2_003Ed__2c : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Sigma_UploadStep2ResponseData> _003C_003Et__builder;

		public Sigma_FileUploadService _003C_003E4__this;

		public Sigma_UploadFileInfo file;

		public Sigma_UploadStep2ResponseData _003Crst_003E5__2d;

		public Sigma_UploadStep2Request _003Creq_003E5__2e;

		public string _003CreqJson_003E5__2f;

		public Sigma_UploadStep2Request _003C_003Eg__initLocal2b;

		private TaskAwaiter<Sigma_FileUploadResponse> _003C_003Eu___0024awaiter30;

		private object _003C_003Et__stack;

		internal static object swCZYhqFQitZSwZur5rN;

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
		static _003CDoUploadStep2_003Ed__2c()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			Psip4sqF7GAyOk76wd9j();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xt6wwEqF3o4Kvk7j3wEQ(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object X1VIpwqFF8vqv3cEW5Qj(object P_0, object P_1)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GxNckfqFRLKI9RomSUW4()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object EFEtCCqFGsFg0mp8K1Kb()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Psip4sqF7GAyOk76wd9j()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDoUploadStep1_003Ed__34 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public Sigma_FileUploadService _003C_003E4__this;

		public Sigma_UploadFileInfo file;

		public Sigma_UploadStep1Request _003Creq_003E5__35;

		public string _003CreqJson_003E5__36;

		public Sigma_UploadStep1Request _003C_003Eg__initLocal32;

		public Sigma_testDataInfo _003C_003Eg__initLocal33;

		private TaskAwaiter<Sigma_FileUploadResponse> _003C_003Eu___0024awaiter37;

		private object _003C_003Et__stack;

		private static object itdWSqqFbXBwxY02b5WQ;

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
		static _003CDoUploadStep1_003Ed__34()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			anjhRmqFPgfcgui3MbUF();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xicUa8qFjhfGYXRWWUlV(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UpfWRRqFeLiNvTyG48AG(object P_0, object P_1)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VHOmswqF0g9ye0NDo3ko(object P_0, object P_1)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool r43IvlqFgXUF0lfs2919()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object mteO3vqFfsKSnYtWtrut()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void anjhRmqFPgfcgui3MbUF()
		{
		}
	}

	public Log DebugLog;

	public OnUploading ReportProgress;

	private string PQGgKK3r0sm;

	private string rpUgKttd00a;

	private Sigma_FileUploadConfig eCGgKu0AIrq;

	private List<Sigma_UploadFileInfo> hYcgKoYFNIh;

	private long KQBgKjGnZ6F;

	private bool McugK7RVpM3;

	private EventHandler zVEgKfR2wWF;

	private EventHandler debgKDmyK8J;

	private EventHandler hA3gKBtRIOE;

	private Sigma_FileUploadResponse LaNgKSBrTbn;

	private Sigma_FileUploadResponse DKygKmO82fy;

	private string DyPgKITjKfi;

	private string b5xgKQ7jCtp;

	private string CPSgKlqNnwR;

	internal static Sigma_FileUploadService T13TEdojQyGPYGpbxDUB;

	public bool IsLogin
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
	}

	public Sigma_FileUploadResponse LastResponse
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
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

	public event EventHandler OnLogout
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
	private string hfTgKYtWByx(string P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Logout()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CLoginAsync_003Ed__1))]
	[DebuggerStepThrough]
	public Task<bool> LoginAsync(Sigma_FileUploadConfig config)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CSendHttpsPostAsync_003Ed__8))]
	public Task<Sigma_FileUploadResponse> SendHttpsPostAsync(string url, string reqJson, bool useToken = false)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopUploading()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUploadFile_003Ed__11))]
	[DebuggerStepThrough]
	public Task<bool> UploadFile(string fullFileName)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void u4ggKHmXrNk(string P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void zhUgK3ZPlg5(Sigma_UploadFileInfo P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] urkgKJaS1tq(string P_0, int P_1, long P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUploadFileShard_003Ed__1c))]
	[DebuggerStepThrough]
	private Task<Sigma_FileUploadResponse> W7LgKr53B0l(string P_0, string P_1, byte[] P_2, string P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CDoUploadStep3_003Ed__26))]
	private Task<bool> YyYgK9jbPxc(Sigma_UploadFileInfo P_0, int P_1, byte[] P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoUploadStep2_003Ed__2c))]
	[DebuggerStepThrough]
	private Task<Sigma_UploadStep2ResponseData> LO6gK8YvAW7(Sigma_UploadFileInfo P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDoUploadStep1_003Ed__34))]
	[DebuggerStepThrough]
	private Task<bool> I4VgKUrXoeI(Sigma_UploadFileInfo P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sigma_FileUploadService()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Sigma_FileUploadService()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		OMsnmyojdok7j6cCVh27();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object at845aoj31HWQZoVoca1(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool W0YomLojRMxb2YJVwVQm()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Sigma_FileUploadService z82ht1ojGMYI0gU6jj9f()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object lUJh5vojFFZLGcmGuKIb(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object s2Ye0Ooj70fDD5oEB3qB(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Vju0pDojbrlryZvpDKbk(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool j5BWIgojgXAVyttsaT2c(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qy9CSlojfdZd2lvnx6By(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kPPjrqojj21rUmj01vei(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wlkA4iojeu49UvPlkni9(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool V59hrqoj0uw27eTHxJC3(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CXZdqfojPyakO69NTYtK(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Hr1ErWojcnyjOvOxOha0(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void a4oOUZoj8cWjRBrjAVeC(object P_0, object P_1, int uploadStatus, double progress)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long rVOIeSojwLXWNeoDPya6(object P_0)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long K7MFmyojhTBUfh3bhDqW(long P_0, long P_1)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long ED3l1Ioj4X7iJe2tkJwb(object P_0, long P_1, SeekOrigin P_2)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int BpMwmyojryPcGxAX7eu7(object P_0, object P_1, int P_2, int P_3)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vFY5Q2ojDHZosobOddCa()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OMsnmyojdok7j6cCVh27()
	{
	}
}
