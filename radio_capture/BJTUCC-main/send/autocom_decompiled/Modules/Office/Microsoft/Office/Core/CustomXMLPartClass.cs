using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[ComImport]
[ClassInterface(0)]
[ComSourceInterfaces("Microsoft.Office.Core._CustomXMLPartEvents\0\0")]
[Guid("000CDB08-0000-0000-C000-000000000046")]
public class CustomXMLPartClass : _CustomXMLPart, CustomXMLPart, _CustomXMLPartEvents_Event
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
	public virtual extern CustomXMLNode DocumentElement
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809345)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(1610809346)]
	public virtual extern string Id
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809346)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610809347)]
	public virtual extern string NamespaceURI
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809347)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610809348)]
	public virtual extern CustomXMLSchemaCollection SchemaCollection
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809348)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809348)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Interface)]
		set;
	}

	[DispId(1610809350)]
	public virtual extern CustomXMLPrefixMappings NamespaceManager
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809350)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(1610809351)]
	public virtual extern string XML
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809351)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610809358)]
	public virtual extern CustomXMLValidationErrors Errors
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809358)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(1610809359)]
	public virtual extern bool BuiltIn
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809359)]
		get;
	}

	public virtual extern event _CustomXMLPartEvents_NodeAfterInsertEventHandler NodeAfterInsert;

	public virtual extern event _CustomXMLPartEvents_NodeAfterDeleteEventHandler NodeAfterDelete;

	public virtual extern event _CustomXMLPartEvents_NodeAfterReplaceEventHandler NodeAfterReplace;

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809352)]
	public virtual extern void AddNode([In][MarshalAs(UnmanagedType.Interface)] CustomXMLNode Parent, [In][MarshalAs(UnmanagedType.BStr)] string Name = "", [In][MarshalAs(UnmanagedType.BStr)] string NamespaceURI = "", [In][MarshalAs(UnmanagedType.Interface)] CustomXMLNode NextSibling = null, [In] MsoCustomXMLNodeType NodeType = MsoCustomXMLNodeType.msoCustomXMLNodeElement, [In][MarshalAs(UnmanagedType.BStr)] string NodeValue = "");

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809353)]
	public virtual extern void Delete();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809354)]
	public virtual extern bool Load([In][MarshalAs(UnmanagedType.BStr)] string FilePath);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809355)]
	public virtual extern bool LoadXML([In][MarshalAs(UnmanagedType.BStr)] string XML);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809356)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern CustomXMLNodes SelectNodes([In][MarshalAs(UnmanagedType.BStr)] string XPath);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809357)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern CustomXMLNode SelectSingleNode([In][MarshalAs(UnmanagedType.BStr)] string XPath);
}
