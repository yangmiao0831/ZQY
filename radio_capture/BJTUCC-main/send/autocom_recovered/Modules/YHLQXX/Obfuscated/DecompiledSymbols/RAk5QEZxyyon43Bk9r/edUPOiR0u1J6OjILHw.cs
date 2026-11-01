using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace RAk5QEZxyyon43Bk9r;

internal class edUPOiR0u1J6OjILHw
{
	internal static ModuleHandle pAwWAPpIPC;

	internal static object qSv8HAG8i1kAtqQQOqb;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle gKN2NrsUSBNGd(int token)
	{
		return pAwWAPpIPC.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeFieldHandle Asp2NrsRO6fZE(int token)
	{
		return pAwWAPpIPC.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public edUPOiR0u1J6OjILHw()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static edUPOiR0u1J6OjILHw()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				pAwWAPpIPC = LwWaYZG1OdvKrUC84u6(PuNbn5G26kf3pHHNViv(typeof(edUPOiR0u1J6OjILHw).TypeHandle).Assembly.GetModules()[0]);
				num2 = 0;
				if (false)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool YBZA6SGGPeR0XAFXvyS()
	{
		return qSv8HAG8i1kAtqQQOqb == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static edUPOiR0u1J6OjILHw q4wWQ5GvKeyhy5y44iH()
	{
		return (edUPOiR0u1J6OjILHw)qSv8HAG8i1kAtqQQOqb;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type PuNbn5G26kf3pHHNViv(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ModuleHandle LwWaYZG1OdvKrUC84u6(object P_0)
	{
		return ((Module)P_0).ModuleHandle;
	}
}
