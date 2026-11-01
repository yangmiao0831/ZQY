using LibUtils;

namespace AARRRC.UI;

public enum DimensionCondition
{
	[MyDescription("小区级 (频点-扰码)", "Cell")]
	Cell = 1,
	[MyDescription("5G Band", "5G Band")]
	Band5G,
	[MyDescription("5G ARFCN", "5G ARFCN")]
	ARFCN5G,
	[MyDescription("5G PCI", "5G PCI")]
	PCI5G,
	[MyDescription("5G NCI", "5G NCI")]
	NCI5G,
	[MyDescription("4G Band", "4G Band")]
	Band4G,
	[MyDescription("4G EARFCN", "4G EARFCN")]
	EARFCN4G,
	[MyDescription("4G PCI", "4G PCI")]
	PCI4G,
	[MyDescription("4G ECI", "4G ECI")]
	ECI4G,
	[MyDescription("运营商", "Operator")]
	Operator,
	[MyDescription("网格 (区域)", "Grid")]
	Grid
}
