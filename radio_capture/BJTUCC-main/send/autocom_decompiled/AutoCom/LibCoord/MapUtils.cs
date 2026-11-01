using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class MapUtils
{
	private ThresholdType VobnT68sQ0G;

	private List<OneThreshold> SaCnTheCnub;

	public Dictionary<double, int> existValues;

	public static Color[] SiteCoverColors;

	public static Color[] MapCellLayerAnaColors;

	private static Dictionary<int, Dictionary<int, int>> xj7nT1121Ki;

	private static Dictionary<int, Dictionary<int, int>> v2LnTdgVpCB;

	[CompilerGenerated]
	private static Comparison<int> O1MnTWfCeak;

	internal static MapUtils m32qqvMZtXfOtyrUwxFX;

	public static Dictionary<int, Dictionary<int, int>> PciColorDict
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public static Dictionary<int, Dictionary<int, int>> DiscreteColorDict
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<int, int> GetOneParamDiscreteColorDict(int paramKey)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitParamThresholdColor(int paramCode, List<Logfile> logfiles)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitParamThresholdColor(int paramCode, Logfile logfile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitParamThresholdColor(int paramCode, List<double> listParamValues)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetParamThresholdColor(double value)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddKMLListDesc(SiteBase site, List<KMLDesc> listDesc)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool InCustomZones(ZoneFile zoneFile, double x, double y)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool InPolygon(OneZone oneZone, double x, double y)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool InPolygonEx(List<OneZonePoint> pts, OneZonePoint point)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double[] LinearCalc(DoublePoint[] dataArr)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static double tI6nTLl5W3W(double P_0, double P_1, object P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static double rQpnTvdCgZw(double P_0, double P_1, double P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int SiteCoverKey2AllInOneKeyByNR(int paramKey)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int SiteCoverKey2AllInOneKeyByLTE(int paramKey)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MapUtils()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private static int iNYnTs5x6IM(int P_0, int P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapUtils()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		int num = 3;
		Color[] array2 = default(Color[]);
		Color[] array = default(Color[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 14:
				{
					ref Color reference9 = ref array2[4];
					reference9 = K2VYsqMZF0nFGfR77wKv(247, 0, 173);
					num2 = 4;
					continue;
				}
				case 5:
					array = new Color[6];
					num2 = 9;
					continue;
				case 1:
				{
					ref Color reference12 = ref array[2];
					reference12 = K2VYsqMZF0nFGfR77wKv(2, 0, 249);
					num2 = 18;
					continue;
				}
				case 4:
				{
					ref Color reference11 = ref array2[5];
					reference11 = K2VYsqMZF0nFGfR77wKv(164, 90, 254);
					num2 = 20;
					continue;
				}
				case 10:
				{
					ref Color reference10 = ref array2[1];
					reference10 = Color.FromArgb(240, 210, 50);
					num2 = 8;
					continue;
				}
				case 13:
					array2 = new Color[6];
					num2 = 16;
					continue;
				case 6:
					SiteCoverColors = array;
					num2 = 0;
					if (0 == 0)
					{
						num2 = 13;
					}
					continue;
				case 9:
				{
					ref Color reference8 = ref array[0];
					reference8 = K2VYsqMZF0nFGfR77wKv(255, 0, 4);
					num = 7;
					break;
				}
				case 17:
				{
					ref Color reference7 = ref array[5];
					reference7 = Color.FromArgb(1, 254, 252);
					num2 = 6;
					if (0 == 0)
					{
						continue;
					}
					break;
				}
				case 11:
					xj7nT1121Ki = null;
					num2 = 12;
					continue;
				case 19:
				{
					ref Color reference6 = ref array[4];
					reference6 = K2VYsqMZF0nFGfR77wKv(254, 0, 253);
					num2 = 17;
					continue;
				}
				case 8:
				{
					ref Color reference5 = ref array2[2];
					reference5 = Color.FromArgb(246, 56, 58);
					num2 = 15;
					if (true)
					{
						continue;
					}
					break;
				}
				case 20:
					MapCellLayerAnaColors = array2;
					num = 11;
					break;
				case 16:
				{
					ref Color reference4 = ref array2[0];
					reference4 = Color.FromArgb(94, 185, 82);
					num2 = 10;
					if (true)
					{
						continue;
					}
					break;
				}
				case 7:
				{
					ref Color reference3 = ref array[1];
					reference3 = K2VYsqMZF0nFGfR77wKv(252, 254, 5);
					num2 = 1;
					if (0 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				case 2:
					DmwmrgMZGMghHIoRmX2O();
					num2 = 5;
					continue;
				case 15:
				{
					ref Color reference2 = ref array2[3];
					reference2 = K2VYsqMZF0nFGfR77wKv(10, 179, 182);
					num2 = 14;
					continue;
				}
				case 0:
					return;
				case 12:
					v2LnTdgVpCB = null;
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 18:
				{
					ref Color reference = ref array[3];
					reference = K2VYsqMZF0nFGfR77wKv(0, 254, 6);
					num = 19;
					break;
				}
				case 3:
					AFXpHoMZ3Wr9f7yBAZWf();
					num2 = 2;
					if (0 == 0)
					{
						continue;
					}
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool tabqoHMZWNh3GTIACfM2()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MapUtils vDPN1AMZBW7nYD7kn4w2()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int DLpqJRMZqp0Vc955DTtS(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color mKt8NUMZEMHSXNxXf4cw()
	{
		return (Color)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CNtdPfMZVamNoV3iXXLW(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int OLwpapMZTPLVNoIrpGOh(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double I8jZdfMZp8rWJb8iC3Sv(double P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double Rw9a8JMZQx2KQq4GqbNy(double P_0, double P_1, object P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double ChgfnhMZRnCFEOSaeCfG(double P_0, double P_1, double P_2)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DmwmrgMZGMghHIoRmX2O()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AFXpHoMZ3Wr9f7yBAZWf()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Color K2VYsqMZF0nFGfR77wKv(int P_0, int P_1, int P_2)
	{
		return (Color)(object)null;
	}
}
