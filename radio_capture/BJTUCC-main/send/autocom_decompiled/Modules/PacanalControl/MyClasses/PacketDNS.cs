using System.Windows.Forms;

namespace MyClasses;

public class PacketDNS
{
	public struct QUESTION_ITEM
	{
		public string Name;

		public ushort Type;

		public string TypeStr;

		public ushort Class;

		public string ClassStr;
	}

	public struct ANSWER_ITEM
	{
		public string Name;

		public string NameStr;

		public ushort Type;

		public string TypeStr;

		public ushort Class;

		public string ClassStr;

		public uint TimeToLive;

		public ushort DataLength;

		public string IpAddress;
	}

	public struct AUTHORITY_ITEM
	{
		public string Name;

		public ushort Type;

		public string TypeStr;

		public ushort Class;

		public string ClassStr;

		public uint TimeToLive;

		public ushort DataLength;

		public string PrimaryNameServer;

		public string ResponsibleAuthoritysMailBox;

		public uint SerialNumber;

		public uint RefreshInterval;

		public uint RetryInterval;

		public uint ExpirationLimit;

		public uint MinimumTTL;
	}

	public struct ADDITIONAL_ITEM
	{
		public string Name;

		public ushort Type;

		public string TypeStr;

		public ushort Class;

		public string ClassStr;

		public uint TimeToLive;

		public string TimeToLiveStr;

		public ushort DataLength;

		public ushort Flags;

		public string FlagsStr;

		public uint Address;

		public string AddressStr;
	}

	public struct PACKET_DNS
	{
		public ushort TransactionId;

		public ushort Flags;

		public string FlagsStr;

		public ushort Questions;

		public ushort AnswerRRS;

		public ushort AuthorityRRS;

		public ushort AdditionalRRS;

		public QUESTION_ITEM[] QuestionObject;

		public ANSWER_ITEM[] AnswerObject;

		public AUTHORITY_ITEM[] AuthorityObject;

		public ADDITIONAL_ITEM[] AdditionalObject;
	}

	private PACKET_DNS PDns;

	private string[] FlagsArray = new string[8];

	private string[] Flags2Array = new string[2];

	private void InitStruct()
	{
		PDns.AdditionalRRS = 0;
		PDns.AnswerRRS = 0;
		PDns.AuthorityRRS = 0;
		PDns.Flags = 0;
		PDns.FlagsStr = "";
		PDns.Questions = 0;
		PDns.TransactionId = 0;
	}

	public string GetTypeString(ushort u)
	{
		string result = "";
		ushort num = u;
		if (num == 32)
		{
			result = "NB";
		}
		return result;
	}

	public string GetClassString(ushort u)
	{
		string result = "";
		ushort num = u;
		if (num == 1)
		{
			result = "inet";
		}
		return result;
	}

	private string GetOpcodeString(ushort b)
	{
		string text = "";
		string text2 = "";
		int num = b;
		num >>= 11;
		num &= 0xF;
		byte b2 = (byte)num;
		switch (num)
		{
		case 0:
			text = "Name query";
			break;
		case 5:
			text = "Registration";
			break;
		}
		text = text + "( " + num + " )";
		text2 = (((b2 & 8) != 8) ? (text2 + ".0") : (text2 + ".1"));
		text2 = (((b2 & 4) != 4) ? (text2 + "0") : (text2 + "1"));
		text2 = (((b2 & 2) != 2) ? (text2 + "0") : (text2 + "1"));
		text2 = (((b2 & 1) != 1) ? (text2 + " 0") : (text2 + " 1"));
		return text2 + "... .... .... = Opcode : " + text;
	}

	private string GetReplayCodeString(ushort b)
	{
		string text = "";
		string text2 = "";
		byte b2 = (byte)b;
		b2 &= 0xF;
		if (b2 == 0)
		{
			text = "No Error";
		}
		text = text + "( " + b2 + " )";
		text2 = (((b2 & 8) != 8) ? (text2 + "0") : (text2 + "1"));
		text2 = (((b2 & 4) != 4) ? (text2 + "0") : (text2 + "1"));
		text2 = (((b2 & 2) != 2) ? (text2 + "0") : (text2 + "1"));
		text2 = (((b2 & 1) != 1) ? (text2 + "0") : (text2 + "1"));
		return ".... .... .... " + text2 + " = Reply Code : " + text;
	}

