using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel;

[ComImport]
[CompilerGenerated]
[InterfaceType(2)]
[Guid("00020893-0000-0000-C000-000000000046")]
[TypeIdentifier]
public interface Window
{
	void _VtblGap1_51();

	[DispId(1189)]
	Range RangeSelection
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1189)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}
}
