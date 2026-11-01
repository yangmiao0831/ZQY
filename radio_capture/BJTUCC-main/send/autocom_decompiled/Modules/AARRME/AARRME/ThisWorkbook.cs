using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Windows.Forms;
using AARRRC;
using AARRRC.UI;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools;
using Microsoft.Office.Tools.Excel;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Microsoft.Win32;

namespace AARRME;

[StartupObject(0)]
[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
public sealed class ThisWorkbook : WorkbookBase
{
	private MainWin _mainWin;

	private ReportMaker _reportMaker;

	private string _officeFile = string.Empty;

	private GlobalInfo _globalInfo;

	private List<string> _selectedTag = new List<string>();

	internal ActionsPane ActionsPane;

	[GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
	private object missing = Type.Missing;

	[GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
	internal Application ThisApplication;

	private string AppPath => System.IO.Path.GetDirectoryName(_officeFile) + "\\";

	private void ThisWorkbook_Startup(object sender, EventArgs e)
	{
		_officeFile = Globals.ThisWorkbook.FullName;
		_globalInfo = new GlobalInfo(_officeFile);
		_reportMaker = new ReportMaker(_globalInfo);
		_mainWin = new MainWin(_globalInfo);
		((Control)_mainWin).Show();
		ActionsPane.Controls.Add((Control)(object)_mainWin);
		((Control)_mainWin).Dock = (DockStyle)5;
		_mainWin.GroupChanged += DoGroupChanged;
		_mainWin.SelectedTagChanged += DoSelectedTagChanged;
	}

	private void DoSelectedTagChanged(Tag tag)
	{
		if (tag == null)
		{
			return;
		}
		foreach (Microsoft.Office.Interop.Excel.Worksheet sheet in base.Sheets)
		{
			if (sheet.Visible != XlSheetVisibility.xlSheetVisible)
			{
				continue;
			}
			foreach (Microsoft.Office.Interop.Excel.Range item in sheet.UsedRange)
			{
				if ((bool)CommonFunc.IsRpfFlag((dynamic)item.Text) && (string.Equals(CommonFunc.ExtractTagName((dynamic)item.Text), tag.Name) ? true : false))
				{
					_globalInfo.IsUserSelectedTag = true;
					sheet.Activate();
					item.Activate();
					_globalInfo.IsUserSelectedTag = false;
					return;
				}
			}
		}
	}

	private void DoGroupChanged(string groupName)
	{
		if (string.IsNullOrEmpty(groupName))
		{
			RemoveGroup();
		}
		else
		{
			AddGroup(groupName);
		}
	}

	private void AddGroup(string groupName)
	{
		Microsoft.Office.Interop.Excel.Range rangeSelection = ((Microsoft.Office.Interop.Excel.Worksheet)Globals.ThisWorkbook.ActiveSheet).Application.ActiveWindow.RangeSelection;
		if (rangeSelection == null)
		{
			return;
		}
		foreach (Microsoft.Office.Interop.Excel.Range item in rangeSelection)
		{
			if ((bool)CommonFunc.IsRpfFlag((dynamic)item.Text))
			{
				string value = CommonFunc.BuildLabel((dynamic)item.Text, groupName);
				item.Value2 = value;
			}
		}
	}

	private void RemoveGroup()
	{
		Microsoft.Office.Interop.Excel.Range rangeSelection = ((Microsoft.Office.Interop.Excel.Worksheet)Globals.ThisWorkbook.ActiveSheet).Application.ActiveWindow.RangeSelection;
		if (rangeSelection == null)
		{
			return;
		}
		foreach (Microsoft.Office.Interop.Excel.Range item in rangeSelection)
		{
			if ((bool)CommonFunc.IsRpfFlag((dynamic)item.Text))
			{
				string text = (dynamic)item.Text;
				int num = text.IndexOf(">_", StringComparison.Ordinal);
				if (num >= 0)
				{
					text = "RPF_" + text.Substring(num + 2);
					item.Value2 = text;
				}
			}
		}
	}

	private void ThisWorkbook_Shutdown(object sender, EventArgs e)
	{
		RemoveSelf();
	}

	private void RemoveSelf()
	{
		_reportMaker.ClearModel();
	}

	private void ThisWorkbook_BeforeSave(bool saveasui, ref bool cancel)
	{
	}

	private void ThisWorkbook_AfterSave(bool success)
	{
		SaveRPT();
	}

	private void ThisWorkbook_Install()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("install");
		Registry.LocalMachine.CreateSubKey("SOFTWARE\\XXReport")?.SetValue("path", AppPath, RegistryValueKind.String);
	}

	private void ThisWorkbook_Uninstall()
	{
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\XXReport", writable: true)?.DeleteValue("path");
	}

	private void SaveRPT()
	{
		List<string> list = new List<string>();
		foreach (Microsoft.Office.Interop.Excel.Worksheet sheet in base.Sheets)
		{
			foreach (Microsoft.Office.Interop.Excel.Range item in sheet.UsedRange)
			{
				if ((bool)CommonFunc.IsRpfFlag((dynamic)item.Text) && ((!list.Contains((dynamic)item.get_Value(Type.Missing))) ? true : false))
				{
					list.Add((dynamic)item.get_Value(Type.Missing));
				}
			}
		}
		_reportMaker.SaveRPT(list);
	}

	private void ThisWorkbook_SheetSelectionChange(object sh, Microsoft.Office.Interop.Excel.Range target)
	{
		if (_globalInfo.IsInDragging)
		{
			_globalInfo.IsInDragging = false;
			_globalInfo.IsUserSelectedTag = false;
		}
		else
		{
			if (_globalInfo.IsUserSelectedTag)
			{
				return;
			}
			_selectedTag.Clear();
			int num = Math.Min(target.Rows.Count, 10);
			int num2 = Math.Min(target.Columns.Count, 10);
			for (int i = 1; i <= num; i++)
			{
				for (int j = 1; j <= num2; j++)
				{
					dynamic val = target.Cells[i, j];
					if (!((val == null) ? true : false))
					{
						string text = val.Text;
						if (CommonFunc.IsRpfFlag(text))
						{
							text = CommonFunc.ExtractTagName(text);
							_selectedTag.Add(text);
						}
					}
				}
			}
			if (_selectedTag.Any())
			{
				_mainWin.CoordinateCurKPI(_selectedTag);
			}
		}
	}

	private void InternalStartup()
	{
		base.SheetSelectionChange += ThisWorkbook_SheetSelectionChange;
		base.BeforeSave += ThisWorkbook_BeforeSave;
		base.AfterSave += ThisWorkbook_AfterSave;
		base.Startup += ThisWorkbook_Startup;
		base.Shutdown += ThisWorkbook_Shutdown;
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ThisWorkbook(Microsoft.Office.Tools.Excel.Factory factory, IServiceProvider serviceProvider)
		: base(factory, serviceProvider, "ThisWorkbook", "ThisWorkbook")
	{
		Globals.Factory = factory;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override void Initialize()
	{
		base.Initialize();
		ThisApplication = GetHostItem<Application>(typeof(Application), "Application");
		Globals.ThisWorkbook = this;
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
		ActionsPane.BeginInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private void EndInitialization()
	{
		ActionsPane.EndInit();
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	private void InitializeControls()
	{
		ActionsPane = Globals.Factory.CreateActionsPane(null, null, "ActionsPane", "ActionsPane", this);
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

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override void OnShutdown()
	{
		ActionsPane.Dispose();
		base.OnShutdown();
	}
}
