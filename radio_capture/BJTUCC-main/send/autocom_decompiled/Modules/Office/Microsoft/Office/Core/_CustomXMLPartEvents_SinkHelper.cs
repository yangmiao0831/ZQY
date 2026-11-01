using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[TypeLibType(TypeLibTypeFlags.FHidden)]
[ClassInterface(ClassInterfaceType.None)]
public sealed class _CustomXMLPartEvents_SinkHelper : _CustomXMLPartEvents
{
	public _CustomXMLPartEvents_NodeAfterInsertEventHandler m_NodeAfterInsertDelegate;

	public _CustomXMLPartEvents_NodeAfterDeleteEventHandler m_NodeAfterDeleteDelegate;

	public _CustomXMLPartEvents_NodeAfterReplaceEventHandler m_NodeAfterReplaceDelegate;

	public int m_dwCookie;

	public void NodeAfterInsert(CustomXMLNode P_0, bool P_1)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_NodeAfterInsertDelegate != null)
		{
			m_NodeAfterInsertDelegate(P_0, P_1);
		}
	}

	public void NodeAfterDelete(CustomXMLNode P_0, CustomXMLNode P_1, CustomXMLNode P_2, bool P_3)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_NodeAfterDeleteDelegate != null)
		{
			m_NodeAfterDeleteDelegate(P_0, P_1, P_2, P_3);
		}
	}

	public void NodeAfterReplace(CustomXMLNode P_0, CustomXMLNode P_1, bool P_2)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_NodeAfterReplaceDelegate != null)
		{
			m_NodeAfterReplaceDelegate(P_0, P_1, P_2);
		}
	}

	internal _CustomXMLPartEvents_SinkHelper()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		m_dwCookie = 0;
		m_NodeAfterInsertDelegate = null;
		m_NodeAfterDeleteDelegate = null;
		m_NodeAfterReplaceDelegate = null;
	}
}
