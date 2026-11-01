using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketNBNS
{
	public struct QUESTION_ITEM
	{
		public string Name;

		public ushort Type;

		public ushort Class;
	}

	public struct QUESTIONS
	{
		public QUESTION_ITEM[] Items;
	}

	public struct ANSWER_ITEM
	{
		public string Name;

		public ushort Flags;
	}

	public struct ANSWERS
	{
		public string Name;

		public ushort Type;

		public ushort Class;

		public uint TimeToLive;

		public ushort DataLength;

		public ushort Flags;

		public string IpAddress;

		public byte NumberOfNames;

		public ANSWER_ITEM[] Items;

		public string UnitId;

		public byte Jumpers;

		public byte TestResult;

		public ushort VersionNumber;

		public ushort PeriodOfStatistics;

		public ushort CRCs;

		public ushort NumberOfAlignmentErrors;

		public ushort NumberOfCollisions;

		public ushort NumberOfSendAborts;

		public uint NumberOfGoodSends;

		public uint NumberOfReceives;

		public ushort NumberOfRetransmits;

		public ushort NumberOfNoResourceConditions;

		public ushort NumberOfCommandBlocks;

		public ushort NumberOfPendingSessions;

		public ushort MaxNumberOfPendingSessions;

		public ushort MaxTotalSessionPossible;

		public ushort SessionDataPacketSize;
	}

	public struct AUTHORITY_ITEM
	{
		public string Name;

		public ushort Type;

		public ushort Class;
	}

	public struct AUTHORITIES
	{
		public AUTHORITY_ITEM[] Items;
	}

	public struct ADDITIONAL_ITEM
	{
		public string Name;

		public ushort Type;

		public ushort Class;

		public uint TimeToLive;

		public ushort DataLength;

		public ushort Flags;

		public string Address;
	}

	public struct ADDITIONALS
	{
		public ADDITIONAL_ITEM[] Items;
	}

	public struct PACKET_NBNS
	{
		public ushort TransactionId;

		public ushort Flags;

		public ushort QuestionRRS;

		public ushort AnswerRRS;

		public ushort AuthorityRRS;

		public ushort AdditionalRRS;

		public QUESTIONS Questions;

		public ANSWERS Answers;

		public AUTHORITIES Authorities;

		public ADDITIONALS Additionals;
	}

	public static string GetTypeString(ushort u)
	{
		string text = "";
		return u switch
		{
			32 => "NB", 
			33 => "NBSTAT", 
			_ => "Unknown", 
		};
	}

	public static string GetClassString(ushort u)
	{
		string result = "";
		switch (u)
		{
		case 1:
			result = "inet";
			break;
		case 32769:
			result = "inet ( data flush )";
			break;
		case 2:
			result = "Csnet";
			break;
		case 3:
			result = "Chaos";
			break;
		case 4:
			result = "Hesiod";
			break;
		case 254:
			result = "None";
			break;
		case 255:
			result = "Any";
			break;
		}
		return result;
	}

	public static string GetErrorCodeString(byte b)
	{
		int num = 0;
		string[] array = new string[16];
		for (num = 0; num < 16; num++)
		{
			array[num] = "Unknown";
		}
		array[0] = "Not listening on called name";
		array[1] = "Not listening for called name";
		array[2] = "Called name not present";
		array[3] = "Called name present, but insufficient resources";
		array[15] = "Unspecified error";
		return array[b - 128];
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Expected O, but got Unknown
		//IL_1615: Unknown result type (might be due to invalid IL or missing references)
		//IL_161b: Expected O, but got Unknown
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected O, but got Unknown
		//IL_24e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ed: Expected O, but got Unknown
		//IL_099e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a4: Expected O, but got Unknown
		//IL_1870: Unknown result type (might be due to invalid IL or missing references)
		//IL_1876: Expected O, but got Unknown
		//IL_2742: Unknown result type (might be due to invalid IL or missing references)
		//IL_2748: Expected O, but got Unknown
		//IL_0dbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc2: Expected O, but got Unknown
		//IL_1c8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c94: Expected O, but got Unknown
		//IL_2b60: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b66: Expected O, but got Unknown
		string text = "";
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		byte NameNumber = 0;
		string[] array = new string[4];
		string[] array2 = new string[3];
		string[] array3 = new string[16];
		string[] array4 = new string[8];
		int num4 = 0;
		int num5 = 0;
		for (num3 = 0; num3 < 8; num3++)
		{
			array4[num3] = "Unknown";
		}
		for (num3 = 0; num3 < 16; num3++)
		{
			array3[num3] = "Unknown";
		}
		array[0] = "B-mode node";
		array[1] = "P-mode node";
		array[2] = "M-mode node";
		array[3] = "H-mode node";
		array2[0] = "B-mode node";
		array2[1] = "P-mode node";
		array2[2] = "M-mode node";
		array3[0] = "Name query";
		array3[5] = "Registration";
		array3[6] = "Release";
		array3[7] = "Wait for acknowledgment";
		array3[8] = "Refresh";
		array3[9] = "Refresh (alternate opcode)";
		array3[15] = "Multi-homed registration";
		array4[0] = "No error";
		array4[1] = "Request was invalidly formatted";
		array4[2] = "Server failure";
		array4[3] = "Requested name does not exist";
		array4[4] = "Request is not implemented";
		array4[5] = "Request was refused";
		array4[6] = "Name is owned by another node";
		array4[7] = "Name is in conflict";
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "NBNS ( Netbios Name Service )";
		num2 = Index;
		try
		{
			PACKET_NBNS pACKET_NBNS = default(PACKET_NBNS);
			pACKET_NBNS.TransactionId = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Transaction Id :" + Function.ReFormatString(pACKET_NBNS.TransactionId, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_NBNS.Flags = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			num4 = (ushort)((pACKET_NBNS.Flags & 0x7800) >> 11);
			TreeNode mNode3 = new TreeNode();
			mNode3.Text = "Flags :" + Function.ReFormatString(pACKET_NBNS.Flags, null);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: true);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Flags, 32768, "Message is a response", "Message is a query"));
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Flags, 30720, array3));
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Flags, 1024, "Authoritative : Server is an authority for domain", "Authoritative : Server is not an authority for domain"));
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Flags, 512, "Truncated : Message is truncated", "Truncated : Message is not truncated"));
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Flags, 256, "Recursion Desired : Do query recursively", "Recursion Desired : Don't do query recursively"));
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Flags, 128, "Recursion Available : Server can do recursive queries", "Recursion Available : Server cann't do recursive queries"));
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Flags, 16, "Broadcast : Packet is broadcast", "Broadcast : Packet is not broadcast"));
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			mNode3.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Flags, 15, array4));
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			mNode2.Nodes.Add(mNode3);
			pACKET_NBNS.QuestionRRS = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Question RRS :" + Function.ReFormatString(pACKET_NBNS.QuestionRRS, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_NBNS.AnswerRRS = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Answer RRS :" + Function.ReFormatString(pACKET_NBNS.AnswerRRS, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_NBNS.AuthorityRRS = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Authority RRS :" + Function.ReFormatString(pACKET_NBNS.AuthorityRRS, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_NBNS.AdditionalRRS = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Additional RRS :" + Function.ReFormatString(pACKET_NBNS.AdditionalRRS, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			if (pACKET_NBNS.QuestionRRS > 0)
			{
				mNode3 = new TreeNode();
				mNode3.Text = "Queries";
				Function.SetPosition(ref mNode3, Index, pACKET_NBNS.QuestionRRS * 38, BaseOrSub: true);
				pACKET_NBNS.Questions.Items = new QUESTION_ITEM[pACKET_NBNS.QuestionRRS];
				for (num3 = 0; num3 < pACKET_NBNS.QuestionRRS; num3++)
				{
					TreeNode mNode4 = new TreeNode();
					Function.SetPosition(ref mNode4, Index, 38, BaseOrSub: true);
					pACKET_NBNS.Questions.Items[num3].Name = Function.GetNetBiosName(PacketData, ref Index, ref NameNumber);
					text = "Name :" + pACKET_NBNS.Questions.Items[num3].Name;
					mNode4.Nodes.Add(text);
					Function.SetPosition(ref mNode4, Index - 34, 34, BaseOrSub: false);
					pACKET_NBNS.Questions.Items[num3].Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
					text = "Type : " + Function.ReFormatString(pACKET_NBNS.Questions.Items[num3].Type, GetTypeString(pACKET_NBNS.Questions.Items[num3].Type));
					mNode4.Nodes.Add(text);
					Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
					pACKET_NBNS.Questions.Items[num3].Class = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
					text = "Class : " + Function.ReFormatString(pACKET_NBNS.Questions.Items[num3].Class, GetClassString(pACKET_NBNS.Questions.Items[num3].Class));
					mNode4.Nodes.Add(text);
					Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
					mNode4.Text = pACKET_NBNS.Questions.Items[num3].Name + " , " + GetTypeString(pACKET_NBNS.Questions.Items[num3].Type) + " , " + GetClassString(pACKET_NBNS.Questions.Items[num3].Class);
					mNode3.Nodes.Add(mNode4);
				}
				mNode2.Nodes.Add(mNode3);
			}
			if (pACKET_NBNS.AnswerRRS > 0)
			{
				mNode3 = new TreeNode();
				mNode3.Text = "Answers";
				num2 = Index;
				pACKET_NBNS.Answers.Name = Function.GetNetBiosName(PacketData, ref Index, ref NameNumber);
				text = "Name :" + pACKET_NBNS.Answers.Name;
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 34, 34, BaseOrSub: false);
				pACKET_NBNS.Answers.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Type : " + Function.ReFormatString(pACKET_NBNS.Answers.Type, GetTypeString(pACKET_NBNS.Answers.Type));
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
				pACKET_NBNS.Answers.Class = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Class : " + Function.ReFormatString(pACKET_NBNS.Answers.Class, GetClassString(pACKET_NBNS.Answers.Class));
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
				pACKET_NBNS.Answers.TimeToLive = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Time to Live : " + Function.ReFormatString(pACKET_NBNS.Answers.TimeToLive, Function.GetTimeStr(pACKET_NBNS.Answers.TimeToLive));
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
				pACKET_NBNS.Answers.DataLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Data Length : " + Function.ReFormatString(pACKET_NBNS.Answers.DataLength, null);
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
				switch (pACKET_NBNS.Answers.Type)
				{
				case 32:
					for (num5 = pACKET_NBNS.Answers.DataLength; num5 > 0; num5 -= 4)
					{
						if (num4 == 7 && num5 < 2)
						{
							text = "Incomplete entry detected ...";
							LItem.Info = "Incomplete entry detected ...";
							mNode3.Nodes.Add(text);
							break;
						}
						pACKET_NBNS.Answers.Flags = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						TreeNode mNode4 = new TreeNode();
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: true);
						mNode4.Text = "Name Flags : " + Function.ReFormatString(pACKET_NBNS.Answers.Flags, null);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Flags, 32768, "Group name", "Unique name"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Flags, 24576, array));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Flags, 4096, "Name is being deregistered", "Name is not being deregistered"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Flags, 2048, "Name is in conflict", "Name is not in conflict"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Flags, 1024, "Name is active", "Name is not active"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Flags, 512, "Permanent node name", "Not permanent node name"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Flags, 15, array4));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode3.Nodes.Add(mNode4);
						num5 -= 2;
						if (num5 < 2)
						{
							text = "Incomplete entry detected ...";
							LItem.Info = "Incomplete entry detected ...";
							mNode3.Nodes.Add(text);
							break;
						}
						pACKET_NBNS.Answers.IpAddress = Function.GetIpAddress(PacketData, ref Index);
						text = "Ip Address : " + pACKET_NBNS.Answers.IpAddress;
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
					}
					break;
				case 33:
					num5 = pACKET_NBNS.Answers.DataLength;
					if (num5 < 1)
					{
						text = "Incomplete entry detected ...";
						LItem.Info = "Incomplete entry detected ...";
						mNode3.Nodes.Add(text);
						break;
					}
					pACKET_NBNS.Answers.NumberOfNames = PacketData[Index++];
					text = "Number of Names : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfNames, null);
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
					if (pACKET_NBNS.Answers.NumberOfNames <= 0)
					{
						break;
					}
					pACKET_NBNS.Answers.Items = new ANSWER_ITEM[pACKET_NBNS.Answers.NumberOfNames];
					for (num3 = 0; num3 < pACKET_NBNS.Answers.NumberOfNames; num3++)
					{
						if (num5 < 16)
						{
							text = "Incomplete entry detected ...";
							LItem.Info = "Incomplete entry detected ...";
							mNode3.Nodes.Add(text);
							break;
						}
						pACKET_NBNS.Answers.Items[num3].Name = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
						ref ANSWER_ITEM reference = ref pACKET_NBNS.Answers.Items[num3];
						reference.Name = reference.Name + " ( " + Const.GetNetBiosNames(NameNumber) + " )";
						text = "Name : " + pACKET_NBNS.Answers.Items[num3].Name;
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 16, 16, BaseOrSub: false);
						num5 -= 16;
						if (num5 < 2)
						{
							text = "Incomplete entry detected ...";
							LItem.Info = "Incomplete entry detected ...";
							mNode3.Nodes.Add(text);
							break;
						}
						pACKET_NBNS.Answers.Items[num3].Flags = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						TreeNode mNode4 = new TreeNode();
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: true);
						mNode4.Text = "Name Flags : " + Function.ReFormatString(pACKET_NBNS.Answers.Items[num3].Flags, null);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Items[num3].Flags, 32768, "Group name", "Unique name"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Items[num3].Flags, 24576, array));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Items[num3].Flags, 4096, "Name is being deregistered", "Name is not being deregistered"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Items[num3].Flags, 2048, "Name is in conflict", "Name is not in conflict"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Items[num3].Flags, 1024, "Name is active", "Name is not active"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Items[num3].Flags, 512, "Permanent node name", "Not permanent node name"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode3.Nodes.Add(mNode4);
						num5 -= 2;
						if (num5 < 6)
						{
							text = "Incomplete entry detected ...";
							LItem.Info = "Incomplete entry detected ...";
							mNode3.Nodes.Add(text);
							break;
						}
						pACKET_NBNS.Answers.UnitId = Function.GetMACAddress(PacketData, ref Index);
						text = "Unit Id : " + pACKET_NBNS.Answers.UnitId;
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 6, 6, BaseOrSub: false);
						pACKET_NBNS.Answers.Jumpers = PacketData[Index++];
						text = "Jumpers : " + Function.ReFormatString(pACKET_NBNS.Answers.Jumpers, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
						pACKET_NBNS.Answers.TestResult = PacketData[Index++];
						text = "Test Result : " + Function.ReFormatString(pACKET_NBNS.Answers.TestResult, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
						pACKET_NBNS.Answers.VersionNumber = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Version Number : " + Function.ReFormatString(pACKET_NBNS.Answers.VersionNumber, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.PeriodOfStatistics = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Period of statistics : " + Function.ReFormatString(pACKET_NBNS.Answers.PeriodOfStatistics, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.CRCs = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of CRCs : " + Function.ReFormatString(pACKET_NBNS.Answers.CRCs, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfAlignmentErrors = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of alignment errors : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfAlignmentErrors, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfCollisions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of collisions : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfCollisions, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfSendAborts = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of send aborts : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfSendAborts, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfGoodSends = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of good sends : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfGoodSends, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfReceives = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of good receives : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfReceives, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfRetransmits = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of retransmits : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfRetransmits, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfNoResourceConditions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of no resource conditions : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfNoResourceConditions, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfCommandBlocks = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of command blocks : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfCommandBlocks, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfPendingSessions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of pending sessions : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfPendingSessions, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.MaxNumberOfPendingSessions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Max number of pending sessions : " + Function.ReFormatString(pACKET_NBNS.Answers.MaxNumberOfPendingSessions, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.MaxTotalSessionPossible = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Max total sessions possible : " + Function.ReFormatString(pACKET_NBNS.Answers.MaxTotalSessionPossible, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.SessionDataPacketSize = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Session data packet size : " + Function.ReFormatString(pACKET_NBNS.Answers.SessionDataPacketSize, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
					}
					break;
				default:
					text = "Data";
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index, PacketData.Length - Index, BaseOrSub: false);
					break;
				}
				Function.SetPosition(ref mNode3, num, Index - num, BaseOrSub: true);
				mNode2.Nodes.Add(mNode3);
			}
			if (pACKET_NBNS.AuthorityRRS > 0)
			{
				mNode3 = new TreeNode();
				mNode3.Text = "Authority Records";
				num2 = Index;
				pACKET_NBNS.Answers.Name = Function.GetNetBiosName(PacketData, ref Index, ref NameNumber);
				text = "Name :" + pACKET_NBNS.Answers.Name;
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 34, 34, BaseOrSub: false);
				pACKET_NBNS.Answers.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Type : " + Function.ReFormatString(pACKET_NBNS.Answers.Type, GetTypeString(pACKET_NBNS.Answers.Type));
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
				pACKET_NBNS.Answers.Class = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Class : " + Function.ReFormatString(pACKET_NBNS.Answers.Class, GetClassString(pACKET_NBNS.Answers.Class));
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
				pACKET_NBNS.Answers.TimeToLive = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Time to Live : " + Function.ReFormatString(pACKET_NBNS.Answers.TimeToLive, Function.GetTimeStr(pACKET_NBNS.Answers.TimeToLive));
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
				pACKET_NBNS.Answers.DataLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Data Length : " + Function.ReFormatString(pACKET_NBNS.Answers.DataLength, null);
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
				switch (pACKET_NBNS.Answers.Type)
				{
				case 32:
					for (num5 = pACKET_NBNS.Answers.DataLength; num5 > 0; num5 -= 4)
					{
						if (num4 == 7 && num5 < 2)
						{
							text = "Incomplete entry detected ...";
							LItem.Info = "Incomplete entry detected ...";
							mNode3.Nodes.Add(text);
							break;
						}
						pACKET_NBNS.Answers.Flags = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						TreeNode mNode4 = new TreeNode();
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: true);
						mNode4.Text = "Name Flags : " + Function.ReFormatString(pACKET_NBNS.Answers.Flags, null);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Flags, 32768, "Group name", "Unique name"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Flags, 24576, array));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Flags, 4096, "Name is being deregistered", "Name is not being deregistered"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Flags, 2048, "Name is in conflict", "Name is not in conflict"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Flags, 1024, "Name is active", "Name is not active"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Flags, 512, "Permanent node name", "Not permanent node name"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Flags, 15, array4));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode3.Nodes.Add(mNode4);
						num5 -= 2;
						if (num5 < 2)
						{
							text = "Incomplete entry detected ...";
							LItem.Info = "Incomplete entry detected ...";
							mNode3.Nodes.Add(text);
							break;
						}
						pACKET_NBNS.Answers.IpAddress = Function.GetIpAddress(PacketData, ref Index);
						text = "Ip Address : " + pACKET_NBNS.Answers.IpAddress;
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
					}
					break;
				case 33:
					num5 = pACKET_NBNS.Answers.DataLength;
					if (num5 < 1)
					{
						text = "Incomplete entry detected ...";
						LItem.Info = "Incomplete entry detected ...";
						mNode3.Nodes.Add(text);
						break;
					}
					pACKET_NBNS.Answers.NumberOfNames = PacketData[Index++];
					text = "Number of Names : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfNames, null);
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
					if (pACKET_NBNS.Answers.NumberOfNames <= 0)
					{
						break;
					}
					pACKET_NBNS.Answers.Items = new ANSWER_ITEM[pACKET_NBNS.Answers.NumberOfNames];
					for (num3 = 0; num3 < pACKET_NBNS.Answers.NumberOfNames; num3++)
					{
						if (num5 < 16)
						{
							text = "Incomplete entry detected ...";
							LItem.Info = "Incomplete entry detected ...";
							mNode3.Nodes.Add(text);
							break;
						}
						pACKET_NBNS.Answers.Items[num3].Name = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
						ref ANSWER_ITEM reference2 = ref pACKET_NBNS.Answers.Items[num3];
						reference2.Name = reference2.Name + " ( " + Const.GetNetBiosNames(NameNumber) + " )";
						text = "Name : " + pACKET_NBNS.Answers.Items[num3].Name;
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 16, 16, BaseOrSub: false);
						num5 -= 16;
						if (num5 < 2)
						{
							text = "Incomplete entry detected ...";
							LItem.Info = "Incomplete entry detected ...";
							mNode3.Nodes.Add(text);
							break;
						}
						pACKET_NBNS.Answers.Items[num3].Flags = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						TreeNode mNode4 = new TreeNode();
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: true);
						mNode4.Text = "Name Flags : " + Function.ReFormatString(pACKET_NBNS.Answers.Items[num3].Flags, null);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Items[num3].Flags, 32768, "Group name", "Unique name"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Items[num3].Flags, 24576, array));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Items[num3].Flags, 4096, "Name is being deregistered", "Name is not being deregistered"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Items[num3].Flags, 2048, "Name is in conflict", "Name is not in conflict"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Items[num3].Flags, 1024, "Name is active", "Name is not active"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Items[num3].Flags, 512, "Permanent node name", "Not permanent node name"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode3.Nodes.Add(mNode4);
						num5 -= 2;
						if (num5 < 6)
						{
							text = "Incomplete entry detected ...";
							LItem.Info = "Incomplete entry detected ...";
							mNode3.Nodes.Add(text);
							break;
						}
						pACKET_NBNS.Answers.UnitId = Function.GetMACAddress(PacketData, ref Index);
						text = "Unit Id : " + pACKET_NBNS.Answers.UnitId;
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 6, 6, BaseOrSub: false);
						pACKET_NBNS.Answers.Jumpers = PacketData[Index++];
						text = "Jumpers : " + Function.ReFormatString(pACKET_NBNS.Answers.Jumpers, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
						pACKET_NBNS.Answers.TestResult = PacketData[Index++];
						text = "Test Result : " + Function.ReFormatString(pACKET_NBNS.Answers.TestResult, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
						pACKET_NBNS.Answers.VersionNumber = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Version Number : " + Function.ReFormatString(pACKET_NBNS.Answers.VersionNumber, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.PeriodOfStatistics = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Period of statistics : " + Function.ReFormatString(pACKET_NBNS.Answers.PeriodOfStatistics, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.CRCs = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of CRCs : " + Function.ReFormatString(pACKET_NBNS.Answers.CRCs, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfAlignmentErrors = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of alignment errors : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfAlignmentErrors, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfCollisions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of collisions : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfCollisions, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfSendAborts = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of send aborts : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfSendAborts, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfGoodSends = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of good sends : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfGoodSends, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfReceives = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of good receives : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfReceives, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfRetransmits = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of retransmits : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfRetransmits, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfNoResourceConditions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of no resource conditions : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfNoResourceConditions, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfCommandBlocks = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of command blocks : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfCommandBlocks, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfPendingSessions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of pending sessions : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfPendingSessions, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.MaxNumberOfPendingSessions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Max number of pending sessions : " + Function.ReFormatString(pACKET_NBNS.Answers.MaxNumberOfPendingSessions, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.MaxTotalSessionPossible = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Max total sessions possible : " + Function.ReFormatString(pACKET_NBNS.Answers.MaxTotalSessionPossible, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.SessionDataPacketSize = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Session data packet size : " + Function.ReFormatString(pACKET_NBNS.Answers.SessionDataPacketSize, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
					}
					break;
				default:
					text = "Data";
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index, PacketData.Length - Index, BaseOrSub: false);
					break;
				}
				Function.SetPosition(ref mNode3, num, Index - num, BaseOrSub: true);
				mNode2.Nodes.Add(mNode3);
			}
			if (pACKET_NBNS.AdditionalRRS > 0)
			{
				mNode3 = new TreeNode();
				mNode3.Text = "Additional Records";
				num2 = Index;
				pACKET_NBNS.Answers.Name = Function.GetNetBiosName(PacketData, ref Index, ref NameNumber);
				text = "Name :" + pACKET_NBNS.Answers.Name;
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 34, 34, BaseOrSub: false);
				pACKET_NBNS.Answers.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Type : " + Function.ReFormatString(pACKET_NBNS.Answers.Type, GetTypeString(pACKET_NBNS.Answers.Type));
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
				pACKET_NBNS.Answers.Class = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Class : " + Function.ReFormatString(pACKET_NBNS.Answers.Class, GetClassString(pACKET_NBNS.Answers.Class));
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
				pACKET_NBNS.Answers.TimeToLive = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Time to Live : " + Function.ReFormatString(pACKET_NBNS.Answers.TimeToLive, Function.GetTimeStr(pACKET_NBNS.Answers.TimeToLive));
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
				pACKET_NBNS.Answers.DataLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Data Length : " + Function.ReFormatString(pACKET_NBNS.Answers.DataLength, null);
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
				switch (pACKET_NBNS.Answers.Type)
				{
				case 32:
					for (num5 = pACKET_NBNS.Answers.DataLength; num5 > 0; num5 -= 4)
					{
						if (num4 == 7 && num5 < 2)
						{
							text = "Incomplete entry detected ...";
							LItem.Info = "Incomplete entry detected ...";
							mNode3.Nodes.Add(text);
							break;
						}
						pACKET_NBNS.Answers.Flags = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						TreeNode mNode4 = new TreeNode();
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: true);
						mNode4.Text = "Name Flags : " + Function.ReFormatString(pACKET_NBNS.Answers.Flags, null);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Flags, 32768, "Group name", "Unique name"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Flags, 24576, array));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Flags, 4096, "Name is being deregistered", "Name is not being deregistered"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Flags, 2048, "Name is in conflict", "Name is not in conflict"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Flags, 1024, "Name is active", "Name is not active"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Flags, 512, "Permanent node name", "Not permanent node name"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Flags, 15, array4));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode3.Nodes.Add(mNode4);
						num5 -= 2;
						if (num5 < 2)
						{
							text = "Incomplete entry detected ...";
							LItem.Info = "Incomplete entry detected ...";
							mNode3.Nodes.Add(text);
							break;
						}
						pACKET_NBNS.Answers.IpAddress = Function.GetIpAddress(PacketData, ref Index);
						text = "Ip Address : " + pACKET_NBNS.Answers.IpAddress;
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
					}
					break;
				case 33:
					num5 = pACKET_NBNS.Answers.DataLength;
					if (num5 < 1)
					{
						text = "Incomplete entry detected ...";
						LItem.Info = "Incomplete entry detected ...";
						mNode3.Nodes.Add(text);
						break;
					}
					pACKET_NBNS.Answers.NumberOfNames = PacketData[Index++];
					text = "Number of Names : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfNames, null);
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
					if (pACKET_NBNS.Answers.NumberOfNames <= 0)
					{
						break;
					}
					pACKET_NBNS.Answers.Items = new ANSWER_ITEM[pACKET_NBNS.Answers.NumberOfNames];
					for (num3 = 0; num3 < pACKET_NBNS.Answers.NumberOfNames; num3++)
					{
						if (num5 < 16)
						{
							text = "Incomplete entry detected ...";
							LItem.Info = "Incomplete entry detected ...";
							mNode3.Nodes.Add(text);
							break;
						}
						pACKET_NBNS.Answers.Items[num3].Name = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
						ref ANSWER_ITEM reference3 = ref pACKET_NBNS.Answers.Items[num3];
						reference3.Name = reference3.Name + " ( " + Const.GetNetBiosNames(NameNumber) + " )";
						text = "Name : " + pACKET_NBNS.Answers.Items[num3].Name;
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 16, 16, BaseOrSub: false);
						num5 -= 16;
						if (num5 < 2)
						{
							text = "Incomplete entry detected ...";
							LItem.Info = "Incomplete entry detected ...";
							mNode3.Nodes.Add(text);
							break;
						}
						pACKET_NBNS.Answers.Items[num3].Flags = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						TreeNode mNode4 = new TreeNode();
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: true);
						mNode4.Text = "Name Flags : " + Function.ReFormatString(pACKET_NBNS.Answers.Items[num3].Flags, null);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Items[num3].Flags, 32768, "Group name", "Unique name"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Items[num3].Flags, 24576, array));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Items[num3].Flags, 4096, "Name is being deregistered", "Name is not being deregistered"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Items[num3].Flags, 2048, "Name is in conflict", "Name is not in conflict"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Items[num3].Flags, 1024, "Name is active", "Name is not active"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode4.Nodes.Add(Function.DecodeBitField(pACKET_NBNS.Answers.Items[num3].Flags, 512, "Permanent node name", "Not permanent node name"));
						Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
						mNode3.Nodes.Add(mNode4);
						num5 -= 2;
						if (num5 < 6)
						{
							text = "Incomplete entry detected ...";
							LItem.Info = "Incomplete entry detected ...";
							mNode3.Nodes.Add(text);
							break;
						}
						pACKET_NBNS.Answers.UnitId = Function.GetMACAddress(PacketData, ref Index);
						text = "Unit Id : " + pACKET_NBNS.Answers.UnitId;
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 6, 6, BaseOrSub: false);
						pACKET_NBNS.Answers.Jumpers = PacketData[Index++];
						text = "Jumpers : " + Function.ReFormatString(pACKET_NBNS.Answers.Jumpers, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
						pACKET_NBNS.Answers.TestResult = PacketData[Index++];
						text = "Test Result : " + Function.ReFormatString(pACKET_NBNS.Answers.TestResult, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
						pACKET_NBNS.Answers.VersionNumber = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Version Number : " + Function.ReFormatString(pACKET_NBNS.Answers.VersionNumber, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.PeriodOfStatistics = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Period of statistics : " + Function.ReFormatString(pACKET_NBNS.Answers.PeriodOfStatistics, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.CRCs = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of CRCs : " + Function.ReFormatString(pACKET_NBNS.Answers.CRCs, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfAlignmentErrors = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of alignment errors : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfAlignmentErrors, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfCollisions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of collisions : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfCollisions, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfSendAborts = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of send aborts : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfSendAborts, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfGoodSends = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of good sends : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfGoodSends, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfReceives = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of good receives : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfReceives, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfRetransmits = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of retransmits : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfRetransmits, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfNoResourceConditions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of no resource conditions : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfNoResourceConditions, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfCommandBlocks = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of command blocks : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfCommandBlocks, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.NumberOfPendingSessions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Number of pending sessions : " + Function.ReFormatString(pACKET_NBNS.Answers.NumberOfPendingSessions, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.MaxNumberOfPendingSessions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Max number of pending sessions : " + Function.ReFormatString(pACKET_NBNS.Answers.MaxNumberOfPendingSessions, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.MaxTotalSessionPossible = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Max total sessions possible : " + Function.ReFormatString(pACKET_NBNS.Answers.MaxTotalSessionPossible, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
						pACKET_NBNS.Answers.SessionDataPacketSize = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Session data packet size : " + Function.ReFormatString(pACKET_NBNS.Answers.SessionDataPacketSize, null);
						mNode3.Nodes.Add(text);
						Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
					}
					break;
				default:
					text = "Data";
					mNode3.Nodes.Add(text);
					Function.SetPosition(ref mNode3, Index, PacketData.Length - Index, BaseOrSub: false);
					break;
				}
				Function.SetPosition(ref mNode3, num, Index - num, BaseOrSub: true);
				mNode2.Nodes.Add(mNode3);
			}
			Function.SetPosition(ref mNode2, num2, Index - num2, BaseOrSub: true);
			LItem.Protocol = "NBNS";
			LItem.Info = "Netbios name service";
			mNode.Add(mNode2);
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed NBNS packet. Remaining bytes don't fit an NBNS packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.Info = "[ Malformed NBNS packet. Remaining bytes don't fit an NBNS packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		int num = 0;
		byte NameNumber = 0;
		int num2 = 0;
		int num3 = 0;
		try
		{
			PACKET_NBNS pACKET_NBNS = default(PACKET_NBNS);
			pACKET_NBNS.TransactionId = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_NBNS.Flags = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			num2 = (ushort)((pACKET_NBNS.Flags & 0x7800) >> 11);
			pACKET_NBNS.QuestionRRS = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_NBNS.AnswerRRS = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_NBNS.AuthorityRRS = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_NBNS.AdditionalRRS = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			if (pACKET_NBNS.QuestionRRS > 0)
			{
				pACKET_NBNS.Questions.Items = new QUESTION_ITEM[pACKET_NBNS.QuestionRRS];
				for (num = 0; num < pACKET_NBNS.QuestionRRS; num++)
				{
					pACKET_NBNS.Questions.Items[num].Name = Function.GetNetBiosName(PacketData, ref Index, ref NameNumber);
					pACKET_NBNS.Questions.Items[num].Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
					pACKET_NBNS.Questions.Items[num].Class = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				}
			}
			if (pACKET_NBNS.AnswerRRS > 0)
			{
				pACKET_NBNS.Answers.Name = Function.GetNetBiosName(PacketData, ref Index, ref NameNumber);
				pACKET_NBNS.Answers.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NBNS.Answers.Class = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NBNS.Answers.TimeToLive = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NBNS.Answers.DataLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				switch (pACKET_NBNS.Answers.Type)
				{
				case 32:
					for (num3 = pACKET_NBNS.Answers.DataLength; num3 > 0; num3 -= 4)
					{
						if (num2 == 7 && num3 < 2)
						{
							LItem.Info = "Incomplete entry detected ...";
							break;
						}
						pACKET_NBNS.Answers.Flags = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						num3 -= 2;
						if (num3 < 2)
						{
							LItem.Info = "Incomplete entry detected ...";
							break;
						}
						pACKET_NBNS.Answers.IpAddress = Function.GetIpAddress(PacketData, ref Index);
					}
					break;
				case 33:
					num3 = pACKET_NBNS.Answers.DataLength;
					if (num3 < 1)
					{
						LItem.Info = "Incomplete entry detected ...";
						break;
					}
					pACKET_NBNS.Answers.NumberOfNames = PacketData[Index++];
					if (pACKET_NBNS.Answers.NumberOfNames <= 0)
					{
						break;
					}
					pACKET_NBNS.Answers.Items = new ANSWER_ITEM[pACKET_NBNS.Answers.NumberOfNames];
					for (num = 0; num < pACKET_NBNS.Answers.NumberOfNames; num++)
					{
						if (num3 < 16)
						{
							LItem.Info = "Incomplete entry detected ...";
							break;
						}
						pACKET_NBNS.Answers.Items[num].Name = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
						num3 -= 16;
						if (num3 < 2)
						{
							LItem.Info = "Incomplete entry detected ...";
							break;
						}
						pACKET_NBNS.Answers.Items[num].Flags = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						num3 -= 2;
						if (num3 < 6)
						{
							LItem.Info = "Incomplete entry detected ...";
							break;
						}
						pACKET_NBNS.Answers.UnitId = Function.GetMACAddress(PacketData, ref Index);
						pACKET_NBNS.Answers.Jumpers = PacketData[Index++];
						pACKET_NBNS.Answers.TestResult = PacketData[Index++];
						pACKET_NBNS.Answers.VersionNumber = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.PeriodOfStatistics = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.CRCs = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfAlignmentErrors = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfCollisions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfSendAborts = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfGoodSends = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfReceives = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfRetransmits = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfNoResourceConditions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfCommandBlocks = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfPendingSessions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.MaxNumberOfPendingSessions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.MaxTotalSessionPossible = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.SessionDataPacketSize = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
					}
					break;
				}
			}
			if (pACKET_NBNS.AuthorityRRS > 0)
			{
				pACKET_NBNS.Answers.Name = Function.GetNetBiosName(PacketData, ref Index, ref NameNumber);
				pACKET_NBNS.Answers.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NBNS.Answers.Class = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NBNS.Answers.TimeToLive = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NBNS.Answers.DataLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				switch (pACKET_NBNS.Answers.Type)
				{
				case 32:
					for (num3 = pACKET_NBNS.Answers.DataLength; num3 > 0; num3 -= 4)
					{
						if (num2 == 7 && num3 < 2)
						{
							LItem.Info = "Incomplete entry detected ...";
							break;
						}
						pACKET_NBNS.Answers.Flags = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						num3 -= 2;
						if (num3 < 2)
						{
							LItem.Info = "Incomplete entry detected ...";
							break;
						}
						pACKET_NBNS.Answers.IpAddress = Function.GetIpAddress(PacketData, ref Index);
					}
					break;
				case 33:
					num3 = pACKET_NBNS.Answers.DataLength;
					if (num3 < 1)
					{
						LItem.Info = "Incomplete entry detected ...";
						break;
					}
					pACKET_NBNS.Answers.NumberOfNames = PacketData[Index++];
					if (pACKET_NBNS.Answers.NumberOfNames <= 0)
					{
						break;
					}
					pACKET_NBNS.Answers.Items = new ANSWER_ITEM[pACKET_NBNS.Answers.NumberOfNames];
					for (num = 0; num < pACKET_NBNS.Answers.NumberOfNames; num++)
					{
						if (num3 < 16)
						{
							LItem.Info = "Incomplete entry detected ...";
							break;
						}
						pACKET_NBNS.Answers.Items[num].Name = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
						num3 -= 16;
						if (num3 < 2)
						{
							LItem.Info = "Incomplete entry detected ...";
							break;
						}
						pACKET_NBNS.Answers.Items[num].Flags = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						num3 -= 2;
						if (num3 < 6)
						{
							LItem.Info = "Incomplete entry detected ...";
							break;
						}
						pACKET_NBNS.Answers.UnitId = Function.GetMACAddress(PacketData, ref Index);
						pACKET_NBNS.Answers.Jumpers = PacketData[Index++];
						pACKET_NBNS.Answers.TestResult = PacketData[Index++];
						pACKET_NBNS.Answers.VersionNumber = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.PeriodOfStatistics = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.CRCs = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfAlignmentErrors = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfCollisions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfSendAborts = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfGoodSends = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfReceives = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfRetransmits = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfNoResourceConditions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfCommandBlocks = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfPendingSessions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.MaxNumberOfPendingSessions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.MaxTotalSessionPossible = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.SessionDataPacketSize = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
					}
					break;
				}
			}
			if (pACKET_NBNS.AdditionalRRS > 0)
			{
				pACKET_NBNS.Answers.Name = Function.GetNetBiosName(PacketData, ref Index, ref NameNumber);
				pACKET_NBNS.Answers.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NBNS.Answers.Class = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NBNS.Answers.TimeToLive = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_NBNS.Answers.DataLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				switch (pACKET_NBNS.Answers.Type)
				{
				case 32:
					for (num3 = pACKET_NBNS.Answers.DataLength; num3 > 0; num3 -= 4)
					{
						if (num2 == 7 && num3 < 2)
						{
							LItem.Info = "Incomplete entry detected ...";
							break;
						}
						pACKET_NBNS.Answers.Flags = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						num3 -= 2;
						if (num3 < 2)
						{
							LItem.Info = "Incomplete entry detected ...";
							break;
						}
						pACKET_NBNS.Answers.IpAddress = Function.GetIpAddress(PacketData, ref Index);
					}
					break;
				case 33:
					num3 = pACKET_NBNS.Answers.DataLength;
					if (num3 < 1)
					{
						LItem.Info = "Incomplete entry detected ...";
						break;
					}
					pACKET_NBNS.Answers.NumberOfNames = PacketData[Index++];
					if (pACKET_NBNS.Answers.NumberOfNames <= 0)
					{
						break;
					}
					pACKET_NBNS.Answers.Items = new ANSWER_ITEM[pACKET_NBNS.Answers.NumberOfNames];
					for (num = 0; num < pACKET_NBNS.Answers.NumberOfNames; num++)
					{
						if (num3 < 16)
						{
							LItem.Info = "Incomplete entry detected ...";
							break;
						}
						pACKET_NBNS.Answers.Items[num].Name = Function.GetNetBiosNameSerial(PacketData, ref Index, ref NameNumber);
						num3 -= 16;
						if (num3 < 2)
						{
							LItem.Info = "Incomplete entry detected ...";
							break;
						}
						pACKET_NBNS.Answers.Items[num].Flags = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						num3 -= 2;
						if (num3 < 6)
						{
							LItem.Info = "Incomplete entry detected ...";
							break;
						}
						pACKET_NBNS.Answers.UnitId = Function.GetMACAddress(PacketData, ref Index);
						pACKET_NBNS.Answers.Jumpers = PacketData[Index++];
						pACKET_NBNS.Answers.TestResult = PacketData[Index++];
						pACKET_NBNS.Answers.VersionNumber = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.PeriodOfStatistics = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.CRCs = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfAlignmentErrors = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfCollisions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfSendAborts = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfGoodSends = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfReceives = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfRetransmits = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfNoResourceConditions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfCommandBlocks = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.NumberOfPendingSessions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.MaxNumberOfPendingSessions = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.MaxTotalSessionPossible = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						pACKET_NBNS.Answers.SessionDataPacketSize = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
					}
					break;
				}
			}
			LItem.Protocol = "NBNS";
			LItem.Info = "Netbios name service";
		}
		catch
		{
			LItem.Info = "[ Malformed NBNS packet. Remaining bytes don't fit an NBNS packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}
}
