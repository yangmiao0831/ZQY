using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using tcEeYRHYMSOOr5xhr11;

namespace HttpServer;

public class InnerCloudFileService
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CQueryAllFileAsync_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<CloudFileInfo>> _003C_003Et__builder;

		public InnerCloudFileService _003C_003E4__this;

		public List<CloudFileInfo> _003CfileList_003E5__1;

		public HttpClient _003Cclient_003E5__2;

		public HttpResponseMessage _003ChttpResponse_003E5__3;

		public string _003CresJson_003E5__4;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu___0024awaiter5;

		private object _003C_003Et__stack;

		private TaskAwaiter<string> _003C_003Eu___0024awaiter6;

		internal static object xP5el1q7S2RITjw5mVJ9;

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
		static _003CQueryAllFileAsync_003Ed__0()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			ae9Nt0q7zSHN6DGmDJDo();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Y8KVo8q7XLQ6r9cMSoqS(int P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object n8KMGvq7UInlUxGeBwBZ(object P_0, object P_1)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object XuGRdLq7ODnnOJ7oZYgI(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object P2N7QJq753SCGXM3REmT(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hUT5C3q7iNyS6FpvIoyl(object P_0)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool bXaCwHq7m9UUXepZZmtA()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object bRNAPrq7Ij5fqnSiHB61()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ae9Nt0q7zSHN6DGmDJDo()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CQuery2Async_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InnerCloudFileService _003C_003E4__this;

		public string fileName;

		public HttpClient _003Cclient_003E5__9;

		public HttpResponseMessage _003ChttpResponse_003E5__a;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu___0024awaiterb;

		private object _003C_003Et__stack;

		private TaskAwaiter<string> _003C_003Eu___0024awaiterc;

		internal static object oWqB7eqbLJkFf9NCHpcv;

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
		static _003CQuery2Async_003Ed__8()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LXAmWUqbuJY8t7AJT7bj(int P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Xr89xFqbynBd7or7bfIQ(object P_0, object P_1, object P_2)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object djc6J5qb6SndZUZHTPKV(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object C3n8YHqb2NschX6HUVIq(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RfFKALqbJjaZ3SQQk96C(object P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool swkWaMqbN1ZX7xVxXerr()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object OYqDqDqbYuOmTYeia1jB()
		{
			return null;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CDownloadFileAsync_003Ed__e : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public InnerCloudFileService _003C_003E4__this;

		public string fileName;

		public string savePath;

		public HttpClient _003Cclient_003E5__f;

		public HttpResponseMessage _003Cresponse_003E5__10;

		public Stream _003CcontentStream_003E5__11;

		public Stream _003CfileStream_003E5__12;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu___0024awaiter13;

		private object _003C_003Et__stack;

		private TaskAwaiter<Stream> _003C_003Eu___0024awaiter14;

		private TaskAwaiter _003C_003Eu___0024awaiter15;

		internal static object iNMy1tqbMh18wJ8ywIo6;

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
		static _003CDownloadFileAsync_003Ed__e()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			XWviGTqbWMcvfOMrhQ9I();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object faBaKaqbo0tSTOmVxHok(int P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object neaRb9qbxAa28Gupv6aZ(object P_0, object P_1, object P_2)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ug6hbAqbAEXuIgxr3qc5(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void DmK9fOqbtxGR8wZGqOXP(object P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KNj4pVqbKHVLEnj5oPIm()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LooWuMqbZcEZP6xpLGXB()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void XWviGTqbWMcvfOMrhQ9I()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CUploadFileByStreamAsync_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

		public InnerCloudFileService _003C_003E4__this;

		public string filePath;

		public string _003Curl_003E5__19;

		public HttpClient _003Cclient_003E5__1a;

		public FileStream _003Cstream_003E5__1b;

		public MultipartFormDataContent _003Ccontent_003E5__1c;

		public StreamContent _003CfileContent_003E5__1d;

		public string _003CfileName_003E5__1e;

		public HttpResponseMessage _003Cresponse_003E5__1f;

		public string _003Crst_003E5__20;

		public HttpClient _003C_003Eg__initLocal17;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu___0024awaiter21;

		private object _003C_003Et__stack;

		private TaskAwaiter<string> _003C_003Eu___0024awaiter22;

		internal static object m59JgjqbBNLhCiaQnP6i;

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
		static _003CUploadFileByStreamAsync_003Ed__18()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			d1HQNNqbe7APPyyXEuev();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object iGnCbNqbVbKwu3me0J76(int P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object lLQAPOqbTvk8RKiHOxpn(object P_0, object P_1)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool h1n2jLqbplleMSU8MaWt(object P_0)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Ltm5ybqbQQUrQ2Rm1qJR(object P_0, TimeSpan P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object fMhgTaqbRmfGZNawuYgX(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void wxv6vbqbGe6LVxH5Rwug(object P_0, object P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object HsYmfJqb3t3G0JbWBOEK(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ofI2FiqbFgPkDuo9S9JC(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hDsFeVqb7hcYFy77RWMx(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void yA0sHxqbbJ7NDVQ0GbMo(object P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object hWxblUqbgKa1rMv7VOsM()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object numRBvqbfYb3p5fiLTdZ(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void UZG0fXqbj6d0UtLpFhKe(object P_0, object P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool C7ITl2qbqlcWlO2C3YZn()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object oFCcXPqbEL6uA9sRc0Yx()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void d1HQNNqbe7APPyyXEuev()
		{
		}
	}

	private string yAwgBmY36p8;

	private static InnerCloudFileService l2HXhmomRs0FGgiRPv8g;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InnerCloudFileService(string url)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CQueryAllFileAsync_003Ed__0))]
	[DebuggerStepThrough]
	public Task<List<CloudFileInfo>> QueryAllFileAsync()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CQuery2Async_003Ed__8))]
	[DebuggerStepThrough]
	public Task Query2Async(string fileName)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CDownloadFileAsync_003Ed__e))]
	[DebuggerStepThrough]
	public Task<bool> DownloadFileAsync(string fileName, string savePath)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CUploadFileByStreamAsync_003Ed__18))]
	[DebuggerStepThrough]
	public Task<string> UploadFileByStreamAsync(string filePath)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static InnerCloudFileService()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		auK0uCombDfqRWO4ZYX4();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zfgKdkomFnD1NoIrv6Bv()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tOHy4Xom7jG2CWwCTRwa(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Rxlt1tomG5AI6ar3cTfX()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static InnerCloudFileService uE2BRnom3n3RIvvSFpd0()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void auK0uCombDfqRWO4ZYX4()
	{
	}
}
