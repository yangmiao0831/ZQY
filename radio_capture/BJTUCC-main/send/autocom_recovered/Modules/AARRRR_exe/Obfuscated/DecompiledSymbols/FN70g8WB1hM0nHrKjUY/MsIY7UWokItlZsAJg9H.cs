using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace FN70g8WB1hM0nHrKjUY;

internal class MsIY7UWokItlZsAJg9H
{
	internal static ModuleHandle Cor7eEEAbD;

	private static object j8cRm0r2p5Earl3SYg7;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle GyrRH8fZ3Cbrj(int token)
	{
		return Cor7eEEAbD.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeFieldHandle OgXRH8f2W2s4E(int token)
	{
		return Cor7eEEAbD.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MsIY7UWokItlZsAJg9H()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MsIY7UWokItlZsAJg9H()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Cor7eEEAbD = YUMe12rb9jgPqBvcSt7(((object[])kJv7sNriwEXUZsyNCGO(dcu3jxrCDVoKc9XV9TT(typeof(MsIY7UWokItlZsAJg9H).TypeHandle).Assembly))[0]);
				num2 = 0;
				if (true)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool R0FjKprkN5uG0mHDdy0()
	{
		return j8cRm0r2p5Earl3SYg7 == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MsIY7UWokItlZsAJg9H cXuT3urF87aCmBP3cq3()
	{
		return (MsIY7UWokItlZsAJg9H)j8cRm0r2p5Earl3SYg7;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type dcu3jxrCDVoKc9XV9TT(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object kJv7sNriwEXUZsyNCGO(object P_0)
	{
		return ((Assembly)P_0).GetModules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ModuleHandle YUMe12rb9jgPqBvcSt7(object P_0)
	{
		return ((Module)P_0).ModuleHandle;
	}
}
