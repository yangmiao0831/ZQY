using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[ComEventInterface(typeof(IMsoEnvelopeVBEvents_0000), typeof(IMsoEnvelopeVBEvents_EventProvider_0000))]
[TypeLibType(16)]
[ComVisible(false)]
public interface IMsoEnvelopeVBEvents_Event
{
	event IMsoEnvelopeVBEvents_EnvelopeShowEventHandler EnvelopeShow;

	event IMsoEnvelopeVBEvents_EnvelopeHideEventHandler EnvelopeHide;
}
