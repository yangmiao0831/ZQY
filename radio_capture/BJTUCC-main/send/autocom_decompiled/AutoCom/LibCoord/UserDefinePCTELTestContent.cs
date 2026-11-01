using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using LibUtils;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class UserDefinePCTELTestContent
{
	[XmlAttribute]
	public bool UseScannerGPS;

	[CompilerGenerated]
	private ENUMPctelUserDefineTestType Aq1gEoUgqg6;

	[CompilerGenerated]
	private ENUMPCTELNetTypeNew tTMgEjqtw1X;

	[CompilerGenerated]
	private ENUMPCTELBandNR5G YDMgE7JEwvn;

	[CompilerGenerated]
	private ENUMPCTELBandLTE EjSgEfGmyLP;

	[CompilerGenerated]
	private double GiigEDgnZWU;

	[CompilerGenerated]
	private double B5qgEBDsiuI;

	[CompilerGenerated]
	private int VCOgESF46dy;

	[CompilerGenerated]
	private int X7QgEmkTQ13;

	[CompilerGenerated]
	private double z07gEI3nR1V;

	[CompilerGenerated]
	private int tQUgEQIKMCD;

	[CompilerGenerated]
	private int mNggElxRNCC;

	[CompilerGenerated]
	private int q9DgEwSodGb;

	[CompilerGenerated]
	private int F5ygEpq5nnK;

	[CompilerGenerated]
	private int YjDgEaLBpif;

	[CompilerGenerated]
	private ENUMPctelEpsScanTS iD0gEk4UPry;

	private static UserDefinePCTELTestContent cIq1XdZxsmVY7BKr0Xys;

	[MyDisplayName("测试模式", "Test Type")]
	[TypeConverter(typeof(EnumConverter))]
	public ENUMPctelUserDefineTestType ScanMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPctelUserDefineTestType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("网络类型", "Net Type")]
	[TypeConverter(typeof(EnumConverter))]
	public ENUMPCTELNetTypeNew NetType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPCTELNetTypeNew)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("扫描频段", "Scan Band")]
	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
	public ENUMPCTELBandNR5G BandNR5G
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPCTELBandNR5G)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[MyDisplayName("扫描频段", "Scan Band")]
	public ENUMPCTELBandLTE BandLTE
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPCTELBandLTE)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("中心频率(MHz)", "Center Freq(MHz)")]
	public double CenterFreq
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("频率步长(FSS)KHz", "Freq Step Size(FSS)KHz")]
	public double FSS
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("测量窗口(MW)", "Measure Window")]
	public int MW
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("Bin个数", "Bin Count")]
	public int BinCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("分辨率带宽(RBW)KHz", "RBW(KHz)")]
	public double RBW
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0.0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("时间周期标签(TPM)", "TPM")]
	public int TPM
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[MyDisplayName("时间周期标签偏移(TPMO)", "TPMO")]
	public int TPMO
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("天线增益(db)", "AntennaGain(db)")]
	[Browsable(false)]
	public int AntennaGain
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(false)]
	[MyDisplayName("线损(db)", "LineLoss(db)")]
	public int LineLoss
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("时间偏置", "TimeOffset")]
	[Browsable(true)]
	public int TimeOffset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("上行时隙", "TimeSlot")]
	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
	public ENUMPctelEpsScanTS TimeSlot
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPctelEpsScanTS)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UserDefinePCTELTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static UserDefinePCTELTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		aT8rYXZx11767vICTayZ();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tbgkCFZxk2boT5tgj6B7()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool rZtBAJZxl2ha7fRnAk7Z()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UserDefinePCTELTestContent otS7TcZx9U4xjMWFj7Wm()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aT8rYXZx11767vICTayZ()
	{
	}
}
