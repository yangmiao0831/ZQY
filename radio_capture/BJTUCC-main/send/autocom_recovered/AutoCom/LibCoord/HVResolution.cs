using System.ComponentModel;
using LibUtils;

namespace LibCoord;

public enum HVResolution
{
	[Description("240P")]
	R240P,
	[Description("256P")]
	R256P,
	[Description("360P")]
	R360P,
	[Description("480P")]
	R480P,
	[Description("720P")]
	R720P,
	[Description("1080P")]
	R1080P,
	[Description("2K")]
	R2K,
	[Description("4K")]
	R4K,
	[Description("8K")]
	R8K,
	[Description("SD")]
	RSD,
	[Description("HD")]
	RHD,
	[Description("SPEED")]
	RSPEED,
	[Description("SUPERHD")]
	RSUPERHD,
	[MyDescription("蓝光4M", "Blue Light 4M")]
	DB4M,
	[MyDescription("蓝光8M", "Blue Light 8M")]
	DB8M,
	[MyDescription("蓝光10M", "Blue Light 10M")]
	DB10M
}
