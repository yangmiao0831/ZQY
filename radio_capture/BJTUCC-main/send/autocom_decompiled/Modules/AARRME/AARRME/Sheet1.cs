using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Permissions;
using System.Windows.Forms;
using Microsoft.Office.Tools.Excel;
using Microsoft.VisualStudio.Tools.Applications.Runtime;

namespace AARRME;

[StartupObject(1)]
[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
public sealed class Sheet1 : WorksheetBase
{
	[GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
	private object missing = System.Type.Missing;

	private void Sheet1_Startup(object sender, EventArgs e)
	{
	}

	private void Sheet1_Shutdown(object sender, EventArgs e)
	{
	}

	private void InternalStartup()
	{
		base.Startup += Sheet1_Startup;
		base.Shutdown += Sheet1_Shutdown;
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Sheet1(Factory factory, IServiceProvider serviceProvider)
		: base(factory, serviceProvider, "Sheet1", "Sheet1")
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override void Initialize()
	{
		base.Initialize();
		Globals.Sheet1 = this;
		Application.EnableVisualStyles();
		InitializeCachedData();
		InitializeControls();
		InitializeComponents();
		InitializeData();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override void FinishInitialization()
	{
		InternalStartup();
		OnStartup();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override void InitializeDataBindings()
	{
		BeginInitialization();
		BindToData();
		EndInitialization();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private void InitializeCachedData()
	{
		if (base.DataHost != null && base.DataHost.IsCacheInitialized)
		{
			base.DataHost.FillCachedData(this);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private void InitializeData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private void BindToData()
	{
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private void StartCaching(string MemberName)
	{
		base.DataHost.StartCaching(this, MemberName);
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private void StopCaching(string MemberName)
	{
		base.DataHost.StopCaching(this, MemberName);
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private bool IsCached(string MemberName)
	{
		return base.DataHost.IsCached(this, MemberName);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private void BeginInitialization()
	{
		BeginInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private void EndInitialization()
	{
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private void InitializeControls()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private void InitializeComponents()
	{
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private bool NeedsFill(string MemberName)
	{
		return base.DataHost.NeedsFill(this, MemberName);
	}
}
