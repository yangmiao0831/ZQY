using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketDCERPC
{
	public struct PACKET_DCE_RPC
	{
		public byte Version;

		public byte VersionMinor;

		public byte PacketType;

		public byte PacketFlags;

		public uint DataRepesantation;

		public ushort FragLength;

		public ushort AuthLength;

		public uint CallId;

		public ushort MaxXmitFrag;

		public ushort MaxRecvFrag;

		public uint AssocGroup;

		public byte NumCtx;

		public ushort ContextId;

		public ushort NumTransItems;

		public string InterfaceUUIDStr;

		public ushort InterfaceVersion;

		public ushort InterfaceMinorVersion;

		public ushort TransferSyntax;

		public string SyntaxVersionStr;
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref ListViewItem LItem)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		string text = "";
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "DCE/RPC (  )";
		Function.SetPosition(ref mNode2, Index, 67, BaseOrSub: true);
		if (Index + 67 > PacketData.Length)
		{
			mNode.Add(mNode2);
			text = "[ Malformed DCE/RPC packet. Remaining bytes don't fit an DCE/RPC packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			LItem.SubItems[9].Text = text;
			return false;
		}
		try
		{
			PACKET_DCE_RPC pACKET_DCE_RPC = default(PACKET_DCE_RPC);
			pACKET_DCE_RPC.Version = PacketData[Index++];
			text = "Version :" + Function.ReFormatString(pACKET_DCE_RPC.Version, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_DCE_RPC.VersionMinor = PacketData[Index++];
			text = "Version ( Minor ) :" + Function.ReFormatString(pACKET_DCE_RPC.VersionMinor, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_DCE_RPC.PacketType = PacketData[Index++];
			text = "Packet Type :" + Function.ReFormatString(pACKET_DCE_RPC.PacketType, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_DCE_RPC.PacketFlags = PacketData[Index++];
			text = "Packet Flags :" + Function.ReFormatString(pACKET_DCE_RPC.PacketFlags, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_DCE_RPC.DataRepesantation = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Data Represantation :" + Function.ReFormatString(pACKET_DCE_RPC.DataRepesantation, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 4, 4, BaseOrSub: false);
			pACKET_DCE_RPC.FragLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Frag Length :" + Function.ReFormatString(pACKET_DCE_RPC.FragLength, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_DCE_RPC.AuthLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Auth Length :" + Function.ReFormatString(pACKET_DCE_RPC.AuthLength, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_DCE_RPC.CallId = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Call Id :" + Function.ReFormatString(pACKET_DCE_RPC.CallId, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 4, 4, BaseOrSub: false);
			pACKET_DCE_RPC.MaxXmitFrag = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Max Xmit Frag :" + Function.ReFormatString(pACKET_DCE_RPC.MaxXmitFrag, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_DCE_RPC.MaxRecvFrag = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Max Recv Frag :" + Function.ReFormatString(pACKET_DCE_RPC.MaxRecvFrag, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_DCE_RPC.AssocGroup = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Assoc Group :" + Function.ReFormatString(pACKET_DCE_RPC.AssocGroup, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 4, 4, BaseOrSub: false);
			pACKET_DCE_RPC.NumCtx = PacketData[Index++];
			text = "Num Ctx :" + Function.ReFormatString(pACKET_DCE_RPC.NumCtx, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_DCE_RPC.ContextId = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Context Id :" + Function.ReFormatString(pACKET_DCE_RPC.ContextId, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_DCE_RPC.NumTransItems = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Num Trans Items :" + Function.ReFormatString(pACKET_DCE_RPC.NumTransItems, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_DCE_RPC.InterfaceUUIDStr = PacketData[Index + 3].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 2].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 1].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr = pACKET_DCE_RPC.InterfaceUUIDStr + PacketData[Index].ToString("x02") + "-";
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 5].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr = pACKET_DCE_RPC.InterfaceUUIDStr + PacketData[Index + 4].ToString("x02") + "-";
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 7].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr = pACKET_DCE_RPC.InterfaceUUIDStr + PacketData[Index + 6].ToString("x02") + "-";
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 8].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr = pACKET_DCE_RPC.InterfaceUUIDStr + PacketData[Index + 9].ToString("x02") + "-";
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 10].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 11].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 12].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 13].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 14].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 15].ToString("x02");
			Index += 16;
			text = "Interface UUID :" + Function.ReFormatString(pACKET_DCE_RPC.InterfaceUUIDStr, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 16, 16, BaseOrSub: false);
			pACKET_DCE_RPC.InterfaceVersion = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Interface Version :" + Function.ReFormatString(pACKET_DCE_RPC.InterfaceVersion, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_DCE_RPC.InterfaceMinorVersion = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Interface Version ( Minor ) :" + Function.ReFormatString(pACKET_DCE_RPC.InterfaceMinorVersion, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_DCE_RPC.TransferSyntax = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Transfer Syntax :" + Function.ReFormatString(pACKET_DCE_RPC.TransferSyntax, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			pACKET_DCE_RPC.SyntaxVersionStr = PacketData[Index + 3].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 2].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 1].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr = pACKET_DCE_RPC.SyntaxVersionStr + PacketData[Index].ToString("x02") + "-";
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 5].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr = pACKET_DCE_RPC.SyntaxVersionStr + PacketData[Index + 4].ToString("x02") + "-";
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 7].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr = pACKET_DCE_RPC.SyntaxVersionStr + PacketData[Index + 6].ToString("x02") + "-";
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 8].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr = pACKET_DCE_RPC.SyntaxVersionStr + PacketData[Index + 9].ToString("x02") + "-";
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 10].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 11].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 12].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 13].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 14].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 15].ToString("x02");
			Index += 16;
			text = "Syntax Version :" + Function.ReFormatString(pACKET_DCE_RPC.SyntaxVersionStr, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 16, 16, BaseOrSub: false);
			LItem.SubItems[6].Text = "DCE/RPC";
			LItem.SubItems[9].Text = "DCE/RPC";
			mNode.Add(mNode2);
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed DCE/RPC packet. Remaining bytes don't fit an DCE/RPC packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.SubItems[9].Text = "[ Malformed DCE/RPC packet. Remaining bytes don't fit an DCE/RPC packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public static bool Parser(ref TreeNode mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		string text = "";
		mNode = new TreeNode();
		mNode.Text = "DCE/RPC (  )";
		Function.SetPosition(ref mNode, Index, 67, BaseOrSub: true);
		if (Index + 67 > PacketData.Length)
		{
			text = "[ Malformed DCE/RPC packet. Remaining bytes don't fit an DCE/RPC packet. Possibly due to bad decoding ]";
			mNode.Nodes.Add(text);
			LItem.Info = text;
			return false;
		}
		try
		{
			PACKET_DCE_RPC pACKET_DCE_RPC = default(PACKET_DCE_RPC);
			pACKET_DCE_RPC.Version = PacketData[Index++];
			text = "Version :" + Function.ReFormatString(pACKET_DCE_RPC.Version, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			pACKET_DCE_RPC.VersionMinor = PacketData[Index++];
			text = "Version ( Minor ) :" + Function.ReFormatString(pACKET_DCE_RPC.VersionMinor, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			pACKET_DCE_RPC.PacketType = PacketData[Index++];
			text = "Packet Type :" + Function.ReFormatString(pACKET_DCE_RPC.PacketType, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			pACKET_DCE_RPC.PacketFlags = PacketData[Index++];
			text = "Packet Flags :" + Function.ReFormatString(pACKET_DCE_RPC.PacketFlags, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			pACKET_DCE_RPC.DataRepesantation = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Data Represantation :" + Function.ReFormatString(pACKET_DCE_RPC.DataRepesantation, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			pACKET_DCE_RPC.FragLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Frag Length :" + Function.ReFormatString(pACKET_DCE_RPC.FragLength, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			pACKET_DCE_RPC.AuthLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Auth Length :" + Function.ReFormatString(pACKET_DCE_RPC.AuthLength, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			pACKET_DCE_RPC.CallId = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Call Id :" + Function.ReFormatString(pACKET_DCE_RPC.CallId, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			pACKET_DCE_RPC.MaxXmitFrag = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Max Xmit Frag :" + Function.ReFormatString(pACKET_DCE_RPC.MaxXmitFrag, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			pACKET_DCE_RPC.MaxRecvFrag = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Max Recv Frag :" + Function.ReFormatString(pACKET_DCE_RPC.MaxRecvFrag, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			pACKET_DCE_RPC.AssocGroup = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Assoc Group :" + Function.ReFormatString(pACKET_DCE_RPC.AssocGroup, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			pACKET_DCE_RPC.NumCtx = PacketData[Index++];
			text = "Num Ctx :" + Function.ReFormatString(pACKET_DCE_RPC.NumCtx, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			pACKET_DCE_RPC.ContextId = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Context Id :" + Function.ReFormatString(pACKET_DCE_RPC.ContextId, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			pACKET_DCE_RPC.NumTransItems = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Num Trans Items :" + Function.ReFormatString(pACKET_DCE_RPC.NumTransItems, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			pACKET_DCE_RPC.InterfaceUUIDStr = PacketData[Index + 3].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 2].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 1].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr = pACKET_DCE_RPC.InterfaceUUIDStr + PacketData[Index].ToString("x02") + "-";
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 5].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr = pACKET_DCE_RPC.InterfaceUUIDStr + PacketData[Index + 4].ToString("x02") + "-";
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 7].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr = pACKET_DCE_RPC.InterfaceUUIDStr + PacketData[Index + 6].ToString("x02") + "-";
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 8].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr = pACKET_DCE_RPC.InterfaceUUIDStr + PacketData[Index + 9].ToString("x02") + "-";
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 10].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 11].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 12].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 13].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 14].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 15].ToString("x02");
			Index += 16;
			text = "Interface UUID :" + Function.ReFormatString(pACKET_DCE_RPC.InterfaceUUIDStr, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 16, 16, BaseOrSub: false);
			pACKET_DCE_RPC.InterfaceVersion = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Interface Version :" + Function.ReFormatString(pACKET_DCE_RPC.InterfaceVersion, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			pACKET_DCE_RPC.InterfaceMinorVersion = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Interface Version ( Minor ) :" + Function.ReFormatString(pACKET_DCE_RPC.InterfaceMinorVersion, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			pACKET_DCE_RPC.TransferSyntax = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Transfer Syntax :" + Function.ReFormatString(pACKET_DCE_RPC.TransferSyntax, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			pACKET_DCE_RPC.SyntaxVersionStr = PacketData[Index + 3].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 2].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 1].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr = pACKET_DCE_RPC.SyntaxVersionStr + PacketData[Index].ToString("x02") + "-";
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 5].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr = pACKET_DCE_RPC.SyntaxVersionStr + PacketData[Index + 4].ToString("x02") + "-";
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 7].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr = pACKET_DCE_RPC.SyntaxVersionStr + PacketData[Index + 6].ToString("x02") + "-";
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 8].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr = pACKET_DCE_RPC.SyntaxVersionStr + PacketData[Index + 9].ToString("x02") + "-";
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 10].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 11].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 12].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 13].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 14].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 15].ToString("x02");
			Index += 16;
			text = "Syntax Version :" + Function.ReFormatString(pACKET_DCE_RPC.SyntaxVersionStr, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 16, 16, BaseOrSub: false);
			LItem.Protocol = "DCE/RPC";
			LItem.Info = "DCE/RPC";
		}
		catch (Exception ex)
		{
			text = "[ Malformed DCE/RPC packet. Remaining bytes don't fit an DCE/RPC packet. Possibly due to bad decoding ]";
			mNode.Nodes.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Nodes.Add(text);
			LItem.Info = "[ Malformed DCE/RPC packet. Remaining bytes don't fit an DCE/RPC packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref int Index, ref ListViewItem LItem)
	{
		string text = "";
		if (Index + 67 > PacketData.Length)
		{
			text = "[ Malformed DCE/RPC packet. Remaining bytes don't fit an DCE/RPC packet. Possibly due to bad decoding ]";
			LItem.SubItems[9].Text = text;
			return false;
		}
		try
		{
			PACKET_DCE_RPC pACKET_DCE_RPC = default(PACKET_DCE_RPC);
			pACKET_DCE_RPC.Version = PacketData[Index++];
			pACKET_DCE_RPC.VersionMinor = PacketData[Index++];
			pACKET_DCE_RPC.PacketType = PacketData[Index++];
			pACKET_DCE_RPC.PacketFlags = PacketData[Index++];
			pACKET_DCE_RPC.DataRepesantation = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_DCE_RPC.FragLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_DCE_RPC.AuthLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_DCE_RPC.CallId = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_DCE_RPC.MaxXmitFrag = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_DCE_RPC.MaxRecvFrag = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_DCE_RPC.AssocGroup = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_DCE_RPC.NumCtx = PacketData[Index++];
			pACKET_DCE_RPC.ContextId = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_DCE_RPC.NumTransItems = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_DCE_RPC.InterfaceUUIDStr = PacketData[Index + 3].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 2].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 1].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr = pACKET_DCE_RPC.InterfaceUUIDStr + PacketData[Index].ToString("x02") + "-";
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 5].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr = pACKET_DCE_RPC.InterfaceUUIDStr + PacketData[Index + 4].ToString("x02") + "-";
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 7].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr = pACKET_DCE_RPC.InterfaceUUIDStr + PacketData[Index + 6].ToString("x02") + "-";
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 8].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr = pACKET_DCE_RPC.InterfaceUUIDStr + PacketData[Index + 9].ToString("x02") + "-";
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 10].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 11].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 12].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 13].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 14].ToString("x02");
			pACKET_DCE_RPC.InterfaceUUIDStr += PacketData[Index + 15].ToString("x02");
			Index += 16;
			pACKET_DCE_RPC.InterfaceVersion = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_DCE_RPC.InterfaceMinorVersion = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_DCE_RPC.TransferSyntax = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_DCE_RPC.SyntaxVersionStr = PacketData[Index + 3].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 2].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 1].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr = pACKET_DCE_RPC.SyntaxVersionStr + PacketData[Index].ToString("x02") + "-";
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 5].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr = pACKET_DCE_RPC.SyntaxVersionStr + PacketData[Index + 4].ToString("x02") + "-";
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 7].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr = pACKET_DCE_RPC.SyntaxVersionStr + PacketData[Index + 6].ToString("x02") + "-";
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 8].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr = pACKET_DCE_RPC.SyntaxVersionStr + PacketData[Index + 9].ToString("x02") + "-";
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 10].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 11].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 12].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 13].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 14].ToString("x02");
			pACKET_DCE_RPC.SyntaxVersionStr += PacketData[Index + 15].ToString("x02");
			Index += 16;
			LItem.SubItems[6].Text = "DCE/RPC";
			LItem.SubItems[9].Text = "DCE/RPC";
		}
		catch
		{
			text = "[ Malformed DCE/RPC packet. Remaining bytes don't fit an DCE/RPC packet. Possibly due to bad decoding ]";
			LItem.SubItems[9].Text = "[ Malformed DCE/RPC packet. Remaining bytes don't fit an DCE/RPC packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}
}
