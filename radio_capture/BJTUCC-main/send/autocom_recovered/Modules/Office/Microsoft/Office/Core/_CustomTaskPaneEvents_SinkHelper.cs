using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[ClassInterface(ClassInterfaceType.None)]
[TypeLibType(TypeLibTypeFlags.FHidden)]
public sealed class _CustomTaskPaneEvents_SinkHelper : _CustomTaskPaneEvents
{
	public _CustomTaskPaneEvents_VisibleStateChangeEventHandler m_VisibleStateChangeDelegate;

	public _CustomTaskPaneEvents_DockPositionStateChangeEventHandler m_DockPositionStateChangeDelegate;

	public int m_dwCookie;

	public void VisibleStateChange(CustomTaskPane P_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_VisibleStateChangeDelegate != null)
		{
			m_VisibleStateChangeDelegate(P_0);
		}
	}

	public void DockPositionStateChange(CustomTaskPane P_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_DockPositionStateChangeDelegate != null)
		{
			m_DockPositionStateChangeDelegate(P_0);
		}
	}

	internal _CustomTaskPaneEvents_SinkHelper()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		m_dwCookie = 0;
		m_VisibleStateChangeDelegate = null;
		m_DockPositionStateChangeDelegate = null;
	}
}
