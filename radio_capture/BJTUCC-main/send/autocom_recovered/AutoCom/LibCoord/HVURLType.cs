using LibUtils;

namespace LibCoord;

public enum HVURLType
{
	[MyDescription("翻译地址", "Source URL")]
	SourceURL,
	[MyDescription("直接地址", "Web URL")]
	WebURL,
	[MyDescription("视频关键字", "Video Keyword")]
	VideoKeyword,
	[MyDescription("首页推荐视频", "Video Top List")]
	VideoTopList
}
