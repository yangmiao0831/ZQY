using System.ComponentModel;
using LibUtils;

namespace LibCoord;

public enum SessionRowType
{
	[MyDescription("业务属性", "Session attribute")]
	stSessionProperty,
	[MyDescription("业务内事件", "Session event")]
	stSessionEvent,
	[Description("AND")]
	stAND,
	[Description("OR")]
	stOR
}
