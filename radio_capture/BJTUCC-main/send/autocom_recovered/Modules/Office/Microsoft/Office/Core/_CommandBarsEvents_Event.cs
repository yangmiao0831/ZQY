using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[ComVisible(false)]
[TypeLibType(16)]
[ComEventInterface(typeof(_CommandBarsEvents_0000), typeof(_CommandBarsEvents_EventProvider_0000))]
public interface _CommandBarsEvents_Event
{
	event _CommandBarsEvents_OnUpdateEventHandler OnUpdate;
}
