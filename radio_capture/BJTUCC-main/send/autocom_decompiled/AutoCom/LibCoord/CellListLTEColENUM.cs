using LibUtils;

namespace LibCoord;

public enum CellListLTEColENUM
{
	[ColumnWidth(80)]
	colCellCategory,
	[ColumnWidth(60)]
	colEARFCN,
	[ColumnWidth(50)]
	colPCI,
	[ColumnWidth(60)]
	colMOD3,
	[ColumnWidth(60)]
	colRSRP,
	[ColumnWidth(60)]
	colRSRQ,
	[ColumnWidth(60)]
	colRSSI,
	[ColumnWidth(60)]
	colSINR,
	[ColumnWidth(60)]
	colDistance,
	[ColumnWidth(100)]
	colCellName,
	[ColumnWidth(65)]
	colCarrierID
}
