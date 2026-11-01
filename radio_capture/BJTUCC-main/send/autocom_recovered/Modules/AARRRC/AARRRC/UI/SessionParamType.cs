namespace AARRRC.UI;

public enum SessionParamType
{
	[MyDescription("日志名称", "LogName")]
	LogName,
	[MyDescription("算术统计", "Statistics")]
	Stat,
	[MyDescription("时间点", "Time")]
	Time,
	[MyDescription("时延", "Delay")]
	Delay,
	[MyDescription("业务属性", "Property")]
	Property
}
