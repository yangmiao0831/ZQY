using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MapWinGIS;

[ComImport]
[Guid("5DC72405-C39C-4755-8CFC-9876A89225BC")]
[TypeIdentifier]
[CompilerGenerated]
public interface IShapefile
{
	int NumShapes
	{
		[DispId(1)]
		get;
	}

	void _VtblGap1_3();

	Shape Shape
	{
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap2_11();

	[DispId(15)]
	bool EditClear();

	void _VtblGap3_1();

	[DispId(17)]
	bool EditDeleteShape([In] int ShapeIndex);

	void _VtblGap4_1();

	[DispId(19)]
	bool StartEditingShapes([In] bool StartEditTable = true, [Optional][In][MarshalAs(UnmanagedType.Interface)] ICallback cBack);

	[DispId(20)]
	bool StopEditingShapes([In] bool ApplyChanges = true, [In] bool StopEditTable = true, [Optional][In][MarshalAs(UnmanagedType.Interface)] ICallback cBack);

	void _VtblGap5_2();

	[DispId(24)]
	bool EditCellValue([In] int FieldIndex, [In] int ShapeIndex, [In][MarshalAs(UnmanagedType.Struct)] object newVal);

	void _VtblGap6_19();

	[DispId(42)]
	bool CreateNewWithShapeID([In][MarshalAs(UnmanagedType.BStr)] string ShapefileName, [In] ShpfileType ShapefileType);

	void _VtblGap7_28();

	Labels Labels
	{
		[DispId(66)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[DispId(66)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}

	void _VtblGap8_2();

	ShapeDrawingOptions DefaultDrawingOptions
	{
		[DispId(69)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[DispId(69)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}

	ShapefileCategories Categories
	{
		[DispId(70)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[DispId(70)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}

	void _VtblGap9_28();

	tkCollisionMode CollisionMode
	{
		[DispId(91)]
		get;
		[DispId(91)]
		[param: In]
		set;
	}

	void _VtblGap10_11();

	[DispId(101)]
	int EditAddShape([In][MarshalAs(UnmanagedType.Interface)] Shape Shape);

	[DispId(102)]
	int EditAddField([In][MarshalAs(UnmanagedType.BStr)] string Name, [In] FieldType Type, [In] int Precision, [In] int Width);

	void _VtblGap11_34();

	int FieldIndexByName
	{
		[DispId(130)]
		get;
	}

	void _VtblGap12_11();

	[DispId(140)]
	void StopAppendMode();

	void _VtblGap13_4();

	[DispId(151)]
	bool SetParamOffset([In] double OffsetX, [In] double OffsetY);

	void _VtblGap14_2();

	bool ArrowShow
	{
		[DispId(1001)]
		get;
		[DispId(1001)]
		[param: In]
		set;
	}

	double ArrowDist
	{
		[DispId(1002)]
		get;
		[DispId(1002)]
		[param: In]
		set;
	}

	int ArrowClr
	{
		[DispId(1003)]
		get;
		[DispId(1003)]
		[param: In]
		set;
	}

	bool THLClose
	{
		[DispId(1004)]
		get;
		[DispId(1004)]
		[param: In]
		set;
	}
}
