using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace u3PigNTQVofxw4PpwX;

internal class ULxoaTwLexJqCZAxd3
{
	internal static ModuleHandle rGJ7EMN2F8;

	internal static object yIuHC7uV41wxibObFjZ;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle p3hW9cgM4lqFf(int token)
	{
		return rGJ7EMN2F8.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeFieldHandle PDOW9cgJ6EmZh(int token)
	{
		return rGJ7EMN2F8.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ULxoaTwLexJqCZAxd3()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ULxoaTwLexJqCZAxd3()
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
				rGJ7EMN2F8 = zOmiD5usw0xD504fS1w(((object[])B1XC14ukbCtpHTm93ME(t2dVAAu8o5DWUil0ttf(typeof(ULxoaTwLexJqCZAxd3).TypeHandle).Assembly))[0]);
				num2 = 0;
			}
			while (true);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tY488UuUE7PRrwoBxst()
	{
		return yIuHC7uV41wxibObFjZ == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ULxoaTwLexJqCZAxd3 ASQQ97uqgeXMf7gXSMj()
	{
		return (ULxoaTwLexJqCZAxd3)yIuHC7uV41wxibObFjZ;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type t2dVAAu8o5DWUil0ttf(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object B1XC14ukbCtpHTm93ME(object P_0)
	{
		return ((Assembly)P_0).GetModules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ModuleHandle zOmiD5usw0xD504fS1w(object P_0)
	{
		return ((Module)P_0).ModuleHandle;
	}
}
