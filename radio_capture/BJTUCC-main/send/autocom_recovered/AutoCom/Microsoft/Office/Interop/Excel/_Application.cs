using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Excel;

[ComImport]
[CompilerGenerated]
[Guid("000208D5-0000-0000-C000-000000000046")]
[DefaultMember("_Default")]
[TypeIdentifier]
public interface _Application
{
	void _VtblGap1_45();

	Workbooks Workbooks
	{
		[DispId(572)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap2_7();

	bool AlertBeforeOverwriting
	{
		[LCIDConversion(0)]
		[DispId(930)]
		get;
		[LCIDConversion(0)]
		[DispId(930)]
		[param: In]
		set;
	}

	void _VtblGap3_57();

	bool DisplayAlerts
	{
		[DispId(343)]
		[LCIDConversion(0)]
		get;
		[LCIDConversion(0)]
		[DispId(343)]
		[param: In]
		set;
	}

	void _VtblGap4_109();

	[DispId(302)]
	void Quit();

	void _VtblGap5_12();

	bool ScreenUpdating
	{
		[LCIDConversion(0)]
		[DispId(382)]
		get;
		[LCIDConversion(0)]
		[DispId(382)]
		[param: In]
		set;
	}

	void _VtblGap6_37();

	bool Visible
	{
		[LCIDConversion(0)]
		[DispId(558)]
		get;
		[DispId(558)]
		[LCIDConversion(0)]
		[param: In]
		set;
	}

	void _VtblGap7_67();

	int Hwnd
	{
		[DispId(1950)]
		get;
	}
}
