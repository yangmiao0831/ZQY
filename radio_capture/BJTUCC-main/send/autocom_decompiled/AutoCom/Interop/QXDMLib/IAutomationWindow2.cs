using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Interop.QXDMLib;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[Guid("10101010-1962-4EA3-8711-E650392C4276")]
[CompilerGenerated]
[TypeIdentifier]
public interface IAutomationWindow2
{
	void _VtblGap1_9();

	[PreserveSig]
	[DispId(9)]
	void Quit();

	void _VtblGap2_50();

	[PreserveSig]
	[DispId(60)]
	uint LoadItemStore([In][MarshalAs(UnmanagedType.BStr)] string p_fileName);

	void _VtblGap3_2();

	[PreserveSig]
	[DispId(63)]
	[return: MarshalAs(UnmanagedType.Interface)]
	AutomationColorItem GetItem([In] uint p_handle, [In] uint p_index);

	[PreserveSig]
	[DispId(64)]
	uint GetItemCount();

	void _VtblGap4_20();

	[PreserveSig]
	[DispId(85)]
	void CloseItemStoreWithHandle([In] uint p_clientHandle);
}
