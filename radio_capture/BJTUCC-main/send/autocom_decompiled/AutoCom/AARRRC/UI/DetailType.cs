using LibUtils;

namespace AARRRC.UI;

public enum DetailType
{
	[MyDescription("业务范围详情", "Details of session scope")]
	sessiondetail,
	[MyDescription("事件前后详情", "Details before and after the event")]
	eventdetail,
	[MyDescription("信令前后详情", "Details before and after the message")]
	msgdetail
}
