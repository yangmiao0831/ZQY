using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketEIGRP
{
	public struct PACKET_EIGRP_SOFTWARE
	{
		public ushort Type;

		public ushort Size;

		public string IOS;

		public string EigrpRelease;
	}

	public struct PACKET_EIGRP_PARAMETERS
	{
		public ushort Type;

		public ushort Size;

		public byte K1;

		public byte K2;

		public byte K3;

		public byte K4;

		public byte K5;

		public byte Reserved;

		public ushort HoldTime;
	}

	public struct PACKET_EIGRP
	{
		public byte Version;

		public byte OpCode;

		public ushort Checksum;

		public uint Flags;

		public uint Sequence;

		public uint Acknowledge;

		public uint AutonomousSystem;

		public PACKET_EIGRP_PARAMETERS Parameters;

		public PACKET_EIGRP_SOFTWARE Software;
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected O, but got Unknown
		string text = "";
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "EIGRP ( Extended Interior Gateway Routing Protocol )";
		Function.SetPosition(ref mNode2, Index, 40, BaseOrSub: true);
		if (Index + 40 > PacketData.Length)
		{
			mNode.Add(mNode2);
			text = "[ Malformed EIGRP packet. Remaining bytes don't fit an EIGRP packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			LItem.Info = text;
			return false;
		}
		try
		{
			PACKET_EIGRP pACKET_EIGRP = default(PACKET_EIGRP);
			pACKET_EIGRP.Version = PacketData[Index++];
			text = "Version : " + Function.ReFormatString(pACKET_EIGRP.Version, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_EIGRP.OpCode = PacketData[Index++];
			text = "Opcode : " + Function.ReFormatString(pACKET_EIGRP.OpCode, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_EIGRP.Checksum = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Checksum : " + Function.ReFormatString(pACKET_EIGRP.Checksum, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_EIGRP.Flags = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Flags : " + Function.ReFormatString(pACKET_EIGRP.Flags, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 4, 4, BaseOrSub: false);
			pACKET_EIGRP.Sequence = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Sequence : " + Function.ReFormatString(pACKET_EIGRP.Sequence, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 4, 4, BaseOrSub: false);
			pACKET_EIGRP.Acknowledge = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Acknowledgement Number : " + Function.ReFormatString(pACKET_EIGRP.Acknowledge, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 4, 4, BaseOrSub: false);
			pACKET_EIGRP.AutonomousSystem = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Autonomous Number : " + Function.ReFormatString(pACKET_EIGRP.AutonomousSystem, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 4, 4, BaseOrSub: false);
			TreeNode mNode3 = new TreeNode();
			mNode3.Text = "EIGRP PARAMETERS";
			Function.SetPosition(ref mNode3, Index, 12, BaseOrSub: true);
			pACKET_EIGRP.Parameters.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Type : " + Function.ReFormatString(pACKET_EIGRP.Parameters.Type, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_EIGRP.Parameters.Size = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Size : " + Function.ReFormatString(pACKET_EIGRP.Parameters.Size, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_EIGRP.Parameters.K1 = PacketData[Index++];
			text = "K1 : " + Function.ReFormatString(pACKET_EIGRP.Parameters.K1, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			pACKET_EIGRP.Parameters.K2 = PacketData[Index++];
			text = "K2 : " + Function.ReFormatString(pACKET_EIGRP.Parameters.K2, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			pACKET_EIGRP.Parameters.K3 = PacketData[Index++];
			text = "K3 : " + Function.ReFormatString(pACKET_EIGRP.Parameters.K3, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			pACKET_EIGRP.Parameters.K4 = PacketData[Index++];
			text = "K4 : " + Function.ReFormatString(pACKET_EIGRP.Parameters.K4, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			pACKET_EIGRP.Parameters.K5 = PacketData[Index++];
			text = "K5 : " + Function.ReFormatString(pACKET_EIGRP.Parameters.K5, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			pACKET_EIGRP.Parameters.Reserved = PacketData[Index++];
			text = "Reserved : " + Function.ReFormatString(pACKET_EIGRP.Parameters.Reserved, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			pACKET_EIGRP.Parameters.HoldTime = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Hold Time : " + Function.ReFormatString(pACKET_EIGRP.Parameters.HoldTime, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			mNode2.Nodes.Add(mNode3);
			mNode3 = new TreeNode();
			mNode3.Text = "EIGRP SOFTWARE VERSION";
			Function.SetPosition(ref mNode3, Index, 8, BaseOrSub: true);
			pACKET_EIGRP.Software.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Type : " + Function.ReFormatString(pACKET_EIGRP.Software.Type, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_EIGRP.Software.Size = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Size : " + Function.ReFormatString(pACKET_EIGRP.Software.Size, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_EIGRP.Software.IOS = PacketData[Index++] + "." + PacketData[Index++];
			text = "IOS : " + pACKET_EIGRP.Software.IOS.ToString();
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_EIGRP.Software.EigrpRelease = PacketData[Index++] + "." + PacketData[Index++];
			text = "EIGRP Release : " + pACKET_EIGRP.Software.EigrpRelease.ToString();
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			mNode2.Nodes.Add(mNode3);
			LItem.Protocol = "EIGRP";
			LItem.Info = "Extended Interior Gateway Routing Protocol";
			mNode.Add(mNode2);
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed EIGRP packet. Remaining bytes don't fit an EIGRP packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.Info = "[ Malformed EIGRP packet. Remaining bytes don't fit an EIGRP packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		string text = "";
		if (Index + 40 > PacketData.Length)
		{
			text = "[ Malformed EIGRP packet. Remaining bytes don't fit an EIGRP packet. Possibly due to bad decoding ]";
			LItem.Info = text;
			return false;
		}
		try
		{
			_ = PacketData[Index++];
			_ = PacketData[Index++];
			Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			_ = PacketData[Index++];
			_ = PacketData[Index++];
			_ = PacketData[Index++];
			_ = PacketData[Index++];
			_ = PacketData[Index++];
			_ = PacketData[Index++];
			Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			_ = PacketData[Index++] + "." + PacketData[Index++];
			_ = PacketData[Index++] + "." + PacketData[Index++];
			LItem.Protocol = "EIGRP";
			LItem.Info = "Extended Interior Gateway Routing Protocol";
		}
		catch
		{
			text = "[ Malformed EIGRP packet. Remaining bytes don't fit an EIGRP packet. Possibly due to bad decoding ]";
			LItem.Info = "[ Malformed EIGRP packet. Remaining bytes don't fit an EIGRP packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}
}
