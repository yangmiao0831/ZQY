using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using LibUtils;
using Newtonsoft.Json;
using YPbEJ89iRh9yNgMatCk;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class EPSPCTELTestContent
{
	[XmlAttribute]
	public bool UseScannerGPS;

	[XmlAttribute]
	public int SSP;

	private PCTELMultiCheckList ffigENafgye;

	private PCTELMultiCheckList XkWgEiWABHU;

	private PCTELMultiCheckList GZwgEFeLCTR;

	private PCTELMultiCheckList v69gEb5i9Sj;

	private PCTELFreqList D4ugEV60CHd;

	private PCTELFreqList j7VgEXojVBm;

	[CompilerGenerated]
	private ENUMPCTELNetTypeEps NMjgE2d3eEZ;

	[CompilerGenerated]
	private ENUMPCTELEpsScanMode QB6gEOLnp8k;

	[CompilerGenerated]
	private ENUMPctelEpsScanMode gJsgEMEf8Bu;

	[CompilerGenerated]
	private ENUMPctelEpsScanTS TcBgE5Il2Ke;

	[CompilerGenerated]
	private ENUMPctelEpsScanSubCarrier Cs4gETXwP56;

	[CompilerGenerated]
	private ENUMPctelEpsCPType xyYgExIBeqS;

	[CompilerGenerated]
	private ENUMPctelEpsTSSA yOHgEqtaJv3;

	internal static EPSPCTELTestContent fNZ0EUZxh1ErHvORA5Zw;

	[MyDisplayName("网络制式", "Net Type")]
	[TypeConverter(typeof(EnumConverter))]
	public ENUMPCTELNetTypeEps NetType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPCTELNetTypeEps)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("扫描模式", "Scan Mode")]
	public ENUMPCTELEpsScanMode ScanType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPCTELEpsScanMode)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("频点列表", "Frequency list")]
	[Browsable(true)]
	[Editor(typeof(Wiq2ET9YoO0xKrjtJsS), typeof(UITypeEditor))]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public PCTELFreqList DivisionFreqListLte
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

	[Editor(typeof(Wiq2ET9YoO0xKrjtJsS), typeof(UITypeEditor))]
	[Browsable(true)]
	[MyDisplayName("频点列表", "Frequency list")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public PCTELFreqList ContinueFreqListLte
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

	[MyDisplayName("扫描类型", "Scan Type")]
	[TypeConverter(typeof(EnumConverter))]
	public ENUMPctelEpsScanMode ScanMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPctelEpsScanMode)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Editor(typeof(BandListNR5GEditor), typeof(UITypeEditor))]
	[MyDisplayName("扫描时隙", "Scan Timeslot")]
	[Browsable(true)]
	public PCTELMultiCheckList TSList
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

	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[MyDisplayName("扫描时隙", "Scan Timeslot")]
	public ENUMPctelEpsScanTS TS
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

	[MyDisplayName("扫描子帧", "Scan SubFrame")]
	[Browsable(true)]
	[Editor(typeof(BandListNR5GEditor), typeof(UITypeEditor))]
	public PCTELMultiCheckList SubFrameList
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

	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("扫描子载波", "Scan SubCarrier")]
	[Browsable(true)]
	public ENUMPctelEpsScanSubCarrier SubCarrier
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPctelEpsScanSubCarrier)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	[MyDisplayName("循环前缀(CP Type)", "CP Type")]
	public ENUMPctelEpsCPType CPType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPctelEpsCPType)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[Browsable(true)]
	[MyDisplayName("扫描符号", "Scan Symbol")]
	[Editor(typeof(BandListNR5GEditor), typeof(UITypeEditor))]
	public PCTELMultiCheckList SymbolList
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

	[Browsable(true)]
	[MyDisplayName("上下行时隙配比SA（DL:UL）", "Timeslot SA（DL:UL）")]
	[TypeConverter(typeof(EnumConverter))]
	public ENUMPctelEpsTSSA SA
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (ENUMPctelEpsTSSA)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("特殊子帧配置SSP（D:G:U）", " SubFrame SSP（D:G:U）")]
	[JsonIgnore]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
	public ENUMPctelEpsSSPNormal SSPNormal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (ENUMPctelEpsSSPNormal)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[Browsable(true)]
	[TypeConverter(typeof(EnumConverter))]
	[MyDisplayName("特殊子帧配置SSP（D:G:U）", " SubFrame SSP（D:G:U）")]
	[JsonIgnore]
	public ENUMPctelEpsSSPExtend SSPExtend
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (ENUMPctelEpsSSPExtend)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EPSPCTELTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static EPSPCTELTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		SMGHYJZxDA3hUeIv9vcw();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VhBqkIZx4ahHMMD2yV0T()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static EPSPCTELTestContent WEKC03ZxruV7cytKLP8u()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SMGHYJZxDA3hUeIv9vcw()
	{
	}
}
