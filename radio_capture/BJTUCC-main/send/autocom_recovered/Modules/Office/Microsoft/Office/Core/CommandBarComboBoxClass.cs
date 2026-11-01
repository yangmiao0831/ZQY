using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[ComImport]
[Guid("55F88897-7708-11D1-ACEB-006008961DA5")]
[ComSourceInterfaces("Microsoft.Office.Core._CommandBarComboBoxEvents\0\0")]
[ClassInterface(0)]
public class CommandBarComboBoxClass : _CommandBarComboBox, CommandBarComboBox, _CommandBarComboBoxEvents_Event
{
	[DispId(-5000)]
	public virtual extern object accParent
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(-5000)]
		[TypeLibFunc(1088)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(-5001)]
	public virtual extern int accChildCount
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(-5001)]
		[TypeLibFunc(1088)]
		get;
	}

	[DispId(-5002)]
	public virtual extern object accChild
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(-5002)]
		[TypeLibFunc(1088)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(-5003)]
	public virtual extern string accName
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[TypeLibFunc(1088)]
		[DispId(-5003)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[TypeLibFunc(1088)]
		[DispId(-5003)]
		[param: Optional]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(-5004)]
	public virtual extern string accValue
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[TypeLibFunc(1088)]
		[DispId(-5004)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(-5004)]
		[TypeLibFunc(1088)]
		[param: Optional]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(-5005)]
	public virtual extern string accDescription
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[TypeLibFunc(1088)]
		[DispId(-5005)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(-5006)]
	public virtual extern object accRole
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[TypeLibFunc(1088)]
		[DispId(-5006)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
	}

	[DispId(-5007)]
	public virtual extern object accState
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[TypeLibFunc(1088)]
		[DispId(-5007)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
	}

	[DispId(-5008)]
	public virtual extern string accHelp
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(-5008)]
		[TypeLibFunc(1088)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(-5009)]
	public virtual extern int accHelpTopic
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(-5009)]
		[TypeLibFunc(1088)]
		get;
	}

	[DispId(-5010)]
	public virtual extern string accKeyboardShortcut
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(-5010)]
		[TypeLibFunc(1088)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(-5011)]
	public virtual extern object accFocus
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(-5011)]
		[TypeLibFunc(1088)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
	}

	[DispId(-5012)]
	public virtual extern object accSelection
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[TypeLibFunc(1088)]
		[DispId(-5012)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
	}

	[DispId(-5013)]
	public virtual extern string accDefaultAction
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[TypeLibFunc(1088)]
		[DispId(-5013)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610809344)]
	public virtual extern object Application
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809344)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(1610809345)]
	public virtual extern int Creator
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809345)]
		get;
	}

	[DispId(1610874880)]
	public virtual extern bool BeginGroup
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874880)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874880)]
		[param: In]
		set;
	}

	[DispId(1610874882)]
	public virtual extern bool BuiltIn
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874882)]
		get;
	}

	[DispId(1610874883)]
	public virtual extern string Caption
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874883)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874883)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1610874885)]
	public virtual extern object Control
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[TypeLibFunc(64)]
		[DispId(1610874885)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	[DispId(1610874888)]
	public virtual extern string DescriptionText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874888)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874888)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1610874890)]
	public virtual extern bool Enabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874890)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874890)]
		[param: In]
		set;
	}

	[DispId(1610874893)]
	public virtual extern int Height
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874893)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874893)]
		[param: In]
		set;
	}

	[DispId(1610874895)]
	public virtual extern int HelpContextId
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874895)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874895)]
		[param: In]
		set;
	}

	[DispId(1610874897)]
	public virtual extern string HelpFile
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874897)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874897)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1610874899)]
	public virtual extern int Id
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874899)]
		get;
	}

	[DispId(1610874900)]
	public virtual extern int Index
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874900)]
		get;
	}

	[DispId(1610874901)]
	public virtual extern int InstanceId
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874901)]
		[TypeLibFunc(64)]
		get;
	}

	[DispId(1610874903)]
	public virtual extern int Left
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874903)]
		get;
	}

	[DispId(1610874904)]
	public virtual extern MsoControlOLEUsage OLEUsage
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874904)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874904)]
		[param: In]
		set;
	}

	[DispId(1610874906)]
	public virtual extern string OnAction
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874906)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874906)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1610874908)]
	public virtual extern CommandBar Parent
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874908)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(1610874909)]
	public virtual extern string Parameter
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874909)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874909)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1610874911)]
	public virtual extern int Priority
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874911)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874911)]
		[param: In]
		set;
	}

	[DispId(1610874915)]
	public virtual extern string Tag
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874915)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874915)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1610874917)]
	public virtual extern string TooltipText
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874917)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874917)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1610874919)]
	public virtual extern int Top
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874919)]
		get;
	}

	[DispId(1610874920)]
	public virtual extern MsoControlType Type
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874920)]
		get;
	}

	[DispId(1610874921)]
	public virtual extern bool Visible
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874921)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874921)]
		[param: In]
		set;
	}

	[DispId(1610874923)]
	public virtual extern int Width
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874923)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874923)]
		[param: In]
		set;
	}

	[DispId(1610874925)]
	public virtual extern bool IsPriorityDropped
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610874925)]
		get;
	}

	[DispId(1610940418)]
	public virtual extern int DropDownLines
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610940418)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610940418)]
		[param: In]
		set;
	}

	[DispId(1610940420)]
	public virtual extern int DropDownWidth
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610940420)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610940420)]
		[param: In]
		set;
	}

	[DispId(1610940422)]
	public virtual extern string List
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610940422)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610940422)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1610940424)]
	public virtual extern int ListCount
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610940424)]
		get;
	}

	[DispId(1610940425)]
	public virtual extern int ListHeaderCount
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610940425)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610940425)]
		[param: In]
		set;
	}

	[DispId(1610940427)]
	public virtual extern int ListIndex
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610940427)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610940427)]
		[param: In]
		set;
	}

	[DispId(1610940430)]
	public virtual extern MsoComboStyle Style
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610940430)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610940430)]
		[param: In]
		set;
	}

	[DispId(1610940432)]
	public virtual extern string Text
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610940432)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610940432)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1610940434)]
	public virtual extern object InstanceIdPtr
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610940434)]
		[TypeLibFunc(64)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
	}

	public virtual extern event _CommandBarComboBoxEvents_ChangeEventHandler Change;

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(-5014)]
	[TypeLibFunc(1088)]
	public virtual extern void accSelect([In] int flagsSelect, [Optional][In][MarshalAs(UnmanagedType.Struct)] object varChild);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(-5015)]
	[TypeLibFunc(1088)]
	public virtual extern void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, [Optional][In][MarshalAs(UnmanagedType.Struct)] object varChild);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(-5016)]
	[TypeLibFunc(1088)]
	[return: MarshalAs(UnmanagedType.Struct)]
	public virtual extern object accNavigate([In] int navDir, [Optional][In][MarshalAs(UnmanagedType.Struct)] object varStart);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(-5017)]
	[TypeLibFunc(1088)]
	[return: MarshalAs(UnmanagedType.Struct)]
	public virtual extern object accHitTest([In] int xLeft, [In] int yTop);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[TypeLibFunc(1088)]
	[DispId(-5018)]
	public virtual extern void accDoDefaultAction([Optional][In][MarshalAs(UnmanagedType.Struct)] object varChild);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610874886)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern CommandBarControl Copy([Optional][In][MarshalAs(UnmanagedType.Struct)] object Bar, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Before);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610874887)]
	public virtual extern void Delete([Optional][In][MarshalAs(UnmanagedType.Struct)] object Temporary);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610874892)]
	public virtual extern void Execute();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610874902)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern CommandBarControl Move([Optional][In][MarshalAs(UnmanagedType.Struct)] object Bar, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Before);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610874913)]
	public virtual extern void Reset();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610874914)]
	public virtual extern void SetFocus();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610874926)]
	[TypeLibFunc(64)]
	public virtual extern void Reserved1();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[TypeLibFunc(64)]
	[DispId(1610874927)]
	public virtual extern void Reserved2();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610874928)]
	[TypeLibFunc(64)]
	public virtual extern void Reserved3();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610874929)]
	[TypeLibFunc(64)]
	public virtual extern void Reserved4();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610874930)]
	[TypeLibFunc(64)]
	public virtual extern void Reserved5();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[TypeLibFunc(64)]
	[DispId(1610874931)]
	public virtual extern void Reserved6();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[TypeLibFunc(64)]
	[DispId(1610874932)]
	public virtual extern void Reserved7();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610940416)]
	public virtual extern void AddItem([In][MarshalAs(UnmanagedType.BStr)] string Text, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Index);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610940417)]
	public virtual extern void Clear();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[DispId(1610940429)]
	public virtual extern void RemoveItem([In] int Index);
}
