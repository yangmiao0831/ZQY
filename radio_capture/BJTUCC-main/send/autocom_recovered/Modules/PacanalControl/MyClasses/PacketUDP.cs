using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketUDP
{
	public struct PACKET_UDP
	{
		public ushort SourcePort;

		public ushort DestinationPort;

		public ushort Length;

		public ushort Checksum;
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, ref ushort LastTftpPort)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		string text = "";
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "UDP ( Unary Datagram Protocol )";
		Function.SetPosition(ref mNode2, Index, 8, BaseOrSub: true);
		if (Index + 8 > PacketData.Length)
		{
			mNode.Add(mNode2);
			text = "[ Malformed UDP packet. Remaining bytes don't fit an UDP packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			LItem.Info = text;
			return false;
		}
		try
		{
			PACKET_UDP pACKET_UDP = default(PACKET_UDP);
			pACKET_UDP.SourcePort = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Source Port : " + Function.ReFormatString(pACKET_UDP.SourcePort, Const.GetPortStr(pACKET_UDP.SourcePort));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			LItem.SourcePort = pACKET_UDP.SourcePort.ToString();
			pACKET_UDP.DestinationPort = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Destination Port : " + Function.ReFormatString(pACKET_UDP.DestinationPort, Const.GetPortStr(pACKET_UDP.DestinationPort));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			LItem.DestinationPort = pACKET_UDP.DestinationPort.ToString();
			pACKET_UDP.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Length : " + Function.ReFormatString(pACKET_UDP.Length, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_UDP.Checksum = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Checksum : " + Function.ReFormatString(pACKET_UDP.Checksum, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			LItem.Protocol = "UDP";
			LItem.Info = "Source Port = " + pACKET_UDP.SourcePort + " ( " + Const.GetPortStr(pACKET_UDP.SourcePort) + " ) , Destination Port = " + pACKET_UDP.DestinationPort + " ( " + Const.GetPortStr(pACKET_UDP.DestinationPort) + " )";
			mNode.Add(mNode2);
			if (pACKET_UDP.SourcePort == 1031 || pACKET_UDP.DestinationPort == 1031 || pACKET_UDP.SourcePort == 1032 || pACKET_UDP.DestinationPort == 1032)
			{
				PacketHTTP.Parser(ref mNode, PacketData, ref Index, ref LItem, DisplayData: true);
			}
			else if (pACKET_UDP.SourcePort != 53 && pACKET_UDP.DestinationPort != 53)
			{
				if (pACKET_UDP.SourcePort == 137 || pACKET_UDP.DestinationPort == 137)
				{
					PacketNBNS.Parser(ref mNode, PacketData, ref Index, ref LItem);
				}
				else if (pACKET_UDP.SourcePort == 138 || pACKET_UDP.DestinationPort == 138)
				{
					PacketNBDS.Parser(ref mNode, PacketData, ref Index, ref LItem);
				}
				else if (pACKET_UDP.SourcePort == 69 || pACKET_UDP.DestinationPort == 69)
				{
					if (pACKET_UDP.SourcePort == 69)
					{
						LastTftpPort = pACKET_UDP.DestinationPort;
					}
					else if (pACKET_UDP.DestinationPort == 69)
					{
						LastTftpPort = pACKET_UDP.SourcePort;
					}
					PacketTFTP.Parser(ref mNode, PacketData, ref Index, ref LItem);
				}
				else if (pACKET_UDP.SourcePort == LastTftpPort || pACKET_UDP.DestinationPort == LastTftpPort)
				{
					PacketTFTP.Parser(ref mNode, PacketData, ref Index, ref LItem);
				}
			}
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed UDP packet. Remaining bytes don't fit an UDP packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.Info = "[ Malformed UDP packet. Remaining bytes don't fit an UDP packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, ref ushort LastTftpPort)
	{
		string text = "";
		if (Index + 8 > PacketData.Length)
		{
			text = "[ Malformed UDP packet. Remaining bytes don't fit an UDP packet. Possibly due to bad decoding ]";
			LItem.Info = text;
			return false;
		}
		try
		{
			PACKET_UDP pACKET_UDP = default(PACKET_UDP);
			pACKET_UDP.SourcePort = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_UDP.DestinationPort = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_UDP.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_UDP.Checksum = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			LItem.SourcePort = pACKET_UDP.SourcePort.ToString();
			LItem.DestinationPort = pACKET_UDP.DestinationPort.ToString();
			LItem.Protocol = "UDP";
			LItem.Info = "Source Port = " + pACKET_UDP.SourcePort + " ( " + Const.GetPortStr(pACKET_UDP.SourcePort) + " ) , Destination Port = " + pACKET_UDP.DestinationPort + " ( " + Const.GetPortStr(pACKET_UDP.DestinationPort) + " )";
			if (pACKET_UDP.SourcePort == 1031 || pACKET_UDP.DestinationPort == 1031 || pACKET_UDP.SourcePort == 1032 || pACKET_UDP.DestinationPort == 1032)
			{
				PacketHTTP.Parser(PacketData, ref Index, ref LItem, DisplayData: true);
			}
			else if (pACKET_UDP.SourcePort != 53 && pACKET_UDP.DestinationPort != 53)
			{
				if (pACKET_UDP.SourcePort == 137 || pACKET_UDP.DestinationPort == 137)
				{
					PacketNBNS.Parser(PacketData, ref Index, ref LItem);
				}
				else if (pACKET_UDP.SourcePort == 138 || pACKET_UDP.DestinationPort == 138)
				{
					PacketNBDS.Parser(PacketData, ref Index, ref LItem);
				}
				else if (pACKET_UDP.SourcePort == 69 || pACKET_UDP.DestinationPort == 69)
				{
					if (pACKET_UDP.SourcePort == 69)
					{
						LastTftpPort = pACKET_UDP.DestinationPort;
					}
					else if (pACKET_UDP.DestinationPort == 69)
					{
						LastTftpPort = pACKET_UDP.SourcePort;
					}
					PacketTFTP.Parser(PacketData, ref Index, ref LItem);
				}
				else if (pACKET_UDP.SourcePort == LastTftpPort || pACKET_UDP.DestinationPort == LastTftpPort)
				{
					PacketTFTP.Parser(PacketData, ref Index, ref LItem);
				}
			}
		}
		catch
		{
			LItem.Info = "[ Malformed UDP packet. Remaining bytes don't fit an UDP packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}
}
