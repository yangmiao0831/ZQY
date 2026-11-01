using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[TypeLibType(TypeLibTypeFlags.FHidden)]
[ClassInterface(ClassInterfaceType.None)]
public sealed class _CommandBarButtonEvents_SinkHelper : _CommandBarButtonEvents
{
	public _CommandBarButtonEvents_ClickEventHandler m_ClickDelegate;

	public int m_dwCookie;

	public void Click(CommandBarButton P_0, ref bool P_1)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_ClickDelegate != null)
		{
			m_ClickDelegate(P_0, ref P_1);
		}
	}

	internal _CommandBarButtonEvents_SinkHelper()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		m_dwCookie = 0;
		m_ClickDelegate = null;
	}
}
