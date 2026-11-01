using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class PESQInterface
{
	internal static PESQInterface TIA8oe6XywY1ArJsR7S;

	[DllImport("pesq.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "P001")]
	public static extern int CalcPESQ(string orgFile, string degFile, ref PESQResult result, int sample, int type, int swap);

	[DllImport("pesqdll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "pesq_run")]
	private static extern void ByCTvlh4gA(byte[] P_0, int P_1, byte[] P_2, int P_3, ref float P_4, ref float P_5);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void KnowYouCalcPESQ(string orgFile, string degFile, ref float pSource, ref float pesq_lq)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static byte[] BK7TGCD1Nk(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int D91TH0lEZ5(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PESQInterface()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static PESQInterface()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				kGjoSe6zgC62n1WJNfC();
				num2 = 1;
				if (1 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				rk38Zg61jlvQNLI07nJ();
				num2 = 0;
				if (0 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				BhSAj5kOMxJ0pSFt0lm();
				num2 = 3;
				if (1 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object BRIdY868DFKqX9Cqs9g(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gtbCXY6wvcXXrnuX7lP()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static PESQInterface oJuisN6eveSLnwTg8IJ()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int R8aIS86sb8h9TBiiksa(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rk38Zg61jlvQNLI07nJ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void kGjoSe6zgC62n1WJNfC()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BhSAj5kOMxJ0pSFt0lm()
	{
	}
}
