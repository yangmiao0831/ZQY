using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketINTERNET
{
	public struct PACKET_INTERNET
	{
		public byte Version;

		public byte HeaderLength;

		public byte DifferentiatedServicesField;

		public ushort Length;

		public ushort Identification;

		public byte Flags;

		public ushort FragmentOffset;

		public ushort TimeToLive;

		public byte Protocol;

		public ushort HeaderChecksum;

		public string Source;

		public string Destination;
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, ref uint PreviousHttpSequence, ref ushort LastTftpPort)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		string text = "";
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "INTERNET";
		Function.SetPosition(ref mNode2, Index, 20, BaseOrSub: true);
		if (Index + 20 > PacketData.Length)
		{
			mNode.Add(mNode2);
			text = "[ Malformed INTERNET packet. Remaining bytes don't fit an INTERNET packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			LItem.Info = text;
			return false;
		}
		try
		{
			PACKET_INTERNET pACKET_INTERNET = default(PACKET_INTERNET);
			pACKET_INTERNET.Version = PacketData[Index++];
			pACKET_INTERNET.HeaderLength = (byte)((pACKET_INTERNET.Version & 0xF) * 4);
			pACKET_INTERNET.Version >>= 4;
			text = "Version : " + Function.ReFormatString(pACKET_INTERNET.Version, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			text = "Length : " + Function.ReFormatString(pACKET_INTERNET.HeaderLength, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_INTERNET.DifferentiatedServicesField = PacketData[Index++];
			TreeNode mNode3 = new TreeNode();
			mNode3.Text = "Differentiated Services Field : " + Function.ReFormatString(pACKET_INTERNET.DifferentiatedServicesField, null);
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: true);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_INTERNET.DifferentiatedServicesField, 252, "Differentiated Services Codepoint ( Default : 0 )"));
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_INTERNET.DifferentiatedServicesField, 2, "ECN Capable Transport ( ECT ) : Yes", "ECN Capable Transport ( ECT ) : No"));
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_INTERNET.DifferentiatedServicesField, 1, "ECN-CE : Yes", "ECN-CE : No"));
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			mNode2.Nodes.Add(mNode3);
			pACKET_INTERNET.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Total Length : " + Function.ReFormatString(pACKET_INTERNET.Length, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_INTERNET.Identification = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Identification : " + Function.ReFormatString(pACKET_INTERNET.Identification, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_INTERNET.FragmentOffset = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_INTERNET.Flags = (byte)(pACKET_INTERNET.FragmentOffset >> 12);
			mNode3 = new TreeNode();
			mNode3.Text = "Flags : " + Function.ReFormatString(pACKET_INTERNET.Flags, null);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: true);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_INTERNET.Flags, 4, "Dont fragment : Yes", "Dont fragment : No"));
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_INTERNET.Flags, 2, "More fragments : Yes", "More fragments : No"));
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			mNode2.Nodes.Add(mNode3);
			pACKET_INTERNET.FragmentOffset &= 15;
			text = "Fragment Offset : " + Function.ReFormatString(pACKET_INTERNET.FragmentOffset, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_INTERNET.TimeToLive = PacketData[Index++];
			text = "Time To Live : " + Function.ReFormatString(pACKET_INTERNET.TimeToLive, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_INTERNET.Protocol = PacketData[Index++];
			text = "Protocol : " + Function.ReFormatString(pACKET_INTERNET.Protocol, Const.GetProtocolStr(pACKET_INTERNET.Protocol));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_INTERNET.HeaderChecksum = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Header Checksum : " + Function.ReFormatString(pACKET_INTERNET.HeaderChecksum, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_INTERNET.Source = Function.GetIpAddress(PacketData, ref Index);
			text = "Source : " + pACKET_INTERNET.Source;
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 4, 4, BaseOrSub: false);
			pACKET_INTERNET.Destination = Function.GetIpAddress(PacketData, ref Index);
			text = "Destination : " + pACKET_INTERNET.Destination;
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 4, 4, BaseOrSub: false);
			LItem.Protocol = "INTERNET";
			LItem.Source = pACKET_INTERNET.Source;
			LItem.Destination = pACKET_INTERNET.Destination;
			LItem.Info = "Internet packet";
			mNode.Add(mNode2);
			if (pACKET_INTERNET.Protocol == 6)
			{
				PacketTCP.Parser(ref mNode, PacketData, ref Index, ref LItem, ref PreviousHttpSequence);
			}
			else if (pACKET_INTERNET.Protocol == 17)
			{
				PacketUDP.Parser(ref mNode, PacketData, ref Index, ref LItem, ref LastTftpPort);
			}
			else if (pACKET_INTERNET.Protocol == 1)
			{
				PacketICMP.Parser(ref mNode, PacketData, ref Index, ref LItem);
			}
			else if (pACKET_INTERNET.Protocol == 88)
			{
				PacketEIGRP.Parser(ref mNode, PacketData, ref Index, ref LItem);
			}
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed INTERNET packet. Remaining bytes don't fit an INTERNET packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.Info = "[ Malformed INTERNET packet. Remaining bytes don't fit an INTERNET packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, ref string TypeInfo, ref uint PreviousHttpSequence, ref ushort LastTftpPort)
	{
		string text = "";
		if (Index + 20 > PacketData.Length)
		{
			text = "[ Malformed INTERNET packet. Remaining bytes don't fit an INTERNET packet. Possibly due to bad decoding ]";
			LItem.Info = text;
			return false;
		}
		try
		{
			PACKET_INTERNET pACKET_INTERNET = default(PACKET_INTERNET);
			pACKET_INTERNET.Version = PacketData[Index++];
			pACKET_INTERNET.HeaderLength = (byte)((pACKET_INTERNET.Version & 0xF) * 4);
			pACKET_INTERNET.Version >>= 4;
			pACKET_INTERNET.DifferentiatedServicesField = PacketData[Index++];
			pACKET_INTERNET.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_INTERNET.Identification = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_INTERNET.FragmentOffset = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_INTERNET.Flags = (byte)(pACKET_INTERNET.FragmentOffset >> 12);
			pACKET_INTERNET.FragmentOffset &= 15;
			pACKET_INTERNET.TimeToLive = PacketData[Index++];
			pACKET_INTERNET.Protocol = PacketData[Index++];
			pACKET_INTERNET.HeaderChecksum = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_INTERNET.Source = Function.GetIpAddress(PacketData, ref Index);
			pACKET_INTERNET.Destination = Function.GetIpAddress(PacketData, ref Index);
			mach2mach.Add(LItem.Source, pACKET_INTERNET.Source);
			mach2mach.Add(LItem.Destination, pACKET_INTERNET.Destination);
			LItem.Protocol = "INTERNET";
			LItem.Source = pACKET_INTERNET.Source;
			LItem.Destination = pACKET_INTERNET.Destination;
			LItem.Info = "Internet packet";
			if (pACKET_INTERNET.Protocol == 6)
			{
				TypeInfo = "TCP";
				PacketTCP.Parser(PacketData, ref Index, ref LItem, ref PreviousHttpSequence);
			}
			else if (pACKET_INTERNET.Protocol == 17)
			{
				TypeInfo = "UDP";
				PacketUDP.Parser(PacketData, ref Index, ref LItem, ref LastTftpPort);
			}
			else if (pACKET_INTERNET.Protocol == 1)
			{
				TypeInfo = "ICMP";
				PacketICMP.Parser(PacketData, ref Index, ref LItem);
			}
			else if (pACKET_INTERNET.Protocol == 88)
			{
				PacketEIGRP.Parser(PacketData, ref Index, ref LItem);
			}
		}
		catch
		{
			LItem.Info = "[ Malformed INTERNET packet. Remaining bytes don't fit an INTERNET packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}
}
