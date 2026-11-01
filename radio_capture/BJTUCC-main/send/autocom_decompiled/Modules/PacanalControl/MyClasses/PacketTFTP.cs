using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketTFTP
{
	public struct PACKET_TFTP
	{
		public ushort OpCode;

		public ushort Bytes;

		public ushort ErrorNo;

		public ushort BlockNo;

		public string ErrorMessage;

		public string SourceFile;

		public string DestinationFile;

		public string TransferType;
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		string text = "";
		int num = 0;
		string text2 = "";
		string text3 = "";
		string text4 = "";
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "TFTP ( Trivial File Transfer Protocol )";
		num = Index;
		try
		{
			PACKET_TFTP pACKET_TFTP = default(PACKET_TFTP);
			pACKET_TFTP.OpCode = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Operation Code : " + Function.ReFormatString(pACKET_TFTP.OpCode, Const.GetTftpOpCodeString(pACKET_TFTP.OpCode));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			text2 = Const.GetTftpOpCodeString(pACKET_TFTP.OpCode);
			switch (pACKET_TFTP.OpCode)
			{
			case 1:
				pACKET_TFTP.SourceFile = Function.FindString(PacketData, ref Index);
				text = "Source File Name : " + pACKET_TFTP.SourceFile;
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - pACKET_TFTP.SourceFile.Length - 1, pACKET_TFTP.SourceFile.Length + 1, BaseOrSub: false);
				text2 = text2 + ", Source File Name : " + pACKET_TFTP.SourceFile;
				pACKET_TFTP.TransferType = Function.FindString(PacketData, ref Index);
				text = "Transfer Type : " + pACKET_TFTP.TransferType;
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - pACKET_TFTP.TransferType.Length - 1, pACKET_TFTP.TransferType.Length + 1, BaseOrSub: false);
				text2 = text2 + ", Transfer Type : " + pACKET_TFTP.TransferType;
				while (Index < PacketData.Length)
				{
					text3 = Function.FindString(PacketData, ref Index);
					text4 = Function.FindString(PacketData, ref Index);
					text = "Option : " + text3 + " = " + text4;
					mNode2.Nodes.Add(text);
					Function.SetPosition(ref mNode2, Index - text3.Length - 1 - text4.Length - 1, text3.Length + 1 + text4.Length + 1, BaseOrSub: false);
					text2 = text2 + ", " + text;
				}
				break;
			case 2:
				pACKET_TFTP.DestinationFile = Function.FindString(PacketData, ref Index);
				text = "Destination File Name : " + pACKET_TFTP.DestinationFile;
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - pACKET_TFTP.DestinationFile.Length - 1, pACKET_TFTP.DestinationFile.Length + 1, BaseOrSub: false);
				text2 = text2 + ", Destination File Name : " + pACKET_TFTP.DestinationFile;
				pACKET_TFTP.TransferType = Function.FindString(PacketData, ref Index);
				text = "Transfer Type : " + pACKET_TFTP.TransferType;
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - pACKET_TFTP.TransferType.Length - 1, pACKET_TFTP.TransferType.Length + 1, BaseOrSub: false);
				text2 = text2 + ", Transfer Type : " + pACKET_TFTP.TransferType;
				while (Index < PacketData.Length)
				{
					text3 = Function.FindString(PacketData, ref Index);
					text4 = Function.FindString(PacketData, ref Index);
					text = "Option : " + text3 + " = " + text4;
					mNode2.Nodes.Add(text);
					Function.SetPosition(ref mNode2, Index - text3.Length - 1 - text4.Length - 1, text3.Length + 1 + text4.Length + 1, BaseOrSub: false);
					text2 = text2 + ", " + text;
				}
				break;
			case 3:
				pACKET_TFTP.BlockNo = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Block No : " + Function.ReFormatString(pACKET_TFTP.BlockNo, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				text2 = text2 + ", Block " + pACKET_TFTP.BlockNo;
				pACKET_TFTP.Bytes = (ushort)(PacketData.Length - Index);
				text = "Data : " + Function.ReFormatString(pACKET_TFTP.Bytes, null) + " bytes(s)";
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index, pACKET_TFTP.Bytes, BaseOrSub: false);
				if (pACKET_TFTP.Bytes < 512)
				{
					text2 += " ( Last )";
				}
				break;
			case 4:
				pACKET_TFTP.BlockNo = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Block No : " + Function.ReFormatString(pACKET_TFTP.BlockNo, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				text2 = text2 + ", Block " + pACKET_TFTP.BlockNo;
				break;
			case 5:
				pACKET_TFTP.ErrorNo = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Error No : " + Function.ReFormatString(pACKET_TFTP.ErrorNo, null);
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				text2 = text2 + ", Error No : " + pACKET_TFTP.ErrorNo;
				pACKET_TFTP.ErrorMessage = Function.FindString(PacketData, ref Index);
				text = "Error Message : " + pACKET_TFTP.ErrorMessage;
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - pACKET_TFTP.ErrorMessage.Length - 1, pACKET_TFTP.ErrorMessage.Length + 1, BaseOrSub: false);
				text2 = text2 + ", ErrorMessage : " + pACKET_TFTP.ErrorMessage;
				break;
			case 6:
				while (Index < PacketData.Length)
				{
					text3 = Function.FindString(PacketData, ref Index);
					text4 = Function.FindString(PacketData, ref Index);
					text = "Option : " + text3 + " = " + text4;
					mNode2.Nodes.Add(text);
					Function.SetPosition(ref mNode2, Index - text3.Length - 1 - text4.Length - 1, text3.Length + 1 + text4.Length + 1, BaseOrSub: false);
					text2 = text2 + ", " + text;
				}
				break;
			default:
				pACKET_TFTP.Bytes = (ushort)(PacketData.Length - Index);
				text = "Data : " + Function.ReFormatString(pACKET_TFTP.Bytes, " bytes(s)");
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index, pACKET_TFTP.Bytes, BaseOrSub: false);
				break;
			}
			LItem.Protocol = "TFTP";
			LItem.Info = text2;
			Function.SetPosition(ref mNode2, num, Index - num, BaseOrSub: true);
			mNode.Add(mNode2);
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed TFTP packet. Remaining bytes don't fit an TFTP packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.Info = "[ Malformed TFTP packet. Remaining bytes don't fit an TFTP packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		string text = "";
		try
		{
			PACKET_TFTP pACKET_TFTP = default(PACKET_TFTP);
			pACKET_TFTP.OpCode = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = Const.GetTftpOpCodeString(pACKET_TFTP.OpCode);
			switch (pACKET_TFTP.OpCode)
			{
			case 1:
				pACKET_TFTP.SourceFile = Function.FindString(PacketData, ref Index);
				text = text + ", Source File Name : " + pACKET_TFTP.SourceFile;
				pACKET_TFTP.TransferType = Function.FindString(PacketData, ref Index);
				text = text + ", Transfer Type : " + pACKET_TFTP.TransferType;
				break;
			case 2:
				pACKET_TFTP.DestinationFile = Function.FindString(PacketData, ref Index);
				text = text + ", Destination File Name : " + pACKET_TFTP.DestinationFile;
				pACKET_TFTP.TransferType = Function.FindString(PacketData, ref Index);
				text = text + ", Transfer Type : " + pACKET_TFTP.TransferType;
				break;
			case 3:
				pACKET_TFTP.BlockNo = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = text + ", Block " + pACKET_TFTP.BlockNo;
				pACKET_TFTP.Bytes = (ushort)(PacketData.Length - Index);
				if (pACKET_TFTP.Bytes < 512)
				{
					text += " ( Last )";
				}
				break;
			case 4:
				pACKET_TFTP.BlockNo = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = text + ", Block " + pACKET_TFTP.BlockNo;
				break;
			case 5:
				pACKET_TFTP.ErrorNo = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = text + ", Error No : " + pACKET_TFTP.ErrorNo;
				pACKET_TFTP.ErrorMessage = Function.FindString(PacketData, ref Index);
				text = text + ", ErrorMessage : " + pACKET_TFTP.ErrorMessage;
				break;
			default:
				pACKET_TFTP.Bytes = (ushort)(PacketData.Length - Index);
				break;
			case 6:
				break;
			}
			LItem.Protocol = "TFTP";
			LItem.Info = text;
		}
		catch
		{
			LItem.Info = "[ Malformed TFTP packet. Remaining bytes don't fit an TFTP packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}
}
