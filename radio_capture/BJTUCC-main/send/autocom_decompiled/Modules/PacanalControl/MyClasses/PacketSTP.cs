using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketSTP
{
	public struct PACKET_STP
	{
		public ushort ProtocolIdentifier;

		public string ProtocolIdentifierStr;

		public byte ProtocolVersionIdentifier;

		public string ProtocolVersionIdentifierStr;

		public byte BPDUType;

		public string BPDUTypeStr;

		public byte BPDUFlags;

		public ushort RootIdentifier;

		public string RootIdentifierStr;

		public uint RootPathCost;

		public ushort BridgeIdentifier;

		public string BridgeIdentifierStr;

		public ushort PortIdentifier;

		public ushort MessageAge;

		public ushort MaxAge;

		public ushort HelloTime;

		public ushort ForwardDelay;
	}

	public static string GetProtocolIdString(ushort u)
	{
		string result = "";
		if (u == 0)
		{
			result = "Spanning Tree Protocol";
		}
		return result;
	}

	public static string GetProtocolVersionIdString(byte u)
	{
		string result = "";
		if (u == 0)
		{
			result = "Spanning Tree";
		}
		return result;
	}

	public static string GetBPDUTypeString(byte u)
	{
		string result = "";
		if (u == 0)
		{
			result = "Configuration";
		}
		return result;
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		string text = "";
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "STP ( Spanning Tree Protocol )";
		Function.SetPosition(ref mNode2, Index, 35, BaseOrSub: true);
		if (Index + 35 > PacketData.Length)
		{
			mNode.Add(mNode2);
			text = "[ Malformed STP packet. Remaining bytes don't fit an STP packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			LItem.Info = text;
			return false;
		}
		try
		{
			PACKET_STP pACKET_STP = default(PACKET_STP);
			pACKET_STP.ProtocolIdentifier = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Protocol Identifier :" + Function.ReFormatString(pACKET_STP.ProtocolIdentifier, GetProtocolIdString(pACKET_STP.ProtocolIdentifier));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_STP.ProtocolVersionIdentifier = PacketData[Index++];
			text = "Protocol Version Identifier :" + Function.ReFormatString(pACKET_STP.ProtocolVersionIdentifier, GetProtocolVersionIdString(pACKET_STP.ProtocolVersionIdentifier));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_STP.BPDUType = PacketData[Index++];
			text = "BPDU Type :" + Function.ReFormatString(pACKET_STP.BPDUType, GetBPDUTypeString(pACKET_STP.BPDUType));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_STP.BPDUFlags = PacketData[Index++];
			TreeNode mNode3 = new TreeNode();
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: true);
			mNode3.Text = "BPDU Flags :" + Function.ReFormatString(pACKET_STP.BPDUFlags, null);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_STP.BPDUFlags, 128, "Topology Change Acknowledgment : Yes", "Topology Change Acknowledgment : No"));
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_STP.BPDUFlags, 1, "Topology Change : Yes", "Topology Change : No"));
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			mNode2.Nodes.Add(mNode3);
			pACKET_STP.RootIdentifier = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_STP.RootIdentifierStr = Function.GetMACAddress(PacketData, ref Index);
			text = "Root Identifier :" + pACKET_STP.RootIdentifier + " , " + pACKET_STP.RootIdentifierStr;
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 8, 8, BaseOrSub: false);
			pACKET_STP.RootPathCost = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Root Path Cost :" + Function.ReFormatString(pACKET_STP.RootPathCost, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 4, 4, BaseOrSub: false);
			pACKET_STP.BridgeIdentifier = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_STP.BridgeIdentifierStr = Function.GetMACAddress(PacketData, ref Index);
			text = "Bridge Identifier :" + pACKET_STP.BridgeIdentifier + " , " + pACKET_STP.BridgeIdentifierStr;
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 8, 8, BaseOrSub: false);
			pACKET_STP.PortIdentifier = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Port Identifier :" + Function.ReFormatString(pACKET_STP.PortIdentifier, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_STP.MessageAge = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Message Age :" + Function.ReFormatString(pACKET_STP.MessageAge, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_STP.MaxAge = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Max Age :" + Function.ReFormatString(pACKET_STP.MaxAge, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_STP.HelloTime = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Hello Time :" + Function.ReFormatString(pACKET_STP.HelloTime, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_STP.ForwardDelay = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Forward Delay :" + Function.ReFormatString(pACKET_STP.ForwardDelay, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			LItem.Protocol = "STP";
			LItem.Info = "STP protocol";
			mNode.Add(mNode2);
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed STP packet. Remaining bytes don't fit an STP packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.Info = "[ Malformed STP packet. Remaining bytes don't fit an STP packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		string text = "";
		if (Index + 35 > PacketData.Length)
		{
			text = "[ Malformed STP packet. Remaining bytes don't fit an STP packet. Possibly due to bad decoding ]";
			LItem.Info = text;
			return false;
		}
		try
		{
			Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			_ = PacketData[Index++];
			_ = PacketData[Index++];
			_ = PacketData[Index++];
			Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			Function.GetMACAddress(PacketData, ref Index);
			Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			Function.GetMACAddress(PacketData, ref Index);
			Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			LItem.Protocol = "STP";
			LItem.Info = "STP protocol";
		}
		catch
		{
			LItem.Info = "[ Malformed STP packet. Remaining bytes don't fit an STP packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}
}
