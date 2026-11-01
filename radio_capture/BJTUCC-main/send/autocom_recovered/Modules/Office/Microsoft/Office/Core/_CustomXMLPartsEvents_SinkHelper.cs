using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[TypeLibType(TypeLibTypeFlags.FHidden)]
[ClassInterface(ClassInterfaceType.None)]
public sealed class _CustomXMLPartsEvents_SinkHelper : _CustomXMLPartsEvents
{
	public _CustomXMLPartsEvents_PartAfterAddEventHandler m_PartAfterAddDelegate;

	public _CustomXMLPartsEvents_PartBeforeDeleteEventHandler m_PartBeforeDeleteDelegate;

	public _CustomXMLPartsEvents_PartAfterLoadEventHandler m_PartAfterLoadDelegate;

	public int m_dwCookie;

	public void PartAfterAdd(CustomXMLPart P_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_PartAfterAddDelegate != null)
		{
			m_PartAfterAddDelegate(P_0);
		}
	}

	public void PartBeforeDelete(CustomXMLPart P_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_PartBeforeDeleteDelegate != null)
		{
			m_PartBeforeDeleteDelegate(P_0);
		}
	}

	public void PartAfterLoad(CustomXMLPart P_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_PartAfterLoadDelegate != null)
		{
			m_PartAfterLoadDelegate(P_0);
		}
	}

	internal _CustomXMLPartsEvents_SinkHelper()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		m_dwCookie = 0;
		m_PartAfterAddDelegate = null;
		m_PartBeforeDeleteDelegate = null;
		m_PartAfterLoadDelegate = null;
	}
}
