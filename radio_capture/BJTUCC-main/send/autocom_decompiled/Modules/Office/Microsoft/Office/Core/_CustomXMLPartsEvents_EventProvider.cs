using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace Microsoft.Office.Core;

internal sealed class _CustomXMLPartsEvents_EventProvider : _CustomXMLPartsEvents_Event, IDisposable
{
	private IConnectionPointContainer m_ConnectionPointContainer;

	private ArrayList m_aEventSinkHelpers;

	private IConnectionPoint m_ConnectionPoint;

	private void Init()
	{
		IConnectionPoint ppCP = null;
		Guid riid = new Guid(new byte[16]
		{
			11, 219, 12, 0, 0, 0, 0, 0, 192, 0,
			0, 0, 0, 0, 0, 70
		});
		m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
		m_ConnectionPoint = ppCP;
		m_aEventSinkHelpers = new ArrayList();
	}

	public void add_PartAfterAdd(_CustomXMLPartsEvents_PartAfterAddEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			_CustomXMLPartsEvents_SinkHelper customXMLPartsEvents_SinkHelper = new _CustomXMLPartsEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(customXMLPartsEvents_SinkHelper, out pdwCookie);
			customXMLPartsEvents_SinkHelper.m_dwCookie = pdwCookie;
			customXMLPartsEvents_SinkHelper.m_PartAfterAddDelegate = P_0;
			m_aEventSinkHelpers.Add(customXMLPartsEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_PartAfterAdd(_CustomXMLPartsEvents_PartAfterAddEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				_CustomXMLPartsEvents_SinkHelper customXMLPartsEvents_SinkHelper = (_CustomXMLPartsEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (customXMLPartsEvents_SinkHelper.m_PartAfterAddDelegate != null && ((customXMLPartsEvents_SinkHelper.m_PartAfterAddDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(customXMLPartsEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void add_PartBeforeDelete(_CustomXMLPartsEvents_PartBeforeDeleteEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			_CustomXMLPartsEvents_SinkHelper customXMLPartsEvents_SinkHelper = new _CustomXMLPartsEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(customXMLPartsEvents_SinkHelper, out pdwCookie);
			customXMLPartsEvents_SinkHelper.m_dwCookie = pdwCookie;
			customXMLPartsEvents_SinkHelper.m_PartBeforeDeleteDelegate = P_0;
			m_aEventSinkHelpers.Add(customXMLPartsEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_PartBeforeDelete(_CustomXMLPartsEvents_PartBeforeDeleteEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				_CustomXMLPartsEvents_SinkHelper customXMLPartsEvents_SinkHelper = (_CustomXMLPartsEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (customXMLPartsEvents_SinkHelper.m_PartBeforeDeleteDelegate != null && ((customXMLPartsEvents_SinkHelper.m_PartBeforeDeleteDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(customXMLPartsEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void add_PartAfterLoad(_CustomXMLPartsEvents_PartAfterLoadEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			_CustomXMLPartsEvents_SinkHelper customXMLPartsEvents_SinkHelper = new _CustomXMLPartsEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(customXMLPartsEvents_SinkHelper, out pdwCookie);
			customXMLPartsEvents_SinkHelper.m_dwCookie = pdwCookie;
			customXMLPartsEvents_SinkHelper.m_PartAfterLoadDelegate = P_0;
			m_aEventSinkHelpers.Add(customXMLPartsEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_PartAfterLoad(_CustomXMLPartsEvents_PartAfterLoadEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_aEventSinkHelpers == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 >= count)
			{
				return;
			}
			do
			{
				_CustomXMLPartsEvents_SinkHelper customXMLPartsEvents_SinkHelper = (_CustomXMLPartsEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (customXMLPartsEvents_SinkHelper.m_PartAfterLoadDelegate != null && ((customXMLPartsEvents_SinkHelper.m_PartAfterLoadDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(customXMLPartsEvents_SinkHelper.m_dwCookie);
					if (count <= 1)
					{
						Marshal.ReleaseComObject(m_ConnectionPoint);
						m_ConnectionPoint = null;
						m_aEventSinkHelpers = null;
					}
					break;
				}
				num++;
			}
			while (num < count);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public _CustomXMLPartsEvents_EventProvider(object P_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		m_ConnectionPointContainer = (IConnectionPointContainer)P_0;
	}

	public void Finalize()
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 < count)
			{
				do
				{
					_CustomXMLPartsEvents_SinkHelper customXMLPartsEvents_SinkHelper = (_CustomXMLPartsEvents_SinkHelper)m_aEventSinkHelpers[num];
					m_ConnectionPoint.Unadvise(customXMLPartsEvents_SinkHelper.m_dwCookie);
					num++;
				}
				while (num < count);
			}
			Marshal.ReleaseComObject(m_ConnectionPoint);
		}
		catch (Exception)
		{
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void Dispose()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		Finalize();
		GC.SuppressFinalize(this);
	}
}
