using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketNBDS
{
	public struct PACKET_NBDS
	{
		public byte MessageType;

		public byte Flags;

		public ushort DatagramId;

		public string SourceIp;

		public ushort SourcePort;

		public ushort DataLength;

		public ushort ErrorCode;

		public ushort PacketOffset;

		public string SourceName;

		public string DestinationName;
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		string text = "";
		int num = 0;
		byte NameNumber = 0;
		string[] array = new string[24];
		string[] array2 = new string[2];
		string[] array3 = new string[4];
		string[] array4 = new string[3];
		int num2 = 0;
		for (num2 = 0; num2 < 17; num2++)
		{
			array[num2] = "Unknown";
		}
		array[16] = "Direct_unique datagram";
		array[17] = "Direct_group datagram";
		array[18] = "Broadcast datagram";
		array[19] = "Datagram error";
		array[20] = "Datagram query request";
		array[21] = "Datagram positive query response";
		array[22] = "Datagram negative query response";
		array2[1] = "Yes";
		array2[0] = "No";
		array3[0] = "B node";
		array3[1] = "P node";
		array3[2] = "M node";
		array3[3] = "NBDD";
		array4[0] = "Destination name not present";
		array4[1] = "Invalid source name format";
		array4[2] = "Invalid destination name format";
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "NBDS ( Netbios Datagram Service )";
		num = Index;
		try
		{
			PACKET_NBDS pACKET_NBDS = default(PACKET_NBDS);
			pACKET_NBDS.MessageType = PacketData[Index++];
			text = "Message Type :" + Function.ReFormatString(pACKET_NBDS.MessageType, array[pACKET_NBDS.MessageType]);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_NBDS.Flags = PacketData[Index++];
			text = "Flags :" + Function.ReFormatString(pACKET_NBDS.Flags, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			text = "More fragments fallow :" + array2[pACKET_NBDS.Flags & 1];
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			text = "This is first fragment :" + array2[(pACKET_NBDS.Flags & 2) >> 1];
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			text = "Node Type :" + array3[(pACKET_NBDS.Flags & 0xC) >> 2];
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_NBDS.DatagramId = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Datagram Id :" + Function.ReFormatString(pACKET_NBDS.DatagramId, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_NBDS.SourceIp = Function.GetIpAddress(PacketData, ref Index);
			text = "Source Ip : " + pACKET_NBDS.SourceIp;
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 4, 4, BaseOrSub: false);
			pACKET_NBDS.SourcePort = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Source Port :" + Function.ReFormatString(pACKET_NBDS.SourcePort, Const.GetPortStr(pACKET_NBDS.SourcePort));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			switch (pACKET_NBDS.MessageType)
			{
			case 16:
			case 17:
			case 18:
				pACKET_NBDS.DataLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Datagram Length :" + Function.ReFormatString(pACKET_NBDS.DataLength, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_NBDS.PacketOffset = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Packet Offset :" + Function.ReFormatString(pACKET_NBDS.PacketOffset, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_NBDS.SourceName = Function.GetNetBiosName(PacketData, ref Index, ref NameNumber);
				text = "Source Name :" + pACKET_NBDS.SourceName + " ( " + Const.GetNetBiosNames(NameNumber) + " )";
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 34, 34, BaseOrSub: false);
				pACKET_NBDS.DestinationName = Function.GetNetBiosName(PacketData, ref Index, ref NameNumber);
				text = "Destination Name :" + pACKET_NBDS.DestinationName + " ( " + Const.GetNetBiosNames(NameNumber) + " )";
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 34, 34, BaseOrSub: false);
				break;
			case 19:
				pACKET_NBDS.ErrorCode = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Error Code :" + Function.ReFormatString(pACKET_NBDS.ErrorCode, array4[pACKET_NBDS.ErrorCode - 130]);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				break;
			case 20:
			case 21:
			case 22:
				pACKET_NBDS.DestinationName = Function.GetNetBiosName(PacketData, ref Index, ref NameNumber);
				text = "Destination Name :" + pACKET_NBDS.DestinationName + " ( " + Const.GetNetBiosNames(NameNumber) + " )";
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 34, 34, BaseOrSub: false);
				break;
			}
			Function.SetPosition(ref mNode2, num, Index - num, BaseOrSub: true);
			mNode.Add(mNode2);
			if (Index + 4 < PacketData.Length && PacketData[Index] == byte.MaxValue && PacketData[Index + 1] == 83 && PacketData[Index + 2] == 77 && PacketData[Index + 3] == 66)
			{
				PacketSMB.Parser(ref mNode, PacketData, ref Index, ref LItem);
			}
			LItem.Protocol = "NBDS";
			LItem.Info = "Netbios datagram service";
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed NBDS packet. Remaining bytes don't fit an NBDS packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.Info = "[ Malformed NBDS packet. Remaining bytes don't fit an NBDS packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		byte NameNumber = 0;
		try
		{
			PACKET_NBDS pACKET_NBDS = default(PACKET_NBDS);
			pACKET_NBDS.MessageType = PacketData[Index++];
			pACKET_NBDS.Flags = PacketData[Index++];
			pACKET_NBDS.DatagramId = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_NBDS.SourceIp = Function.GetIpAddress(PacketData, ref Index);
			pACKET_NBDS.SourcePort = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			switch (pACKET_NBDS.MessageType)
			{
			case 16:
			case 17:
			case 18:
				pACKET_NBDS.DataLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NBDS.PacketOffset = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NBDS.SourceName = Function.GetNetBiosName(PacketData, ref Index, ref NameNumber);
				pACKET_NBDS.DestinationName = Function.GetNetBiosName(PacketData, ref Index, ref NameNumber);
				break;
			case 19:
				pACKET_NBDS.ErrorCode = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				break;
			case 20:
			case 21:
			case 22:
				pACKET_NBDS.DestinationName = Function.GetNetBiosName(PacketData, ref Index, ref NameNumber);
				break;
			}
			LItem.Protocol = "NBDS";
			LItem.Info = "Netbios datagram service";
		}
		catch
		{
			LItem.Info = "[ Malformed NBDS packet. Remaining bytes don't fit an NBDS packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}
}
