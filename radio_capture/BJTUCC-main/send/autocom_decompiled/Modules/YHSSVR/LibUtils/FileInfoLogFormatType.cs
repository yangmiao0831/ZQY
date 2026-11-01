namespace LibUtils;

public enum FileInfoLogFormatType
{
	[MyDescription("其他文件", "Other File")]
	ftInvalid = -16777215,
	[MyDescription("未知文件", "Unknown File")]
	ftUnknown = 0,
	[MyDescription("saf文件", "saf File")]
	ftsaf = 1,
	[MyDescription("raf文件", "raf File")]
	ftraf = 2,
	[MyDescription("高通文件", "Qualcomm File")]
	ftMDM = 3,
	[MyDescription("DTLog文件", "DTLog File")]
	ftDtlog = 4,
	[MyDescription("eCTI文件", "eCTI File")]
	fteCTI = 5,
	[MyDescription("海思文件", "Hisi File")]
	ftHisiUeViewLog = 6,
	[MyDescription("ASPS文件", "ASPS File")]
	ftASPS = 7,
	[MyDescription("CU文件", "CU File")]
	ftCU = 8,
	[MyDescription("gesf文件", "gesf File")]
	ftGesf = 10,
	[MyDescription("新DTLog文件", "New DTLog File")]
	ftNewDtlog = 11,
	[MyDescription("高通文件", "Qualcomm File")]
	ftQmdl = 12,
	[MyDescription("tlf文件", "tlf File")]
	ftTlf = 13,
	[MyDescription("蔚来文件", "NIO File")]
	ftNIO = 14,
	[MyDescription("CPF文件", "CPF File")]
	ftCPF = 15,
	[MyDescription("Muxraw文件", "Muxraw File")]
	ftMuxraw = 20,
	[MyDescription("CPF文件", "CPF File")]
	ftCPFOrgData = 21,
	[MyDescription("zd文件", "zd File")]
	ftZD = 22
}
