using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[ComImport]
[ClassInterface(0)]
[Guid("0006F01A-0000-0000-C000-000000000046")]
[ComSourceInterfaces("Microsoft.Office.Core.IMsoEnvelopeVBEvents\0\0")]
public class MsoEnvelopeClass : IMsoEnvelopeVB, MsoEnvelope, IMsoEnvelopeVBEvents_Event
{
	[DispId(1)]
	public virtual extern string Introduction
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(2)]
	public virtual extern object Item
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(2)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(3)]
	public virtual extern object Parent
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(3)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(4)]
	public virtual extern object CommandBars
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(4)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	public virtual extern event IMsoEnvelopeVBEvents_EnvelopeShowEventHandler EnvelopeShow;

	public virtual extern event IMsoEnvelopeVBEvents_EnvelopeHideEventHandler EnvelopeHide;
}
