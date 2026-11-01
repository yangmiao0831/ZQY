using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[TypeLibType(16)]
[ComVisible(false)]
public delegate void _CustomXMLPartsEvents_PartAfterLoadEventHandler([In][MarshalAs(UnmanagedType.Interface)] CustomXMLPart Part);
