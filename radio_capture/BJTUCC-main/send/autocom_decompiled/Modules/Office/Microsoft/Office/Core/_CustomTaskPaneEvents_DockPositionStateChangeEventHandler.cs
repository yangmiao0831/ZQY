using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[TypeLibType(16)]
[ComVisible(false)]
public delegate void _CustomTaskPaneEvents_DockPositionStateChangeEventHandler([In][MarshalAs(UnmanagedType.Interface)] CustomTaskPane CustomTaskPaneInst);
