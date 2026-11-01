using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[TypeLibType(16)]
[ComEventInterface(typeof(_CommandBarComboBoxEvents_0000), typeof(_CommandBarComboBoxEvents_EventProvider_0000))]
[ComVisible(false)]
public interface _CommandBarComboBoxEvents_Event
{
	event _CommandBarComboBoxEvents_ChangeEventHandler Change;
}
