using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[TypeLibType(16)]
[ComVisible(false)]
[ComEventInterface(typeof(_CommandBarButtonEvents_0000), typeof(_CommandBarButtonEvents_EventProvider_0000))]
public interface _CommandBarButtonEvents_Event
{
	event _CommandBarButtonEvents_ClickEventHandler Click;
}
