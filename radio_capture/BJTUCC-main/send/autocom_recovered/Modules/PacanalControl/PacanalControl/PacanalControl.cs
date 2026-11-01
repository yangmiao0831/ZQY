using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using BrightIdeasSoftware;
using MyClasses;

namespace PacanalControl;

public class PacanalControl : UserControl
{
	private delegate void ParserPackageDelegate();

	private OpenFileDialog DlgOpen = new OpenFileDialog();

	private ColumnSorter TheColumnSorter = new ColumnSorter();

	private Packet32 P32 = new Packet32();

	private string CurrentFileNameForLoad = "";

	private int OriginalX;

	private int OriginalY;

	private int MouseX;

	private int MouseY;

	private Function.COLUMN_DEFAULT_OPTIONS ClmnDefOptions;

	public FastObjectListView lvEvent = new FastObjectListView();

	private int nPos;

	private Timer tmrRefresh;

	private Thread threadParse;

	private bool HasInitEvent;

	private static long MaxTime;

	private IContainer components;

	private SplitContainer splitContainer2;

	private TreeView TVwPacketDetails;

	private RichTextBox RtxPacketData;

	private ColumnHeader ClmnPercentage;

	private ColumnHeader ClmnCount;

	private ColumnHeader ClmnProtocolName;

	private StatusBarPanel PnlGlobal;

	private StatusBarPanel PnlLocation;

	private StatusBarPanel PnlFileName;

	private StatusBar StatusBar;

	private SplitContainer splitContainer1;

	public event EventOnSelectedRow OnSelectedRow;

