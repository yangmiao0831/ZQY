using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AARRRC;
using AARRRC.UI;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools;
using Microsoft.Office.Tools.Word;
using Microsoft.VisualStudio.Tools.Applications.Runtime;

namespace WordReportMaker;

[StartupObject(0)]
[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
public sealed class ThisDocument : DocumentBase
{
	private MainWin _mainWin;

	private ReportMaker _reportMaker;

	private string _officeFile = string.Empty;

	private GlobalInfo _globalInfo;

	private List<string> _selectedTag = new List<string>();

	internal ActionsPane ActionsPane;

	[GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
	private object missing = System.Type.Missing;

	[GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
	internal Application ThisApplication;

	private void ThisWorkbook_SelectionChange(object sender, SelectionEventArgs e)
	{
		if (_globalInfo.IsInDragging)
		{
			string text = e.Selection.Range.Text;
			if (!string.IsNullOrEmpty(text))
			{
				string name = BuildBookMarkName(text);
				Bookmarks bookmarks = base.Bookmarks;
				object Range = System.Type.Missing;
				bookmarks.Add(name, ref Range);
				_globalInfo.IsInDragging = false;
			}
			return;
		}
		_selectedTag.Clear();
		foreach (Bookmark bookmark in e.Selection.Bookmarks)
		{
			string name2 = bookmark.Name;
			string item = CommonFunc.ExtractTagName(BKName2LabelName(name2));
			_selectedTag.Add(item);
		}
		if (_selectedTag.Any())
		{
			_mainWin.CoordinateCurKPI(_selectedTag);
		}
	}

	private string BKName2LabelName(string bkName)
	{
		int num = bkName.LastIndexOf('_');
		if (num < 0)
		{
			return string.Empty;
		}
		return bkName.Substring(0, num);
	}

	private string BuildBookMarkName(string labelName)
	{
		int num = 0;
		int num2 = labelName.IndexOf(">_", StringComparison.Ordinal);
		if (num2 >= 0)
		{
			labelName = "RPF_" + labelName.Substring(num2 + 2);
		}
		labelName = Regex.Replace(labelName, "\\W", "");
		string text;
		while (true)
		{
			text = labelName + "_" + num;
			if (!base.Bookmarks.Exists(text))
			{
				break;
			}
			num++;
		}
		return text;
	}

	private void ThisWorkbook_BeforeClose(object sender, CancelEventArgs e)
	{
		SaveRPT();
	}

	private void SaveRPT()
	{
		List<string> list = new List<string>();
		foreach (Bookmark bookmark in base.Bookmarks)
		{
			string text = bookmark.Range.Text.Trim();
			text = text.Remove(0, 2);
			text = text.Remove(text.Length - 1);
			if (CommonFunc.IsRpfFlag(text))
			{
				list.Add(text);
			}
		}
		if (list.Count > 0)
		{
			_reportMaker.SaveRPT(list);
		}
	}

	private void ThisWorkbook_BeforeSave(object sender, SaveEventArgs e)
	{
		SaveRPT();
	}

	private void ThisDocument_Startup(object sender, EventArgs e)
	{
		_officeFile = Globals.ThisDocument.FullName;
		_globalInfo = new GlobalInfo(_officeFile);
		_reportMaker = new ReportMaker(_globalInfo);
		_mainWin = new MainWin(_globalInfo);
		((Control)_mainWin).Show();
		ActionsPane.Controls.Add((Control)(object)_mainWin);
		((Control)_mainWin).Dock = (DockStyle)5;
		_mainWin.GroupChanged += DoGroupChanged;
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
		Selection selection = ((DocumentBase)Globals.ThisDocument).ActiveWindow.Selection;
		Microsoft.Office.Interop.Word.Range range = selection.Range;
		List<Bookmark> list = new List<Bookmark>();
		foreach (Bookmark bookmark2 in selection.Bookmarks)
		{
			list.Add(bookmark2);
		}
		for (int i = 0; i <= list.Count - 1; i++)
		{
			Bookmark bookmark = list[i];
			string text = bookmark.Range.Text;
			int num = text.IndexOf("${", StringComparison.Ordinal);
			int num2 = text.IndexOf("}", StringComparison.Ordinal);
			if (num >= 0 && num2 >= 0)
			{
				num += 2;
				string text2 = text.Substring(num, num2 - num);
				if (CommonFunc.IsRpfFlag(text2))
				{
					string arg = CommonFunc.BuildLabel(text2, groupName);
					arg = $"${{{arg}}}";
					Microsoft.Office.Interop.Word.Range range2 = bookmark.Range;
					range2.Text = arg;
					range2.Select();
					string name = BuildBookMarkName(text2);
					Bookmarks bookmarks = base.Bookmarks;
					object Range = System.Type.Missing;
					bookmarks.Add(name, ref Range);
				}
			}
		}
		range.Select();
	}

	private void RemoveGroup()
	{
		Selection selection = ((DocumentBase)Globals.ThisDocument).ActiveWindow.Selection;
		Microsoft.Office.Interop.Word.Range range = selection.Range;
		List<Bookmark> list = new List<Bookmark>();
		foreach (Bookmark bookmark2 in selection.Bookmarks)
		{
			list.Add(bookmark2);
		}
		for (int i = 0; i <= list.Count - 1; i++)
		{
			Bookmark bookmark = list[i];
			string text = bookmark.Range.Text;
			int num = text.IndexOf("${", StringComparison.Ordinal);
			int num2 = text.IndexOf("}", StringComparison.Ordinal);
			if (num < 0 || num2 < 0)
			{
				continue;
			}
			num += 2;
			string text2 = text.Substring(num, num2 - num);
			if (CommonFunc.IsRpfFlag(text2))
			{
				string text3 = text2;
				int num3 = text3.IndexOf(">_", StringComparison.Ordinal);
				if (num3 >= 0)
				{
					text2 = "RPF_" + text3.Substring(num3 + 2);
					text3 = $"${{{text2}}}";
					Microsoft.Office.Interop.Word.Range range2 = bookmark.Range;
					range2.Text = text3;
					range2.Select();
					string name = BuildBookMarkName(text2);
					Bookmarks bookmarks = base.Bookmarks;
					object Range = System.Type.Missing;
					bookmarks.Add(name, ref Range);
				}
			}
		}
		range.Select();
	}

	private void ThisDocument_Shutdown(object sender, EventArgs e)
	{
		RemoveSelf();
	}

	private void RemoveSelf()
	{
		_reportMaker.ClearModel();
	}

	private void InternalStartup()
	{
		base.SelectionChange += ThisWorkbook_SelectionChange;
		base.BeforeSave += ThisWorkbook_BeforeSave;
		base.BeforeClose += ThisWorkbook_BeforeClose;
		base.Startup += ThisDocument_Startup;
		base.Shutdown += ThisDocument_Shutdown;
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ThisDocument(Microsoft.Office.Tools.Word.Factory factory, IServiceProvider serviceProvider)
		: base(factory, serviceProvider, "ThisDocument", "ThisDocument")
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
		Globals.ThisDocument = this;
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
