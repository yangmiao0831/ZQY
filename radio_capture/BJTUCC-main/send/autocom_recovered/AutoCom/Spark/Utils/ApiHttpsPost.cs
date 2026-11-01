using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using tcEeYRHYMSOOr5xhr11;

namespace Spark.Utils;

public class ApiHttpsPost
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CSendHttpsPost_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Sigma_Response> _003C_003Et__builder;

		public string url;

		public string reqStr;

		public bool useToken;

		public string token;

		public HttpClient _003Cclient_003E5__4;

		public StringContent _003CjsonContent_003E5__5;

		public HttpResponseMessage _003Cresponse_003E5__6;

		public string _003CresJson_003E5__7;

		public HttpClient _003C_003Eg__initLocal0;

		private TaskAwaiter<HttpResponseMessage> _003C_003Eu___0024awaiter8;

		private object _003C_003Et__stack;

		private TaskAwaiter<string> _003C_003Eu___0024awaiter9;

		private static object vOLrngqkqryiUISR8FqV;

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
		static _003CSendHttpsPost_003Ed__3()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			xIug6hqkjqakSEQ0Ht9m();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void beEGa2qkTAxfSgRCpstb(SecurityProtocolType P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TimeSpan Lo7sleqkp3Kw4iYjA4FK(double P_0)
		{
			return (TimeSpan)(object)null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void VKk5bsqkQFYeLPn9tkXD(object P_0, TimeSpan P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dViMGdqkRAkrnIU0KfvC(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object rQANleqkGhuSAaCnsQCH(int P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void B69aoPqk3Vk90MKd3Tof(object P_0, object P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object up3jjJqkFpkBGAZnng49(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object xtGNqxqk7qFBG2aLg8QS(object P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object IhPf2mqkb8oxj50OhNP0()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void faKBA7qkg7oUIqaa3J9B(object P_0, object P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void PbqEsEqkfCD521Nqgob0(object P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool FqgUpDqkE3Vc3WMGYwad()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object wl0rtSqkVp12g35J4sr1()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void xIug6hqkjqakSEQ0Ht9m()
		{
		}
	}

	private static readonly string wBqezZKSwDp;

	internal static ApiHttpsPost CjvMfQtchI8I2qNEx8kM;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool zwLez0nnOOX(object P_0, object P_1, object P_2, SslPolicyErrors P_3)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static HttpWebResponse CreatePostHttpResponse(string url, string reqStr, string auth)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CSendHttpsPost_003Ed__3))]
	public static Task<Sigma_Response> SendHttpsPost(string url, string reqStr, bool useToken = false, string token = "")
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool DoHttpsPost(string url, string reqStr, ref string respStr, ref string ErrorMsg, string auth = "")
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool DoHttpsGet(string url, string reqStr, out string respStr, out string ErrorMsg, string auth = "")
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static HttpWebResponse CreateGetHttpResponse(string url, string reqStr, string auth)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool DownloadFile(string url, ref int iCurSize, string filePath, out string ErrorMsg)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ApiHttpsPost()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ApiHttpsPost()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					wBqezZKSwDp = (string)j2YN4XtcdR8FQBhWTmqK(462186);
					num2 = 2;
					if (0 == 0)
					{
						continue;
					}
					break;
				default:
					bHdQqqt8xt1HpG6AYMty();
					num2 = 3;
					continue;
				case 1:
					gsMlxSt8opu6dJmEMRMP();
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 2:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void f4uenctcDtrrQEg2bWBH(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object j2YN4XtcdR8FQBhWTmqK(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JNDbrrtcCNOSFyGjuflc(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KN9LBHtcnIGeP7EAkZ80(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tKRyE7tcaMoswSekrGet(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zrUgNotcHticawNQlEGY(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool zaF424tcsbZjFf5JrgfC(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HGbDBDtcl6OcB4NykNYD(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object YaJty0tc9YbTrqOK1Bmh()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IvEInftckuCL40nBDuCX(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OBFapJtc1BibWAN7FFWh(object P_0, object P_1, int P_2, int P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nSp1eitcvqc5EEYtFnkx(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool I7Tx6xtc4sEGo0b3aemr()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ApiHttpsPost vaTyBptcrfvQE0fsMcW9()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AbtYwhtcSMyHu3whZn9j(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object JxjwE3tcmbqZ8JygK6Wj(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Uai7xBtcIcusVDGooWd9(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mIGsW4tcXCcueE5Bx8ma(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object LHqq3gtcUQE7ik5EIK9U(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qAALaNtcOBhioicarBat(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QI0pnDtc5NlLOYWYeUUT()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mcJkDatcipJKLgJyWISZ(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DR1tCUtcz4MJbvdwkYmj(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VqFbXLt8LXDcrX0qIkKy(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gM8ihwt8N5FHc9whtHBI(object P_0, DecompressionMethods P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object V7EjGst8YQtPRvUA7Bqv(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jW7ufvt8uL4J6owb1IPa(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void maIYAit8yCZUaNNA7544(object P_0, long P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gob5Oot86Gn3xepd1TJy(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Om87Cft82toJlNuxUqGl(SecurityProtocolType P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YmJZcIt8JQRehiJaWIqB(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JFUN10t8MHEkDVP1R0PE(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xBRxomt8KbhVFpjBm3j5(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int GBF0cJt8ZGnhl7DVtKgF(object P_0, object P_1, int P_2, int P_3)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gsMlxSt8opu6dJmEMRMP()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bHdQqqt8xt1HpG6AYMty()
	{
	}
}
