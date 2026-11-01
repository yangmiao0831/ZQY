using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketTB
{
	public struct PACKET_TRANSPARENT_BRIDGE
	{
		public ushort ProtocolIdentifier;

		public byte Version;

		public byte MessageType;

		public byte Flags;

		public ushort RootPriority;

		public string RootId;

		public uint RootPathCost;

		public ushort BridgePriority;

		public string BrifgeId;

		public ushort PortId;

		public ushort MessageAge;

		public ushort MaximumAge;

		public ushort HelloTime;

		public ushort ForwardDelay;
	}

	public bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref ListViewItem LItem)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		string text = "";
		TreeNode val = new TreeNode();
		val.Text = "TB ( Trans Bridging Protocol )";
		try
		{
			LItem.SubItems[6].Text = "TB";
			LItem.SubItems[9].Text = "TB protocol";
			mNode.Add(val);
		}
		catch (Exception ex)
		{
			mNode.Add(val);
			text = "[ Malformed TB packet. Remaining bytes don't fit an TB packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.SubItems[9].Text = "[ Malformed TB packet. Remaining bytes don't fit an TB packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}
}
