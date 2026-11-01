using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[TypeLibType(16)]
[ComVisible(false)]
public delegate void _CustomXMLPartsEvents_PartAfterAddEventHandler([In][MarshalAs(UnmanagedType.Interface)] CustomXMLPart NewPart);
