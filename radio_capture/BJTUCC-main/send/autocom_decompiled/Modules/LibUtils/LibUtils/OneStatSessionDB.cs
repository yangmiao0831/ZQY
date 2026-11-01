using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class OneStatSessionDB
{
	public int ParamCode;

	public string Name;

	public int StatisticType;

	public double ShowScale;

	public int paramKey1;

	public string aggType1;

	public string conditions1;

	public int paramKey2;

	public string aggType2;

	public string conditions2;

	public string NameEn;

	public int ValueType;

	public double Max;

	public double Min;

	[JsonIgnore]
	public double CalcValue;

	private static OneStatSessionDB lLLgUVaw8b4BCIQlVeX;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OneStatSessionDB Clone()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OneStatSessionDB()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static OneStatSessionDB()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 2;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0017:
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					break;
				case 3:
					powsbqa1XWGXTDw4eVJ();
					num2 = 0;
					if (false)
					{
						num2 = 0;
					}
					goto IL_0017;
				case 1:
					dVgQhJasuAvejIYHdTT();
					num2 = 3;
					if (1 == 0)
					{
						num2 = 0;
					}
					goto IL_0017;
				}
				b99vLwQv4vNmPibnHM.CO84lAqjUl();
				num2 = 1;
			}
			while (true);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fw5FDRaeK1atObX3EjT()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static OneStatSessionDB wqiviKa8qif4FowcHI0()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dVgQhJasuAvejIYHdTT()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void powsbqa1XWGXTDw4eVJ()
	{
	}
}
