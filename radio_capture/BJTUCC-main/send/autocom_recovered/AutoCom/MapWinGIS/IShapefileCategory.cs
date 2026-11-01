using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MapWinGIS;

[ComImport]
[TypeIdentifier]
[CompilerGenerated]
[Guid("688EB3FF-CF7A-490C-9BC7-BE47CEB32C59")]
public interface IShapefileCategory
{
	void _VtblGap1_4();

	ShapeDrawingOptions DrawingOptions
	{
		[DispId(3)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[DispId(3)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}
}
