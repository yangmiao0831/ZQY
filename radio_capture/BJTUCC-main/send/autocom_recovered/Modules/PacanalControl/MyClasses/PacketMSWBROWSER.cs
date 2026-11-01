using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketMSWBROWSER
{
	public struct PACKET_MSW_BROWSER
	{
		public byte Command;

		public string CommandStr;

		public byte UpdateCount;

		public uint ServerType;

		public string ServerTypeStr;

		public byte OSMajorVersion;

		public byte OSMinorVersion;

		public ushort UpdatePeriodicity;

		public string ServerName;

		public string HostComment;
	}

	private PACKET_MSW_BROWSER PMswBrowser;

	public TreeNode GetMSWBROWSERNode(PACKET_MSW_BROWSER PMswBrowser)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		string text = "";
		TreeNode val = new TreeNode();
		val.Text = "Microsoft Windows Browser Protocol";
		text = "Command            :" + Function.ReFormatString(PMswBrowser.Command, PMswBrowser.CommandStr);
		val.Nodes.Add(text);
		text = "Update Count       :" + Function.ReFormatString(PMswBrowser.UpdateCount, null);
		val.Nodes.Add(text);
		text = "Server Type        :" + Function.ReFormatString(PMswBrowser.ServerType, PMswBrowser.ServerTypeStr);
		val.Nodes.Add(text);
		text = "OS Major Version   :" + Function.ReFormatString(PMswBrowser.OSMajorVersion, null);
		val.Nodes.Add(text);
		text = "OS Minor Version   :" + Function.ReFormatString(PMswBrowser.OSMinorVersion, null);
		val.Nodes.Add(text);
		text = "Update Peridiocity :" + Function.ReFormatString(PMswBrowser.UpdatePeriodicity, null);
		val.Nodes.Add(text);
		text = "Server Name        : " + PMswBrowser.ServerName;
		val.Nodes.Add(text);
		text = "Host Comment       : " + PMswBrowser.HostComment;
		val.Nodes.Add(text);
		return val;
	}

	private string GetCommandString(byte cmd)
	{
		string result = "";
		byte b = cmd;
		if (b == 1)
		{
			result = "Announcemnet & Broadcast";
		}
		return result;
	}

	public PACKET_MSW_BROWSER GetMSWBROWSERPart(byte[] PacketData, ref int Index)
	{
		PMswBrowser.Command = PacketData[Index++];
		PMswBrowser.UpdateCount = PacketData[Index++];
		PMswBrowser.ServerType = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
		PMswBrowser.OSMajorVersion = PacketData[Index++];
		PMswBrowser.OSMinorVersion = PacketData[Index++];
		PMswBrowser.UpdatePeriodicity = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
		PMswBrowser.ServerName = "";
		while (PacketData[Index] != 0)
		{
			PMswBrowser.ServerName += (char)PacketData[Index++];
		}
		Index++;
		PMswBrowser.HostComment = "";
		if (Index >= PacketData.GetLength(0))
		{
			PMswBrowser.HostComment = "Null";
		}
		else
		{
			while (PacketData[Index] != 0)
			{
				PMswBrowser.HostComment += (char)PacketData[Index++];
			}
		}
		return PMswBrowser;
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref ListViewItem LItem)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		string text = "";
		TreeNode val = new TreeNode();
		val.Text = "LLC ( Logical Link Control Protocol )";
		try
		{
			LItem.SubItems[6].Text = "LLC";
			LItem.SubItems[9].Text = "Logical link control protocol";
			mNode.Add(val);
		}
		catch (Exception ex)
		{
			mNode.Add(val);
			text = "[ Malformed LLC packet. Remaining bytes don't fit an LLC packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.SubItems[9].Text = "[ Malformed LLC packet. Remaining bytes don't fit an LLC packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref int Index, ref ListViewItem LItem)
	{
		try
		{
			LItem.SubItems[6].Text = "LLC";
			LItem.SubItems[9].Text = "Logical link control protocol";
		}
		catch
		{
			LItem.SubItems[9].Text = "[ Malformed MSW BROWSER packet. Remaining bytes don't fit an MSW BROWSER packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}
}
