using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketIPX
{
	public struct PACKET_IPX
	{
		public ushort Checksum;

		public ushort PacketLength;

		public byte TransparentControl;

		public byte PacketType;

		public string DestinationNetwork;

		public string DestinationNode;

		public ushort DestinationSocket;

		public string SourceNetwork;

		public string SourceNode;

		public ushort SourceSocket;

		public byte[] Data;
	}

	public static string GetSocketString(ushort u)
	{
		string result = "";
		ushort num = u;
		if (num == 1106)
		{
			result = "SAP";
		}
		return result;
	}

	public static string GetPacketTypeString(byte b)
	{
		string result = "";
		switch (b)
		{
		case 17:
			result = "NetWare Core Protocol ( NCP )";
			break;
		case 5:
			result = "Packet Exchange Protocol ( SPX )";
			break;
		}
		return result;
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		string text = "";
		int num = 0;
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "IPX ( Internet Packet Exchange Protocol )";
		Function.SetPosition(ref mNode2, Index, PacketData.Length - Index - 1, BaseOrSub: true);
		if (Index + 30 > PacketData.Length)
		{
			mNode.Add(mNode2);
			text = "[ Malformed IPX packet. Remaining bytes don't fit an IPX packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			LItem.Info = text;
			return false;
		}
		try
		{
			PACKET_IPX pACKET_IPX = default(PACKET_IPX);
			pACKET_IPX.Checksum = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Checksum : " + Function.ReFormatString(pACKET_IPX.Checksum, (pACKET_IPX.Checksum == ushort.MaxValue) ? "Checksum is not used" : null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_IPX.PacketLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Packet Length :" + Function.ReFormatString(pACKET_IPX.PacketLength, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_IPX.TransparentControl = PacketData[Index++];
			text = "Transparent Control :" + Function.ReFormatString(pACKET_IPX.TransparentControl, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_IPX.PacketType = PacketData[Index++];
			text = "Packet Type :" + Function.ReFormatString(pACKET_IPX.PacketType, GetPacketTypeString(pACKET_IPX.PacketType));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_IPX.DestinationNetwork = Function.GetIpAddress(PacketData, ref Index);
			text = "Destination Network : " + pACKET_IPX.DestinationNetwork;
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 4, 4, BaseOrSub: false);
			pACKET_IPX.DestinationNode = Function.GetMACAddress(PacketData, ref Index);
			text = "Destination Node : " + pACKET_IPX.DestinationNode;
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 6, 6, BaseOrSub: false);
			pACKET_IPX.DestinationSocket = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Destination Socket :" + Function.ReFormatString(pACKET_IPX.DestinationSocket, GetSocketString(pACKET_IPX.DestinationSocket));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_IPX.SourceNetwork = Function.GetIpAddress(PacketData, ref Index);
			text = "Source Network : " + pACKET_IPX.SourceNetwork;
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 4, 4, BaseOrSub: false);
			pACKET_IPX.SourceNode = Function.GetMACAddress(PacketData, ref Index);
			text = "Source Node : " + pACKET_IPX.SourceNode;
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 6, 6, BaseOrSub: false);
			pACKET_IPX.SourceSocket = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Source Socket :" + Function.ReFormatString(pACKET_IPX.SourceSocket, GetSocketString(pACKET_IPX.SourceSocket));
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			int num2 = PacketData.GetLength(0) - Index - 1;
			if (num2 > 0)
			{
				pACKET_IPX.Data = new byte[num2];
				for (num = 0; num < num2; num++)
				{
					pACKET_IPX.Data[num] = PacketData[Index++];
				}
				text = "IPX Data :";
				mNode2.Nodes.Add(text);
				Function.SetPosition(ref mNode2, Index - num2, num2, BaseOrSub: false);
			}
			LItem.Protocol = "IPX";
			LItem.Source = pACKET_IPX.SourceNetwork;
			LItem.Destination = pACKET_IPX.DestinationNetwork;
			LItem.Info = "Ipx protocol";
			mNode.Add(mNode2);
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed IPX packet. Remaining bytes don't fit an IPX packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.Info = "[ Malformed IPX packet. Remaining bytes don't fit an IPX packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		string text = "";
		int num = 0;
		if (Index + 30 > PacketData.Length)
		{
			text = "[ Malformed IPX packet. Remaining bytes don't fit an IPX packet. Possibly due to bad decoding ]";
			LItem.Info = text;
			return false;
		}
		try
		{
			PACKET_IPX pACKET_IPX = default(PACKET_IPX);
			pACKET_IPX.Checksum = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_IPX.PacketLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_IPX.TransparentControl = PacketData[Index++];
			pACKET_IPX.PacketType = PacketData[Index++];
			pACKET_IPX.DestinationNetwork = Function.GetIpAddress(PacketData, ref Index);
			pACKET_IPX.DestinationNode = Function.GetMACAddress(PacketData, ref Index);
			pACKET_IPX.DestinationSocket = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_IPX.SourceNetwork = Function.GetIpAddress(PacketData, ref Index);
			pACKET_IPX.SourceNode = Function.GetMACAddress(PacketData, ref Index);
			pACKET_IPX.SourceSocket = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			int num2 = PacketData.GetLength(0) - Index - 1;
			if (num2 > 0)
			{
				pACKET_IPX.Data = new byte[num2];
				for (num = 0; num < num2; num++)
				{
					pACKET_IPX.Data[num] = PacketData[Index++];
				}
			}
			LItem.Protocol = "IPX";
			LItem.Source = pACKET_IPX.SourceNetwork;
			LItem.Destination = pACKET_IPX.DestinationNetwork;
			LItem.Info = "Ipx protocol";
		}
		catch
		{
			text = "[ Malformed IPX packet. Remaining bytes don't fit an IPX packet. Possibly due to bad decoding ]";
			LItem.Info = "[ Malformed IPX packet. Remaining bytes don't fit an IPX packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}
}
