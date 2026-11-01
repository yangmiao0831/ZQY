using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using hXOHrEMstPH6ugc4aru;

namespace Bfp89EMyTtM1velS7iY;

internal class cE16qXMRvsecmb62urx
{
	internal static ModuleHandle OdrV1wPvvk;

	private static object tQpnif6KtaZfrIowRHU;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle dSsONHkXtiSgg(int token)
	{
		return OdrV1wPvvk.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeFieldHandle fsPONHk4B57ZB(int token)
	{
		return OdrV1wPvvk.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public cE16qXMRvsecmb62urx()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static cE16qXMRvsecmb62urx()
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0019:
				switch (num2)
				{
				default:
					return;
				case 1:
					OdrV1wPvvk = zq6McJ65w8AdsgXweLC(Uo3FEQ6U5mySVgMLUvZ(typeof(cE16qXMRvsecmb62urx).TypeHandle).Assembly.GetModules()[0]);
					num2 = 0;
					if (true)
					{
						num2 = 0;
					}
					goto IL_0019;
				case 0:
					return;
				case 2:
					break;
				}
				eYd6rPMHQCbJoHGiNKT.rsnT7tGxP4apO();
				num2 = 1;
			}
			while (0 == 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool a7is8x6mxEBsTRc7p3R()
	{
		return tQpnif6KtaZfrIowRHU == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static cE16qXMRvsecmb62urx mq7FEH6oE8klHemUIe0()
	{
		return (cE16qXMRvsecmb62urx)tQpnif6KtaZfrIowRHU;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type Uo3FEQ6U5mySVgMLUvZ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ModuleHandle zq6McJ65w8AdsgXweLC(object P_0)
	{
		return ((Module)P_0).ModuleHandle;
	}
}
