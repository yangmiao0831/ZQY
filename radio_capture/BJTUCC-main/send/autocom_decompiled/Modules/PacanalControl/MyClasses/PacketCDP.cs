using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketCDP
{
	public struct PACKET_CDP_ADDRESS
	{
		public byte ProtocolType;

		public string ProtocolTypeStr;

		public byte ProtocolLength;

		public byte Protocol;

		public string ProtocolStr;

		public ushort AddressLength;

		public string IpAddress;
	}

	public struct PACKET_CDP_ADDRESSES
	{
		public ushort Type;

		public ushort Length;

		public uint AddressCount;

		public PACKET_CDP_ADDRESS[] IpAddresses;
	}

	public struct PACKET_CDP_CONTENTS
	{
		public ushort Type;

		public ushort Length;

		public string Name;
	}

	public struct PACKET_CDP
	{
		public byte Version;

		public byte TTL;

		public ushort Checksum;

		public PACKET_CDP_CONTENTS DeviceId;

		public PACKET_CDP_CONTENTS SoftwareVersion;

		public PACKET_CDP_CONTENTS Platform;

		public PACKET_CDP_ADDRESSES Addresses;

		public PACKET_CDP_CONTENTS PortId;

		public ushort CapabilitiesType;

		public ushort CapabilitiesLength;

		public uint CapabilitiesFlag;

		public string CapabilitiesFlagStr;

		public PACKET_CDP_CONTENTS VTP;

		public PACKET_CDP_CONTENTS Duplex;
	}

	public static string GetTypeList(ushort b)
	{
		int num = 0;
		string[] array = new string[256];
		for (num = 0; num < 256; num++)
		{
			array[num] = "Unknown";
		}
		array[1] = "Device ID";
		array[2] = "Addresses";
		array[3] = "Port ID";
		array[4] = "Capabilities";
		array[5] = "Software version";
		array[6] = "Platform";
		array[7] = "IP Prefix (used for ODR)";
		array[9] = "VTP Management Domain";
		array[10] = "Native VLAN";
		array[11] = "Duplex";
		return array[b];
	}

	public static string GetProtocolSubTypeList(byte b)
	{
		int num = 0;
		string[] array = new string[256];
		for (num = 0; num < 256; num++)
		{
			array[num] = "Unknown";
		}
		array[0] = "NULL";
		array[1] = "IP T.70";
		array[1] = "SPI X.29";
		array[3] = "X.633";
		array[8] = "Q931";
		array[9] = "Q2931";
		array[12] = "Q2119";
		array[128] = "SNAP";
		array[129] = "ISO 8473 CLNP";
		array[130] = "ISO 9542 ESIS";
		array[131] = "ISO 10589 ISIS";
		array[133] = " ISO 10747 IDRP";
		array[138] = "ISO 9542 X.25 ESIS";
		array[140] = "ISO 10030";
		array[141] = "ISO 11577";
		array[142] = "IP.6";
		array[176] = "COMPRESSED";
		array[193] = "SNDCF";
		array[204] = "IP";
		array[207] = "PPP";
		return array[b];
	}

	public static string GetProtocolTypeList(byte b)
	{
		int num = 0;
		string[] array = new string[256];
		for (num = 0; num < 256; num++)
		{
			array[num] = "Unknown";
		}
		array[1] = "NLPID";
		array[2] = "802.2";
		return array[b];
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected O, but got Unknown
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected O, but got Unknown
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af8: Expected O, but got Unknown
		//IL_0ca1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca7: Expected O, but got Unknown
		//IL_0d64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6a: Expected O, but got Unknown
		//IL_0f13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f19: Expected O, but got Unknown
		//IL_0758: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Expected O, but got Unknown
		//IL_10f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f9: Expected O, but got Unknown
		string text = "";
		int num = 0;
		int num2 = 0;
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "CDP ( Cisco Discovery Protocol )";
		num2 = Index;
		try
		{
			PACKET_CDP pACKET_CDP = default(PACKET_CDP);
			pACKET_CDP.Version = PacketData[Index++];
			text = "Version :" + Function.ReFormatString(pACKET_CDP.Version, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_CDP.TTL = PacketData[Index++];
			text = "TTL :" + Function.ReFormatString(pACKET_CDP.TTL, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			pACKET_CDP.Checksum = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Checksum :" + Function.ReFormatString(pACKET_CDP.Checksum, null);
			mNode2.Nodes.Add(text);
			Function.SetPosition(ref mNode2, Index - 2, 2, BaseOrSub: false);
			TreeNode mNode3 = new TreeNode();
			mNode3.Text = "Device Id";
			pACKET_CDP.DeviceId.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Type :" + Function.ReFormatString(pACKET_CDP.DeviceId.Type, GetTypeList(pACKET_CDP.DeviceId.Type));
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_CDP.DeviceId.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Length :" + Function.ReFormatString(pACKET_CDP.DeviceId.Length, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_CDP.DeviceId.Name = "";
			for (num = 0; num < pACKET_CDP.DeviceId.Length - 4; num++)
			{
				pACKET_CDP.DeviceId.Name += (char)PacketData[Index++];
			}
			text = "Name : " + pACKET_CDP.DeviceId.Name;
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - pACKET_CDP.DeviceId.Length + 4, pACKET_CDP.DeviceId.Length - 4, BaseOrSub: false);
			Function.SetPosition(ref mNode3, Index - pACKET_CDP.DeviceId.Length, pACKET_CDP.DeviceId.Length, BaseOrSub: true);
			mNode2.Nodes.Add(mNode3);
			mNode3 = new TreeNode();
			mNode3.Text = "Software Version";
			pACKET_CDP.SoftwareVersion.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Type :" + Function.ReFormatString(pACKET_CDP.SoftwareVersion.Type, GetTypeList(pACKET_CDP.SoftwareVersion.Type));
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_CDP.SoftwareVersion.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Length :" + Function.ReFormatString(pACKET_CDP.SoftwareVersion.Length, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_CDP.SoftwareVersion.Name = "";
			for (num = 0; num < pACKET_CDP.SoftwareVersion.Length - 4; num++)
			{
				pACKET_CDP.SoftwareVersion.Name += (char)PacketData[Index++];
			}
			text = "Name : " + pACKET_CDP.SoftwareVersion.Name;
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - pACKET_CDP.SoftwareVersion.Length + 4, pACKET_CDP.SoftwareVersion.Length - 4, BaseOrSub: false);
			Function.SetPosition(ref mNode3, Index - pACKET_CDP.SoftwareVersion.Length, pACKET_CDP.SoftwareVersion.Length, BaseOrSub: true);
			mNode2.Nodes.Add(mNode3);
			mNode3 = new TreeNode();
			mNode3.Text = "Platform";
			pACKET_CDP.Platform.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Type :" + Function.ReFormatString(pACKET_CDP.Platform.Type, GetTypeList(pACKET_CDP.Platform.Type));
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_CDP.Platform.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Length :" + Function.ReFormatString(pACKET_CDP.Platform.Length, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_CDP.Platform.Name = "";
			for (num = 0; num < pACKET_CDP.Platform.Length - 4; num++)
			{
				pACKET_CDP.Platform.Name += (char)PacketData[Index++];
			}
			text = "Name : " + pACKET_CDP.Platform.Name;
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - pACKET_CDP.Platform.Name.Length, pACKET_CDP.Platform.Name.Length, BaseOrSub: false);
			Function.SetPosition(ref mNode3, Index - pACKET_CDP.Platform.Name.Length - 4, pACKET_CDP.Platform.Name.Length + 4, BaseOrSub: true);
			mNode2.Nodes.Add(mNode3);
			mNode3 = new TreeNode();
			mNode3.Text = "Addresses";
			pACKET_CDP.Addresses.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Type :" + Function.ReFormatString(pACKET_CDP.Addresses.Type, GetTypeList(pACKET_CDP.Addresses.Type));
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_CDP.Addresses.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Length :" + Function.ReFormatString(pACKET_CDP.Addresses.Length, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_CDP.Addresses.AddressCount = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Number of Addresses :" + Function.ReFormatString(pACKET_CDP.Addresses.AddressCount, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
			Function.SetPosition(ref mNode3, Index - 8, (int)(8 + pACKET_CDP.Addresses.AddressCount * 9), BaseOrSub: true);
			TreeNode mNode4;
			if (pACKET_CDP.Addresses.AddressCount != 0)
			{
				pACKET_CDP.Addresses.IpAddresses = new PACKET_CDP_ADDRESS[pACKET_CDP.Addresses.AddressCount];
				for (num = 0; num < pACKET_CDP.Addresses.AddressCount; num++)
				{
					mNode4 = new TreeNode();
					Function.SetPosition(ref mNode4, Index, 9, BaseOrSub: true);
					pACKET_CDP.Addresses.IpAddresses[num].ProtocolType = PacketData[Index++];
					text = "Protocol Type :" + Function.ReFormatString(pACKET_CDP.Addresses.IpAddresses[num].ProtocolType, GetProtocolTypeList(pACKET_CDP.Addresses.IpAddresses[num].ProtocolType));
					mNode4.Nodes.Add(text);
					Function.SetPosition(ref mNode4, Index - 1, 1, BaseOrSub: false);
					if (pACKET_CDP.Addresses.IpAddresses[num].ProtocolType == 1)
					{
						pACKET_CDP.Addresses.IpAddresses[num].ProtocolTypeStr = "NLPID";
					}
					pACKET_CDP.Addresses.IpAddresses[num].ProtocolLength = PacketData[Index++];
					text = "Protocol Length :" + Function.ReFormatString(pACKET_CDP.Addresses.IpAddresses[num].ProtocolLength, null);
					mNode4.Nodes.Add(text);
					Function.SetPosition(ref mNode4, Index - 1, 1, BaseOrSub: false);
					pACKET_CDP.Addresses.IpAddresses[num].Protocol = PacketData[Index++];
					text = ((pACKET_CDP.Addresses.IpAddresses[num].ProtocolType != 1) ? ("Protocol :" + Function.ReFormatString(pACKET_CDP.Addresses.IpAddresses[num].Protocol, pACKET_CDP.Addresses.IpAddresses[num].ProtocolStr)) : ("Protocol :" + Function.ReFormatString(pACKET_CDP.Addresses.IpAddresses[num].Protocol, GetProtocolSubTypeList(pACKET_CDP.Addresses.IpAddresses[num].Protocol))));
					mNode4.Nodes.Add(text);
					Function.SetPosition(ref mNode4, Index - 1, 1, BaseOrSub: false);
					if (pACKET_CDP.Addresses.IpAddresses[num].Protocol == 204)
					{
						pACKET_CDP.Addresses.IpAddresses[num].ProtocolStr = "IP";
					}
					pACKET_CDP.Addresses.IpAddresses[num].AddressLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
					text = "Address Length :" + Function.ReFormatString(pACKET_CDP.Addresses.IpAddresses[num].AddressLength, null);
					mNode4.Nodes.Add(text);
					Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
					pACKET_CDP.Addresses.IpAddresses[num].IpAddress = Function.GetIpAddress(PacketData, ref Index, pACKET_CDP.Addresses.IpAddresses[num].AddressLength);
					text = "IP Address :" + pACKET_CDP.Addresses.IpAddresses[num].IpAddress;
					mNode4.Nodes.Add(text);
					Function.SetPosition(ref mNode4, Index - 4, 4, BaseOrSub: false);
					mNode4.Text = pACKET_CDP.Addresses.IpAddresses[num].IpAddress;
					mNode3.Nodes.Add(mNode4);
				}
			}
			mNode2.Nodes.Add(mNode3);
			mNode3 = new TreeNode();
			mNode3.Text = "Port Id";
			pACKET_CDP.PortId.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Type :" + Function.ReFormatString(pACKET_CDP.PortId.Type, GetTypeList(pACKET_CDP.PortId.Type));
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_CDP.PortId.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Length :" + Function.ReFormatString(pACKET_CDP.PortId.Length, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_CDP.PortId.Name = "";
			for (num = 0; num < pACKET_CDP.PortId.Length - 4; num++)
			{
				pACKET_CDP.PortId.Name += (char)PacketData[Index++];
			}
			text = "Name : " + pACKET_CDP.PortId.Name;
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - pACKET_CDP.PortId.Name.Length, pACKET_CDP.PortId.Name.Length, BaseOrSub: false);
			Function.SetPosition(ref mNode3, Index - pACKET_CDP.PortId.Name.Length - 4, pACKET_CDP.PortId.Name.Length + 4, BaseOrSub: true);
			mNode2.Nodes.Add(mNode3);
			mNode3 = new TreeNode();
			mNode3.Text = "Capabilities";
			pACKET_CDP.CapabilitiesType = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Type :" + Function.ReFormatString(pACKET_CDP.CapabilitiesType, GetTypeList(pACKET_CDP.CapabilitiesType));
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_CDP.CapabilitiesLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Length :" + Function.ReFormatString(pACKET_CDP.CapabilitiesLength, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_CDP.CapabilitiesFlag = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			mNode4 = new TreeNode();
			mNode4.Text = "Flags : " + Function.ReFormatString(pACKET_CDP.CapabilitiesFlag, null);
			Function.SetPosition(ref mNode4, Index - 4, 4, BaseOrSub: true);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_CDP.CapabilitiesFlag, 1, "Performs level 3 routing", "Doesn't perform level 3 routing"));
			Function.SetPosition(ref mNode4, Index - 4, 4, BaseOrSub: false);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_CDP.CapabilitiesFlag, 2, "Performs level 2 transparent routing", "Doesn't perform level 2 transparent routing"));
			Function.SetPosition(ref mNode4, Index - 4, 4, BaseOrSub: false);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_CDP.CapabilitiesFlag, 4, "Performs level 2 source-route bridging", "Doesn't perform Level 2 source-route bridging"));
			Function.SetPosition(ref mNode4, Index - 4, 4, BaseOrSub: false);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_CDP.CapabilitiesFlag, 8, "Performs level 2 switching", "Doesn't perform level 2 switching"));
			Function.SetPosition(ref mNode4, Index - 4, 4, BaseOrSub: false);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_CDP.CapabilitiesFlag, 16, "Sends or receives packets for network layer protocols", "Doesn't send or receive packets for network layer protocols"));
			Function.SetPosition(ref mNode4, Index - 4, 4, BaseOrSub: false);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_CDP.CapabilitiesFlag, 32, "Doesn't forward IGMP report packets on nonrouter ports", "Forwards IGMP report packets on nonrouter ports"));
			Function.SetPosition(ref mNode4, Index - 4, 4, BaseOrSub: false);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_CDP.CapabilitiesFlag, 64, "Performs level 1 functionality", "Doesn't perform level 1 functionality"));
			Function.SetPosition(ref mNode4, Index - 4, 4, BaseOrSub: false);
			mNode3.Nodes.Add(mNode4);
			Function.SetPosition(ref mNode3, Index - 8, 8, BaseOrSub: true);
			mNode2.Nodes.Add(mNode3);
			mNode3 = new TreeNode();
			mNode3.Text = "VTP";
			pACKET_CDP.VTP.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Type :" + Function.ReFormatString(pACKET_CDP.VTP.Type, GetTypeList(pACKET_CDP.VTP.Type));
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_CDP.VTP.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Length :" + Function.ReFormatString(pACKET_CDP.VTP.Length, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_CDP.VTP.Name = "";
			if (pACKET_CDP.VTP.Length > 4)
			{
				for (num = 0; num < pACKET_CDP.VTP.Length - 4; num++)
				{
					pACKET_CDP.VTP.Name += (char)PacketData[Index++];
				}
			}
			else
			{
				pACKET_CDP.VTP.Name = "Null";
			}
			text = "VTP Management Domain : " + pACKET_CDP.VTP.Name;
			mNode3.Nodes.Add(text);
			if (pACKET_CDP.VTP.Length > 4)
			{
				Function.SetPosition(ref mNode3, Index - pACKET_CDP.VTP.Name.Length, pACKET_CDP.VTP.Name.Length, BaseOrSub: false);
			}
			Function.SetPosition(ref mNode3, Index - pACKET_CDP.VTP.Name.Length - 4, pACKET_CDP.VTP.Name.Length + 4, BaseOrSub: true);
			mNode2.Nodes.Add(mNode3);
			mNode3 = new TreeNode();
			mNode3.Text = "Duplex";
			pACKET_CDP.Duplex.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Type :" + Function.ReFormatString(pACKET_CDP.Duplex.Type, GetTypeList(pACKET_CDP.Duplex.Type));
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_CDP.Duplex.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Length :" + Function.ReFormatString(pACKET_CDP.Duplex.Length, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_CDP.Duplex.Name = "Null";
			if (PacketData[Index++] == 1)
			{
				pACKET_CDP.Duplex.Name = "Full";
			}
			text = "Name : " + pACKET_CDP.Duplex.Name;
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - pACKET_CDP.Duplex.Length + 4, pACKET_CDP.Duplex.Length + 4, BaseOrSub: false);
			Function.SetPosition(ref mNode3, Index - pACKET_CDP.Duplex.Length, pACKET_CDP.Duplex.Length, BaseOrSub: true);
			mNode2.Nodes.Add(mNode3);
			LItem.Protocol = "CDP/VTP";
			LItem.Info = "Cisco Discovery Protocol";
			Function.SetPosition(ref mNode2, num2, Index - num2, BaseOrSub: true);
			mNode.Add(mNode2);
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed CDP packet. Remaining bytes don't fit an CDP packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.Info = text;
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		string text = "";
		int num = 0;
		try
		{
			PACKET_CDP pACKET_CDP = default(PACKET_CDP);
			pACKET_CDP.Version = PacketData[Index++];
			pACKET_CDP.TTL = PacketData[Index++];
			pACKET_CDP.Checksum = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_CDP.DeviceId.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_CDP.DeviceId.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_CDP.DeviceId.Name = "";
			for (num = 0; num < pACKET_CDP.DeviceId.Length - 4; num++)
			{
				pACKET_CDP.DeviceId.Name += (char)PacketData[Index++];
			}
			pACKET_CDP.SoftwareVersion.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_CDP.SoftwareVersion.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_CDP.SoftwareVersion.Name = "";
			for (num = 0; num < pACKET_CDP.SoftwareVersion.Length - 4; num++)
			{
				pACKET_CDP.SoftwareVersion.Name += (char)PacketData[Index++];
			}
			pACKET_CDP.Platform.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_CDP.Platform.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_CDP.Platform.Name = "";
			for (num = 0; num < pACKET_CDP.Platform.Length - 4; num++)
			{
				pACKET_CDP.Platform.Name += (char)PacketData[Index++];
			}
			pACKET_CDP.Addresses.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_CDP.Addresses.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_CDP.Addresses.AddressCount = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			if (pACKET_CDP.Addresses.AddressCount != 0)
			{
				pACKET_CDP.Addresses.IpAddresses = new PACKET_CDP_ADDRESS[pACKET_CDP.Addresses.AddressCount];
				for (num = 0; num < pACKET_CDP.Addresses.AddressCount; num++)
				{
					pACKET_CDP.Addresses.IpAddresses[num].ProtocolType = PacketData[Index++];
					if (pACKET_CDP.Addresses.IpAddresses[num].ProtocolType == 1)
					{
						pACKET_CDP.Addresses.IpAddresses[num].ProtocolTypeStr = "NLPID";
					}
					pACKET_CDP.Addresses.IpAddresses[num].ProtocolLength = PacketData[Index++];
					pACKET_CDP.Addresses.IpAddresses[num].Protocol = PacketData[Index++];
					if (pACKET_CDP.Addresses.IpAddresses[num].Protocol == 204)
					{
						pACKET_CDP.Addresses.IpAddresses[num].ProtocolStr = "IP";
					}
					pACKET_CDP.Addresses.IpAddresses[num].AddressLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
					pACKET_CDP.Addresses.IpAddresses[num].IpAddress = Function.GetIpAddress(PacketData, ref Index, pACKET_CDP.Addresses.IpAddresses[num].AddressLength);
				}
			}
			pACKET_CDP.PortId.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_CDP.PortId.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_CDP.PortId.Name = "";
			for (num = 0; num < pACKET_CDP.PortId.Length - 4; num++)
			{
				pACKET_CDP.PortId.Name += (char)PacketData[Index++];
			}
			pACKET_CDP.CapabilitiesType = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_CDP.CapabilitiesLength = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_CDP.CapabilitiesFlag = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_CDP.VTP.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_CDP.VTP.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_CDP.VTP.Name = "";
			for (num = 0; num < pACKET_CDP.VTP.Length - 4; num++)
			{
				pACKET_CDP.VTP.Name += (char)PacketData[Index++];
			}
			pACKET_CDP.Duplex.Type = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_CDP.Duplex.Length = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			pACKET_CDP.Duplex.Name = "Null";
			if (PacketData[Index++] == 1)
			{
				pACKET_CDP.Duplex.Name = "Full";
			}
			LItem.Protocol = "CDP/VTP";
			LItem.Info = "Cisco Discovery Protocol";
		}
		catch
		{
			text = "[ Malformed CDP packet. Remaining bytes don't fit an CDP packet. Possibly due to bad decoding ]";
			LItem.Info = text;
			return false;
		}
		return true;
	}
}