	private void GetFlagsString(ushort u)
	{
		string text = "";
		text = (((u & 0x8000) != 32768) ? "0... .... .... .... = Response : Message is a query" : "1... .... .... .... = Response : Message is a response");
		FlagsArray[0] = text;
		text = GetOpcodeString(u);
		FlagsArray[1] = text;
		text = (((u & 0x400) != 1024) ? ".... .0.. .... .... = Authoritative : Server is not an authority for domain" : ".... .1.. .... .... = Authoritative : Server is an authority for domain");
		FlagsArray[2] = text;
		text = (((u & 0x200) != 512) ? ".... ..0. .... .... = Truncated : Message is not truncated" : ".... ..1. .... .... = Truncated : Message is truncated");
		FlagsArray[3] = text;
		text = (((u & 0x100) != 256) ? ".... ...0 .... .... = Recursion Desired : Don't do query recursively" : ".... ...1 .... .... = Recursion Desired : Do query recursively");
		FlagsArray[4] = text;
		text = (((u & 0x80) != 128) ? ".... .... 0... .... = Recursion Available : Server cann't do recursive queries" : ".... .... 1... .... = Recursion Available : Server can do recursive queries");
		FlagsArray[5] = text;
		text = (((u & 0x10) != 16) ? ".... .... ...0 .... = Broadcast : Packet is not broadcast" : ".... .... ...1 .... = Broadcast : Packet is broadcast");
		FlagsArray[6] = text;
		text = GetReplayCodeString(u);
		FlagsArray[7] = text;
	}

	private void GetFlags2String(ushort u)
	{
		string text = "";
		text = (((u & 0x80) != 128) ? "0... .... .... .... = Unique name" : "1... .... .... .... = Not unique name");
		Flags2Array[0] = text;
		int num = u;
		num >>= 13;
		num &= 3;
		switch ((byte)num)
		{
		case 0:
			text = ".00. .... .... .... = B-node";
			break;
		case 1:
			text = ".01. .... .... .... = ?";
			break;
		case 2:
			text = ".10. .... .... .... = ?";
			break;
		case 3:
			text = ".11. .... .... .... = ?";
			break;
		}
		Flags2Array[1] = text;
	}

