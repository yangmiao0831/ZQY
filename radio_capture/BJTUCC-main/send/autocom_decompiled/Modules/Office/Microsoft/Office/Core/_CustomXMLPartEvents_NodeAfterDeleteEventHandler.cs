using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[ComVisible(false)]
[TypeLibType(16)]
public delegate void _CustomXMLPartEvents_NodeAfterDeleteEventHandler([In][MarshalAs(UnmanagedType.Interface)] CustomXMLNode OldNode, [In][MarshalAs(UnmanagedType.Interface)] CustomXMLNode OldParentNode, [In][MarshalAs(UnmanagedType.Interface)] CustomXMLNode OldNextSibling, [In] bool InUndoRedo);
