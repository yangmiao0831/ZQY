using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MapWinGIS;

[ComImport]
[TypeIdentifier]
[Guid("EC594CB1-FA55-469C-B662-192F7A464C23")]
[CompilerGenerated]
public interface IShapefileCategories
{
	void _VtblGap1_10();

	ShapefileCategory Item
	{
		[DispId(9)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[DispId(9)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}

	void _VtblGap2_1();

	int Count
	{
		[DispId(11)]
		get;
	}

	void _VtblGap3_1();

	[DispId(13)]
	void ApplyExpressions();

	void _VtblGap4_10();

	[DispId(23)]
	bool AddRange([In] int FieldIndex, [In] tkClassificationType ClassificationType, [In] int numClasses, [In][MarshalAs(UnmanagedType.Struct)] object MinValue, [In][MarshalAs(UnmanagedType.Struct)] object MaxValue);
}
