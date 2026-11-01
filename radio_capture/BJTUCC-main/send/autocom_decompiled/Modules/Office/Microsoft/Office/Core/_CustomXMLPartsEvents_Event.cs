using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[TypeLibType(16)]
[ComVisible(false)]
[ComEventInterface(typeof(_CustomXMLPartsEvents_0000), typeof(_CustomXMLPartsEvents_EventProvider_0000))]
public interface _CustomXMLPartsEvents_Event
{
	event _CustomXMLPartsEvents_PartAfterAddEventHandler PartAfterAdd;

	event _CustomXMLPartsEvents_PartBeforeDeleteEventHandler PartBeforeDelete;

	event _CustomXMLPartsEvents_PartAfterLoadEventHandler PartAfterLoad;
}
