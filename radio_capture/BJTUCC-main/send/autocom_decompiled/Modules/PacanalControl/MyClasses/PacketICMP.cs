using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketICMP
{
	public struct PACKET_ICMP
	{
		public byte Type;

		public byte Code;

		public ushort Checksum;

		public ushort Identifier;

		public ushort SequenceNumber;

		public byte[] Data;
	}

	public static string GetTypeCodeString(byte b)
	{
		string[] array = new string[32];
		int num = 0;
		for (num = 0; num < 32; num++)
		{
			array[num] = "Not defined";
		}
		array[0] = "Echo Reply";
		array[3] = "Destination Unreachable";
		array[4] = "Source Quench";
		array[5] = "Redirect";
		array[8] = "Echo";
		array[9] = "Router Advertisement";
		array[10] = "Router Selection";
		array[11] = "Time Exceeded";
		array[12] = "Parameter Problem";
		array[13] = "Timestamp";
		array[14] = "Timestamp Reply";
		array[15] = "Information Request";
		array[16] = "Information Reply";
		array[17] = "Address Mask Request";
		array[18] = "Address Mask Reply";
		array[30] = "Traceroute";
		array[31] = "Datagram Conversion Error";
		if (b > 31)
		{
			return "Not defined";
		}
		return array[b];
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		string text = "";
		int num = 0;
		int num2 = 0;
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "ICMP ( Internet Control Message Protocol )";
		Function.SetPosition(ref mNode2, Index, PacketData.Length - Index, BaseOrSub: true);
		if (Index + 8 > PacketData.Length)
		{
			mNode.Add(mNode2);
			text = "[ Malformed ICMP packet. Remaining bytes don't fit an ICMP packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			LItem.Info = text;
			return false;
		}
		try
		{
			PACKET_ICMP pACKET_ICMP = default(PACKET_ICMP);
			pACKET_ICMP.Type = PacketData[Index++];
			text = "Type : " + Function.ReFormatString(pACKET_ICMP.Type, GetTypeCodeString(pACKET_ICMP.Type));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_ICMP.Code = PacketData[Index++];
			text = "Code : " + Function.ReFormatString(pACKET_ICMP.Code, GetTypeCodeString(pACKET_ICMP.Code));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_ICMP.Checksum = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Checksum : " + Function.ReFormatString(pACKET_ICMP.Checksum, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_ICMP.Identifier = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Identifier : " + Function.ReFormatString(pACKET_ICMP.Identifier, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_ICMP.SequenceNumber = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Sequence Number : " + Function.ReFormatString(pACKET_ICMP.SequenceNumber, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			num2 = PacketData.GetLength(0) - Index;
			pACKET_ICMP.Data = new byte[num2];
			for (num = 0; num < num2; num++)
			{
				pACKET_ICMP.Data[num] = PacketData[Index++];
			}
			text = "Data : ";
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index, num2, BaseOrSub: false);
			LItem.Protocol = "ICMP";
			LItem.Info = GetTypeCodeString(pACKET_ICMP.Type);
			mNode.Add(mNode2);
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed ICMP packet. Remaining bytes don't fit an ICMP packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.Info = "[ Malformed ICMP packet. Remaining bytes don't fit an ICMP packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		string text = "";
		int num = 0;
		int num2 = 0;
		if (Index + 8 > PacketData.Length)
		{
			text = "[ Malformed ICMP packet. Remaining bytes don't fit an ICMP packet. Possibly due to bad decoding ]";
			LItem.Info = text;
			return false;
		}
		try
		{
			PACKET_ICMP pACKET_ICMP = default(PACKET_ICMP);
			pACKET_ICMP.Type = PacketData[Index++];
			pACKET_ICMP.Code = PacketData[Index++];
			pACKET_ICMP.Checksum = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_ICMP.Identifier = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_ICMP.SequenceNumber = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			num2 = PacketData.GetLength(0) - Index;
			pACKET_ICMP.Data = new byte[num2];
			for (num = 0; num < num2; num++)
			{
				pACKET_ICMP.Data[num] = PacketData[Index++];
			}
			LItem.Protocol = "ICMP";
			LItem.Info = GetTypeCodeString(pACKET_ICMP.Type);
		}
		catch
		{
			text = "[ Malformed ICMP packet. Remaining bytes don't fit an ICMP packet. Possibly due to bad decoding ]";
			LItem.Info = "[ Malformed ICMP packet. Remaining bytes don't fit an ICMP packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}
}
