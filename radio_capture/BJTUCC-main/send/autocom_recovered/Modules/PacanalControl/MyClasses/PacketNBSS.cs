using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketNBSS
{
	public struct PACKET_NBSS
	{
		public byte MessageType;

		public byte Flags;

		public uint Length;

		public byte ErrorCode;

		public string ReTargetIpAddress;

		public ushort ReTargetPort;

		public string CalledName;

		public byte CalledNameNumber;

		public string CallingName;

		public byte CallingNameNumber;

		public object NextPacket;
	}

	public static string GetMessageTypeString(byte b)
	{
		int num = 0;
		string[] array = new string[256];
		for (num = 0; num < 256; num++)
		{
			array[num] = "Unknown";
		}
		array[0] = "Session message";
		array[129] = "Session request";
		array[130] = "Positive session response";
		array[131] = "Negative session response";
		array[132] = "Retarget session response";
		array[133] = "Session keep-alive";
		return array[b];
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
		if (b < 128)
		{
			return "Invalid Error Code !!!";
		}
		return array[b - 128];
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, bool IsCifs)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		string text = "";
		int num = 0;
		byte NameNumber = 0;
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "NBSS ( Netbios Session Service )";
		num = Index;
		try
		{
			if (Index >= PacketData.Length)
			{
				text = "Continuation message";
				mNode2.Nodes.Add(text);
				LItem.Protocol = "NBSS";
				LItem.Info = "Continuation message";
				mNode.Add(mNode2);
			}
			else
			{
				PACKET_NBSS pACKET_NBSS = default(PACKET_NBSS);
				pACKET_NBSS.MessageType = PacketData[Index++];
				text = "Message Type :" + Function.ReFormatString(pACKET_NBSS.MessageType, GetMessageTypeString(pACKET_NBSS.MessageType));
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
				if (IsCifs)
				{
					pACKET_NBSS.Flags = 0;
					TreeNode mNode3 = new TreeNode();
					text = "Flags        :" + Function.ReFormatString(pACKET_NBSS.Flags, null);
					mNode3.Text = text;
					Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: true);
					mNode3.Nodes.Add(Function.DecodeBitField(pACKET_NBSS.Flags, 1, "Add 65536 to length", "Add 0 to length"));
					Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
					mNode2.Nodes.Add(mNode3);
					Index++;
					pACKET_NBSS.Length = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
					text = "Length       :" + Function.ReFormatString(pACKET_NBSS.Length, null);
					mNode2.Nodes.Add(text);
					Function.SetPosition(ref mNode2, Index - 4, 4, BaseOrSub: false);
				}
				else
				{
					pACKET_NBSS.Flags = PacketData[Index++];
					TreeNode mNode3 = new TreeNode();
					text = "Flags        :" + Function.ReFormatString(pACKET_NBSS.Flags, null);
					mNode3.Text = text;
					Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: true);
					mNode3.Nodes.Add(Function.DecodeBitField(pACKET_NBSS.Flags, 1, "Add 65536 to length", "Add 0 to length"));
					Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
					mNode2.Nodes.Add(mNode3);
					pACKET_NBSS.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
					if ((pACKET_NBSS.Flags & 1) > 0)
					{
						pACKET_NBSS.Length += 65536u;
					}
					text = "Length       :" + Function.ReFormatString(pACKET_NBSS.Length, null);
					mNode2.Nodes.Add(text);
					Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
				}
				if ((pACKET_NBSS.Flags & -2) != 0)
				{
					text = "Continuation Message";
					mNode2.Nodes.Add(text);
					LItem.Info = "Continuation message";
				}
				else
				{
					switch (pACKET_NBSS.MessageType)
					{
					case 129:
						if (pACKET_NBSS.Length < 2 || pACKET_NBSS.Length > 256)
						{
							text = "Continuation Message";
							mNode2.Nodes.Add(text);
							LItem.Info = "Continuation message";
							break;
						}
						pACKET_NBSS.CalledName = Function.GetNetBiosName(PacketData, ref Index, ref NameNumber);
						text = "Called Name :" + pACKET_NBSS.CalledName + " ( " + Const.GetNetBiosNames(NameNumber) + " )";
						mNode2.Nodes.Add(text);
						Function.SetPosition(ref mNode2, Index - 34, 34, BaseOrSub: false);
						pACKET_NBSS.CallingName = Function.GetNetBiosName(PacketData, ref Index, ref NameNumber);
						text = "Calling Name :" + pACKET_NBSS.CallingName + " ( " + Const.GetNetBiosNames(NameNumber) + " )";
						mNode2.Nodes.Add(text);
						Function.SetPosition(ref mNode2, Index - 34, 34, BaseOrSub: false);
						break;
					case 130:
						if (pACKET_NBSS.Length != 0)
						{
							text = "Continuation Message";
							mNode2.Nodes.Add(text);
							LItem.Info = "Continuation message";
						}
						break;
					case 131:
						if (pACKET_NBSS.Length != 1)
						{
							text = "Continuation Message";
							mNode2.Nodes.Add(text);
							LItem.Info = "Continuation message";
						}
						else
						{
							pACKET_NBSS.ErrorCode = PacketData[Index++];
							text = "Error Code       :" + Function.ReFormatString(pACKET_NBSS.ErrorCode, GetErrorCodeString(pACKET_NBSS.ErrorCode));
							mNode2.Nodes.Add(text);
							Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
						}
						break;
					case 133:
						if (pACKET_NBSS.Length != 0)
						{
							text = "Continuation Message";
							mNode2.Nodes.Add(text);
							LItem.Info = "Continuation message";
						}
						break;
					case 132:
						if (pACKET_NBSS.Length != 6)
						{
							text = "Continuation Message";
							mNode2.Nodes.Add(text);
							LItem.Info = "Continuation message";
							break;
						}
						pACKET_NBSS.ReTargetIpAddress = Function.GetIpAddress(PacketData, ref Index);
						text = "Retarget Ip Address :" + pACKET_NBSS.ReTargetIpAddress;
						mNode2.Nodes.Add(text);
						Function.SetPosition(ref mNode2, Index - 4, 4, BaseOrSub: false);
						pACKET_NBSS.ReTargetPort = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
						text = "Retarget Port :" + Function.ReFormatString(pACKET_NBSS.ReTargetPort, Const.GetPortStr(pACKET_NBSS.ReTargetPort));
						mNode2.Nodes.Add(text);
						Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
						break;
					case 0:
						if (pACKET_NBSS.Length == 0)
						{
							text = "Continuation Message";
							mNode2.Nodes.Add(text);
							LItem.Info = "Continuation message";
						}
						break;
					}
				}
				Function.SetPosition(ref mNode2, num, Index - num, BaseOrSub: true);
				mNode.Add(mNode2);
				LItem.Protocol = "NBSS";
				if (pACKET_NBSS.MessageType == 0 && Index + 4 < PacketData.Length && PacketData[Index] == byte.MaxValue && PacketData[Index + 1] == 83 && PacketData[Index + 2] == 77 && PacketData[Index + 3] == 66)
				{
					PacketSMB.Parser(ref mNode, PacketData, ref Index, ref LItem);
				}
			}
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed NBSS packet. Remaining bytes don't fit an NBSS packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.Info = "[ Malformed NBSS packet. Remaining bytes don't fit an NBSS packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, bool IsCifs)
	{
		byte NameNumber = 0;
		try
		{
			if (Index >= PacketData.Length)
			{
				LItem.Protocol = "NBSS";
				LItem.Info = "Continuation message";
				return true;
			}
			PACKET_NBSS pACKET_NBSS = default(PACKET_NBSS);
			pACKET_NBSS.MessageType = PacketData[Index++];
			if (IsCifs)
			{
				pACKET_NBSS.Flags = 0;
				pACKET_NBSS.Length = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			}
			else
			{
				pACKET_NBSS.Flags = PacketData[Index++];
				pACKET_NBSS.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				if ((pACKET_NBSS.Flags & 1) > 0)
				{
					pACKET_NBSS.Length += 65536u;
				}
			}
			switch (pACKET_NBSS.MessageType)
			{
			case 129:
				pACKET_NBSS.CalledName = Function.GetNetBiosName(PacketData, ref Index, ref NameNumber);
				pACKET_NBSS.CallingName = Function.GetNetBiosName(PacketData, ref Index, ref NameNumber);
				break;
			case 131:
				pACKET_NBSS.ErrorCode = PacketData[Index++];
				break;
			case 132:
				pACKET_NBSS.ReTargetIpAddress = Function.GetIpAddress(PacketData, ref Index);
				pACKET_NBSS.ReTargetPort = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				break;
			}
			LItem.Protocol = "NBSS";
			LItem.Info = "Netbios session service";
		}
		catch
		{
			LItem.Info = "[ Malformed NBSS packet. Remaining bytes don't fit an NBSS packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}
}
