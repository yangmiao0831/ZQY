using System.ComponentModel;

namespace LibCoord;

public enum LiveAppType
{
	[Description("仅观看")]
	look,
	[Description("仅直播")]
	live,
	[Description("配对-观看端")]
	doubleLook,
	[Description("配对-直播端")]
	doubleLive
}
