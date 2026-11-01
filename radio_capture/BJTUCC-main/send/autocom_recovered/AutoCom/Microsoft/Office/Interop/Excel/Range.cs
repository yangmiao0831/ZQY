using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel;

[ComImport]
[Guid("00020846-0000-0000-C000-000000000046")]
[CompilerGenerated]
[TypeIdentifier]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
public interface Range : IEnumerable
{
	void _VtblGap1_35();

	[PreserveSig]
	[DispId(551)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Copy([Optional][In][MarshalAs(UnmanagedType.Struct)] object Destination);

	void _VtblGap2_9();

	[IndexerName("_Default")]
	object this[[Optional][In][MarshalAs(UnmanagedType.Struct)] object RowIndex, [Optional][In][MarshalAs(UnmanagedType.Struct)] object ColumnIndex]
	{
		[PreserveSig]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[PreserveSig]
		[DispId(0)]
		[param: Optional]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[PreserveSig]
	[DispId(117)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Delete([Optional][In][MarshalAs(UnmanagedType.Struct)] object Shift);
}
