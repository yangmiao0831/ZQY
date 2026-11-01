using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class LayerProperty
{
	public int ID;

	public LayerType Type;

	public string Name;

	public bool Visible;

	public int OffSetX;

	public int OffSetY;

	public int PointSize;

	public int Transparency;

	[JsonIgnore]
	public int ParamCode;

	[JsonIgnore]
	public Logfile Logfile;

	[JsonIgnore]
	public int LastRowIdxInTest_Scanner;

	[JsonIgnore]
	public int LastRowIdxInTest;

	[JsonIgnore]
	public int LastPointIdxInTest;

	[JsonIgnore]
	public long PreGPSUTCTime;

	[JsonIgnore]
	public double PreGPSLong;

	[JsonIgnore]
	public double PreGPSLat;

	[JsonIgnore]
	public int PrePointIdx;

	[JsonIgnore]
	public double PreValue;

	[JsonIgnore]
	public long PreValueTime;

	[JsonIgnore]
	public List<int> ParamPointIdxList;

	[JsonIgnore]
	public List<double> ValueList;

	[JsonIgnore]
	public List<int> TmpPointIdxList;

	internal static LayerProperty Tv8TZ8JXCok5TmPoW3hW;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LayerProperty()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static LayerProperty()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		Xu7nDgJXsqdBp9gnYhpI();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rj0dm2JXHjQ3wkj96KXc()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool bQyj3XJXnqvFEoX1pN77()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static LayerProperty mdeIdqJXaWFPTk6BjRtZ()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Xu7nDgJXsqdBp9gnYhpI()
	{
	}
}
