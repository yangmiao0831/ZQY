using LibUtils;

namespace LibCoord;

public enum CarGPSModeENUM
{
	[MyDescription("不采集", "None")]
	none = 0,
	[MyDescription("车机系统", "In-vehicle system")]
	car = 1,
	[MyDescription("TBox", "TBox")]
	tbox = 3,
	[MyDescription("主设备:车机系统, 辅设备:TBox", "Main:In-vehicle system, Auxiliary:TBox")]
	cartbox = 5,
	[MyDescription("主设备:TBox, 辅设备:车机系统", "Main:TBox, Auxiliary:In-vehicle system")]
	tboxcar = 4
}
