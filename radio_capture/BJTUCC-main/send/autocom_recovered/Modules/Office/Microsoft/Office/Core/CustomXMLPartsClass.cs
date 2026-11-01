using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[ComImport]
[Guid("000CDB0C-0000-0000-C000-000000000046")]
[ClassInterface(0)]
[ComSourceInterfaces("Microsoft.Office.Core._CustomXMLPartsEvents\0\0")]
public class CustomXMLPartsClass : _CustomXMLParts, CustomXMLParts, _CustomXMLPartsEvents_Event, IEnumerable
{
	[DispId(1610743808)]
	public virtual extern object Application
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610743808)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(1610743809)]
	public virtual extern int Creator
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610743809)]
		get;
	}

	[DispId(1610809344)]
	public virtual extern object Parent
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809344)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(1610809345)]
	public virtual extern int Count
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809345)]
		get;
	}

	[DispId(0)]
	public virtual extern CustomXMLPart this[[In][MarshalAs(UnmanagedType.Struct)] object Index]
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	public virtual extern event _CustomXMLPartsEvents_PartAfterAddEventHandler PartAfterAdd;

	public virtual extern event _CustomXMLPartsEvents_PartBeforeDeleteEventHandler PartBeforeDelete;

	public virtual extern event _CustomXMLPartsEvents_PartAfterLoadEventHandler PartAfterLoad;

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809347)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern CustomXMLPart Add([In][MarshalAs(UnmanagedType.BStr)] string XML = "", [Optional][In][MarshalAs(UnmanagedType.Struct)] object SchemaCollection);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809348)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern CustomXMLPart SelectByID([In][MarshalAs(UnmanagedType.BStr)] string Id);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809349)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern CustomXMLParts SelectByNamespace([In][MarshalAs(UnmanagedType.BStr)] string NamespaceURI);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[TypeLibFunc(1024)]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public virtual extern IEnumerator GetEnumerator();
}
