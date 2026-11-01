using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketLLC
{
	public struct PACKET_LLC
	{
		public byte DSAP;

		public byte SSAP;

		public ushort ControlField;

		public uint OrganizationCode;

		public ushort ProtocolId;
	}

	public static string GetLLCControlTypeString(byte Type)
	{
		string text = "";
		byte b = (byte)(Type & 0xE0);
		byte b2 = (byte)(Type & 0x10);
		byte b3 = (byte)(Type & 0xC);
		byte b4 = (byte)(Type & 3);
		if (b4 != 3)
		{
			return "";
		}
		switch (b)
		{
		case 0:
			text = "UI- Unnumbered information";
			break;
		case 1:
			text = "DISC- Disconnect";
			break;
		case 2:
			text = "SABME- Set Asynchronous Balanced Mode Extended";
			break;
		case 3:
			text = "XID- Exchange IDs";
			break;
		case 4:
			text = "TEST- Test the link";
			break;
		case 5:
			text = "UA- Unnumbered Acknowledgement";
			break;
		case 6:
			text = "DM- Disconnect Mode";
			break;
		case 7:
			text = "FRMR- Frame Reject";
			break;
		}
		switch (b2)
		{
		case 0:
			text += ", Poll";
			break;
		case 1:
			text += ", Final";
			break;
		}
		switch (b3)
		{
		case 1:
			text += ", Command";
			break;
		case 2:
			text += ", Response";
			break;
		case 3:
			text += ", Data";
			break;
		}
		return text;
	}

	public static string GetLLCControlTypeString(ushort Type)
	{
		string text = "";
		if ((Type & 1) == 1)
		{
			ushort num = (ushort)(Type & 0xE000);
			num >>= 13;
			ushort num2 = (ushort)(Type & 0x1000);
			num2 >>= 12;
			ushort num3 = (ushort)(Type & 0xC0);
			num3 >>= 2;
			text = "Received Pdu Number : " + num;
			text = ((num2 != 1) ? (text + ", Poll, ") : (text + ", Final, "));
			switch (num3)
			{
			case 0:
				text += "Receiver is ready";
				break;
			case 1:
				text += "Receiver is not ready";
				break;
			case 2:
				text += "Rejected";
				break;
			}
		}
		else
		{
			ushort num = (ushort)(Type & 0xE000);
			num >>= 13;
			ushort num2 = (ushort)(Type & 0x1000);
			num2 >>= 12;
			ushort num3 = (ushort)(Type & 0xE00);
			num3 >>= 1;
			text = "Received Pdu Number : " + num;
			text = ((num2 != 1) ? (text + ", Poll, ") : (text + ", Final, "));
			text = text + ", Sent Pdu Number : " + num3;
		}
		return text;
	}

	public static string GetLLCTypeString(byte Type)
	{
		string result = "";
		switch (Type)
		{
		case 0:
			result = "LSAP";
			break;
		case 2:
			result = "LLC Sublayer Management Function ( Individual )";
			break;
		case 3:
			result = "LLC Sublayer Management Function ( Group )";
			break;
		case 4:
			result = "IBM Sna Path Control ( Individual )";
			break;
		case 5:
			result = "IBM Sna Path Control ( Group )";
			break;
		case 6:
			result = "ARPANET Internet Protocol ( IP )";
			break;
		case 8:
			result = "SNA CSNA EPROWAY (IEC955 ) Network Management & Initialization";
			break;
		case 24:
			result = "Texas Instruments";
			break;
		case 66:
			result = "IEEE 802.1 Bridge Spannning Tree Protocol";
			break;
		case 78:
			result = "EIA RS-511 Manufacturing Message Service";
			break;
		case 126:
			result = "ISO 8208 (X.25 over IEEE 802.2 Type 2 LLC)";
			break;
		case 128:
			result = "Xerox Network Systems (XNS)";
			break;
		case 134:
			result = "Nestar";
			break;
		case 142:
			result = "PROWAY (IEC 955) Active Station List Maintenance";
			break;
		case 152:
			result = "ARPANET Address Resolution Protocol (ARP)";
			break;
		case 188:
			result = "Banyan VINES";
			break;
		case 170:
			result = "SubNetwork Access Protocl (SNAP)";
			break;
		case 224:
			result = "Novell NetWare";
			break;
		case 240:
			result = "IBM NetBIOS";
			break;
		case 244:
			result = "IBM LAN Management ( Individual )";
			break;
		case 245:
			result = "IBM LAN Management ( Group )";
			break;
		case 248:
			result = "IBM Remote Program Load (RPL)";
			break;
		case 250:
			result = "Ungermann-Bass";
			break;
		case 254:
			result = "ISO Network Layer Protocol";
			break;
		case byte.MaxValue:
			result = "Global LSAP";
			break;
		}
		return result;
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, ushort LLCLength, ref uint PreviousHttpSequence, ref ushort LastTftpPort)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		string text = "";
		bool flag = false;
		int num = 0;
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "LLC ( Logical Link Control Protocol )";
		num = Index;
		try
		{
			PACKET_LLC pACKET_LLC = default(PACKET_LLC);
			pACKET_LLC.DSAP = PacketData[Index++];
			text = "DSAP : " + Function.ReFormatString(pACKET_LLC.DSAP, GetLLCTypeString(pACKET_LLC.DSAP));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_LLC.SSAP = PacketData[Index++];
			text = "SSAP : " + Function.ReFormatString(pACKET_LLC.SSAP, GetLLCTypeString(pACKET_LLC.SSAP));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			flag = ((pACKET_LLC.DSAP == 170 && pACKET_LLC.SSAP == 170) ? true : false);
			pACKET_LLC.ControlField = PacketData[Index++];
			bool flag2 = true;
			if ((pACKET_LLC.ControlField & 3) != 3)
			{
				pACKET_LLC.ControlField *= 256;
				pACKET_LLC.ControlField += PacketData[Index++];
				flag2 = false;
			}
			text = "Control Field : " + Function.ReFormatString(pACKET_LLC.ControlField, null);
			mNode2.Nodes.Add(text);
			if (flag2)
			{
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			}
			else
			{
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			}
			pACKET_LLC.OrganizationCode = 0u;
			if (flag)
			{
				pACKET_LLC.OrganizationCode = Function.Get3Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Organization Code : " + Function.ReFormatString(pACKET_LLC.OrganizationCode, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 3, 3, BaseOrSub: false);
				pACKET_LLC.ProtocolId = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Protocol Id : " + Function.ReFormatString(pACKET_LLC.ProtocolId, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			}
			LItem.Protocol = "LLC";
			LItem.Info = "Logical link control protocol";
			Function.SetPosition(ref mNode2, num, Index - num, BaseOrSub: true);
			mNode.Add(mNode2);
			if (flag)
			{
				switch (pACKET_LLC.OrganizationCode)
				{
				case 12u:
					PacketCDP.Parser(ref mNode, PacketData, ref Index, ref LItem);
					break;
				}
			}
			else if (LLCLength > 4)
			{
				switch (pACKET_LLC.DSAP)
				{
				case 6:
					PacketINTERNET.Parser(ref mNode, PacketData, ref Index, ref LItem, ref PreviousHttpSequence, ref LastTftpPort);
					break;
				case 224:
					PacketIPX.Parser(ref mNode, PacketData, ref Index, ref LItem);
					break;
				case 240:
					PacketNETBIOS.Parser(ref mNode, PacketData, ref Index, ref LItem);
					break;
				case 66:
					PacketSTP.Parser(ref mNode, PacketData, ref Index, ref LItem);
					break;
				}
			}
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed LLC packet. Remaining bytes don't fit an LLC packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.Info = "[ Malformed LLC packet. Remaining bytes don't fit an LLC packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, ref string TypeInfo, ushort LLCLength, ref uint PreviousHttpSequence, ref ushort LastTftpPort)
	{
		bool flag = false;
		try
		{
			PACKET_LLC pACKET_LLC = default(PACKET_LLC);
			pACKET_LLC.DSAP = PacketData[Index++];
			pACKET_LLC.SSAP = PacketData[Index++];
			flag = ((pACKET_LLC.DSAP == 170 && pACKET_LLC.SSAP == 170) ? true : false);
			pACKET_LLC.ControlField = PacketData[Index++];
			if ((pACKET_LLC.ControlField & 0xFC) != 3)
			{
				pACKET_LLC.ControlField *= 256;
				pACKET_LLC.ControlField += PacketData[Index++];
			}
			if (flag)
			{
				pACKET_LLC.OrganizationCode = Function.Get3Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_LLC.ProtocolId = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			}
			LItem.Protocol = "LLC";
			LItem.Info = "Logical link control protocol";
			pACKET_LLC.OrganizationCode = 0u;
			if (flag)
			{
				switch (pACKET_LLC.OrganizationCode)
				{
				case 12u:
					PacketCDP.Parser(PacketData, ref Index, ref LItem);
					break;
				}
			}
			else if (LLCLength > 4)
			{
				switch (pACKET_LLC.DSAP)
				{
				case 6:
					PacketINTERNET.Parser(PacketData, ref Index, ref LItem, ref TypeInfo, ref PreviousHttpSequence, ref LastTftpPort);
					break;
				case 224:
					TypeInfo = "IPX";
					PacketIPX.Parser(PacketData, ref Index, ref LItem);
					break;
				case 240:
					TypeInfo = "NetBIOS";
					PacketNETBIOS.Parser(PacketData, ref Index, ref LItem);
					break;
				case 66:
					PacketSTP.Parser(PacketData, ref Index, ref LItem);
					break;
				}
			}
		}
		catch
		{
			LItem.Info = "[ Malformed LLC packet. Remaining bytes don't fit an LLC packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}
}
