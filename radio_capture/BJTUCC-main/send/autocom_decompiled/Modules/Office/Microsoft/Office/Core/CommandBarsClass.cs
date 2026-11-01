using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using stdole;

namespace Microsoft.Office.Core;

[ComImport]
[Guid("55F88893-7708-11D1-ACEB-006008961DA5")]
[ClassInterface(0)]
[ComSourceInterfaces("Microsoft.Office.Core._CommandBarsEvents\0\0")]
public class CommandBarsClass : _CommandBars, CommandBars, _CommandBarsEvents_Event, IEnumerable
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
	public virtual extern CommandBarControl ActionControl
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809344)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(1610809345)]
	public virtual extern CommandBar ActiveMenuBar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809345)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(1610809347)]
	public virtual extern int Count
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809347)]
		get;
	}

	[DispId(1610809348)]
	public virtual extern bool DisplayTooltips
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809348)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809348)]
		[param: In]
		set;
	}

	[DispId(1610809350)]
	public virtual extern bool DisplayKeysInTooltips
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809350)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809350)]
		[param: In]
		set;
	}

	[DispId(0)]
	public virtual extern CommandBar this[[In][MarshalAs(UnmanagedType.Struct)] object Index]
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(1610809354)]
	public virtual extern bool LargeButtons
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809354)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809354)]
		[param: In]
		set;
	}

	[DispId(1610809356)]
	public virtual extern MsoMenuAnimation MenuAnimationStyle
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809356)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809356)]
		[param: In]
		set;
	}

	[DispId(1610809359)]
	public virtual extern object Parent
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809359)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(1610809361)]
	public virtual extern int IdsString
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809361)]
		[TypeLibFunc(64)]
		get;
	}

	[DispId(1610809362)]
	public virtual extern int TmcGetName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[TypeLibFunc(64)]
		[DispId(1610809362)]
		get;
	}

	[DispId(1610809363)]
	public virtual extern bool AdaptiveMenus
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809363)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809363)]
		[param: In]
		set;
	}

	[DispId(1610809367)]
	public virtual extern bool DisplayFonts
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809367)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809367)]
		[param: In]
		set;
	}

	[DispId(1610809369)]
	public virtual extern bool DisableCustomize
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809369)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809369)]
		[param: In]
		set;
	}

	[DispId(1610809371)]
	public virtual extern bool DisableAskAQuestionDropdown
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809371)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809371)]
		[param: In]
		set;
	}

	public virtual extern event _CommandBarsEvents_OnUpdateEventHandler OnUpdate;

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809346)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern CommandBar Add([Optional][In][MarshalAs(UnmanagedType.Struct)] object Name, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Position, [Optional][In][MarshalAs(UnmanagedType.Struct)] object MenuBar, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Temporary);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809352)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern CommandBarControl FindControl([Optional][In][MarshalAs(UnmanagedType.Struct)] object Type, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Id, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Tag, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Visible);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[TypeLibFunc(1024)]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public virtual extern IEnumerator GetEnumerator();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809360)]
	public virtual extern void ReleaseFocus();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809365)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern CommandBarControls FindControls([Optional][In][MarshalAs(UnmanagedType.Struct)] object Type, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Id, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Tag, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Visible);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809366)]
	[TypeLibFunc(64)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern CommandBar AddEx([Optional][In][MarshalAs(UnmanagedType.Struct)] object TbidOrName, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Position, [Optional][In][MarshalAs(UnmanagedType.Struct)] object MenuBar, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Temporary, [Optional][In][MarshalAs(UnmanagedType.Struct)] object TbtrProtection);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809373)]
	public virtual extern void ExecuteMso([In][MarshalAs(UnmanagedType.BStr)] string idMso);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809374)]
	public virtual extern bool GetEnabledMso([In][MarshalAs(UnmanagedType.BStr)] string idMso);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809375)]
	public virtual extern bool GetVisibleMso([In][MarshalAs(UnmanagedType.BStr)] string idMso);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809376)]
	public virtual extern bool GetPressedMso([In][MarshalAs(UnmanagedType.BStr)] string idMso);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809377)]
	[return: MarshalAs(UnmanagedType.BStr)]
	public virtual extern string GetLabelMso([In][MarshalAs(UnmanagedType.BStr)] string idMso);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809378)]
	[return: MarshalAs(UnmanagedType.BStr)]
	public virtual extern string GetScreentipMso([In][MarshalAs(UnmanagedType.BStr)] string idMso);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809379)]
	[return: MarshalAs(UnmanagedType.BStr)]
	public virtual extern string GetSupertipMso([In][MarshalAs(UnmanagedType.BStr)] string idMso);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809380)]
	[return: MarshalAs(UnmanagedType.Interface)]
	[return: ComAliasName("stdole.IPictureDisp")]
	public virtual extern IPictureDisp GetImageMso([In][MarshalAs(UnmanagedType.BStr)] string idMso, [In] int Width, [In] int Height);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610809381)]
	public virtual extern void CommitRenderingTransaction([In] int hwnd);
}
