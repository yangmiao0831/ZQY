using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketDLSW
{
	public struct PACKET_DLSW
	{
		public byte Version;

		public byte HeaderLength;

		public ushort MessageLength;

		public uint RemoteDataLinkCorrelator;

		public uint RemoteDLCPortId;

		public ushort Reserved1;

		public byte MessageType;

		public byte FlowControlByte;

		public byte ProtocolId;

		public byte HeaderNumber;

		public ushort Reserved2;

		public byte LargestFrameSize;

		public byte SSPFlags;

		public byte CircuitPriority;

		public byte OldMessageType;

		public string TargetMACAddress;

		public string OriginMACAddress;

		public byte OriginLSAP;

		public byte TargetLSAP;

		public byte FrameDirector;

		public byte Reserved3;

		public ushort Reserved5;

		public ushort DLCPortId;

		public uint X;

		public uint OriginDLCPortId;

		public uint OriginTransporter;

		public uint TargetDataLink;

		public ushort DlcHeaderLength;

		public uint OriginDLC;

		public uint TargetDLCPortId;

		public uint TargetTransportId;

		public uint Reserved6;
	}

	private static void ParseCapEx(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref ListViewItem LItem)
	{
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref ListViewItem LItem)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		string text = "";
		int num = 0;
		byte b = 0;
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "DLSw ( Data Link Switching )";
		num = Index;
		PACKET_DLSW pACKET_DLSW = default(PACKET_DLSW);
		pACKET_DLSW.DlcHeaderLength = 0;
		try
		{
			TreeNode mNode3 = new TreeNode();
			mNode3.Text = "DLSW HEADER";
			pACKET_DLSW.Version = PacketData[Index++];
			text = "Version : " + Function.ReFormatString(pACKET_DLSW.Version, Const.GetDlswVersionString(pACKET_DLSW.Version));
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			pACKET_DLSW.HeaderLength = PacketData[Index++];
			text = "Header Length : " + Function.ReFormatString(pACKET_DLSW.HeaderLength, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			pACKET_DLSW.MessageLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Message Length : " + Function.ReFormatString(pACKET_DLSW.MessageLength, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_DLSW.RemoteDataLinkCorrelator = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Remote DLC : " + Function.ReFormatString(pACKET_DLSW.RemoteDataLinkCorrelator, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
			pACKET_DLSW.RemoteDLCPortId = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Remote DLC PID : " + Function.ReFormatString(pACKET_DLSW.HeaderLength, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
			pACKET_DLSW.Reserved1 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Reserved : " + Function.ReFormatString(pACKET_DLSW.HeaderLength, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_DLSW.MessageType = PacketData[Index++];
			text = "Message Tpye : " + Function.ReFormatString(pACKET_DLSW.MessageType, Const.GetDlswTypeString(pACKET_DLSW.MessageType));
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			pACKET_DLSW.FlowControlByte = PacketData[Index++];
			text = "Flow Control Byte : " + Function.ReFormatString(pACKET_DLSW.FlowControlByte, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			if (pACKET_DLSW.HeaderLength != 16)
			{
				pACKET_DLSW.ProtocolId = PacketData[Index++];
				text = "Protocol ID : " + Function.ReFormatString(pACKET_DLSW.ProtocolId, null);
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
				pACKET_DLSW.HeaderNumber = PacketData[Index++];
				text = "Header Number : " + Function.ReFormatString(pACKET_DLSW.HeaderNumber, null);
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
				pACKET_DLSW.Reserved2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Reserved : " + Function.ReFormatString(pACKET_DLSW.Reserved2, null);
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
				pACKET_DLSW.LargestFrameSize = PacketData[Index++];
				text = "Largest Frame Size : " + Function.ReFormatString(pACKET_DLSW.LargestFrameSize, null);
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
				pACKET_DLSW.SSPFlags = PacketData[Index++];
				text = "SSP Flags : " + Function.ReFormatString(pACKET_DLSW.SSPFlags, null);
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
				pACKET_DLSW.CircuitPriority = PacketData[Index++];
				text = "Circuit Priority : " + Function.ReFormatString(pACKET_DLSW.CircuitPriority, Const.GetDlswPriorityString(pACKET_DLSW.CircuitPriority));
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
				pACKET_DLSW.OldMessageType = PacketData[Index++];
				text = "Old Message Type : " + Function.ReFormatString(pACKET_DLSW.OldMessageType, Const.GetDlswTypeString(pACKET_DLSW.OldMessageType));
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
				if (pACKET_DLSW.MessageType == 32)
				{
					Index += 14;
					text = "Not used for CapEx";
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index - 14, 14, BaseOrSub: false);
					pACKET_DLSW.FrameDirector = PacketData[Index++];
					text = "Frame Direction : " + Function.ReFormatString(pACKET_DLSW.FrameDirector, (pACKET_DLSW.FrameDirector == 1) ? "Capabilities request" : "Capabilities response");
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
					Index += 33;
					text = "Not used for CapEx";
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index - 33, 33, BaseOrSub: false);
				}
				else
				{
					pACKET_DLSW.TargetMACAddress = Function.GetMACAddress(PacketData, ref Index);
					text = "Target MAC Address : " + pACKET_DLSW.TargetMACAddress;
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index - 6, 6, BaseOrSub: false);
					pACKET_DLSW.OriginMACAddress = Function.GetMACAddress(PacketData, ref Index);
					text = "Origin MAC Address : " + pACKET_DLSW.OriginMACAddress;
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index - 6, 6, BaseOrSub: false);
					pACKET_DLSW.OriginLSAP = PacketData[Index++];
					text = "Origin Link SAP : " + Function.ReFormatString(pACKET_DLSW.OriginLSAP, null);
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
					pACKET_DLSW.TargetLSAP = PacketData[Index++];
					text = "Target Link SAP : " + Function.ReFormatString(pACKET_DLSW.TargetLSAP, null);
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
					pACKET_DLSW.FrameDirector = PacketData[Index++];
					text = "Frame Direction : " + Function.ReFormatString(pACKET_DLSW.FrameDirector, null);
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
					pACKET_DLSW.Reserved3 = PacketData[Index++];
					text = "Reserved : " + Function.ReFormatString(pACKET_DLSW.Reserved3, null);
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
					pACKET_DLSW.Reserved5 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
					text = "Reserved : " + Function.ReFormatString(pACKET_DLSW.Reserved5, null);
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
					pACKET_DLSW.DlcHeaderLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
					text = "DLC Header Length : " + Function.ReFormatString(pACKET_DLSW.DlcHeaderLength, null);
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
					pACKET_DLSW.OriginDLCPortId = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
					text = "Reserved : " + Function.ReFormatString(pACKET_DLSW.OriginDLCPortId, null);
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
					pACKET_DLSW.OriginDLC = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
					text = "Origin DLC : " + Function.ReFormatString(pACKET_DLSW.OriginDLC, null);
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
					pACKET_DLSW.OriginTransporter = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
					text = "Origin Transport ID : " + Function.ReFormatString(pACKET_DLSW.OriginTransporter, null);
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
					pACKET_DLSW.TargetDLCPortId = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
					text = "Target DLC Port ID : " + Function.ReFormatString(pACKET_DLSW.TargetDLCPortId, null);
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
					pACKET_DLSW.TargetDataLink = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
					text = "Target DLC : " + Function.ReFormatString(pACKET_DLSW.TargetDataLink, null);
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
					pACKET_DLSW.TargetTransportId = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
					text = "Target Transport ID : " + Function.ReFormatString(pACKET_DLSW.TargetTransportId, null);
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
					pACKET_DLSW.Reserved6 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
					text = "Reserved : " + Function.ReFormatString(pACKET_DLSW.Reserved6, null);
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
				}
			}
			Function.SetPosition(ref mNode3, num, Index - num, BaseOrSub: false);
			mNode2.Nodes.Add(mNode3);
			text = "Dlsw Data ";
			mNode3.Nodes.Add(text);
			switch (pACKET_DLSW.MessageType)
			{
			case 32:
				ParseCapEx(ref mNode, PacketData, ref Index, ref LItem);
				break;
			case 10:
			case 29:
			case 33:
				text = "Data ";
				mNode3.Nodes.Add(text);
				break;
			default:
				if (pACKET_DLSW.DlcHeaderLength != 0)
				{
					Index = pACKET_DLSW.HeaderLength;
					b = PacketData[Index++];
					text = "DLC Header - AC byte : " + Function.ReFormatString(b, null);
					mNode2.Nodes.Add(text);
					Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
					b = PacketData[Index++];
					text = "DLC Header - FC byte : " + Function.ReFormatString(b, null);
					mNode2.Nodes.Add(text);
					Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
					b = PacketData[Index++];
					text = "DLC Header - DA : " + Function.GetMACAddress(PacketData, ref Index);
					mNode2.Nodes.Add(text);
					Function.SetPosition(ref mNode2, Index - 6, 6, BaseOrSub: false);
					text = "DLC Header - SA : " + Function.GetMACAddress(PacketData, ref Index);
					mNode2.Nodes.Add(text);
					Function.SetPosition(ref mNode2, Index - 6, 6, BaseOrSub: false);
					text = "DLC Header - RIF : " + Function.GetString(PacketData, ref Index, 18);
					mNode2.Nodes.Add(text);
					Function.SetPosition(ref mNode2, Index - 18, 18, BaseOrSub: false);
					b = PacketData[Index++];
					text = "DLC Header - DSAP : " + Function.ReFormatString(b, null);
					mNode2.Nodes.Add(text);
					Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
					b = PacketData[Index++];
					text = "DLC Header - SSAP : " + Function.ReFormatString(b, null);
					mNode2.Nodes.Add(text);
					Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
					b = PacketData[Index++];
					text = "DLC Header - Ctrl : " + Function.ReFormatString(b, null);
					mNode2.Nodes.Add(text);
					Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				}
				text = "Dlsw Data ";
				mNode3.Nodes.Add(text);
				break;
			}
			Function.SetPosition(ref mNode2, num, Index - num, BaseOrSub: true);
			LItem.SubItems[6].Text = "DLSw";
			text = "DLSw " + pACKET_DLSW.Version + " : " + Const.GetDlswVersionString(pACKET_DLSW.Version);
			string text2 = text;
			text = text2 + "," + pACKET_DLSW.MessageType + " : " + Const.GetDlswTypeString(pACKET_DLSW.MessageType);
			LItem.SubItems[9].Text = text;
			mNode.Add(mNode2);
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed DLSw packet. Remaining bytes don't fit an DLSw packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.SubItems[9].Text = text;
			return false;
		}
		return true;
	}
}
