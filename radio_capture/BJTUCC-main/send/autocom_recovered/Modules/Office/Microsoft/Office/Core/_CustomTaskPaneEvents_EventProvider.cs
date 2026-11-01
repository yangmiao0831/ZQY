using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace Microsoft.Office.Core;

internal sealed class _CustomTaskPaneEvents_EventProvider : _CustomTaskPaneEvents_Event, IDisposable
{
	private IConnectionPointContainer m_ConnectionPointContainer;

	private ArrayList m_aEventSinkHelpers;

	private IConnectionPoint m_ConnectionPoint;

	private void Init()
	{
		IConnectionPoint ppCP = null;
		Guid riid = new Guid(new byte[16]
		{
			60, 3, 12, 0, 0, 0, 0, 0, 192, 0,
			0, 0, 0, 0, 0, 70
		});
		m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
		m_ConnectionPoint = ppCP;
		m_aEventSinkHelpers = new ArrayList();
	}

	public void add_VisibleStateChange(_CustomTaskPaneEvents_VisibleStateChangeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			_CustomTaskPaneEvents_SinkHelper customTaskPaneEvents_SinkHelper = new _CustomTaskPaneEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(customTaskPaneEvents_SinkHelper, out pdwCookie);
			customTaskPaneEvents_SinkHelper.m_dwCookie = pdwCookie;
			customTaskPaneEvents_SinkHelper.m_VisibleStateChangeDelegate = P_0;
			m_aEventSinkHelpers.Add(customTaskPaneEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_VisibleStateChange(_CustomTaskPaneEvents_VisibleStateChangeEventHandler P_0)
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
				_CustomTaskPaneEvents_SinkHelper customTaskPaneEvents_SinkHelper = (_CustomTaskPaneEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (customTaskPaneEvents_SinkHelper.m_VisibleStateChangeDelegate != null && ((customTaskPaneEvents_SinkHelper.m_VisibleStateChangeDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(customTaskPaneEvents_SinkHelper.m_dwCookie);
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

	public void add_DockPositionStateChange(_CustomTaskPaneEvents_DockPositionStateChangeEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			_CustomTaskPaneEvents_SinkHelper customTaskPaneEvents_SinkHelper = new _CustomTaskPaneEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(customTaskPaneEvents_SinkHelper, out pdwCookie);
			customTaskPaneEvents_SinkHelper.m_dwCookie = pdwCookie;
			customTaskPaneEvents_SinkHelper.m_DockPositionStateChangeDelegate = P_0;
			m_aEventSinkHelpers.Add(customTaskPaneEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_DockPositionStateChange(_CustomTaskPaneEvents_DockPositionStateChangeEventHandler P_0)
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
				_CustomTaskPaneEvents_SinkHelper customTaskPaneEvents_SinkHelper = (_CustomTaskPaneEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (customTaskPaneEvents_SinkHelper.m_DockPositionStateChangeDelegate != null && ((customTaskPaneEvents_SinkHelper.m_DockPositionStateChangeDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(customTaskPaneEvents_SinkHelper.m_dwCookie);
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

	public _CustomTaskPaneEvents_EventProvider(object P_0)
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
					_CustomTaskPaneEvents_SinkHelper customTaskPaneEvents_SinkHelper = (_CustomTaskPaneEvents_SinkHelper)m_aEventSinkHelpers[num];
					m_ConnectionPoint.Unadvise(customTaskPaneEvents_SinkHelper.m_dwCookie);
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
