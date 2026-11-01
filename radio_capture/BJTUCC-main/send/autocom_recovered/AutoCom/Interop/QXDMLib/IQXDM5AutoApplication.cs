using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Interop.QXDMLib;

[ComImport]
[TypeIdentifier]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[Guid("FF22FACC-01DC-412E-9CF1-C082020AECDB")]
public interface IQXDM5AutoApplication
{
	void _VtblGap1_2();

	[PreserveSig]
	[DispId(3)]
	[return: MarshalAs(UnmanagedType.Interface)]
	AutomationWindow2 GetAutomationWindow2();
}
