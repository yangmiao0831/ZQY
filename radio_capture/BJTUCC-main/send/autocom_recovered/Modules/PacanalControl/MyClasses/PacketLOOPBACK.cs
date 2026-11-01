using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketLOOPBACK
{
	public struct PACKET_LOOPBACK
	{
		public byte[] Data;
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		string text = "";
		int num = 0;
		int num2 = 0;
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "LOOPBACK ( Loopback Protocol )";
		Function.SetPosition(ref mNode2, Index, PacketData.Length - Index - 1, BaseOrSub: true);
		try
		{
			num2 = PacketData.GetLength(0) - Index;
			PACKET_LOOPBACK pACKET_LOOPBACK = default(PACKET_LOOPBACK);
			pACKET_LOOPBACK.Data = new byte[num2];
			for (num = 0; num < num2; num++)
			{
				pACKET_LOOPBACK.Data[num] = PacketData[Index++];
			}
			text = "Data : ";
			mNode2.Nodes.Add(text);
			LItem.Protocol = "LOOPBACK";
			LItem.Info = "Loopback protocol";
			mNode.Add(mNode2);
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed LOOPBACK packet. Remaining bytes don't fit an LOOPBACK packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.Info = "[ Malformed LOOPBACK packet. Remaining bytes don't fit an LOOPBACK packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		int num = 0;
		int num2 = 0;
		try
		{
			num2 = PacketData.GetLength(0) - Index;
			PACKET_LOOPBACK pACKET_LOOPBACK = default(PACKET_LOOPBACK);
			pACKET_LOOPBACK.Data = new byte[num2];
			for (num = 0; num < num2; num++)
			{
				pACKET_LOOPBACK.Data[num] = PacketData[Index++];
			}
			LItem.Protocol = "LOOPBACK";
			LItem.Info = "Loopback protocol";
		}
		catch
		{
			LItem.Info = "[ Malformed LOOPBACK packet. Remaining bytes don't fit an LOOPBACK packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}
}
