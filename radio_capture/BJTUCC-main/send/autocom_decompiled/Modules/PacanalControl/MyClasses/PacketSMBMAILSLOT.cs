using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketSMBMAILSLOT
{
	public struct PACKET_SMB_MAIL_SLOT
	{
		public ushort OpCode;

		public ushort Priority;

		public ushort Class;

		public string ClassStr;

		public ushort Size;

		public string MailSlotName;
	}

	public static string GetOpCodeString(ushort cmd)
	{
		string text = "";
		ushort num = cmd;
		if (num == 1)
		{
			return "Write Mail Slot";
		}
		return "Unknown";
	}

	public static string GetClassString(ushort cmd)
	{
		string text = "";
		return cmd switch
		{
			1 => "Reliable", 
			2 => "Unreliable & Broadcast", 
			_ => "Unknown", 
		};
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref ListViewItem LItem, bool IsRequest, string MailSlotName)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		string text = "";
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		byte b = 0;
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "SMB Mail Slot ( SMB Mail Slot Protocol )";
		num2 = Index;
		try
		{
			if (Index == PacketData.Length)
			{
				text = "Interim Reply";
				mNode2.Nodes.Add(text);
			}
			else
			{
				b = 0;
				if (IsRequest && MailSlotName != "")
				{
					if (MailSlotName.Substring(0, 6) == "BROWSE")
					{
						b = 1;
					}
					else if (MailSlotName.Substring(0, 6) == "LANMAN")
					{
						b = 2;
					}
					else if (MailSlotName.Substring(0, 3) == "NET")
					{
						b = 3;
					}
					else if (MailSlotName.Substring(0, 13) == "TEMP\\NETLOGON")
					{
						b = 4;
					}
					else if (MailSlotName.Substring(0, 4) == "MSSP")
					{
						b = 5;
					}
				}
				PACKET_SMB_MAIL_SLOT pACKET_SMB_MAIL_SLOT = default(PACKET_SMB_MAIL_SLOT);
				pACKET_SMB_MAIL_SLOT.OpCode = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "OpCode :" + Function.ReFormatString(pACKET_SMB_MAIL_SLOT.OpCode, GetOpCodeString(pACKET_SMB_MAIL_SLOT.OpCode));
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_SMB_MAIL_SLOT.Priority = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Priority :" + Function.ReFormatString(pACKET_SMB_MAIL_SLOT.Priority, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_SMB_MAIL_SLOT.Class = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Class :" + Function.ReFormatString(pACKET_SMB_MAIL_SLOT.Class, GetClassString(pACKET_SMB_MAIL_SLOT.Class));
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_SMB_MAIL_SLOT.Size = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Size :" + Function.ReFormatString(pACKET_SMB_MAIL_SLOT.Size, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				num = Index;
				pACKET_SMB_MAIL_SLOT.MailSlotName = "";
				while (PacketData[Index] != 0)
				{
					pACKET_SMB_MAIL_SLOT.MailSlotName += (char)PacketData[Index++];
				}
				text = "Mail Slot Name :" + pACKET_SMB_MAIL_SLOT.MailSlotName;
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, num, Index - num, BaseOrSub: false);
				mNode.Add(mNode2);
				Function.SetPosition(ref mNode2, num2, Index - num2, BaseOrSub: false);
			}
			mNode.Add(mNode2);
			Function.SetPosition(ref mNode2, num3, Index - num3, BaseOrSub: true);
			LItem.SubItems[6].Text = "SMB MAIL SLOT";
			LItem.SubItems[9].Text = "SMB Mail Slot Protocol";
			switch (b)
			{
			}
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed SMB Mail Slot packet. Remaining bytes don't fit an SMB Mail Slot packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.SubItems[9].Text = text;
			return false;
		}
		return true;
	}

	public static bool Parser(ref TreeNode mNode, ref TreeNode mNodeSubNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, bool IsRequest, string MailSlotName)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		string text = "";
		int num = 0;
		int num2 = 0;
		byte b = 0;
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "SMB Mail Slot ( SMB Mail Slot Protocol )";
		try
		{
			if (Index == PacketData.Length)
			{
				text = "Interim Reply";
				mNode2.Nodes.Add(text);
			}
			else
			{
				b = 0;
				if (IsRequest && MailSlotName != "")
				{
					if (MailSlotName.Substring(0, 6) == "BROWSE")
					{
						b = 1;
					}
					else if (MailSlotName.Substring(0, 6) == "LANMAN")
					{
						b = 2;
					}
					else if (MailSlotName.Substring(0, 3) == "NET")
					{
						b = 3;
					}
					else if (MailSlotName.Substring(0, 13) == "TEMP\\NETLOGON")
					{
						b = 4;
					}
					else if (MailSlotName.Substring(0, 4) == "MSSP")
					{
						b = 5;
					}
				}
				PACKET_SMB_MAIL_SLOT pACKET_SMB_MAIL_SLOT = default(PACKET_SMB_MAIL_SLOT);
				pACKET_SMB_MAIL_SLOT.OpCode = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "OpCode :" + Function.ReFormatString(pACKET_SMB_MAIL_SLOT.OpCode, GetOpCodeString(pACKET_SMB_MAIL_SLOT.OpCode));
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_SMB_MAIL_SLOT.Priority = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Priority :" + Function.ReFormatString(pACKET_SMB_MAIL_SLOT.Priority, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_SMB_MAIL_SLOT.Class = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Class :" + Function.ReFormatString(pACKET_SMB_MAIL_SLOT.Class, GetClassString(pACKET_SMB_MAIL_SLOT.Class));
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				pACKET_SMB_MAIL_SLOT.Size = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Size :" + Function.ReFormatString(pACKET_SMB_MAIL_SLOT.Size, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				num = Index;
				pACKET_SMB_MAIL_SLOT.MailSlotName = "";
				while (PacketData[Index] != 0)
				{
					pACKET_SMB_MAIL_SLOT.MailSlotName += (char)PacketData[Index++];
				}
				text = "Mail Slot Name :" + pACKET_SMB_MAIL_SLOT.MailSlotName;
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, num, Index - num, BaseOrSub: false);
			}
			mNode = mNode2;
			Function.SetPosition(ref mNode, num2, Index - num2, BaseOrSub: true);
			LItem.Protocol = "SMB MAIL SLOT";
			LItem.Info = "SMB Mail Slot protocol";
			switch (b)
			{
			}
		}
		catch (Exception ex)
		{
			mNode = mNode2;
			text = "[ Malformed SMB Mail Slot packet. Remaining bytes don't fit an SMB Mail Slot packet. Possibly due to bad decoding ]";
			mNode.Nodes.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Nodes.Add(text);
			LItem.Info = text;
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref int Index, ref ListViewItem LItem, bool IsRequest, string MailSlotName)
	{
		string text = "";
		byte b = 0;
		try
		{
			if (Index != PacketData.Length)
			{
				b = 0;
				if (IsRequest && MailSlotName != "")
				{
					if (MailSlotName.Substring(0, 6) == "BROWSE")
					{
						b = 1;
					}
					else if (MailSlotName.Substring(0, 6) == "LANMAN")
					{
						b = 2;
					}
					else if (MailSlotName.Substring(0, 3) == "NET")
					{
						b = 3;
					}
					else if (MailSlotName.Substring(0, 13) == "TEMP\\NETLOGON")
					{
						b = 4;
					}
					else if (MailSlotName.Substring(0, 4) == "MSSP")
					{
						b = 5;
					}
				}
				PACKET_SMB_MAIL_SLOT pACKET_SMB_MAIL_SLOT = default(PACKET_SMB_MAIL_SLOT);
				pACKET_SMB_MAIL_SLOT.OpCode = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_SMB_MAIL_SLOT.Priority = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_SMB_MAIL_SLOT.Class = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_SMB_MAIL_SLOT.Size = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				pACKET_SMB_MAIL_SLOT.MailSlotName = "";
				while (PacketData[Index] != 0)
				{
					pACKET_SMB_MAIL_SLOT.MailSlotName += (char)PacketData[Index++];
				}
			}
			LItem.SubItems[6].Text = "SMB MAIL SLOT";
			LItem.SubItems[9].Text = "SMB Mail Slot protocol";
			switch (b)
			{
			}
		}
		catch
		{
			text = "[ Malformed SMB Mail Slot packet. Remaining bytes don't fit an SMB Mail Slot packet. Possibly due to bad decoding ]";
			LItem.SubItems[9].Text = text;
			return false;
		}
		return true;
	}
}
