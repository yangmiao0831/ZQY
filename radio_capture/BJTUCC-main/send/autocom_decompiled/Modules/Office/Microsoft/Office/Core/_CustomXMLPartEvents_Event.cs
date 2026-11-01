using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[ComVisible(false)]
[ComEventInterface(typeof(_CustomXMLPartEvents_0000), typeof(_CustomXMLPartEvents_EventProvider_0000))]
[TypeLibType(16)]
public interface _CustomXMLPartEvents_Event
{
	event _CustomXMLPartEvents_NodeAfterInsertEventHandler NodeAfterInsert;

	event _CustomXMLPartEvents_NodeAfterDeleteEventHandler NodeAfterDelete;

	event _CustomXMLPartEvents_NodeAfterReplaceEventHandler NodeAfterReplace;
}
