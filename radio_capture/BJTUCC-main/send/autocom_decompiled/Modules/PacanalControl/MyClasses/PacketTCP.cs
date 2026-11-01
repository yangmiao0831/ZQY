using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketTCP
{
	public struct PACKET_TCP
	{
		public ushort SourcePort;

		public ushort DestinationPort;

		public uint SequenceNumber;

		public uint Acknowledgement;

		public byte HeaderLength;

		public byte Falgs;

		public ushort WindowSize;

		public ushort Checksum;

		public ushort Options;
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, ref uint PreviousHttpSequence)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		string text = "";
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "TCP ( Transmission Control Protocol )";
		Function.SetPosition(ref mNode2, Index, 20, BaseOrSub: true);
		if (Index + 20 > PacketData.Length)
		{
			mNode.Add(mNode2);
			text = "[ Malformed TCP packet. Remaining bytes don't fit an TCP packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			LItem.Info = text;
			return false;
		}
		try
		{
			PACKET_TCP pACKET_TCP = default(PACKET_TCP);
			pACKET_TCP.SourcePort = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Source Port : " + Function.ReFormatString(pACKET_TCP.SourcePort, Const.GetPortStr(pACKET_TCP.SourcePort));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			LItem.SourcePort = pACKET_TCP.SourcePort.ToString();
			pACKET_TCP.DestinationPort = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Destination Port : " + Function.ReFormatString(pACKET_TCP.DestinationPort, Const.GetPortStr(pACKET_TCP.DestinationPort));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			LItem.DestinationPort = pACKET_TCP.DestinationPort.ToString();
			pACKET_TCP.SequenceNumber = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Sequence Number : " + Function.ReFormatString(pACKET_TCP.SequenceNumber, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 4, 4, BaseOrSub: false);
			LItem.Sequence = pACKET_TCP.SequenceNumber.ToString();
			pACKET_TCP.Acknowledgement = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Acknowledgement : " + Function.ReFormatString(pACKET_TCP.Acknowledgement, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 4, 4, BaseOrSub: false);
			LItem.Acknowledge = pACKET_TCP.Acknowledgement.ToString();
			pACKET_TCP.HeaderLength = PacketData[Index++];
			pACKET_TCP.HeaderLength = (byte)((pACKET_TCP.HeaderLength >> 4) * 4);
			text = "Length : " + Function.ReFormatString(pACKET_TCP.HeaderLength, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_TCP.Falgs = PacketData[Index++];
			TreeNode mNode3 = new TreeNode();
			mNode3.Text = "Flags : " + Function.ReFormatString(pACKET_TCP.Falgs, null);
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: true);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_TCP.Falgs, 128, "Congestion window reduced ( CWR ) : Set", "Congestion window reduced ( CWR ) : Not set"));
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_TCP.Falgs, 64, "ECN-Echo : Set", "ECN-Echo : Not set"));
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_TCP.Falgs, 32, "Urgent : Set", "Urgent : Not set"));
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_TCP.Falgs, 16, "Acknowldegement : Set", "Acknowldegement : Not set"));
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_TCP.Falgs, 8, "Push : Set", "Push : Not set"));
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_TCP.Falgs, 4, "Reset : Set", "Reset : Not set"));
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_TCP.Falgs, 2, "Sync : Set", "Sync : Not set"));
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_TCP.Falgs, 1, "Fin : Set", "Fin : Not set"));
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			mNode2.Nodes.Add(mNode3);
			pACKET_TCP.WindowSize = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Window Size : " + Function.ReFormatString(pACKET_TCP.WindowSize, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_TCP.Checksum = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Checksum : " + Function.ReFormatString(pACKET_TCP.Checksum, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_TCP.Options = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Options : " + Function.ReFormatString(pACKET_TCP.Options, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			LItem.Protocol = "TCP";
			LItem.Info = "Source Port = " + pACKET_TCP.SourcePort + " ( " + Const.GetPortStr(pACKET_TCP.SourcePort) + " ) , Destination Port = " + pACKET_TCP.DestinationPort + " ( " + Const.GetPortStr(pACKET_TCP.DestinationPort) + " )";
			mNode.Add(mNode2);
			bool flag = false;
			if (pACKET_TCP.SourcePort == 80 || pACKET_TCP.DestinationPort == 80 || pACKET_TCP.SourcePort == 8080 || pACKET_TCP.DestinationPort == 8080)
			{
				if (PreviousHttpSequence == pACKET_TCP.SequenceNumber - (PacketData.Length - 54))
				{
					PreviousHttpSequence = pACKET_TCP.SequenceNumber;
					PacketHTTP.Parser(ref mNode, PacketData, ref Index, ref LItem, DisplayData: false);
				}
				else
				{
					PreviousHttpSequence = 0u;
					PacketHTTP.Parser(ref mNode, PacketData, ref Index, ref LItem, DisplayData: true);
				}
			}
			else if (pACKET_TCP.SourcePort == 1433 || pACKET_TCP.DestinationPort == 1433)
			{
				PacketSQL.Parser(ref mNode, PacketData, ref Index, ref LItem, DisplayData: true);
			}
			else if (pACKET_TCP.SourcePort == 139 || pACKET_TCP.DestinationPort == 139)
			{
				flag = ((pACKET_TCP.SourcePort == 445 || pACKET_TCP.DestinationPort == 445) ? true : false);
				PacketNBSS.Parser(ref mNode, PacketData, ref Index, ref LItem, flag);
			}
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed TCP packet. Remaining bytes don't fit an TCP packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.Info = "[ Malformed TCP packet. Remaining bytes don't fit an TCP packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, ref uint PreviousHttpSequence)
	{
		string text = "";
		if (Index + 20 > PacketData.Length)
		{
			text = "[ Malformed TCP packet. Remaining bytes don't fit an TCP packet. Possibly due to bad decoding ]";
			LItem.Info = text;
			return false;
		}
		try
		{
			PACKET_TCP pACKET_TCP = default(PACKET_TCP);
			pACKET_TCP.SourcePort = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_TCP.DestinationPort = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_TCP.SequenceNumber = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_TCP.Acknowledgement = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_TCP.HeaderLength = PacketData[Index++];
			pACKET_TCP.HeaderLength = (byte)((pACKET_TCP.HeaderLength >> 4) * 4);
			pACKET_TCP.Falgs = PacketData[Index++];
			pACKET_TCP.WindowSize = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_TCP.Checksum = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_TCP.Options = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			LItem.SourcePort = pACKET_TCP.SourcePort.ToString();
			LItem.DestinationPort = pACKET_TCP.DestinationPort.ToString();
			LItem.Sequence = pACKET_TCP.SequenceNumber.ToString();
			LItem.Acknowledge = pACKET_TCP.Acknowledgement.ToString();
			LItem.Protocol = "TCP";
			LItem.Info = "Source Port = " + pACKET_TCP.SourcePort + " ( " + Const.GetPortStr(pACKET_TCP.SourcePort) + " ) , Destination Port = " + pACKET_TCP.DestinationPort + " ( " + Const.GetPortStr(pACKET_TCP.DestinationPort) + " )";
			bool flag = false;
			if (pACKET_TCP.SourcePort == 80 || pACKET_TCP.DestinationPort == 80 || pACKET_TCP.SourcePort == 8080 || pACKET_TCP.DestinationPort == 8080)
			{
				if (PreviousHttpSequence == pACKET_TCP.SequenceNumber - (PacketData.Length - 54))
				{
					PreviousHttpSequence = pACKET_TCP.SequenceNumber;
					PacketHTTP.Parser(PacketData, ref Index, ref LItem, DisplayData: false);
				}
				else
				{
					PreviousHttpSequence = 0u;
					PacketHTTP.Parser(PacketData, ref Index, ref LItem, DisplayData: true);
				}
			}
			else if (pACKET_TCP.SourcePort == 1433 || pACKET_TCP.DestinationPort == 1433)
			{
				PacketSQL.Parser(PacketData, ref Index, ref LItem, DisplayData: false);
			}
			else if (pACKET_TCP.SourcePort == 139 || pACKET_TCP.DestinationPort == 139)
			{
				flag = ((pACKET_TCP.SourcePort == 445 || pACKET_TCP.DestinationPort == 445) ? true : false);
				PacketNBSS.Parser(PacketData, ref Index, ref LItem, flag);
			}
		}
		catch
		{
			LItem.Info = "[ Malformed TCP packet. Remaining bytes don't fit an TCP packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}
}
