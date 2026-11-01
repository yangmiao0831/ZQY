using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BrightIdeasSoftware;
using HttpServer;
using LibBase;
using LibCoord;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace Spark;

public class CAERI_FileUploaderV2 : BaseWin
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CfbUpload_Click_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CAERI_FileUploaderV2 _003C_003E4__this;

		public InnerCloudFileService _003CinnerCloudFileService_003E5__1;

		public Sigma_UploadFile _003Cfile_003E5__2;

		public string _003CuploadRst_003E5__3;

		public List<Sigma_UploadFile>.Enumerator _003C_003E7__wrap4;

		private TaskAwaiter<string> _003C_003Eu___0024awaiter5;

		private object _003C_003Et__stack;

		private static object rt40QuqGsx59CqGbYyxx;

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
		static _003CfbUpload_Click_003Ed__0()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			AvnpMTqGUL7p1A2tSZQo();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int nc57ObqGkjn8wRVPWCKV(object P_0)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool OcrQxwqG1wLNXw97Dvi0(object P_0)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void JnFrlLqGveJjAKjx4qFB(object P_0, int P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void oaXiJlqGS9U0hFUUbQvD(object P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RJJFZNqGm5TkGddCV1yb(int P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void sqIDb6qGI6EGnXXys6oP(object P_0, bool P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Y7IcgDqGXXWJy2iMb2hL(object P_0, object P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kqfh7IqGllC42dNagth3()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object dG60PIqG9jiSXRXnwupx()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AvnpMTqGUL7p1A2tSZQo()
		{
		}
	}

	private string ygKgU4dpq2s;

	private string eCSgUNHpXEC;

	public static string cfgFile;

	private HQCloud_FileUploadConfig uubgUiTd4l2;

	private FastObjectListView qrXgUFlQhRa;

	private List<Sigma_UploadFile> kJygUbvd1kA;

	private bool uCygUV9pJGy;

	public static bool reMix;

	private IContainer TAigUXeyq3H;

	private Panel xhpgU22coho;

	public FlatTabControl tcCategory;

	private Panel ED5gUO9Ip6N;

	private Panel DJQgUMiPoQw;

	private FlatButton s8YgU5ay22Z;

	private FlatButton rWDgUTPIVG1;

	private FlatButton fEogUxJEHUL;

	private CheckBox H4BgUq6PGTL;

	private Label vmZgUAShGEs;

	private CheckBox TxhgUYfw2o7;

	private FlatButton sL0gUHB8Xmm;

	private TextBox DlEgU3kRetT;

	private Panel Oc1gUJAdGtl;

	[CompilerGenerated]
	private static AspectGetterDelegate SEigUrZBqYN;

	[CompilerGenerated]
	private static AspectGetterDelegate lqXgU9j6jYj;

	private static CAERI_FileUploaderV2 TlsEV9o75yVcUo2irDCa;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CAERI_FileUploaderV2()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CAERI_FileUploader_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void uP6gUe3gITc(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void kXqgUPPS345()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void langUERXVIE(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool Qs1gUyeTcxQ()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RmTgUcdebRF(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_003CfbUpload_Click_003Ed__0))]
	[DebuggerStepThrough]
	private void kU9gULacKY8(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void kOpgUv0uK7J()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pFcgUsjcAZu(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<Sigma_UploadFile> uV1gU6ibbB6(List<string> P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Uy1gUhBKFMl(object P_0, EventArgs P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void fQIgU1WljKX()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static object JWygUd0CWnk(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static object y2vgUW5Usm5(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CAERI_FileUploaderV2()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					cfgFile = (string)eQhnjrog34EbG6dsryA0(ConstUtils.SparkAppDataPath, xNOTlSHosQAMkdL3Vlu.bM2EhtOW6Or(421366));
					num2 = 4;
					continue;
				case 2:
					Lfn9HQogGqbfIacGnQeC();
					num2 = 1;
					if (true)
					{
						continue;
					}
					break;
				case 4:
					reMix = false;
					num2 = 0;
					if (true)
					{
						continue;
					}
					break;
				case 0:
					return;
				case 3:
					fTmtTxogRIqRRCsoXvSD();
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mpr98fobLsW0qWdSKOKR(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Q5OZNHobNBpSnkYmavD6(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void I1E9JuobYD853G1JycJP(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AVOQ42obuRVSkZWvNl8J(object P_0, FormStartPosition P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Xl2odIobypWYIRmXqf24(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wOCaw9ob6xfkiBTVlXEr(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tZFo8Uob235n2YdXijls(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Q6iJKCobJZbdrcm6Ub18(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Igr7xBo7iXe7djPXaE1w()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CAERI_FileUploaderV2 csSlwao7zj830tcplHpv()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static CloseReason bePoSmobMefkCqn7CljM(object P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return (CloseReason)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void slx5xIobKSJVbFbFKgop(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AiJwDLobZ6CgdsVP0jPb(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EJAJuoobosoX7CmiVuLq(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object W5XQXvobx4XNoVlo7FGi(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oQkERqobA8DAfI6S7fug(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool XCH9PdobtZZmeljQRynJ(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object V9YebjobWKnWdhKEGyK0(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tLTrIFobBulkU4qUNYWu(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RBs7jLobqmd3fDXeOeLb(object P_0, object P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TcpbLhobEfolF2HwP93P(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pNdSIRobVO53BuILdR3V(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kCdZA1obTgMc7r9N4m0b(object P_0, BorderStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cPy1TwobpWodrLZxc0Zb(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IP8WJhobQaXu4ghsYFJV(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UWSD34obRrpEQris1sp8(object P_0, ColumnHeaderStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UUeLY8obGxiKM9SXJgMm(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color BLcCtTob3JHQCRXD5gmb()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void shOcVHobFrpP4HMllNQp(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gZqoRGob7oQE0JTf5VUH(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jjUAlrobbfbbdf6q1s84(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dHdyQqobgiDUc357xjHE(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eNt68cobfrSu1OQp2bJP(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ymCJ1HobjCEoA1NcUt4r(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KksNKNobeBYN0OUeo8hT(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gyCDd3ob05D6cVgglqKK(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dSAUE3obPvgTCEdTX48H(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fH3FqWobcmnepHjqjKiZ(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int miwiE9ob8TRFCQGandSj(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QpDFFkobwnoIZu2ZbVax(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MLjsYqobhBMZEotorucN(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void s5GSvUob4hnF3JVpNOVf(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SwEZhjobryWAJcgQKkQ0(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void acNxBwobDmvbUakcM0m3(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object uHLhoxobd1GcmMFRdVDf(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VBiM19obC9ktXFFUif4t(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EKorBvobnlCpRJHoMoEL(object P_0, Point P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nvXh9yobaUN49bUcWMM0(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void b3v9KtobH73Smn9HBFVJ(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void otVRjlobshx9X2x1I33y(object P_0, AnchorStyles P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uygR9oobl7NxOpkmAfUG(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VjHdWSob9jHhkvyoBihh(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OYDb87obkWQRXTcDTjrl(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color o2CcHFob1w1y4ICSgqQ0(int P_0, int P_1, int P_2)
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void P5XpMcobvbJA2GPVEDLp(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zdLTJGobSAjIe3f6iAE8(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bpjfNDobmtmD7ltssAoy(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HfE79PobI1iLxde2TmHK(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jflc5FobXhitho0IKyLR(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cLeRe6obUCUfV1WSjJxk(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void xGZdthobOflGce7WKiPJ(object P_0, Padding P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QpqgU8ob5Xk88ydJwvaf(object P_0, Size P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void I6SEdKobiMjp5JcTBdaT(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FTyDauobzfSGdZePJyvR(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void k7LxbPogLN8JDPlCuIlO(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TWxEgDogNsinKLLNv34H(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color qPL32FogYXXTnSeY5Fk5()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PX698ioguXbqwh67ISwC(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mX3MIUogyOFSdXxBWmRm(object P_0, DockStyle P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yc9B04og6IXDSa37KQWo(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cDtPZLog2jiop9NjST1G(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PKQ023ogJN4QmH4Q89lc(object P_0, int P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rGCxfWogMTpPgOff0xZm(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PppmSHogKVsFh7u9oylh(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OdspmcogZ8FbO9Qmgjs0(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cZdGNAogoZUVtK7efArr(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NRtCnmogxM7YwAslvaO2(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CwfKFqogAnJwvgPjuX3G(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void L7qZ7WogtObaeN3K6qNu(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void g0HG2wogWeCyxJ1bTAGF(object P_0, Color P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void l5KeuvogBx9E6B2osYGq(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void qJ31wrogqHOlq6VltePi(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IpHPh5ogEDE2AC3nO1cc(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void pRuBhWogVYbOf7jcQtur(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FNBJGeogTBSs4aQbwkrg(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eUNdZPogpOZBiA1MK3g9(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object mxUQJ4ogQyMAWppFRIpm(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void fTmtTxogRIqRRCsoXvSD()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Lfn9HQogGqbfIacGnQeC()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eQhnjrog34EbG6dsryA0(object P_0, object P_1)
	{
		return null;
	}
}
