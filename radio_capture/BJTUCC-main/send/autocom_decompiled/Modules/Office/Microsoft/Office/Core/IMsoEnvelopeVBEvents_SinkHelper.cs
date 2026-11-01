using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[TypeLibType(TypeLibTypeFlags.FHidden)]
[ClassInterface(ClassInterfaceType.None)]
public sealed class IMsoEnvelopeVBEvents_SinkHelper : IMsoEnvelopeVBEvents
{
	public IMsoEnvelopeVBEvents_EnvelopeShowEventHandler m_EnvelopeShowDelegate;

	public IMsoEnvelopeVBEvents_EnvelopeHideEventHandler m_EnvelopeHideDelegate;

	public int m_dwCookie;

	public void EnvelopeShow()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_EnvelopeShowDelegate != null)
		{
			m_EnvelopeShowDelegate();
		}
	}

	public void EnvelopeHide()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_EnvelopeHideDelegate != null)
		{
			m_EnvelopeHideDelegate();
		}
	}

	internal IMsoEnvelopeVBEvents_SinkHelper()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		m_dwCookie = 0;
		m_EnvelopeShowDelegate = null;
		m_EnvelopeHideDelegate = null;
	}
}
