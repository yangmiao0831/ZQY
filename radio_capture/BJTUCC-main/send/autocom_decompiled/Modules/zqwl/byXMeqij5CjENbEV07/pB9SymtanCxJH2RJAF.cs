using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace byXMeqij5CjENbEV07;

internal class pB9SymtanCxJH2RJAF
{
	internal static ModuleHandle XnT9XD3jvc;

	internal static object JkIjgUByI6apN4aprbG;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle Gfq3kx6Fn59ql(int token)
	{
		return XnT9XD3jvc.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeFieldHandle yZQ3kx6BBx1ai(int token)
	{
		return XnT9XD3jvc.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public pB9SymtanCxJH2RJAF()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static pB9SymtanCxJH2RJAF()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					break;
				}
				XnT9XD3jvc = My8iGcB5qNcISUqJ8Ud(((object[])DIdtMOB6Aj6ed0yu3SH(sKhktGBnhN3cdo46PI2(typeof(pB9SymtanCxJH2RJAF).TypeHandle).Assembly))[0]);
				num2 = 0;
			}
			while (true);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool w7f09KB7PRVTCr44xp8()
	{
		return JkIjgUByI6apN4aprbG == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static pB9SymtanCxJH2RJAF wW0DP9Bw9X6Ob7lq4xQ()
	{
		return (pB9SymtanCxJH2RJAF)JkIjgUByI6apN4aprbG;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type sKhktGBnhN3cdo46PI2(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object DIdtMOB6Aj6ed0yu3SH(object P_0)
	{
		return ((Assembly)P_0).GetModules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ModuleHandle My8iGcB5qNcISUqJ8Ud(object P_0)
	{
		return ((Module)P_0).ModuleHandle;
	}
}
