using LibUtils;

namespace Spark;

public enum AMTUMode
{
	[MyDescription("定点模式", "Fixed mode")]
	Fixed,
	[MyDescription("渐变模式-单向", "Gradient Unidirectional")]
	Gradient,
	[MyDescription("渐变模式-往返", "Gradient Round")]
	Both
}
