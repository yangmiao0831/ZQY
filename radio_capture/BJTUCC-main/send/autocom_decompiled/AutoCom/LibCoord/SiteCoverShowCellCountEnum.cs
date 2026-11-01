using LibUtils;

namespace LibCoord;

public enum SiteCoverShowCellCountEnum
{
	[MyDescription("仅显示单扇区轨迹", "Display Single Sector Only")]
	Single,
	[MyDescription("显示多个扇区轨迹", "Display Multi Sectors")]
	Multi,
	[MyDescription("显示全部轨迹", "Display All Points")]
	All
}
