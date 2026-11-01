using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace aZj2GVniQtWJUTZdXi;

internal class r4Y1efkYCZE2VXrH7E
{
	internal static ModuleHandle Rw3brYKtCB;

	private static object hAdqk6NXEeWyGBoiXGY;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle rlsiF8cXbE9aL(int token)
	{
		return Rw3brYKtCB.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeFieldHandle suGiF8c3dmG8J(int token)
	{
		return Rw3brYKtCB.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public r4Y1efkYCZE2VXrH7E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static r4Y1efkYCZE2VXrH7E()
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
				case 1:
					break;
				case 0:
					return;
				}
				Rw3brYKtCB = ((Module)((object[])dVg4oINpbUK5CrfZdUH(typeof(r4Y1efkYCZE2VXrH7E).Assembly))[0]).ModuleHandle;
				num2 = 0;
			}
			while (0 == 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool wwRqG9Nr34s8M2cdl80()
	{
		return hAdqk6NXEeWyGBoiXGY == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static r4Y1efkYCZE2VXrH7E sy26c5Ny4MEGTWXN6v1()
	{
		return (r4Y1efkYCZE2VXrH7E)hAdqk6NXEeWyGBoiXGY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dVg4oINpbUK5CrfZdUH(object P_0)
	{
		return ((Assembly)P_0).GetModules();
	}
}