	public PacanalControl()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		InitializeComponent();
		((UserControl)this).Load += PacanalControl_Load;
		((Control)TVwPacketDetails).Click += TVwPacketDetails_Click;
		((Control)TVwPacketDetails).MouseMove += new MouseEventHandler(TVwPacketDetails_MouseMove);
		((Control)RtxPacketData).KeyDown += new KeyEventHandler(RtxPacketData_KeyDown);
		((Control)RtxPacketData).MouseDown += new MouseEventHandler(RtxPacketData_MouseDown);
		((Control)RtxPacketData).MouseMove += new MouseEventHandler(RtxPacketData_MouseMove);
	}

	private void lvEvent_Click(object sender, EventArgs e)
	{
		if (this.OnSelectedRow != null && lvEvent.SelectedObject != null)
		{
			PACKET_ITEM pACKET_ITEM = lvEvent.SelectedObject as PACKET_ITEM;
			long value = (long)pACKET_ITEM.Seconds * 1000000L + pACKET_ITEM.MicroSeconds;
			DateTime time = LongToDateTime(value);
			this.OnSelectedRow(time);
		}
	}

	private void lvEvent_SelectionChanged(object sender, EventArgs e)
	{
		if (lvEvent.SelectedObject != null)
		{
			PACKET_ITEM LItem = lvEvent.SelectedObject as PACKET_ITEM;
			P32.PParser.ParseSingle(ref LItem);
		}
	}

	public void RelocatedItem(DateTime time)
	{
		if (!HasInitEvent)
		{
			return;
		}
		try
		{
			int findPointIdx = (int)(DateTimeToLong(time) / 1000000);
			new List<PACKET_ITEM>();
			int num = BinarySearchMoreEqual(P32.PParser.PacketCollection, 0, P32.PParser.PacketCollection.Count, findPointIdx);
			if (num >= 0)
			{
				lvEvent.SelectedIndex = num;
				((ListView)lvEvent).EnsureVisible(num);
			}
		}
		catch
		{
		}
	}

	public void InitLvEvent(SplitterPanel panel)
	{
		((ListView)lvEvent).Clear();
		((Control)lvEvent).Parent = (Control)(object)panel;
		((ListView)lvEvent).BorderStyle = (BorderStyle)0;
		((Control)lvEvent).Dock = (DockStyle)5;
		((ListView)lvEvent).FullRowSelect = true;
		((ListView)lvEvent).HideSelection = false;
		((ListView)lvEvent).HeaderStyle = (ColumnHeaderStyle)1;
		lvEvent.ShowImagesOnSubItems = true;
		((ListView)lvEvent).Scrollable = true;
		lvEvent.SelectedForeColor = Color.Black;
		lvEvent.SelectedBackColor = Color.FromArgb(173, 185, 202);
		lvEvent.SelectedForeColor = Color.Black;
		lvEvent.UnfocusedSelectedBackColor = Color.FromArgb(173, 185, 202);
		lvEvent.UnfocusedSelectedForeColor = Color.Black;
		((Control)lvEvent).Click += lvEvent_Click;
		lvEvent.SelectionChanged += lvEvent_SelectionChanged;
		lvEvent.UseFilterIndicator = true;
		lvEvent.UseFiltering = true;
		OLVColumn oLVColumn = new OLVColumn();
		((ColumnHeader)oLVColumn).Text = "Time";
		oLVColumn.Sortable = false;
		oLVColumn.Width = 85;
		oLVColumn.AspectGetter = delegate(object x)
		{
			if (x == null)
			{
				return string.Empty;
			}
			long value = (long)(x as PACKET_ITEM).Seconds * 1000000L + (x as PACKET_ITEM).MicroSeconds;
			return LongToDateTime(value).ToString("HH:mm:ss.fff");
		};
		OLVColumn oLVColumn2 = new OLVColumn();
		((ColumnHeader)oLVColumn2).Text = "Source";
		oLVColumn2.Sortable = false;
		oLVColumn2.Width = 100;
		oLVColumn2.AspectGetter = (object x) => (x == null) ? string.Empty : (x as PACKET_ITEM).Source;
		OLVColumn oLVColumn3 = new OLVColumn();
		((ColumnHeader)oLVColumn3).Text = "Src. Port";
		oLVColumn3.Sortable = false;
		oLVColumn3.Width = 70;
		oLVColumn3.AspectGetter = (object x) => (x == null) ? string.Empty : (x as PACKET_ITEM).SourcePort;
		OLVColumn oLVColumn4 = new OLVColumn();
		((ColumnHeader)oLVColumn4).Text = "Destination";
		oLVColumn4.Sortable = false;
		oLVColumn4.Width = 100;
		oLVColumn4.AspectGetter = (object x) => (x == null) ? string.Empty : (x as PACKET_ITEM).Destination;
		OLVColumn oLVColumn5 = new OLVColumn();
		((ColumnHeader)oLVColumn5).Text = "Dest. Port";
		oLVColumn5.Sortable = false;
		oLVColumn5.Width = 80;
		oLVColumn5.AspectGetter = (object x) => (x == null) ? string.Empty : (x as PACKET_ITEM).DestinationPort;
		OLVColumn oLVColumn6 = new OLVColumn();
		((ColumnHeader)oLVColumn6).Text = "Protocol";
		oLVColumn6.Sortable = false;
		oLVColumn6.Width = 70;
		oLVColumn6.AspectGetter = (object x) => (x == null) ? string.Empty : (x as PACKET_ITEM).Protocol;
		OLVColumn oLVColumn7 = new OLVColumn();
		((ColumnHeader)oLVColumn7).Text = "Sequence";
		oLVColumn7.Sortable = false;
		oLVColumn7.Width = 80;
		oLVColumn7.AspectGetter = (object x) => (x == null) ? string.Empty : (x as PACKET_ITEM).Sequence;
		OLVColumn oLVColumn8 = new OLVColumn();
		((ColumnHeader)oLVColumn8).Text = "Acknowledge";
		oLVColumn8.Sortable = false;
		oLVColumn8.Width = 80;
		oLVColumn8.AspectGetter = (object x) => (x == null) ? string.Empty : (x as PACKET_ITEM).Acknowledge;
		OLVColumn oLVColumn9 = new OLVColumn();
		((ColumnHeader)oLVColumn9).Text = "Info";
		oLVColumn9.Sortable = false;
		oLVColumn9.Width = 100;
		oLVColumn9.FillsFreeSpace = true;
		oLVColumn9.AspectGetter = (object x) => (x == null) ? string.Empty : (x as PACKET_ITEM).Info;
		lvEvent.Columns.AddRange((ColumnHeader[])(object)new ColumnHeader[9] { oLVColumn, oLVColumn2, oLVColumn3, oLVColumn4, oLVColumn5, oLVColumn6, oLVColumn7, oLVColumn8, oLVColumn9 });
		HasInitEvent = true;
	}

	private void PacanalControl_Load(object sender, EventArgs e)
	{
		CurrentFileNameForLoad = "";
		OriginalX = ((Control)this).Width;
		OriginalY = ((Control)this).Height;
		_ = ((Control)this).Width;
		_ = ((Control)this).Height;
		Function.MakeFont((int)((Control)RtxPacketData).Handle);
		Function.MakeFont((int)((Control)TVwPacketDetails).Handle);
		InitLvEvent(splitContainer1.Panel1);
		ClmnDefOptions.No = 50;
		ClmnDefOptions.Time = 70;
		ClmnDefOptions.Source = 150;
		ClmnDefOptions.SourcePort = 75;
		ClmnDefOptions.Destination = 150;
		ClmnDefOptions.DestinationPort = 75;
		ClmnDefOptions.Protocol = 75;
		ClmnDefOptions.Sequence = 90;
		ClmnDefOptions.Acknowledge = 90;
		ClmnDefOptions.Info = 1000;
	}

	private void tmrRefresh_Tick(object sender, EventArgs e)
	{
		lock (P32.PParser.PacketCollection)
		{
			PACKET_ITEM[] array = (PACKET_ITEM[])P32.PParser.PacketCollection.ToArray(typeof(PACKET_ITEM));
			if (array.Length - nPos > 0)
			{
				PACKET_ITEM[] array2 = new PACKET_ITEM[array.Length - nPos];
				Array.Copy(array, nPos, array2, 0, array.Length - nPos);
				lvEvent.AddObjects(array2.ToList());
				nPos = array.Length;
			}
			else if (P32.PParser.hasDone)
			{
				nPos = 0;
				tmrRefresh.Stop();
			}
		}
	}

	public void OpenPcapFile(string fileName)
	{
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		if (!string.IsNullOrEmpty(fileName) && !"".Equals(fileName))
		{
			TheColumnSorter.Enabled = false;
			CurrentFileNameForLoad = fileName;
			P32.LoadFromFile(CurrentFileNameForLoad);
			P32.PParser.Rtx = RtxPacketData;
			P32.PParser.mNode = TVwPacketDetails.Nodes;
			P32.PParser.PacketOnOff = false;
			P32.PParser.mDisplayOptions = P32.DisplayOptions;
			P32.PParser.mCaptureOptions = P32.CaptureOptions;
			P32.PParser.PreviousHttpSequence = 0u;
			P32.PParser.LastTftpPort = ushort.MaxValue;
			threadParse = new Thread(P32.PParser.Parse);
			threadParse.IsBackground = true;
			threadParse.Start();
			TheColumnSorter.Enabled = true;
			lvEvent.ClearObjects();
			tmrRefresh = new Timer();
			tmrRefresh.Tick += tmrRefresh_Tick;
			tmrRefresh.Interval = 200;
			tmrRefresh.Start();
		}
	}

	public int ReadPcapFile(string fileName, int filePos)
	{
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		if (string.IsNullOrEmpty(fileName) || "".Equals(fileName))
		{
			return 0;
		}
		TheColumnSorter.Enabled = false;
		CurrentFileNameForLoad = fileName;
		int result = P32.ReadFileIncrement(fileName, filePos);
		P32.PParser.Rtx = RtxPacketData;
		P32.PParser.mNode = TVwPacketDetails.Nodes;
		P32.PParser.PacketOnOff = false;
		P32.PParser.mDisplayOptions = P32.DisplayOptions;
		P32.PParser.mCaptureOptions = P32.CaptureOptions;
		P32.PParser.PreviousHttpSequence = 0u;
		P32.PParser.LastTftpPort = ushort.MaxValue;
		threadParse = new Thread(P32.PParser.Parse);
		threadParse.IsBackground = true;
		threadParse.Start();
		TheColumnSorter.Enabled = true;
		lvEvent.ClearObjects();
		tmrRefresh = new Timer();
		tmrRefresh.Tick += tmrRefresh_Tick;
		tmrRefresh.Interval = 200;
		tmrRefresh.Start();
		return result;
	}

	public void SetOnSelectedRowEvent(EventOnSelectedRow onSelectedRow)
	{
		OnSelectedRow += onSelectedRow;
	}

	public void DoFilter(string sFilter)
	{
		TextMatchFilter textMatchFilter = TextMatchFilter.Contains(lvEvent, sFilter);
		if (lvEvent.DefaultRenderer == null)
		{
			lvEvent.DefaultRenderer = new HighlightTextRenderer(textMatchFilter);
		}
		lvEvent.AdditionalFilter = textMatchFilter;
	}

	private DateTime PParser_OnSelectedRow(DateTime time)
	{
		return time;
	}

	public static DateTime LongToDateTime(long value)
	{
		DateTime result = new DateTime(1970, 1, 1, 0, 0, 0);
		long num = result.Ticks;
		if (value > 0 && value < long.MaxValue)
		{
			num += value * 10;
		}
		if (num > 0 && num < MaxTime)
		{
			return new DateTime(num);
		}
		return result;
	}

	public static long DateTimeToLong(DateTime time)
	{
		long ticks = new DateTime(1970, 1, 1, 0, 0, 0).Ticks;
		return (time.Ticks - ticks) / 10;
	}

	public int BinarySearchMoreEqual(ArrayList list, int low, int high, int findPointIdx)
	{
		if (list.Count == 0)
		{
			return -1;
		}
		if (low > high)
		{
			return -1;
		}
		int num = (low + high) / 2;
		PACKET_ITEM pACKET_ITEM = list[num] as PACKET_ITEM;
		if (pACKET_ITEM.Seconds >= findPointIdx)
		{
			if (num <= 0 || pACKET_ITEM.Seconds == findPointIdx)
			{
				return num;
			}
			if ((list[num - 1] as PACKET_ITEM).Seconds < findPointIdx)
			{
				return num - 1;
			}
			return BinarySearchMoreEqual(list, low, num - 1, findPointIdx);
		}
		return BinarySearchMoreEqual(list, num + 1, high, findPointIdx);
	}

	private void LVwReceivedPackets_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		switch (e.Column)
		{
		case 0:
			TheColumnSorter.CaseSensitivity = true;
			TheColumnSorter.Direction = ((TheColumnSorter.Direction == 0) ? 1 : 0);
			TheColumnSorter.ColumnType = 0;
			TheColumnSorter.CurrentColumn = 0;
			break;
		case 1:
			TheColumnSorter.CaseSensitivity = true;
			TheColumnSorter.Direction = ((TheColumnSorter.Direction == 0) ? 1 : 0);
			TheColumnSorter.ColumnType = 1;
			TheColumnSorter.CurrentColumn = 1;
			break;
		case 2:
			TheColumnSorter.CaseSensitivity = true;
			TheColumnSorter.Direction = ((TheColumnSorter.Direction == 0) ? 1 : 0);
			TheColumnSorter.ColumnType = 2;
			TheColumnSorter.CurrentColumn = 2;
			break;
		case 3:
			TheColumnSorter.CaseSensitivity = true;
			TheColumnSorter.Direction = ((TheColumnSorter.Direction == 0) ? 1 : 0);
			TheColumnSorter.ColumnType = 2;
			TheColumnSorter.CurrentColumn = 3;
			break;
		case 4:
			TheColumnSorter.CaseSensitivity = true;
			TheColumnSorter.Direction = ((TheColumnSorter.Direction == 0) ? 1 : 0);
			TheColumnSorter.ColumnType = 2;
			TheColumnSorter.CurrentColumn = 4;
			break;
		case 5:
			TheColumnSorter.CaseSensitivity = true;
			TheColumnSorter.Direction = ((TheColumnSorter.Direction == 0) ? 1 : 0);
			TheColumnSorter.ColumnType = 2;
			TheColumnSorter.CurrentColumn = 5;
			break;
		case 6:
			TheColumnSorter.CaseSensitivity = true;
			TheColumnSorter.Direction = ((TheColumnSorter.Direction == 0) ? 1 : 0);
			TheColumnSorter.ColumnType = 2;
			TheColumnSorter.CurrentColumn = 6;
			break;
		case 7:
			TheColumnSorter.CaseSensitivity = true;
			TheColumnSorter.Direction = ((TheColumnSorter.Direction == 0) ? 1 : 0);
			TheColumnSorter.ColumnType = 2;
			TheColumnSorter.CurrentColumn = 7;
			break;
		case 8:
			TheColumnSorter.CaseSensitivity = true;
			TheColumnSorter.Direction = ((TheColumnSorter.Direction == 0) ? 1 : 0);
			TheColumnSorter.ColumnType = 2;
			TheColumnSorter.CurrentColumn = 8;
			break;
		case 9:
			TheColumnSorter.CaseSensitivity = true;
			TheColumnSorter.Direction = ((TheColumnSorter.Direction == 0) ? 1 : 0);
			TheColumnSorter.ColumnType = 2;
			TheColumnSorter.CurrentColumn = 9;
			break;
		}
	}

	private void TVwPacketDetails_Click(object sender, EventArgs e)
	{
		TreeNode nodeAt = TVwPacketDetails.GetNodeAt(MouseX, MouseY);
		if (nodeAt != null)
		{
			Function.HighlightText(RtxPacketData, nodeAt, ref StatusBar);
		}
	}

	private void TVwPacketDetails_MouseMove(object sender, MouseEventArgs e)
	{
		MouseX = e.X;
		MouseY = e.Y;
	}

	private void RtxPacketData_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		Point pt = new Point(e.X, e.Y);
		if ((int)e.Button == 1048576)
		{
			Function.ReverseHighlightText(RtxPacketData, TVwPacketDetails, pt, ref StatusBar);
		}
	}

	private void RtxPacketData_MouseMove(object sender, MouseEventArgs e)
	{
		MouseX = e.X;
		MouseY = e.Y;
	}

	private void RtxPacketData_KeyDown(object sender, KeyEventArgs e)
	{
		int keyValue = e.KeyValue;
		if (keyValue >= 48 && keyValue > 57 && keyValue >= 65)
		{
			_ = 70;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		splitContainer2 = new SplitContainer();
		TVwPacketDetails = new TreeView();
		RtxPacketData = new RichTextBox();
		ClmnPercentage = new ColumnHeader();
		ClmnCount = new ColumnHeader();
		ClmnProtocolName = new ColumnHeader();
		PnlGlobal = new StatusBarPanel();
		PnlLocation = new StatusBarPanel();
		PnlFileName = new StatusBarPanel();
		StatusBar = new StatusBar();
		splitContainer1 = new SplitContainer();
		((ISupportInitialize)splitContainer2).BeginInit();
		((Control)splitContainer2.Panel1).SuspendLayout();
		((Control)splitContainer2.Panel2).SuspendLayout();
		((Control)splitContainer2).SuspendLayout();
		((ISupportInitialize)PnlGlobal).BeginInit();
		((ISupportInitialize)PnlLocation).BeginInit();
		((ISupportInitialize)PnlFileName).BeginInit();
		((ISupportInitialize)splitContainer1).BeginInit();
		((Control)splitContainer1.Panel2).SuspendLayout();
		((Control)splitContainer1).SuspendLayout();
		((Control)this).SuspendLayout();
		splitContainer2.Dock = (DockStyle)5;
		((Control)splitContainer2).Location = new Point(0, 0);
		((Control)splitContainer2).Margin = new Padding(4);
		((Control)splitContainer2).Name = "splitContainer2";
		splitContainer2.Orientation = (Orientation)0;
		((Control)splitContainer2.Panel1).Controls.Add((Control)(object)TVwPacketDetails);
		((Control)splitContainer2.Panel2).Controls.Add((Control)(object)RtxPacketData);
		((Control)splitContainer2).Size = new Size(986, 405);
		splitContainer2.SplitterDistance = 194;
		splitContainer2.SplitterWidth = 6;
		((Control)splitContainer2).TabIndex = 0;
		((Control)TVwPacketDetails).Dock = (DockStyle)5;
		TVwPacketDetails.FullRowSelect = true;
		TVwPacketDetails.HideSelection = false;
		((Control)TVwPacketDetails).Location = new Point(0, 0);
		((Control)TVwPacketDetails).Margin = new Padding(4);
		((Control)TVwPacketDetails).Name = "TVwPacketDetails";
		((Control)TVwPacketDetails).Size = new Size(986, 194);
		((Control)TVwPacketDetails).TabIndex = 1;
		((Control)RtxPacketData).Dock = (DockStyle)5;
		((Control)RtxPacketData).Location = new Point(0, 0);
		((Control)RtxPacketData).Margin = new Padding(4);
		((Control)RtxPacketData).Name = "RtxPacketData";
		((TextBoxBase)RtxPacketData).ReadOnly = true;
		RtxPacketData.ShowSelectionMargin = true;
		((Control)RtxPacketData).Size = new Size(986, 205);
		((Control)RtxPacketData).TabIndex = 2;
		((Control)RtxPacketData).Text = "";
		((TextBoxBase)RtxPacketData).WordWrap = false;
		ClmnPercentage.Text = "Percentage";
		ClmnPercentage.Width = 100;
		ClmnCount.Text = "Count";
		ClmnCount.Width = 75;
		ClmnProtocolName.Text = "Protocol";
		ClmnProtocolName.Width = 200;
		PnlGlobal.AutoSize = (StatusBarPanelAutoSize)2;
		PnlGlobal.MinWidth = 120;
		PnlGlobal.Name = "PnlGlobal";
		PnlGlobal.Width = 619;
		PnlLocation.AutoSize = (StatusBarPanelAutoSize)3;
		PnlLocation.MinWidth = 200;
		PnlLocation.Name = "PnlLocation";
		PnlLocation.Width = 200;
		PnlFileName.AutoSize = (StatusBarPanelAutoSize)3;
		PnlFileName.MinWidth = 150;
		PnlFileName.Name = "PnlFileName";
		PnlFileName.Width = 150;
		((Control)StatusBar).AllowDrop = true;
		((Control)StatusBar).Location = new Point(0, 630);
		((Control)StatusBar).Margin = new Padding(4);
		((Control)StatusBar).Name = "StatusBar";
		StatusBar.Panels.AddRange((StatusBarPanel[])(object)new StatusBarPanel[3] { PnlFileName, PnlLocation, PnlGlobal });
		StatusBar.ShowPanels = true;
		((Control)StatusBar).Size = new Size(986, 26);
		((Control)StatusBar).TabIndex = 7;
		splitContainer1.Dock = (DockStyle)5;
		((Control)splitContainer1).Location = new Point(0, 0);
		((Control)splitContainer1).Margin = new Padding(4);
		((Control)splitContainer1).Name = "splitContainer1";
		splitContainer1.Orientation = (Orientation)0;
		((Control)splitContainer1.Panel2).Controls.Add((Control)(object)splitContainer2);
		((Control)splitContainer1).Size = new Size(986, 630);
		splitContainer1.SplitterDistance = 219;
		splitContainer1.SplitterWidth = 6;
		((Control)splitContainer1).TabIndex = 8;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)0;
		((Control)this).Controls.Add((Control)(object)splitContainer1);
		((Control)this).Controls.Add((Control)(object)StatusBar);
		((Control)this).Margin = new Padding(4);
		((Control)this).Name = "PacanalControl";
		((Control)this).Size = new Size(986, 656);
		((Control)splitContainer2.Panel1).ResumeLayout(false);
		((Control)splitContainer2.Panel2).ResumeLayout(false);
		((ISupportInitialize)splitContainer2).EndInit();
		((Control)splitContainer2).ResumeLayout(false);
		((ISupportInitialize)PnlGlobal).EndInit();
		((ISupportInitialize)PnlLocation).EndInit();
		((ISupportInitialize)PnlFileName).EndInit();
		((Control)splitContainer1.Panel2).ResumeLayout(false);
		((ISupportInitialize)splitContainer1).EndInit();
		((Control)splitContainer1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	static PacanalControl()
	{
		DateTime maxValue = DateTime.MaxValue;
		MaxTime = maxValue.Ticks;
	}
}
