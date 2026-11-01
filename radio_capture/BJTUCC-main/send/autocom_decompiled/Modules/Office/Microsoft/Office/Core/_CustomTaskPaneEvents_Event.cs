using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[TypeLibType(16)]
[ComEventInterface(typeof(_CustomTaskPaneEvents_0000), typeof(_CustomTaskPaneEvents_EventProvider_0000))]
[ComVisible(false)]
public interface _CustomTaskPaneEvents_Event
{
	event _CustomTaskPaneEvents_VisibleStateChangeEventHandler VisibleStateChange;

	event _CustomTaskPaneEvents_DockPositionStateChangeEventHandler DockPositionStateChange;
}
