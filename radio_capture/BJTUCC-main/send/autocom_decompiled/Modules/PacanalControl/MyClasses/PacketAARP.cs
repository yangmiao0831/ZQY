using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketAARP
{
	public struct PACKET_AARP
	{
		public ushort HardwareType;

		public ushort ProtocolType;

		public byte HardwareLength;

		public byte ProtocolLength;

		public ushort OpCode;

		public string SourceHardwareAddress;

		public string SourceIpAddress;

		public string DestinationHardwareAddress;

		public string DestinationIpAddress;
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref ListViewItem LItem)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		string text = "";
		int num = 0;
		int num2 = 0;
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "AARP ( Apple Talk Address Resolution Protocol )";
		num2 = Index;
		try
		{
			PACKET_AARP pACKET_AARP = default(PACKET_AARP);
			pACKET_AARP.HardwareType = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Hardware Type : " + Function.ReFormatString(pACKET_AARP.HardwareType, Const.GetAarpHardwareString(pACKET_AARP.HardwareType));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_AARP.ProtocolType = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Protocol Type : " + Function.ReFormatString(pACKET_AARP.ProtocolType, Const.GetAarpHardwareString(pACKET_AARP.HardwareType));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_AARP.HardwareLength = PacketData[Index++];
			text = "Hardware Length : " + Function.ReFormatString(pACKET_AARP.HardwareLength, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_AARP.ProtocolLength = PacketData[Index++];
			text = "Protocol Length : " + Function.ReFormatString(pACKET_AARP.ProtocolLength, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_AARP.OpCode = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Operation Code : " + Function.ReFormatString(pACKET_AARP.OpCode, Const.GetAarpOptionString(pACKET_AARP.OpCode));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_AARP.SourceHardwareAddress = Const.GetAarpHardwareAddress(PacketData, ref Index, pACKET_AARP.HardwareLength, pACKET_AARP.HardwareType);
			text = "Source MAC Address : " + Function.ReFormatString(pACKET_AARP.SourceHardwareAddress, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - pACKET_AARP.HardwareLength, pACKET_AARP.HardwareLength, BaseOrSub: false);
			pACKET_AARP.SourceIpAddress = Const.GetAarpIpAddress(PacketData, ref Index, pACKET_AARP.ProtocolLength, pACKET_AARP.ProtocolType);
			text = "source Ip Address : " + Function.ReFormatString(pACKET_AARP.SourceIpAddress, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - pACKET_AARP.ProtocolLength, pACKET_AARP.ProtocolLength, BaseOrSub: false);
			pACKET_AARP.DestinationHardwareAddress = Const.GetAarpHardwareAddress(PacketData, ref Index, pACKET_AARP.HardwareLength, pACKET_AARP.HardwareType);
			text = "Destination MAC Address : " + Function.ReFormatString(pACKET_AARP.DestinationHardwareAddress, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - pACKET_AARP.HardwareLength, pACKET_AARP.HardwareLength, BaseOrSub: false);
			pACKET_AARP.DestinationIpAddress = Const.GetAarpIpAddress(PacketData, ref Index, pACKET_AARP.ProtocolLength, pACKET_AARP.ProtocolType);
			text = "Destination Ip Address : " + Function.ReFormatString(pACKET_AARP.DestinationIpAddress, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - pACKET_AARP.ProtocolLength, pACKET_AARP.ProtocolLength, BaseOrSub: false);
			switch (pACKET_AARP.OpCode)
			{
			case 1:
			case 256:
				LItem.SubItems[9].Text = "Who has " + pACKET_AARP.DestinationIpAddress + " ?  Tell " + pACKET_AARP.SourceIpAddress;
				break;
			case 2:
			case 512:
				LItem.SubItems[9].Text = pACKET_AARP.SourceIpAddress + " is at " + pACKET_AARP.SourceHardwareAddress;
				break;
			case 3:
			case 768:
				LItem.SubItems[9].Text = "Is there a " + pACKET_AARP.DestinationIpAddress + " ?";
				break;
			default:
				LItem.SubItems[9].Text = "Unknown AARP opcode " + pACKET_AARP.OpCode.ToString("x04");
				break;
			}
			LItem.SubItems[6].Text = "AARP";
			LItem.SubItems[2].Text = pACKET_AARP.SourceHardwareAddress;
			LItem.SubItems[4].Text = pACKET_AARP.DestinationHardwareAddress;
			num = num2;
			num2 = Index - num;
			Function.SetPosition(ref mNode2, num, num2, BaseOrSub: true);
			mNode.Add(mNode2);
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed AARP packet. Remaining bytes don't fit an AARP packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.SubItems[9].Text = text;
			return false;
		}
		return true;
	}
}
