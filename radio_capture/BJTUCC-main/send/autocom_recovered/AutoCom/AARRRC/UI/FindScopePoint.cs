using LibUtils;

namespace AARRRC.UI;

public enum FindScopePoint
{
	[MyDescription("业务开始", "Start Task")]
	start,
	[MyDescription("业务结束", "End Task")]
	end,
	[MyDescription("文件开始", "File Start")]
	fileStart,
	[MyDescription("下一次业务开始", "Next Session Start")]
	nextStart,
	[MyDescription("上一次业务结束", "Previos Session End")]
	preEnd
}
