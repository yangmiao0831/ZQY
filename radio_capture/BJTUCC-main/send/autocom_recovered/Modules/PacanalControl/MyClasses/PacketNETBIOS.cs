using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketNETBIOS
{
	public struct PACKET_NETBIOS
	{
		public ushort Length;

		public ushort Delimeter;

		public string DelimeterStr;

		public byte Command;

		public string CommandStr;

		public ushort ResponseCorrelator;

		public string NameToAdd;

		public string ReceiversName;

		public string SendersName;

		public string NameInConflict;

		public string QueryName;

		public byte StatusRequest;

		public byte StatusResponse;

		public ushort Data2;

		public byte Data1;

		public byte LocalSessionNumber;

		public byte RemoteSessionNumber;

		public byte CallNameType;

		public ushort XmitCorrelator;

		public byte DataFirstMidleFlags;

		public byte ResyncIndicator;

		public byte DataOnlyFlags;

		public byte SessionConfirmFlags;

		public byte SessionInitFlags;

		public byte NoReceiveFlags;
	}

	public static string GetCommandString(byte cmd)
	{
		string result = "";
		switch (cmd)
		{
		case 1:
			result = "Add Name Query";
			break;
		case 8:
			result = "Datagram";
			break;
		}
		return result;
	}

	public static string GetDelimeterString(ushort cmd)
	{
		string result = "";
		ushort num = cmd;
		if (num == 61439)
		{
			result = "Netbios";
		}
		return result;
	}

	public static string GetNameNumberString(byte cmd)
	{
		string text = "";
		return "";
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		string text = "";
		int num = 0;
		byte NameNumber = 0;
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "NETBIOS ( Netbios Protocol )";
		num = Index;
		try
		{
			PACKET_NETBIOS pACKET_NETBIOS = default(PACKET_NETBIOS);
			pACKET_NETBIOS.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Length     :" + Function.ReFormatString(pACKET_NETBIOS.Length, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_NETBIOS.Delimeter = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Delimeter  :" + Function.ReFormatString(pACKET_NETBIOS.Delimeter, GetDelimeterString(pACKET_NETBIOS.Delimeter));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_NETBIOS.Command = PacketData[Index++];
			text = "Command    :" + Function.ReFormatString(pACKET_NETBIOS.Command, GetCommandString(pACKET_NETBIOS.Command));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			switch (pACKET_NETBIOS.Command)
			{
			case 0:
				pACKET_NETBIOS.ResponseCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Response Correlator : " + Function.ReFormatString(pACKET_NETBIOS.ResponseCorrelator, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_NETBIOS.NameToAdd = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				text = "Name to Add : " + pACKET_NETBIOS.NameToAdd;
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 16, 16, BaseOrSub: false);
				break;
			case 1:
				pACKET_NETBIOS.ResponseCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Response Correlator : " + Function.ReFormatString(pACKET_NETBIOS.ResponseCorrelator, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_NETBIOS.NameToAdd = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				text = "Name To Add : " + pACKET_NETBIOS.NameToAdd;
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 16, 16, BaseOrSub: false);
				break;
			case 2:
				pACKET_NETBIOS.NameInConflict = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				text = "Name in Conflict : " + pACKET_NETBIOS.NameInConflict;
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 16, 16, BaseOrSub: false);
				pACKET_NETBIOS.SendersName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				text = "Sender's Name : " + pACKET_NETBIOS.SendersName;
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 16, 16, BaseOrSub: false);
				break;
			case 3:
				pACKET_NETBIOS.StatusRequest = PacketData[Index++];
				text = "Status Request : " + Function.ReFormatString(pACKET_NETBIOS.StatusRequest, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.Data2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Data 2 : " + Function.ReFormatString(pACKET_NETBIOS.Data2, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_NETBIOS.ResponseCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Response Correlator : " + Function.ReFormatString(pACKET_NETBIOS.ResponseCorrelator, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_NETBIOS.ReceiversName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				text = "Receiver's Name : " + pACKET_NETBIOS.ReceiversName;
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 16, 16, BaseOrSub: false);
				pACKET_NETBIOS.SendersName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				text = "Sender's Name : " + pACKET_NETBIOS.SendersName;
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 16, 16, BaseOrSub: false);
				break;
			case 8:
				while (PacketData[Index] == 0)
				{
					Index++;
				}
				pACKET_NETBIOS.ReceiversName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				text = "Receiver's Name : " + pACKET_NETBIOS.ReceiversName;
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 16, 16, BaseOrSub: false);
				if (Function.CheckBytesForZero(PacketData, Index, 10))
				{
					Index += 10;
					pACKET_NETBIOS.SendersName = Function.GetMACAddress(PacketData, ref Index);
					text = "Sender's MAC Address : " + pACKET_NETBIOS.SendersName;
					mNode2.Nodes.Add(text);
					Function.SetPosition(ref mNode2, Index - 6, 6, BaseOrSub: false);
				}
				else
				{
					pACKET_NETBIOS.SendersName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
					text = "Sender's Name : " + pACKET_NETBIOS.SendersName;
					mNode2.Nodes.Add(text);
					Function.SetPosition(ref mNode2, Index - 16, 16, BaseOrSub: false);
				}
				break;
			case 9:
				if (Function.CheckBytesForZero(PacketData, Index, 10))
				{
					Index += 10;
					pACKET_NETBIOS.SendersName = Function.GetMACAddress(PacketData, ref Index);
					text = "Sender's MAC Address : " + pACKET_NETBIOS.SendersName;
					mNode2.Nodes.Add(text);
					Function.SetPosition(ref mNode2, Index - 6, 6, BaseOrSub: false);
				}
				else
				{
					pACKET_NETBIOS.SendersName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
					text = "Sender's Name : " + pACKET_NETBIOS.SendersName;
					mNode2.Nodes.Add(text);
					Function.SetPosition(ref mNode2, Index - 16, 16, BaseOrSub: false);
				}
				break;
			case 10:
				Index++;
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				text = "Local Session Number : " + Function.ReFormatString(pACKET_NETBIOS.LocalSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.CallNameType = PacketData[Index++];
				text = "Call Name Type : " + Function.ReFormatString(pACKET_NETBIOS.CallNameType, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				Index += 2;
				pACKET_NETBIOS.ResponseCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Response Correlator : " + Function.ReFormatString(pACKET_NETBIOS.ResponseCorrelator, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_NETBIOS.QueryName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				text = "Query Name : " + pACKET_NETBIOS.QueryName;
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 16, 16, BaseOrSub: false);
				if (pACKET_NETBIOS.LocalSessionNumber != 0)
				{
					pACKET_NETBIOS.SendersName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
					text = "Sender's Name : " + pACKET_NETBIOS.SendersName;
					mNode2.Nodes.Add(text);
					Function.SetPosition(ref mNode2, Index - 16, 16, BaseOrSub: false);
				}
				break;
			case 13:
				pACKET_NETBIOS.Data1 = PacketData[Index++];
				text = "Data 1 : " + Function.ReFormatString(pACKET_NETBIOS.Data1, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.Data2 = PacketData[Index++];
				text = "Data 2 : " + Function.ReFormatString(pACKET_NETBIOS.Data2, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				Index++;
				pACKET_NETBIOS.XmitCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Xmit Correlator : " + Function.ReFormatString(pACKET_NETBIOS.XmitCorrelator, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				Index += 2;
				pACKET_NETBIOS.ReceiversName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				text = "Receiver's Name : " + pACKET_NETBIOS.ReceiversName;
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 16, 16, BaseOrSub: false);
				pACKET_NETBIOS.SendersName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				text = "Sender's Name : " + pACKET_NETBIOS.SendersName;
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 16, 16, BaseOrSub: false);
				break;
			case 14:
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				text = "Local Session Number : " + Function.ReFormatString(pACKET_NETBIOS.LocalSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.CallNameType = PacketData[Index++];
				text = "Call Name Type : " + Function.ReFormatString(pACKET_NETBIOS.CallNameType, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.XmitCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Xmit Correlator : " + Function.ReFormatString(pACKET_NETBIOS.XmitCorrelator, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				if (pACKET_NETBIOS.LocalSessionNumber != 0 && pACKET_NETBIOS.LocalSessionNumber != byte.MaxValue)
				{
					pACKET_NETBIOS.ResponseCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
					text = "Response Correlator : " + Function.ReFormatString(pACKET_NETBIOS.ResponseCorrelator, null);
					mNode2.Nodes.Add(text);
					Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				}
				pACKET_NETBIOS.ReceiversName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				text = "Receiver's Name : " + pACKET_NETBIOS.ReceiversName;
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 16, 16, BaseOrSub: false);
				if (pACKET_NETBIOS.LocalSessionNumber != 0 && pACKET_NETBIOS.LocalSessionNumber != byte.MaxValue)
				{
					pACKET_NETBIOS.SendersName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
					text = "Sender's Name : " + pACKET_NETBIOS.SendersName;
					mNode2.Nodes.Add(text);
					Function.SetPosition(ref mNode2, Index - 16, 16, BaseOrSub: false);
				}
				break;
			case 15:
				pACKET_NETBIOS.StatusResponse = PacketData[Index++];
				text = "Status Response : " + Function.ReFormatString(pACKET_NETBIOS.StatusResponse, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.Data2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Data 2 : " + Function.ReFormatString(pACKET_NETBIOS.Data2, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				Index--;
				pACKET_NETBIOS.CallNameType = PacketData[Index++];
				text = "Call Name Type : " + Function.ReFormatString(pACKET_NETBIOS.CallNameType, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.XmitCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Xmit Correlator : " + Function.ReFormatString(pACKET_NETBIOS.XmitCorrelator, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				Index += 2;
				pACKET_NETBIOS.ReceiversName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				text = "Receiver's Name : " + pACKET_NETBIOS.ReceiversName;
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 16, 16, BaseOrSub: false);
				pACKET_NETBIOS.SendersName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				text = "Sender's Name : " + pACKET_NETBIOS.SendersName;
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 16, 16, BaseOrSub: false);
				break;
			case 20:
				Index += 5;
				pACKET_NETBIOS.XmitCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Xmit Correlator : " + Function.ReFormatString(pACKET_NETBIOS.XmitCorrelator, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_NETBIOS.RemoteSessionNumber = PacketData[Index++];
				text = "Remote Session Number : " + Function.ReFormatString(pACKET_NETBIOS.RemoteSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				text = "Local Session Number : " + Function.ReFormatString(pACKET_NETBIOS.LocalSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				break;
			case 21:
				pACKET_NETBIOS.DataFirstMidleFlags = PacketData[Index++];
				text = "Data First Midle Flags : " + Function.ReFormatString(pACKET_NETBIOS.DataFirstMidleFlags, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.ResyncIndicator = PacketData[Index++];
				text = "Resync Indicator : " + Function.ReFormatString(pACKET_NETBIOS.ResyncIndicator, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				Index++;
				pACKET_NETBIOS.ResponseCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Response Correlator : " + Function.ReFormatString(pACKET_NETBIOS.ResponseCorrelator, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_NETBIOS.XmitCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Xmit Correlator : " + Function.ReFormatString(pACKET_NETBIOS.XmitCorrelator, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_NETBIOS.RemoteSessionNumber = PacketData[Index++];
				text = "Remote Session Number : " + Function.ReFormatString(pACKET_NETBIOS.RemoteSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				text = "Local Session Number : " + Function.ReFormatString(pACKET_NETBIOS.LocalSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				break;
			case 22:
				pACKET_NETBIOS.DataOnlyFlags = PacketData[Index++];
				text = "Data Only Flags : " + Function.ReFormatString(pACKET_NETBIOS.DataOnlyFlags, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.ResyncIndicator = PacketData[Index++];
				text = "Resync Indicator : " + Function.ReFormatString(pACKET_NETBIOS.ResyncIndicator, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				Index++;
				pACKET_NETBIOS.ResponseCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Response Correlator : " + Function.ReFormatString(pACKET_NETBIOS.ResponseCorrelator, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_NETBIOS.XmitCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Xmit Correlator : " + Function.ReFormatString(pACKET_NETBIOS.XmitCorrelator, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_NETBIOS.RemoteSessionNumber = PacketData[Index++];
				text = "Remote Session Number : " + Function.ReFormatString(pACKET_NETBIOS.RemoteSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				text = "Local Session Number : " + Function.ReFormatString(pACKET_NETBIOS.LocalSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				break;
			case 23:
				pACKET_NETBIOS.SessionConfirmFlags = PacketData[Index++];
				text = "Session Confirm Flags : " + Function.ReFormatString(pACKET_NETBIOS.SessionConfirmFlags, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.Data2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Data 2 : " + Function.ReFormatString(pACKET_NETBIOS.Data2, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_NETBIOS.ResponseCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Response Correlator : " + Function.ReFormatString(pACKET_NETBIOS.ResponseCorrelator, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_NETBIOS.XmitCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Xmit Correlator : " + Function.ReFormatString(pACKET_NETBIOS.XmitCorrelator, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_NETBIOS.RemoteSessionNumber = PacketData[Index++];
				text = "Remote Session Number : " + Function.ReFormatString(pACKET_NETBIOS.RemoteSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				text = "Local Session Number : " + Function.ReFormatString(pACKET_NETBIOS.LocalSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				break;
			case 24:
				Index++;
				pACKET_NETBIOS.Data2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Data 2 : " + Function.ReFormatString(pACKET_NETBIOS.Data2, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				Index += 4;
				pACKET_NETBIOS.RemoteSessionNumber = PacketData[Index++];
				text = "Remote Session Number : " + Function.ReFormatString(pACKET_NETBIOS.RemoteSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				text = "Local Session Number : " + Function.ReFormatString(pACKET_NETBIOS.LocalSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				break;
			case 25:
				pACKET_NETBIOS.SessionInitFlags = PacketData[Index++];
				text = "Session Init Number : " + Function.ReFormatString(pACKET_NETBIOS.SessionInitFlags, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.Data2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Data 2 : " + Function.ReFormatString(pACKET_NETBIOS.Data2, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_NETBIOS.ResponseCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Response Correlator : " + Function.ReFormatString(pACKET_NETBIOS.ResponseCorrelator, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_NETBIOS.XmitCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Xmit Correlator : " + Function.ReFormatString(pACKET_NETBIOS.XmitCorrelator, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_NETBIOS.RemoteSessionNumber = PacketData[Index++];
				text = "Remote Session Number : " + Function.ReFormatString(pACKET_NETBIOS.RemoteSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				text = "Local Session Number : " + Function.ReFormatString(pACKET_NETBIOS.LocalSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				break;
			case 26:
				pACKET_NETBIOS.NoReceiveFlags = PacketData[Index++];
				text = "No Receive Flags : " + Function.ReFormatString(pACKET_NETBIOS.NoReceiveFlags, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.Data2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Data 2 : " + Function.ReFormatString(pACKET_NETBIOS.Data2, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				Index += 2;
				pACKET_NETBIOS.RemoteSessionNumber = PacketData[Index++];
				text = "Remote Session Number : " + Function.ReFormatString(pACKET_NETBIOS.RemoteSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				text = "Local Session Number : " + Function.ReFormatString(pACKET_NETBIOS.LocalSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				break;
			case 27:
				Index++;
				pACKET_NETBIOS.Data2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Data 2 : " + Function.ReFormatString(pACKET_NETBIOS.Data2, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				Index += 2;
				pACKET_NETBIOS.RemoteSessionNumber = PacketData[Index++];
				text = "Remote Session Number : " + Function.ReFormatString(pACKET_NETBIOS.RemoteSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				text = "Local Session Number : " + Function.ReFormatString(pACKET_NETBIOS.LocalSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				break;
			case 28:
				Index += 5;
				pACKET_NETBIOS.XmitCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Xmit Correlator : " + Function.ReFormatString(pACKET_NETBIOS.XmitCorrelator, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_NETBIOS.RemoteSessionNumber = PacketData[Index++];
				text = "Remote Session Number : " + Function.ReFormatString(pACKET_NETBIOS.RemoteSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				text = "Local Session Number : " + Function.ReFormatString(pACKET_NETBIOS.LocalSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				break;
			case 31:
				Index += 7;
				pACKET_NETBIOS.RemoteSessionNumber = PacketData[Index++];
				text = "Remote Session Number : " + Function.ReFormatString(pACKET_NETBIOS.RemoteSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				text = "Local Session Number : " + Function.ReFormatString(pACKET_NETBIOS.LocalSessionNumber, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				break;
			}
			Function.SetPosition(ref mNode2, num, Index - num, BaseOrSub: true);
			mNode.Add(mNode2);
			if (Index + 4 < PacketData.Length && PacketData[Index] == byte.MaxValue && PacketData[Index + 1] == 83 && PacketData[Index + 2] == 77 && PacketData[Index + 3] == 66)
			{
				PacketSMB.Parser(ref mNode, PacketData, ref Index, ref LItem);
			}
			LItem.Protocol = "NETBIOS";
			LItem.Info = "Netbios";
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed NETBIOS packet. Remaining bytes don't fit an NETBIOS packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.Info = "[ Malformed NETBIOS packet. Remaining bytes don't fit an NETBIOS packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		byte NameNumber = 0;
		try
		{
			PACKET_NETBIOS pACKET_NETBIOS = default(PACKET_NETBIOS);
			pACKET_NETBIOS.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_NETBIOS.Delimeter = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_NETBIOS.Command = PacketData[Index++];
			switch (pACKET_NETBIOS.Command)
			{
			case 0:
				pACKET_NETBIOS.ResponseCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NETBIOS.NameToAdd = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				break;
			case 1:
				pACKET_NETBIOS.ResponseCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NETBIOS.NameToAdd = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				break;
			case 2:
				pACKET_NETBIOS.NameInConflict = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				pACKET_NETBIOS.SendersName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				break;
			case 3:
				pACKET_NETBIOS.StatusRequest = PacketData[Index++];
				pACKET_NETBIOS.ResponseCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NETBIOS.ReceiversName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				pACKET_NETBIOS.SendersName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				break;
			case 8:
				while (PacketData[Index] == 0)
				{
					Index++;
				}
				pACKET_NETBIOS.ReceiversName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				if (Function.CheckBytesForZero(PacketData, Index, 10))
				{
					Index += 10;
					pACKET_NETBIOS.SendersName = Function.GetMACAddress(PacketData, ref Index);
				}
				else
				{
					pACKET_NETBIOS.SendersName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				}
				break;
			case 9:
				if (Function.CheckBytesForZero(PacketData, Index, 10))
				{
					Index += 10;
					pACKET_NETBIOS.SendersName = Function.GetMACAddress(PacketData, ref Index);
				}
				else
				{
					pACKET_NETBIOS.SendersName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				}
				break;
			case 10:
				Index++;
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				pACKET_NETBIOS.CallNameType = PacketData[Index++];
				Index += 2;
				pACKET_NETBIOS.ResponseCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NETBIOS.QueryName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				if (pACKET_NETBIOS.LocalSessionNumber != 0)
				{
					pACKET_NETBIOS.SendersName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				}
				break;
			case 13:
				pACKET_NETBIOS.Data1 = PacketData[Index++];
				pACKET_NETBIOS.Data2 = PacketData[Index++];
				Index++;
				pACKET_NETBIOS.XmitCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				Index += 2;
				pACKET_NETBIOS.ReceiversName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				pACKET_NETBIOS.SendersName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				break;
			case 14:
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				pACKET_NETBIOS.CallNameType = PacketData[Index++];
				pACKET_NETBIOS.XmitCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				if (pACKET_NETBIOS.LocalSessionNumber != 0 && pACKET_NETBIOS.LocalSessionNumber != byte.MaxValue)
				{
					pACKET_NETBIOS.ResponseCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				}
				pACKET_NETBIOS.ReceiversName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				if (pACKET_NETBIOS.LocalSessionNumber != 0 && pACKET_NETBIOS.LocalSessionNumber != byte.MaxValue)
				{
					pACKET_NETBIOS.SendersName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				}
				break;
			case 15:
				pACKET_NETBIOS.StatusResponse = PacketData[Index++];
				pACKET_NETBIOS.Data2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				Index--;
				pACKET_NETBIOS.CallNameType = PacketData[Index++];
				pACKET_NETBIOS.XmitCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				Index += 2;
				pACKET_NETBIOS.ReceiversName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				pACKET_NETBIOS.SendersName = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
				break;
			case 20:
				Index += 5;
				pACKET_NETBIOS.XmitCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NETBIOS.RemoteSessionNumber = PacketData[Index++];
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				break;
			case 21:
				pACKET_NETBIOS.DataFirstMidleFlags = PacketData[Index++];
				pACKET_NETBIOS.ResyncIndicator = PacketData[Index++];
				Index++;
				pACKET_NETBIOS.ResponseCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NETBIOS.XmitCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NETBIOS.RemoteSessionNumber = PacketData[Index++];
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				break;
			case 22:
				pACKET_NETBIOS.DataOnlyFlags = PacketData[Index++];
				pACKET_NETBIOS.ResyncIndicator = PacketData[Index++];
				Index++;
				pACKET_NETBIOS.ResponseCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NETBIOS.XmitCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NETBIOS.RemoteSessionNumber = PacketData[Index++];
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				break;
			case 23:
				pACKET_NETBIOS.SessionConfirmFlags = PacketData[Index++];
				pACKET_NETBIOS.Data2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NETBIOS.ResponseCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NETBIOS.XmitCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NETBIOS.RemoteSessionNumber = PacketData[Index++];
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				break;
			case 24:
				Index++;
				pACKET_NETBIOS.Data2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				Index += 4;
				pACKET_NETBIOS.RemoteSessionNumber = PacketData[Index++];
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				break;
			case 25:
				pACKET_NETBIOS.SessionInitFlags = PacketData[Index++];
				pACKET_NETBIOS.Data2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NETBIOS.ResponseCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NETBIOS.XmitCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NETBIOS.RemoteSessionNumber = PacketData[Index++];
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				break;
			case 26:
				pACKET_NETBIOS.NoReceiveFlags = PacketData[Index++];
				pACKET_NETBIOS.Data2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				Index += 2;
				pACKET_NETBIOS.RemoteSessionNumber = PacketData[Index++];
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				break;
			case 27:
				Index++;
				pACKET_NETBIOS.Data2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				Index += 2;
				pACKET_NETBIOS.RemoteSessionNumber = PacketData[Index++];
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				break;
			case 28:
				Index += 5;
				pACKET_NETBIOS.XmitCorrelator = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NETBIOS.RemoteSessionNumber = PacketData[Index++];
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				break;
			case 31:
				Index += 7;
				pACKET_NETBIOS.RemoteSessionNumber = PacketData[Index++];
				pACKET_NETBIOS.LocalSessionNumber = PacketData[Index++];
				break;
			}
			LItem.Protocol = "NETBIOS";
			LItem.Info = "Netbios";
		}
		catch
		{
			LItem.Info = "[ Malformed NETBIOS packet. Remaining bytes don't fit an NETBIOS packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}
}
