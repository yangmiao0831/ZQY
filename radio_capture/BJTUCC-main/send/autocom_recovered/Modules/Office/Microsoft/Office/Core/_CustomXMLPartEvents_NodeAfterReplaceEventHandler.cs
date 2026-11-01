using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[TypeLibType(16)]
[ComVisible(false)]
public delegate void _CustomXMLPartEvents_NodeAfterReplaceEventHandler([In][MarshalAs(UnmanagedType.Interface)] CustomXMLNode OldNode, [In][MarshalAs(UnmanagedType.Interface)] CustomXMLNode NewNode, [In] bool InUndoRedo);
