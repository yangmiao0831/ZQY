using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[TypeLibType(16)]
[ComVisible(false)]
public delegate void _CustomXMLPartEvents_NodeAfterInsertEventHandler([In][MarshalAs(UnmanagedType.Interface)] CustomXMLNode NewNode, [In] bool InUndoRedo);
