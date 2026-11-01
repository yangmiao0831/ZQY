using System.Windows.Forms;

namespace MyClasses;

public class PacketMSWLOGON
{
	public struct PACKET_MSW_LOGON
	{
		public byte Command;

		public string CommandStr;

		public string ComputerName;

		public string MailSlotName;

		public string UnicodeComputerName;

		public uint NTVersion;

		public ushort LMNTToken;

		public string LMNTTokenStr;

		public ushort LM20Token;

		public string LM20TokenStr;
	}

	private PACKET_MSW_LOGON PMswLogon;

	public TreeNode GetMSWLOGONNode(PACKET_MSW_LOGON PMswLogon)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		string text = "";
		TreeNode val = new TreeNode();
		val.Text = "Microsoft Windows Browser Protocol";
		text = "Command               :" + Function.ReFormatString(PMswLogon.Command, PMswLogon.CommandStr);
		val.Nodes.Add(text);
		text = "Computer Name         :" + PMswLogon.ComputerName;
		val.Nodes.Add(text);
		text = "Mailslot Name         :" + PMswLogon.MailSlotName;
		val.Nodes.Add(text);
		text = "Unicode Computer Name :" + PMswLogon.UnicodeComputerName;
		val.Nodes.Add(text);
		text = "NT Version            :" + Function.ReFormatString(PMswLogon.NTVersion, null);
		val.Nodes.Add(text);
		text = "LM NT Token           :" + Function.ReFormatString(PMswLogon.LMNTToken, PMswLogon.LMNTTokenStr);
		val.Nodes.Add(text);
		text = "LM 20 Token           : " + Function.ReFormatString(PMswLogon.LM20Token, PMswLogon.LM20TokenStr);
		val.Nodes.Add(text);
		return val;
	}

	private string GetCommandString(byte cmd)
	{
		string result = "";
		byte b = cmd;
		if (b == 7)
		{
			result = "Query for PDC ( Primary Domain Controller )";
		}
		return result;
	}

	private string GetLMNTTOKENString(uint cmd)
	{
		string result = "";
		if (cmd == 65535)
		{
			result = "Windows NT Networking";
		}
		return result;
	}

	private string GetLM20TOKENString(uint cmd)
	{
		string result = "";
		if (cmd == 65535)
		{
			result = "Lan Man 2.0 Or Higer";
		}
		return result;
	}

	public PACKET_MSW_LOGON GetMSWLOGONPart(byte[] PacketData, ref int Index)
	{
		PMswLogon.Command = PacketData[Index++];
		while (PacketData[Index] == 0)
		{
			Index++;
		}
		PMswLogon.ComputerName = "";
		while (PacketData[Index] != 0)
		{
			PMswLogon.ComputerName += (char)PacketData[Index++];
		}
		Index++;
		PMswLogon.MailSlotName = "";
		while (PacketData[Index] != 0)
		{
			PMswLogon.MailSlotName += (char)PacketData[Index++];
		}
		Index++;
		PMswLogon.UnicodeComputerName = "";
		while (PacketData[Index] != 0 && PacketData[Index + 1] != 0)
		{
			PMswLogon.UnicodeComputerName += (char)PacketData[Index++];
		}
		Index++;
		Index += 3;
		PMswLogon.NTVersion = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
		PMswLogon.LMNTToken = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
		PMswLogon.LM20Token = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
		return PMswLogon;
	}
}
