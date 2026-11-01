using LibUtils;

namespace LibCoord;

public enum ENUM_YY_UECapability
{
	[MyDescription("关闭NB特性能力", "Turn off NB feature capability")]
	TurnOffNB = 0,
	[MyDescription("仅上报MultiTone能力", "Only report MultiTone capabilities")]
	EGSM900 = 2,
	[MyDescription("仅上报MultiCarrier能力", "Only report MultiCarrier capabilities")]
	DCS1800 = 4,
	[MyDescription("上报MultiCarrier和MultiTone能力", "Report MultiCarrier and MultiTone capabilities")]
	GSM850 = 6
}
