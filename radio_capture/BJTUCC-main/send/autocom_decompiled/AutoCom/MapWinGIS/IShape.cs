using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MapWinGIS;

[ComImport]
[TypeIdentifier]
[Guid("5FA550E3-2044-4034-BAAA-B4CCE90A0C41")]
[CompilerGenerated]
public interface IShape
{
	void _VtblGap1_2();

	ShpfileType ShapeType
	{
		[DispId(3)]
		get;
		[DispId(3)]
		[param: In]
		set;
	}

	Point Point
	{
		[DispId(4)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[DispId(4)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}

	void _VtblGap2_8();

	[DispId(10)]
	bool Create([In] ShpfileType ShpType);

	void _VtblGap3_2();

	[DispId(13)]
	bool InsertPart([In] int pointIndex, [In][Out] ref int PartIndex);

	void _VtblGap4_39();

	[DispId(53)]
	int AddPoint([In] double x, [In] double y);
}
