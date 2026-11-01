using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Interop.QXDMLib;

[ComImport]
[Guid("10101010-1962-4EA3-8711-C68F9DE5304F")]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[TypeIdentifier]
[CompilerGenerated]
public interface IAutomationColorItem
{
	void _VtblGap1_24();

	[PreserveSig]
	[DispId(25)]
	[return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_UI1)]
	byte[] GetItemDLFBuffer();
}
