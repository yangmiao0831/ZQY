using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using N6SFqGFYBDLpvREgEy;

namespace GQ5WBCHY80rpWYOkPJ;

internal class YdQ9UZGTIchNBUWtvW
{
	internal static ModuleHandle ymTxnSe9Fe;

	internal static object pVJVjS3566KKHdDCpvd;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle G9NRbPA4u2slQ(int token)
	{
		return ymTxnSe9Fe.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeFieldHandle tARRbPAX7UVqc(int token)
	{
		return ymTxnSe9Fe.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public YdQ9UZGTIchNBUWtvW()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static YdQ9UZGTIchNBUWtvW()
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
					ymTxnSe9Fe = G5VQiL3lDCFqgdGiLtb(((object[])aS5o3f3utYbnygduL9L(nnXZrD30amL2DBRru8P(typeof(YdQ9UZGTIchNBUWtvW).TypeHandle).Assembly))[0]);
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
				MM7VKe3Pc8T3i4t0RMO();
				num2 = 1;
			}
			while (0 == 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qlLoUu3NOxnARSOUrEZ()
	{
		return pVJVjS3566KKHdDCpvd == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static YdQ9UZGTIchNBUWtvW vZOBW13qx2yRfUAa9gM()
	{
		return (YdQ9UZGTIchNBUWtvW)pVJVjS3566KKHdDCpvd;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MM7VKe3Pc8T3i4t0RMO()
	{
		uohpcdf6WhqqAYX2dj.s2tfRIu5OIpAl();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type nnXZrD30amL2DBRru8P(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object aS5o3f3utYbnygduL9L(object P_0)
	{
		return ((Assembly)P_0).GetModules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ModuleHandle G5VQiL3lDCFqgdGiLtb(object P_0)
	{
		return ((Module)P_0).ModuleHandle;
	}
}
