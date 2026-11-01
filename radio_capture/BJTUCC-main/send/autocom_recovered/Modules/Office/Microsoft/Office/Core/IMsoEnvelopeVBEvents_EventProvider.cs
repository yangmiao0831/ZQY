using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace Microsoft.Office.Core;

internal sealed class IMsoEnvelopeVBEvents_EventProvider : IMsoEnvelopeVBEvents_Event, IDisposable
{
	private IConnectionPointContainer m_ConnectionPointContainer;

	private ArrayList m_aEventSinkHelpers;

	private IConnectionPoint m_ConnectionPoint;

	private void Init()
	{
		IConnectionPoint ppCP = null;
		Guid riid = new Guid(new byte[16]
		{
			173, 114, 6, 0, 0, 0, 0, 0, 192, 0,
			0, 0, 0, 0, 0, 70
		});
		m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
		m_ConnectionPoint = ppCP;
		m_aEventSinkHelpers = new ArrayList();
	}

	public void add_EnvelopeShow(IMsoEnvelopeVBEvents_EnvelopeShowEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsoEnvelopeVBEvents_SinkHelper msoEnvelopeVBEvents_SinkHelper = new IMsoEnvelopeVBEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msoEnvelopeVBEvents_SinkHelper, out pdwCookie);
			msoEnvelopeVBEvents_SinkHelper.m_dwCookie = pdwCookie;
			msoEnvelopeVBEvents_SinkHelper.m_EnvelopeShowDelegate = P_0;
			m_aEventSinkHelpers.Add(msoEnvelopeVBEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_EnvelopeShow(IMsoEnvelopeVBEvents_EnvelopeShowEventHandler P_0)
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
				IMsoEnvelopeVBEvents_SinkHelper msoEnvelopeVBEvents_SinkHelper = (IMsoEnvelopeVBEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msoEnvelopeVBEvents_SinkHelper.m_EnvelopeShowDelegate != null && ((msoEnvelopeVBEvents_SinkHelper.m_EnvelopeShowDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msoEnvelopeVBEvents_SinkHelper.m_dwCookie);
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

	public void add_EnvelopeHide(IMsoEnvelopeVBEvents_EnvelopeHideEventHandler P_0)
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				Init();
			}
			IMsoEnvelopeVBEvents_SinkHelper msoEnvelopeVBEvents_SinkHelper = new IMsoEnvelopeVBEvents_SinkHelper();
			int pdwCookie = 0;
			m_ConnectionPoint.Advise(msoEnvelopeVBEvents_SinkHelper, out pdwCookie);
			msoEnvelopeVBEvents_SinkHelper.m_dwCookie = pdwCookie;
			msoEnvelopeVBEvents_SinkHelper.m_EnvelopeHideDelegate = P_0;
			m_aEventSinkHelpers.Add(msoEnvelopeVBEvents_SinkHelper);
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public void remove_EnvelopeHide(IMsoEnvelopeVBEvents_EnvelopeHideEventHandler P_0)
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
				IMsoEnvelopeVBEvents_SinkHelper msoEnvelopeVBEvents_SinkHelper = (IMsoEnvelopeVBEvents_SinkHelper)m_aEventSinkHelpers[num];
				if (msoEnvelopeVBEvents_SinkHelper.m_EnvelopeHideDelegate != null && ((msoEnvelopeVBEvents_SinkHelper.m_EnvelopeHideDelegate.Equals(P_0) ? 1u : 0u) & 0xFFu) != 0)
				{
					m_aEventSinkHelpers.RemoveAt(num);
					m_ConnectionPoint.Unadvise(msoEnvelopeVBEvents_SinkHelper.m_dwCookie);
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

	public IMsoEnvelopeVBEvents_EventProvider(object P_0)
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
					IMsoEnvelopeVBEvents_SinkHelper msoEnvelopeVBEvents_SinkHelper = (IMsoEnvelopeVBEvents_SinkHelper)m_aEventSinkHelpers[num];
					m_ConnectionPoint.Unadvise(msoEnvelopeVBEvents_SinkHelper.m_dwCookie);
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
