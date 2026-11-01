using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketARP
{
	public struct PACKET_ARP
	{
		public ushort HardwareType;

		public ushort ProtocolType;

		public byte HardwareSize;

		public byte ProtocolSize;

		public ushort OpCode;

		public string SenderMACAddress;

		public string SenderIpAddress;

		public string TargetMACAddress;

		public string TargetIpAddress;
	}

	public static string GetOpCodeList(ushort u)
	{
		int num = 0;
		string[] array = new string[16];
		for (num = 0; num < 16; num++)
		{
			array[num] = "";
		}
		array[1] = "Request";
		array[2] = "Reply";
		array[3] = "Reverse request";
		array[4] = "Reverse reply";
		array[8] = "Inverse request";
		array[9] = "Inverse reply";
		return array[u];
	}

	public static string GetAtmOpCodeList(ushort u)
	{
		int num = 0;
		string[] array = new string[16];
		for (num = 0; num < 16; num++)
		{
			array[num] = "";
		}
		array[1] = "Request";
		array[2] = "Reply";
		array[8] = "Inverse request";
		array[9] = "Inverse reply";
		array[10] = "Nak";
		return array[u];
	}

	public static string GetHardwareList(ushort u)
	{
		int num = 0;
		string[] array = new string[255];
		for (num = 0; num < 255; num++)
		{
			array[num] = "";
		}
		array[0] = "NET/ROM pseudo";
		array[1] = "Ethernet";
		array[2] = "Experimental Ethernet";
		array[3] = "AX.25";
		array[4] = "ProNET";
		array[5] = "Chaos";
		array[6] = "IEEE 802";
		array[7] = "ARCNET";
		array[8] = "Hyperchannel";
		array[9] = "Lanstar";
		array[10] = "Autonet Short Address";
		array[11] = "Localtalk";
		array[12] = "LocalNet";
		array[13] = "Ultra link";
		array[14] = "SMDS";
		array[15] = "Frame Relay DLCI";
		array[16] = "ATM";
		array[17] = "HDLC";
		array[18] = "Fibre Channel";
		array[19] = "ATM (RFC 2225)";
		array[20] = "Serial Line";
		array[21] = "ATM";
		array[22] = "MIL-STD-188-220";
		array[23] = "Metricom STRIP";
		array[24] = "IEEE 1394.1995";
		array[25] = "MAPOS";
		array[26] = "Twinaxial";
		array[27] = "EUI-64";
		return array[u];
	}

	public static string GetInfoARP(PACKET_ARP PArp)
	{
		string text = "";
		return PArp.OpCode switch
		{
			1 => "Who has " + PArp.TargetIpAddress + " ?  Tell " + PArp.SenderIpAddress, 
			2 => PArp.SenderIpAddress + " is at " + PArp.SenderMACAddress, 
			3 => "Who has " + PArp.TargetIpAddress + " ?  Tell " + PArp.SenderIpAddress, 
			8 => "Who has " + PArp.TargetMACAddress + " ?  Tell " + PArp.TargetIpAddress, 
			4 => PArp.TargetIpAddress + " is at " + PArp.TargetMACAddress, 
			9 => PArp.SenderMACAddress + " is at " + PArp.SenderIpAddress, 
			_ => "Unknown ARP opcode " + PArp.OpCode.ToString("x04"), 
		};
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		string text = "";
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "ARP ( Address Resolution Protocol )";
		Function.SetPosition(ref mNode2, Index, 28, BaseOrSub: true);
		if (Index + 28 > PacketData.Length)
		{
			mNode.Add(mNode2);
			text = "[ Malformed ARP packet. Remaining bytes don't fit an ARP packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			LItem.Info = text;
			return false;
		}
		try
		{
			PACKET_ARP pArp = default(PACKET_ARP);
			pArp.HardwareType = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Hardware Type : " + Function.ReFormatString(pArp.HardwareType, GetHardwareList(pArp.HardwareType));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pArp.ProtocolType = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Protocol Type : " + Function.ReFormatString(pArp.ProtocolType, Const.GetETHERTYPEStr(pArp.ProtocolType));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pArp.HardwareSize = PacketData[Index++];
			text = "Hardware Size : " + Function.ReFormatString(pArp.HardwareSize, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pArp.ProtocolSize = PacketData[Index++];
			text = "Protocol Size : " + Function.ReFormatString(pArp.ProtocolSize, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pArp.OpCode = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Opcode : " + Function.ReFormatString(pArp.OpCode, GetOpCodeList(pArp.OpCode));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pArp.SenderMACAddress = Function.GetMACAddress(PacketData, ref Index);
			text = "Sender MAC Address : " + pArp.SenderMACAddress;
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 6, 6, BaseOrSub: false);
			pArp.SenderIpAddress = Function.GetIpAddress(PacketData, ref Index);
			text = "Sender Ip Address : " + pArp.SenderIpAddress;
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 4, 4, BaseOrSub: false);
			pArp.TargetMACAddress = Function.GetMACAddress(PacketData, ref Index);
			text = "Target MAC Address : " + pArp.TargetMACAddress;
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 6, 6, BaseOrSub: false);
			pArp.TargetIpAddress = Function.GetIpAddress(PacketData, ref Index);
			text = "Target Ip Address : " + pArp.TargetIpAddress;
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 4, 4, BaseOrSub: false);
			LItem.Protocol = "ARP";
			LItem.Source = pArp.SenderIpAddress;
			LItem.Destination = pArp.TargetIpAddress;
			LItem.Info = GetInfoARP(pArp);
			mNode.Add(mNode2);
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed ARP packet. Remaining bytes don't fit an ARP packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.Info = text;
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		string text = "";
		if (Index + 28 > PacketData.Length)
		{
			text = "[ Malformed ARP packet. Remaining bytes don't fit an ARP packet. Possibly due to bad decoding ]";
			LItem.Info = text;
			return false;
		}
		try
		{
			PACKET_ARP pArp = default(PACKET_ARP);
			pArp.HardwareType = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pArp.ProtocolType = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pArp.HardwareSize = PacketData[Index++];
			pArp.ProtocolSize = PacketData[Index++];
			pArp.OpCode = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pArp.SenderMACAddress = Function.GetMACAddress(PacketData, ref Index);
			pArp.SenderIpAddress = Function.GetIpAddress(PacketData, ref Index);
			pArp.TargetMACAddress = Function.GetMACAddress(PacketData, ref Index);
			pArp.TargetIpAddress = Function.GetIpAddress(PacketData, ref Index);
			LItem.Protocol = "ARP";
			LItem.Source = pArp.SenderIpAddress;
			LItem.Destination = pArp.TargetIpAddress;
			LItem.Info = GetInfoARP(pArp);
		}
		catch
		{
			text = "[ Malformed ARP packet. Remaining bytes don't fit an ARP packet. Possibly due to bad decoding ]";
			LItem.Info = text;
			return false;
		}
		return true;
	}
}
