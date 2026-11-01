using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[ClassInterface(ClassInterfaceType.None)]
[TypeLibType(TypeLibTypeFlags.FHidden)]
public sealed class _CommandBarComboBoxEvents_SinkHelper : _CommandBarComboBoxEvents
{
	public _CommandBarComboBoxEvents_ChangeEventHandler m_ChangeDelegate;

	public int m_dwCookie;

	public void Change(CommandBarComboBox P_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (m_ChangeDelegate != null)
		{
			m_ChangeDelegate(P_0);
		}
	}

	internal _CommandBarComboBoxEvents_SinkHelper()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		m_dwCookie = 0;
		m_ChangeDelegate = null;
	}
}
