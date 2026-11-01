using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[ClassInterface(ClassInterfaceType.None)]
[TypeLibType(TypeLibTypeFlags.FHidden)]
public sealed class _CommandBarsEvents_SinkHelper : _CommandBarsEvents
{
	public _CommandBarsEvents_OnUpdateEventHandler m_OnUpdateDelegate;

	public int m_dwCookie;

	public void OnUpdate()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_OnUpdateDelegate != null)
		{
			m_OnUpdateDelegate();
		}
	}

	internal _CommandBarsEvents_SinkHelper()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		m_dwCookie = 0;
		m_OnUpdateDelegate = null;
	}
}
