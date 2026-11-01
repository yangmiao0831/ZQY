using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace Microsoft.Office.Core;

internal sealed class _CustomXMLPartEvents_EventProvider : _CustomXMLPartEvents_Event, IDisposable
{
	private IConnectionPointContainer m_ConnectionPointContainer;

	private ArrayList m_aEventSinkHelpers;

	private IConnectionPoint m_ConnectionPoint;

	private void Init()
	{
		IConnectionPoint ppCP = null;
		Guid riid = new Guid(new byte[16]
		{
			7, 219, 12, 0, 0, 0, 0, 0, 192, 0,
			0, 0, 0, 0, 0, 70
		});
		m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
		m_ConnectionPoint = ppCP;
		m_aEventSinkHelpers = new ArrayList();
	}

	public void add_NodeAfterInsert(_CustomXMLPartEvents_NodeAfterInsertEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			_CustomXMLPartEvents_SinkHelper customXMLPartEvents_SinkHelper = new _CustomXMLPartEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(customXMLPartEvents_SinkHelper, out pdwCookie);
			customXMLPartEvents_SinkHelper.m_dwCookie = pdwCookie;
			customXMLPartEvents_SinkHelper.m_NodeAfterInsertDelegate = P_0;
			m_aEventSinkHelpers.Add(customXMLPartEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_NodeAfterInsert(_CustomXMLPartEvents_NodeAfterInsertEventHandler P_0)
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
				_CustomXMLPartEvents_SinkHelper customXMLPartEvents_SinkHelper = (_CustomXMLPartEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (customXMLPartEvents_SinkHelper.m_NodeAfterInsertDelegate != null && ((customXMLPartEvents_SinkHelper.m_NodeAfterInsertDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(customXMLPartEvents_SinkHelper.m_dwCookie);
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

	public void add_NodeAfterDelete(_CustomXMLPartEvents_NodeAfterDeleteEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			_CustomXMLPartEvents_SinkHelper customXMLPartEvents_SinkHelper = new _CustomXMLPartEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(customXMLPartEvents_SinkHelper, out pdwCookie);
			customXMLPartEvents_SinkHelper.m_dwCookie = pdwCookie;
			customXMLPartEvents_SinkHelper.m_NodeAfterDeleteDelegate = P_0;
			m_aEventSinkHelpers.Add(customXMLPartEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_NodeAfterDelete(_CustomXMLPartEvents_NodeAfterDeleteEventHandler P_0)
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
				_CustomXMLPartEvents_SinkHelper customXMLPartEvents_SinkHelper = (_CustomXMLPartEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (customXMLPartEvents_SinkHelper.m_NodeAfterDeleteDelegate != null && ((customXMLPartEvents_SinkHelper.m_NodeAfterDeleteDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(customXMLPartEvents_SinkHelper.m_dwCookie);
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

	public void add_NodeAfterReplace(_CustomXMLPartEvents_NodeAfterReplaceEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			_CustomXMLPartEvents_SinkHelper customXMLPartEvents_SinkHelper = new _CustomXMLPartEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(customXMLPartEvents_SinkHelper, out pdwCookie);
			customXMLPartEvents_SinkHelper.m_dwCookie = pdwCookie;
			customXMLPartEvents_SinkHelper.m_NodeAfterReplaceDelegate = P_0;
			m_aEventSinkHelpers.Add(customXMLPartEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_NodeAfterReplace(_CustomXMLPartEvents_NodeAfterReplaceEventHandler P_0)
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
				_CustomXMLPartEvents_SinkHelper customXMLPartEvents_SinkHelper = (_CustomXMLPartEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (customXMLPartEvents_SinkHelper.m_NodeAfterReplaceDelegate != null && ((customXMLPartEvents_SinkHelper.m_NodeAfterReplaceDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(customXMLPartEvents_SinkHelper.m_dwCookie);
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

	public _CustomXMLPartEvents_EventProvider(object P_0)
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
					_CustomXMLPartEvents_SinkHelper customXMLPartEvents_SinkHelper = (_CustomXMLPartEvents_SinkHelper)m_aEventSinkHelpers[num];
					m_ConnectionPoint.Unadvise(customXMLPartEvents_SinkHelper.m_dwCookie);
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
