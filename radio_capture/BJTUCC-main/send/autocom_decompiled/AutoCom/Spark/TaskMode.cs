using LibUtils;

namespace Spark;

public enum TaskMode
{
	[MyDescription("单机模式", "Single Mode")]
	Default,
	[MyDescription("ATU模式(license文件)", "ATU Mode(license file)")]
	Atu,
	[MyDescription("ATU模式(BoxID)", "ATU Mode(BoxID)")]
	OldAtu,
	[MyDescription("Sigma模式", "Sigma Mode")]
	Sigma,
	[MyDescription("CU模式", "CU Mode")]
	CU
}