	public TreeNode GetDNSNode(PACKET_DNS PDns)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Expected O, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected O, but got Unknown
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected O, but got Unknown
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_0906: Expected O, but got Unknown
		string text = "";
		int num = 0;
		TreeNode val = new TreeNode();
		val.Text = "DOMAIN NAME SERVICE";
		text = "Transaction Id :" + Function.ReFormatString(PDns.TransactionId, null);
		val.Nodes.Add(text);
		TreeNode val2 = new TreeNode();
		val2.Text = "Flags :" + Function.ReFormatString(PDns.Flags, null);
		GetFlagsString(PDns.Flags);
		for (num = 0; num < 8; num++)
		{
			val2.Nodes.Add(FlagsArray[num]);
		}
		val.Nodes.Add(val2);
		text = "Questions :" + Function.ReFormatString(PDns.Questions, null);
		val.Nodes.Add(text);
		text = "Answer RRS :" + Function.ReFormatString(PDns.AnswerRRS, null);
		val.Nodes.Add(text);
		text = "Authority RRS :" + Function.ReFormatString(PDns.AuthorityRRS, null);
		val.Nodes.Add(text);
		text = "Additional RRS :" + Function.ReFormatString(PDns.AdditionalRRS, null);
		val.Nodes.Add(text);
		if (PDns.Questions > 0)
		{
			val2 = new TreeNode();
			val2.Text = "QUERIES";
			for (num = 1; num <= PDns.Questions; num++)
			{
				TreeNode val3 = new TreeNode();
				val3.Text = "Query Record " + num;
				text = "Name :" + PDns.QuestionObject[num - 1].Name;
				val3.Nodes.Add(text);
				text = "Type : " + Function.ReFormatString(PDns.QuestionObject[num - 1].Type, PDns.QuestionObject[num - 1].TypeStr);
				val3.Nodes.Add(text);
				text = "Class : " + Function.ReFormatString(PDns.QuestionObject[num - 1].Class, PDns.QuestionObject[num - 1].ClassStr);
				val3.Nodes.Add(text);
				val2.Nodes.Add(val3);
			}
			val.Nodes.Add(val2);
		}
		if (PDns.AnswerRRS > 0)
		{
			val2 = new TreeNode();
			val2.Text = "ANSWER RECORDS";
			for (num = 1; num <= PDns.AnswerRRS; num++)
			{
				TreeNode val3 = new TreeNode();
				val3.Text = "Answer Record " + num;
				text = "Name :" + PDns.AnswerObject[num - 1].Name;
				val3.Nodes.Add(text);
				text = "Type : " + Function.ReFormatString(PDns.AnswerObject[num - 1].Type, PDns.AnswerObject[num - 1].TypeStr);
				val3.Nodes.Add(text);
				text = "Class : " + Function.ReFormatString(PDns.AnswerObject[num - 1].Class, PDns.AnswerObject[num - 1].ClassStr);
				val3.Nodes.Add(text);
				text = "Time to Live : " + Function.ReFormatString(PDns.AnswerObject[num - 1].TimeToLive, null);
				val3.Nodes.Add(text);
				text = "Data Length : " + Function.ReFormatString(PDns.AnswerObject[num - 1].DataLength, null);
				val3.Nodes.Add(text);
				text = "Ip Address :" + PDns.AnswerObject[num - 1].IpAddress;
				val3.Nodes.Add(text);
				val2.Nodes.Add(val3);
			}
			val.Nodes.Add(val2);
		}
		if (PDns.AuthorityRRS > 0)
		{
			val2 = new TreeNode();
			val2.Text = "AUTHORITY RECORDS";
			for (num = 1; num <= PDns.AuthorityRRS; num++)
			{
				TreeNode val3 = new TreeNode();
				val3.Text = "Authority Record " + num;
				text = "Name :" + PDns.AuthorityObject[num - 1].Name;
				val3.Nodes.Add(text);
				text = "Type : " + Function.ReFormatString(PDns.AuthorityObject[num - 1].Type, PDns.AuthorityObject[num - 1].TypeStr);
				val3.Nodes.Add(text);
				text = "Class : " + Function.ReFormatString(PDns.AuthorityObject[num - 1].Class, PDns.AuthorityObject[num - 1].ClassStr);
				val3.Nodes.Add(text);
				text = "Time to Live : " + Function.ReFormatString(PDns.AuthorityObject[num - 1].TimeToLive, null);
				val3.Nodes.Add(text);
				text = "Data Length : " + Function.ReFormatString(PDns.AuthorityObject[num - 1].DataLength, null);
				val3.Nodes.Add(text);
				text = "Primary Name Server : " + PDns.AuthorityObject[num - 1].PrimaryNameServer;
				val3.Nodes.Add(text);
				text = "Responsible Authority's Mailbox : " + PDns.AuthorityObject[num - 1].ResponsibleAuthoritysMailBox;
				val3.Nodes.Add(text);
				text = "Serial Number : " + Function.ReFormatString(PDns.AuthorityObject[num - 1].SerialNumber, null);
				val3.Nodes.Add(text);
				text = "Refresh Interval : " + Function.ReFormatString(PDns.AuthorityObject[num - 1].RefreshInterval, null);
				val3.Nodes.Add(text);
				text = "Retry Interval : " + Function.ReFormatString(PDns.AuthorityObject[num - 1].RetryInterval, null);
				val3.Nodes.Add(text);
				text = "Expiration Limit : " + Function.ReFormatString(PDns.AuthorityObject[num - 1].ExpirationLimit, null);
				val3.Nodes.Add(text);
				text = "Minimum TTL : " + Function.ReFormatString(PDns.AuthorityObject[num - 1].MinimumTTL, null);
				val3.Nodes.Add(text);
				val2.Nodes.Add(val3);
			}
			val.Nodes.Add(val2);
		}
		if (PDns.AdditionalRRS > 0)
		{
			val2 = new TreeNode();
			val2.Text = "Additional Records";
			for (num = 1; num <= PDns.AdditionalRRS; num++)
			{
				TreeNode val3 = new TreeNode();
				val3.Text = "Additional Record " + num;
				text = "Name :" + PDns.AdditionalObject[num - 1].Name;
				val3.Nodes.Add(text);
				text = "Type : " + Function.ReFormatString(PDns.AdditionalObject[num - 1].Type, PDns.AdditionalObject[num - 1].TypeStr);
				val3.Nodes.Add(text);
				text = "Class : " + Function.ReFormatString(PDns.AdditionalObject[num - 1].Class, PDns.AdditionalObject[num - 1].ClassStr);
				val3.Nodes.Add(text);
				text = "Time to Live : " + Function.ReFormatString(PDns.AdditionalObject[num - 1].TimeToLive, PDns.AdditionalObject[num - 1].TimeToLiveStr);
				val3.Nodes.Add(text);
				text = "Data Length : " + Function.ReFormatString(PDns.AdditionalObject[num - 1].DataLength, null);
				val3.Nodes.Add(text);
				val3 = new TreeNode();
				val3.Text = "Flags :" + Function.ReFormatString(PDns.AdditionalObject[num - 1].Flags, null);
				for (num = 0; num < 2; num++)
				{
					val3.Nodes.Add(Flags2Array[num]);
				}
				val2.Nodes.Add(val3);
				text = "Flags : " + Function.ReFormatString(PDns.AdditionalObject[num - 1].Class, PDns.AdditionalObject[num - 1].ClassStr);
				val3.Nodes.Add(text);
				text = "Address : " + Function.ReFormatString(PDns.AdditionalObject[num - 1].Address, PDns.AdditionalObject[num - 1].AddressStr);
				val3.Nodes.Add(text);
				val2.Nodes.Add(val3);
			}
			val.Nodes.Add(val2);
		}
		return val;
	}

	public PACKET_DNS GetDNSPart(byte[] PacketData, ref int Index)
	{
		int num = 0;
		PDns.TransactionId = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
		PDns.Flags = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
		PDns.Questions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
		PDns.AnswerRRS = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
		PDns.AuthorityRRS = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
		PDns.AdditionalRRS = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
		if (PDns.Questions > 0)
		{
			PDns.QuestionObject = new QUESTION_ITEM[PDns.Questions];
			for (num = 0; num < PDns.Questions; num++)
			{
				PDns.QuestionObject[num].Name = "";
				while (PacketData[Index] != 0)
				{
					PDns.QuestionObject[num].Name += (char)PacketData[Index++];
				}
				Index++;
				PDns.QuestionObject[num].Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				PDns.QuestionObject[num].TypeStr = GetTypeString(PDns.QuestionObject[num].Type);
				PDns.QuestionObject[num].Class = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				PDns.QuestionObject[num].ClassStr = GetClassString(PDns.QuestionObject[num].Class);
			}
		}
		if (PDns.AnswerRRS > 0)
		{
			PDns.AnswerObject = new ANSWER_ITEM[PDns.AnswerRRS];
			for (num = 0; num < PDns.AnswerRRS; num++)
			{
				PDns.AnswerObject[num].Name = "";
				while (PacketData[Index] != 0)
				{
					PDns.AnswerObject[num].Name += (char)PacketData[Index++];
				}
				Index++;
				PDns.AnswerObject[num].Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				PDns.AnswerObject[num].TypeStr = GetTypeString(PDns.AnswerObject[num].Type);
				PDns.AnswerObject[num].Class = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				PDns.AnswerObject[num].ClassStr = GetClassString(PDns.AnswerObject[num].Class);
				PDns.AnswerObject[num].TimeToLive = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
				PDns.AnswerObject[num].DataLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				PDns.AnswerObject[num].IpAddress = "";
				ref ANSWER_ITEM reference = ref PDns.AnswerObject[num];
				reference.IpAddress = reference.IpAddress + PacketData[Index++] + ".";
				ref ANSWER_ITEM reference2 = ref PDns.AnswerObject[num];
				reference2.IpAddress = reference2.IpAddress + PacketData[Index++] + ".";
				ref ANSWER_ITEM reference3 = ref PDns.AnswerObject[num];
				reference3.IpAddress = reference3.IpAddress + PacketData[Index++] + ".";
				PDns.AnswerObject[num].IpAddress += PacketData[Index++];
			}
		}
		if (PDns.AuthorityRRS > 0)
		{
			PDns.AuthorityObject = new AUTHORITY_ITEM[PDns.AuthorityRRS];
			for (num = 0; num < PDns.AuthorityRRS; num++)
			{
				PDns.AuthorityObject[num].Name = "";
				while (PacketData[Index] != 0)
				{
					PDns.AuthorityObject[num].Name += (char)PacketData[Index++];
				}
				Index++;
				PDns.AuthorityObject[num].Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				PDns.AuthorityObject[num].TypeStr = GetTypeString(PDns.AuthorityObject[num].Type);
				PDns.AuthorityObject[num].Class = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				PDns.AuthorityObject[num].ClassStr = GetClassString(PDns.AuthorityObject[num].Class);
				PDns.AuthorityObject[num].TimeToLive = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
				PDns.AuthorityObject[num].DataLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				PDns.AuthorityObject[num].PrimaryNameServer = "";
				while (PacketData[Index] != 0)
				{
					PDns.AuthorityObject[num].PrimaryNameServer += (char)PacketData[Index++];
				}
				PDns.AuthorityObject[num].ResponsibleAuthoritysMailBox = "";
				while (PacketData[Index] != 0)
				{
					PDns.AuthorityObject[num].ResponsibleAuthoritysMailBox += (char)PacketData[Index++];
				}
				PDns.AuthorityObject[num].SerialNumber = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
				PDns.AuthorityObject[num].RefreshInterval = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
				PDns.AuthorityObject[num].RetryInterval = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
				PDns.AuthorityObject[num].ExpirationLimit = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
				PDns.AuthorityObject[num].MinimumTTL = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			}
		}
		if (PDns.AdditionalRRS > 0)
		{
			PDns.AdditionalObject = new ADDITIONAL_ITEM[PDns.AdditionalRRS];
			for (num = 0; num < PDns.AdditionalRRS; num++)
			{
				PDns.AdditionalObject[num].Name = "";
				while (PacketData[Index] != 0)
				{
					PDns.AdditionalObject[num].Name += (char)PacketData[Index++];
				}
				Index++;
				PDns.AdditionalObject[num].Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				PDns.AdditionalObject[num].TypeStr = GetTypeString(PDns.AdditionalObject[num].Type);
				PDns.AdditionalObject[num].Class = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				PDns.AdditionalObject[num].ClassStr = GetClassString(PDns.AdditionalObject[num].Class);
				PDns.AdditionalObject[num].TimeToLive = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
				PDns.AdditionalObject[num].TimeToLiveStr = PDns.AdditionalObject[num].TimeToLive + " sn";
				PDns.AdditionalObject[num].Flags = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				PDns.AdditionalObject[num].FlagsStr = "";
				PDns.AdditionalObject[num].Address = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
				Index -= 4;
				PDns.AdditionalObject[num].AddressStr = "";
				ref ADDITIONAL_ITEM reference4 = ref PDns.AdditionalObject[num];
				reference4.AddressStr = reference4.AddressStr + (char)PacketData[Index++] + ".";
				ref ADDITIONAL_ITEM reference5 = ref PDns.AdditionalObject[num];
				reference5.AddressStr = reference5.AddressStr + (char)PacketData[Index++] + ".";
				ref ADDITIONAL_ITEM reference6 = ref PDns.AdditionalObject[num];
				reference6.AddressStr = reference6.AddressStr + (char)PacketData[Index++] + ".";
				PDns.AdditionalObject[num].AddressStr += (char)PacketData[Index++];
			}
		}
		return PDns;
	}
}
