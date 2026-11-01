using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketETHERNET
{
	public struct PACKET_ETHERNET
	{
		public string Destination;

		public string Source;

		public ushort Type;
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref PACKET_ITEM LItem, ref uint PreviousHttpSequence, ref ushort LastTftpPort)
	{
		string text = "";
		int Index = 0;
		TreeNode mNode2 = Function.AddNodeItem("ETHERNET", "", Index, 14);
		if (Index + 14 > PacketData.Length)
		{
			mNode.Add(mNode2);
			text = "[ Malformed ETHERNET packet. Remaining bytes don't fit an ETHERNET packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			LItem.Info = text;
			return false;
		}
		try
		{
			Index = 32;
			PACKET_ETHERNET pACKET_ETHERNET = default(PACKET_ETHERNET);
			pACKET_ETHERNET.Destination = "";
			Function.AddNodeItem(ref mNode2, "Destination", ref pACKET_ETHERNET.Destination, null, PacketData, ref Index, 6, 0, PassNullBytes: true);
			pACKET_ETHERNET.Source = "";
			Function.AddNodeItem(ref mNode2, "Source", ref pACKET_ETHERNET.Source, null, PacketData, ref Index, 6, 0, PassNullBytes: true);
			LItem.SourcePort = Function.Get2Bytes(PacketData, ref Index, 0).ToString();
			LItem.DestinationPort = Function.Get2Bytes(PacketData, ref Index, 0).ToString();
			Index = 12;
			pACKET_ETHERNET.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			Index -= 2;
			if (pACKET_ETHERNET.Type <= 1500)
			{
				Function.AddNodeItem(ref mNode2, "Length", ref pACKET_ETHERNET.Type, null, PacketData, ref Index, Const.CurFileType);
			}
			else
			{
				Function.AddNodeItem(ref mNode2, "Type", ref pACKET_ETHERNET.Type, null, PacketData, ref Index, Const.CurFileType);
			}
			LItem.Protocol = "ETHERNET";
			LItem.Source = pACKET_ETHERNET.Source;
			LItem.Destination = pACKET_ETHERNET.Destination;
			LItem.Info = "Ethernet protocol";
			mNode.Add(mNode2);
			if (pACKET_ETHERNET.Type <= 1500)
			{
				PacketLLC.Parser(ref mNode, PacketData, ref Index, ref LItem, pACKET_ETHERNET.Type, ref PreviousHttpSequence, ref LastTftpPort);
			}
			else
			{
				switch (pACKET_ETHERNET.Type)
				{
				case 2048:
					PacketINTERNET.Parser(ref mNode, PacketData, ref Index, ref LItem, ref PreviousHttpSequence, ref LastTftpPort);
					break;
				case 2054:
					PacketARP.Parser(ref mNode, PacketData, ref Index, ref LItem);
					break;
				case 33079:
					PacketIPX.Parser(ref mNode, PacketData, ref Index, ref LItem);
					break;
				case 36864:
					PacketLOOPBACK.Parser(ref mNode, PacketData, ref Index, ref LItem);
					break;
				}
			}
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed ETHERNET packet. Remaining bytes don't fit an ETHERNET packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.Info = "[ Malformed ETHERNET packet. Remaining bytes don't fit an ETHERNET packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref PACKET_ITEM LItem, ref string TypeInfo, ref uint PreviousHttpSequence, ref ushort LastTftpPort)
	{
		string text = "";
		int num = 0;
		if (num + 14 > PacketData.Length)
		{
			text = "[ Malformed ETHERNET packet. Remaining bytes don't fit an ETHERNET packet. Possibly due to bad decoding ]";
			LItem.Info = text;
			return false;
		}
		try
		{
			num = 32;
			PACKET_ETHERNET pACKET_ETHERNET = default(PACKET_ETHERNET);
			pACKET_ETHERNET.Destination = Function.GetIpAddress(PacketData, ref num);
			pACKET_ETHERNET.Source = Function.GetIpAddress(PacketData, ref num);
			LItem.SourcePort = Function.Get2Bytes(PacketData, ref num, 0).ToString();
			LItem.DestinationPort = Function.Get2Bytes(PacketData, ref num, 0).ToString();
			num = 12;
			pACKET_ETHERNET.Type = Function.Get2Bytes(PacketData, ref num, Const.CurFileType);
			mach2mach.Add(pACKET_ETHERNET.Source, pACKET_ETHERNET.Destination, PacketData.GetLength(0));
			LItem.Protocol = "ETHERNET";
			LItem.Source = pACKET_ETHERNET.Source;
			LItem.Destination = pACKET_ETHERNET.Destination;
			LItem.Info = "Ethernet protocol";
			if (pACKET_ETHERNET.Type <= 1500)
			{
				PacketLLC.Parser(PacketData, ref num, ref LItem, ref TypeInfo, pACKET_ETHERNET.Type, ref PreviousHttpSequence, ref LastTftpPort);
			}
			else
			{
				switch (pACKET_ETHERNET.Type)
				{
				case 512:
					TypeInfo = "Other";
					break;
				case 1280:
					TypeInfo = "Other";
					break;
				case 1536:
					TypeInfo = "Other";
					break;
				case 4096:
					TypeInfo = "Other";
					break;
				case 24577:
					TypeInfo = "Other";
					break;
				case 24578:
					TypeInfo = "Other";
					break;
				case 24579:
					TypeInfo = "Other";
					break;
				case 24580:
					TypeInfo = "Other";
					break;
				case 24583:
					TypeInfo = "Other";
					break;
				case 2048:
					TypeInfo = "Other";
					PacketINTERNET.Parser(PacketData, ref num, ref LItem, ref TypeInfo, ref PreviousHttpSequence, ref LastTftpPort);
					break;
				case 2054:
					TypeInfo = "Other";
					PacketARP.Parser(PacketData, ref num, ref LItem);
					break;
				case 32821:
					TypeInfo = "Other";
					break;
				case 32824:
					TypeInfo = "Other";
					break;
				case 32828:
					TypeInfo = "Other";
					break;
				case 32830:
					TypeInfo = "Other";
					break;
				case 32859:
					TypeInfo = "Other";
					break;
				case 32860:
					TypeInfo = "Other";
					break;
				case 32923:
					TypeInfo = "Other";
					break;
				case 33011:
					TypeInfo = "Other";
					break;
				case 33024:
					TypeInfo = "Other";
					break;
				case 33079:
					TypeInfo = "IPX";
					PacketIPX.Parser(PacketData, ref num, ref LItem);
					break;
				case 34525:
					TypeInfo = "Other";
					break;
				case 36864:
					TypeInfo = "Other";
					PacketLOOPBACK.Parser(PacketData, ref num, ref LItem);
					break;
				}
			}
		}
		catch
		{
			LItem.Info = "[ Malformed ETHERNET packet. Remaining bytes don't fit an ETHERNET packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}
}
