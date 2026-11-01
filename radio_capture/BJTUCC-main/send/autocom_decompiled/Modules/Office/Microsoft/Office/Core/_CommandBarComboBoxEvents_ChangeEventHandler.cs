using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[ComVisible(false)]
[TypeLibType(16)]
public delegate void _CommandBarComboBoxEvents_ChangeEventHandler([In][MarshalAs(UnmanagedType.Interface)] CommandBarComboBox Ctrl);
