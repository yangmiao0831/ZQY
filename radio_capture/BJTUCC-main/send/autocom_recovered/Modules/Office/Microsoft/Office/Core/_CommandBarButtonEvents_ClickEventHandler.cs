using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[TypeLibType(16)]
[ComVisible(false)]
public delegate void _CommandBarButtonEvents_ClickEventHandler([In][MarshalAs(UnmanagedType.Interface)] CommandBarButton Ctrl, [In][Out] ref bool CancelDefault);
