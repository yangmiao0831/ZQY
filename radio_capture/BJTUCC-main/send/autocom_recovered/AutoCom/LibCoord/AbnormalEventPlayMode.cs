using LibUtils;

namespace LibCoord;

public enum AbnormalEventPlayMode
{
	[MyDescription("按事件名播放", "play event name")]
	EventName,
	[MyDescription("按Wave文件播放", "play wave file")]
	WaveFile
}
