using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MapWinGIS;

[ComImport]
[TypeIdentifier]
[Guid("7399B752-61D9-4A23-973F-1033431DD009")]
[CompilerGenerated]
public interface IShapeDrawingOptions
{
	void _VtblGap1_2();

	bool LineVisible
	{
		[DispId(2)]
		get;
		[DispId(2)]
		[param: In]
		set;
	}

	void _VtblGap2_2();

	uint FillColor
	{
		[DispId(4)]
		get;
		[DispId(4)]
		[param: In]
		set;
	}

	void _VtblGap3_4();

	tkGDIPlusHatchStyle FillHatchStyle
	{
		[DispId(7)]
		get;
		[DispId(7)]
		[param: In]
		set;
	}

	void _VtblGap4_2();

	tkPointShapeType PointShape
	{
		[DispId(9)]
		get;
		[DispId(9)]
		[param: In]
		set;
	}

	float FillTransparency
	{
		[DispId(10)]
		get;
		[DispId(10)]
		[param: In]
		set;
	}

	void _VtblGap5_2();

	float PointSize
	{
		[DispId(12)]
		get;
		[DispId(12)]
		[param: In]
		set;
	}

	void _VtblGap6_4();

	Image Picture
	{
		[DispId(15)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[DispId(15)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}

	void _VtblGap7_2();

	tkFillType FillType
	{
		[DispId(17)]
		get;
		[DispId(17)]
		[param: In]
		set;
	}

	void _VtblGap8_2();

	tkPointSymbolType PointType
	{
		[DispId(19)]
		get;
		[DispId(19)]
		[param: In]
		set;
	}

	void _VtblGap9_63();

	bool ShowValue
	{
		[DispId(65)]
		get;
		[DispId(65)]
		[param: In]
		set;
	}

	bool ShowValueChanged
	{
		[DispId(66)]
		get;
		[DispId(66)]
		[param: In]
		set;
	}
}
