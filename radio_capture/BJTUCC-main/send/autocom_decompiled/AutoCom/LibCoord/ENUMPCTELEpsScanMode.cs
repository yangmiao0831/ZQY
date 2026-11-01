using System.ComponentModel;
using LibUtils;

namespace LibCoord;

public enum ENUMPCTELEpsScanMode
{
	[MyDescription("连续频点扫描", "Continuous Frequency Scan")]
	ScanContinuousFreq = 3,
	[MyDescription("分频点扫描", "Division Frequency Scan")]
	ScanDivisionFreq
}
public enum ENUMPctelEpsScanMode
{
	[Description("TS(TimeSlot)")]
	TimeSlot = 1,
	[Description("SFN/SubSFN")]
	Frame,
	[Description("DwPTS/GP/UpPTS")]
	DwPTS,
	[Description("RB(Resource Block)")]
	RB,
	[Description("RE(Resource Element)")]
	RE,
	[Description("Symbol")]
	Symbol
}
