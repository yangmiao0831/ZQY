using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketSMB
{
	public struct PACKET_SMB_HEADER
	{
		public string ServerComponent;

		public byte Command;

		public string CommandStr;

		public byte ErrorClass;

		public byte Reserved1;

		public ushort ErrorCode;

		public uint NtStatus;

		public byte Flags;

		public string FlagsStr;

		public ushort Flags2;

		public string Flags2Str;

		public string Reserved2;

		public ushort TreeId;

		public ushort ProcessId;

		public ushort UserId;

		public ushort MultiplexId;
	}

	public struct PACKET_SMB_BODY
	{
		public byte WordCount;

		public ushort ByteCount;
	}

	public struct PACKET_SMB_MESSAGE_REQUEST
	{
		public byte WordCount;

		public ushort ByteCount;

		public byte OriginatorBufferFormat;

		public string OriginatorName;

		public byte DestinationBufferFormat;

		public string DestinationName;

		public byte MessageBufferFormat;

		public ushort MessageLen;

		public string Message;
	}

	public struct PACKET_SMB_TRANSACTION_REQUEST
	{
		public byte WordCount;

		public ushort TotalParamaterCount;

		public ushort TotalDataCount;

		public ushort MaxParameterCount;

		public ushort MaxDataCount;

		public byte MaxSetupCount;

		public byte Reserved1;

		public ushort Flags;

		public uint TimeOut;

		public ushort Reserved2;

		public ushort ParameterCount;

		public ushort ParameterOffset;

		public ushort DataCount;

		public ushort DataOffset;

		public byte SetupCount;

		public byte Reserved3;

		public ushort ByteCount;

		public ushort ParameterDisplay;

		public ushort DataDisplay;

		public ushort FId;

		public string TransactionName;

		public ushort SubCmd;

		public byte Padding;
	}

	public struct PACKET_SMB
	{
		public PACKET_SMB_HEADER SmbHeader;

		public PACKET_SMB_BODY SmbBody;

		public object NextPacket;

		public object NextPacketEx;
	}

	private static TreeNode ParseOpenFunction(ushort Mask, int Index)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		TreeNode mNode = new TreeNode();
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: true);
		mNode.Text = "Open Function :" + Function.ReFormatString(Mask, null);
		return mNode;
	}

	private static TreeNode ParseAccess(ushort Mask, int Index)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		TreeNode mNode = new TreeNode();
		string[] valueText = new string[4] { "Locality of reference unknown", "Mainly sequential access", "Mainly random access", "Random access with some locality" };
		string[] valueText2 = new string[5] { "Compatibility mode", "Deny read/write/execute (exclusive)", "Deny write", "Deny read/execute", "Deny none" };
		string[] valueText3 = new string[4] { "Open for reading", "Open for writing", "Open for reading and writing", "Open for execute" };
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: true);
		mNode.Text = "Access :" + Function.ReFormatString(Mask, null);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 16384, "Write through enabled", "Write through disabled"));
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 4096, "Do not cache this file", "Caching permitted on this file"));
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 1792, valueText));
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 112, valueText2));
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 7, valueText3));
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
		return mNode;
	}

	private static TreeNode ParseSearchAttributes(ushort Mask, int Index)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		TreeNode mNode = new TreeNode();
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: true);
		mNode.Text = "Search Attributes :" + Function.ReFormatString(Mask, null);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 32, "Include READ ONLY files in search results", "Do NOT include read only files in search results"));
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 16, "Include HIDDEN files in search results", "Do NOT include hidden files in search results"));
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 8, "Include SYSTEM files in search results", "Do NOT include system files in search results"));
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 4, "Include VOLUME IDs in search results", "Do NOT include volume IDs in search results"));
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 2, "Include DIRECTORIES in search results", "Do NOT include directories in search results"));
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 1, "Include ARCHIVE files in search results", "Do NOT include archive files in search results"));
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
		return mNode;
	}

	private static TreeNode ParseFileAttributes(ushort Mask, int Index)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		TreeNode mNode = new TreeNode();
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: true);
		mNode.Text = "Search Attributes :" + Function.ReFormatString(Mask, null);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 32, "This is an ARCHIVE file", "This is NOT an archive file"));
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 16, "This is a DIRECTORY", "This is NOT a directory"));
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 8, "This is a VOLUME ID", "This is NOT a volume ID"));
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 4, "This is a SYSTEM file", "This is NOT a system file"));
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 2, "This is a HIDDEN file", "This is NOT a hidden file"));
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 1, "This file is READ ONLY", "This file is NOT read only"));
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
		return mNode;
	}

	private static TreeNode ParseExtendedFileAttributes(uint Mask, int Index)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		TreeNode mNode = new TreeNode();
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: true);
		mNode.Text = "Extended File Attributes :" + Function.ReFormatString(Mask, null);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 16384, "This is an ENCRYPTED file", "This is NOT an encrypted file"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 8192, "This file MAY NOT be indexed by the CONTENT INDEXING service", "This file MAY be indexed by the content indexing service"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 4096, "This file is OFFLINE", "This file is NOT offline"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 2048, "This is a COMPRESSED file", "This is NOT a compressed file"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 1024, "This file has an associated REPARSE POINT", "This file does NOT have an associated reparse point"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 512, "This is a SPARSE file", "This is NOT a sparse file"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 256, "This is a TEMPORARY file", "This is NOT a temporary file"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 128, "This file is an ordinary file", "This file has some attribute set"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 64, "This is a DEVICE", "This is NOT a device"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 32, "This is an ARCHIVE file", "This is NOT an archive file"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 16, "This is a DIRECTORY", "This is NOT a directory"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 8, "This is a VOLUME ID", "This is NOT a volume ID"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 4, "This is a SYSTEM file", "This is NOT a system file"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 2, "This is a HIDDEN file", "This is NOT a hidden file"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 1, "This file is READ ONLY", "This file is NOT read only"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		return mNode;
	}

	private static TreeNode ParseDirectoryInfoFileAttributes(byte Mask, int Index)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		TreeNode mNode = new TreeNode();
		Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: true);
		mNode.Text = "Directory Info Attributes :" + Function.ReFormatString(Mask, null);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 32, "This is an ARCHIVE file", "This is NOT an archive file"));
		Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 16, "This is a DIRECTORY", "This is NOT a directory"));
		Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 8, "This is a VOLUME ID", "This is NOT a volume ID"));
		Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 4, "This is a SYSTEM file", "This is NOT a system file"));
		Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 2, "This is a HIDDEN file", "This is NOT a hidden file"));
		Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 1, "This file is READ ONLY", "This file is NOT read only"));
		Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
		return mNode;
	}

	private static TreeNode ParseNegotiateProtocolCapabilities(uint Mask, int Index)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		TreeNode mNode = new TreeNode();
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: true);
		mNode.Text = "Capabilities :" + Function.ReFormatString(Mask, null);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 1, "Read Raw and Write Raw are supported", "Read Raw and Write Raw are not supported"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 2, "Read Mpx and Write Mpx are supported", "Read Mpx and Write Mpx are not supported"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 4, "Unicode strings are supported", "Unicode strings are not supported"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 8, "Large files are supported", "Large files are not supported"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 16, "NT SMBs are supported", "NT SMBs are not supported"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 32, "RPC remote APIs are supported", "RPC remote APIs are not supported"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 64, "NT status codes are supported", "NT status codes are not supported"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 128, "Level 2 oplocks are supported", "Level 2 oplocks are not supported"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 256, "Lock and Read is supported", "Lock and Read is not supported"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 512, "NT Find is supported", "NT Find is not supported"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 4096, "Dfs is supported", "Dfs is not supported"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 8192, "NT information level request passthrough is supported", "NT information level request passthrough is not supported"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 16384, "Large Read andX is supported", "Large Read andX is not supported"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 32768, "Large Write andX is supported", "Large Write andX is not supported"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 8388608, "UNIX extensions are supported", "UNIX extensions are not supported"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 33554432, "Reserved", "Reserved"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 536870912, "Bulk Read and Bulk Write are supported", "Bulk Read and Bulk Write are not supported"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 1073741824, "Compressed data transfer is supported", "Compressed data transfer is not supported"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 2147483648u, "Extended security exchanges are supported", "Extended security exchanges are not supported"));
		Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		return mNode;
	}

	private static TreeNode ParseNegotiateProtocolRawMode(ushort Mask, int Index)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		TreeNode mNode = new TreeNode();
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: true);
		mNode.Text = "Raw Mode :" + Function.ReFormatString(Mask, null);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 1, "Read Raw is supported", "Read Raw is not supported"));
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
		mNode.Nodes.Add(Function.DecodeBitField(Mask, 2, "Write Raw is supported", "Write Raw is not supported"));
		Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
		return mNode;
	}

	private static TreeNode ParseNegotiateProtocolSecurityMode(ushort Mask, int Index, int WordCount, int Len)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		TreeNode mNode = new TreeNode();
		Function.SetPosition(ref mNode, Index - Len, Len, BaseOrSub: true);
		mNode.Text = "Security Mode :" + Function.ReFormatString(Mask, null);
		switch (WordCount)
		{
		case 13:
			mNode.Nodes.Add(Function.DecodeBitField(Mask, 1, "USER security mode", "SHARE security mode"));
			Function.SetPosition(ref mNode, Index - Len, Len, BaseOrSub: false);
			mNode.Nodes.Add(Function.DecodeBitField(Mask, 2, "ENCRYPTED password. Use challenge/response", "PLAINTEXT password"));
			Function.SetPosition(ref mNode, Index - Len, Len, BaseOrSub: false);
			break;
		case 17:
			mNode.Nodes.Add(Function.DecodeBitField(Mask, 1, "USER security mode", "SHARE security mode"));
			Function.SetPosition(ref mNode, Index - Len, Len, BaseOrSub: false);
			mNode.Nodes.Add(Function.DecodeBitField(Mask, 2, "ENCRYPTED password. Use challenge/response", "PLAINTEXT password"));
			Function.SetPosition(ref mNode, Index - Len, Len, BaseOrSub: false);
			mNode.Nodes.Add(Function.DecodeBitField(Mask, 4, "Security signatures ENABLED", "Security signatures NOT enabled"));
			Function.SetPosition(ref mNode, Index - Len, Len, BaseOrSub: false);
			mNode.Nodes.Add(Function.DecodeBitField(Mask, 8, "Security signatures REQUIRED", "Security signatures NOT required"));
			Function.SetPosition(ref mNode, Index - Len, Len, BaseOrSub: false);
			break;
		}
		return mNode;
	}

	public static bool ParserSendSingleBlockMessageRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, string CommandName)
	{
		int num = 0;
		int num2 = 0;
		string text = "";
		try
		{
			num2 = Index;
			mNode.Text = CommandName;
			PACKET_SMB_MESSAGE_REQUEST pACKET_SMB_MESSAGE_REQUEST = default(PACKET_SMB_MESSAGE_REQUEST);
			pACKET_SMB_MESSAGE_REQUEST.WordCount = PacketData[Index++];
			text = "Word Count ( Wct ) :" + Function.ReFormatString(pACKET_SMB_MESSAGE_REQUEST.WordCount, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			pACKET_SMB_MESSAGE_REQUEST.ByteCount = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Byte Count ( Wct ) :" + Function.ReFormatString(pACKET_SMB_MESSAGE_REQUEST.ByteCount, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			if (pACKET_SMB_MESSAGE_REQUEST.ByteCount > 0)
			{
				pACKET_SMB_MESSAGE_REQUEST.OriginatorBufferFormat = PacketData[Index++];
				text = "Originator Buffer Format :" + Function.ReFormatString(pACKET_SMB_MESSAGE_REQUEST.OriginatorBufferFormat, null);
				mNode.Nodes.Add(text);
				Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
				num = Index;
				pACKET_SMB_MESSAGE_REQUEST.OriginatorName = Function.GetString(PacketData, ref Index);
				text = "Originator Name :" + pACKET_SMB_MESSAGE_REQUEST.OriginatorName;
				mNode.Nodes.Add(text);
				Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: false);
				pACKET_SMB_MESSAGE_REQUEST.DestinationBufferFormat = PacketData[Index++];
				text = "Destination Buffer Format :" + Function.ReFormatString(pACKET_SMB_MESSAGE_REQUEST.DestinationBufferFormat, null);
				mNode.Nodes.Add(text);
				Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
				num = Index;
				pACKET_SMB_MESSAGE_REQUEST.DestinationName = Function.GetString(PacketData, ref Index);
				text = "Destination Name :" + pACKET_SMB_MESSAGE_REQUEST.DestinationName;
				mNode.Nodes.Add(text);
				Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: false);
				pACKET_SMB_MESSAGE_REQUEST.MessageBufferFormat = PacketData[Index++];
				text = "Message Buffer Format :" + Function.ReFormatString(pACKET_SMB_MESSAGE_REQUEST.MessageBufferFormat, null);
				mNode.Nodes.Add(text);
				Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
				pACKET_SMB_MESSAGE_REQUEST.MessageLen = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Message Length :" + Function.ReFormatString(pACKET_SMB_MESSAGE_REQUEST.MessageLen, null);
				mNode.Nodes.Add(text);
				Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
				num = Index;
				pACKET_SMB_MESSAGE_REQUEST.Message = Function.GetString(PacketData, ref Index, pACKET_SMB_MESSAGE_REQUEST.MessageLen);
				pACKET_SMB_MESSAGE_REQUEST.Message = Function.AnalyzeSmbMessage(pACKET_SMB_MESSAGE_REQUEST.Message);
				text = "Message :" + pACKET_SMB_MESSAGE_REQUEST.Message;
				mNode.Nodes.Add(text);
				Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: false);
				Function.SetPosition(ref mNode, num2, Index - num2, BaseOrSub: true);
			}
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserCreateDirectory(ref TreeNode mNode, byte[] PacketData, ref int Index, string CommandName, bool IsUnicode)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		int num = 0;
		int num2 = 0;
		byte b = 0;
		byte b2 = 0;
		ushort num3 = 0;
		string text = "";
		string text2 = "";
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num2 = Index;
			b = PacketData[Index++];
			text = "Word Count (Wct ) :" + Function.ReFormatString(b, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			_ = 0;
			num3 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Word Count (Wct ) :" + Function.ReFormatString(b, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			if (num3 > 1)
			{
				b2 = PacketData[Index++];
				text = "Buffer Format :" + Function.ReFormatString(b2, null);
				mNode.Nodes.Add(text);
				Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
				num = Index;
				text2 = Function.GetString(PacketData, ref Index, IsUnicode);
				text = "Directory Name :" + text2;
				mNode.Nodes.Add(text);
				Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: false);
			}
			Function.SetPosition(ref mNode, num2, Index - num2, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserOpenFileRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, string CommandName)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		int num = 0;
		int num2 = 0;
		byte b = 0;
		byte b2 = 0;
		ushort num3 = 0;
		string text = "";
		string text2 = "";
		ushort num4 = 0;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num2 = Index;
			b = PacketData[Index++];
			text = "Word Count (Wct ) :" + Function.ReFormatString(b, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num4 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			TreeNode val = ParseAccess(num4, Index);
			mNode.Nodes.Add(val);
			num4 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			val = ParseSearchAttributes(num4, Index);
			mNode.Nodes.Add(val);
			num3 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Byte Count ( Byc ) :" + Function.ReFormatString(num3, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			if (num3 > 1)
			{
				b2 = PacketData[Index++];
				text = "Buffer Format :" + Function.ReFormatString(b2, null);
				mNode.Nodes.Add(text);
				Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
				num = Index;
				text2 = Function.GetUnicodeOrAscii(PacketData, ref Index);
				text = "File Name :" + text2;
				mNode.Nodes.Add(text);
				Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: false);
			}
			Function.SetPosition(ref mNode, num2, Index - num2, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserCreateFileRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, string CommandName)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		int num = 0;
		int num2 = 0;
		byte b = 0;
		ushort num3 = 0;
		string text = "";
		string text2 = "";
		uint num4 = 0u;
		ushort num5 = 0;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num2 = Index;
			b = PacketData[Index++];
			text = "Word Count (Wct ) :" + Function.ReFormatString(b, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num5 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			TreeNode val = ParseFileAttributes(num5, Index);
			mNode.Nodes.Add(val);
			num4 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Creation Time :" + Function.ReFormatString(num4, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			num3 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Byte Count (Byc ) :" + Function.ReFormatString(num3, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num = Index;
			text2 = Function.GetUnicodeOrAscii(PacketData, ref Index);
			text = "File Name :" + text2;
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: false);
			Function.SetPosition(ref mNode, num2, Index - num2, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserCloseFileRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, string CommandName)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		int num = 0;
		byte b = 0;
		ushort num2 = 0;
		string text = "";
		ushort num3 = 0;
		uint num4 = 0u;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num = Index;
			b = PacketData[Index++];
			text = "Word Count (Wct ) :" + Function.ReFormatString(b, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num3 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "File Id :" + Function.ReFormatString(num3, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num4 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Creation Time :" + Function.ReFormatString(num4, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			num2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Byte Count ( Byc ) :" + Function.ReFormatString(num2, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserFid(ref TreeNode mNode, byte[] PacketData, ref int Index, string CommandName)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		int num = 0;
		byte b = 0;
		ushort num2 = 0;
		string text = "";
		ushort num3 = 0;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num = Index;
			b = PacketData[Index++];
			text = "Word Count (Wct ) :" + Function.ReFormatString(b, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num3 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "File Id :" + Function.ReFormatString(num3, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Byte Count ( Byc ) :" + Function.ReFormatString(num2, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserSid(ref TreeNode mNode, byte[] PacketData, ref int Index, string CommandName)
	{
		int num = 0;
		byte NodeValue = 0;
		ushort NodeValue2 = 0;
		ushort NodeValue3 = 0;
		try
		{
			mNode = Function.AddNodeItem(CommandName, "", -1, -1);
			num = Index;
			Function.AddNodeItem(ref mNode, "Word Count ( Wct )", ref NodeValue, null, PacketData, ref Index);
			Function.AddNodeItem(ref mNode, "Source Id", ref NodeValue3, null, PacketData, ref Index, Const.CurFileType);
			Function.AddNodeItem(ref mNode, "Byte Count ( Byc )", ref NodeValue2, null, PacketData, ref Index, Const.CurFileType);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserDeleteFileRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, string CommandName)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		int num = 0;
		int num2 = 0;
		byte b = 0;
		ushort num3 = 0;
		string text = "";
		string text2 = "";
		ushort num4 = 0;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num2 = Index;
			b = PacketData[Index++];
			text = "Word Count (Wct ) :" + Function.ReFormatString(b, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num4 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			TreeNode val = ParseSearchAttributes(num4, Index);
			mNode.Nodes.Add(val);
			num3 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Byte Count ( Byc ) :" + Function.ReFormatString(num3, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num = Index;
			text2 = Function.GetUnicodeOrAscii(PacketData, ref Index);
			text = "File Name :" + text2;
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: false);
			Function.SetPosition(ref mNode, num2, Index - num2, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserRenameFileRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, string CommandName)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		int num = 0;
		int num2 = 0;
		byte b = 0;
		byte b2 = 0;
		ushort num3 = 0;
		string text = "";
		string text2 = "";
		ushort num4 = 0;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num2 = Index;
			b = PacketData[Index++];
			text = "Word Count (Wct ) :" + Function.ReFormatString(b, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num4 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			TreeNode val = ParseSearchAttributes(num4, Index);
			mNode.Nodes.Add(val);
			num3 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Byte Count ( Byc ) :" + Function.ReFormatString(num3, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			b2 = PacketData[Index++];
			text = "Buffer Format :" + Function.ReFormatString(b2, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num = Index;
			text2 = Function.GetUnicodeOrAscii(PacketData, ref Index);
			text = "Old File Name :" + text2;
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: false);
			b2 = PacketData[Index++];
			text = "Buffer Format :" + Function.ReFormatString(b2, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num = Index;
			text2 = Function.GetUnicodeOrAscii(PacketData, ref Index);
			text = "File Name :" + text2;
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: false);
			Function.SetPosition(ref mNode, num2, Index - num2, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserQueryInformationRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, string CommandName)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		int num = 0;
		int num2 = 0;
		byte b = 0;
		byte b2 = 0;
		ushort num3 = 0;
		string text = "";
		string text2 = "";
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num2 = Index;
			b = PacketData[Index++];
			text = "Word Count (Wct ) :" + Function.ReFormatString(b, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num3 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Byte Count ( Byc ) :" + Function.ReFormatString(num3, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			b2 = PacketData[Index++];
			text = "Buffer Format :" + Function.ReFormatString(b2, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num = Index;
			text2 = Function.GetUnicodeOrAscii(PacketData, ref Index);
			text = "Path :" + text2;
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: false);
			Function.SetPosition(ref mNode, num2, Index - num2, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserSetInformationRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, string CommandName)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		int num = 0;
		int num2 = 0;
		byte b = 0;
		byte b2 = 0;
		ushort num3 = 0;
		string text = "";
		string text2 = "";
		ushort num4 = 0;
		int num5 = 0;
		uint num6 = 0u;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num2 = Index;
			b = PacketData[Index++];
			text = "Word Count (Wct ) :" + Function.ReFormatString(b, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num4 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			TreeNode val = ParseFileAttributes(num4, Index);
			mNode.Nodes.Add(val);
			num6 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Last Write Time :" + Function.ReFormatString(num6, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			text = "";
			for (num5 = 0; num5 < 10; num5++)
			{
				text += PacketData[Index++].ToString("x02");
			}
			text = "Reserved :" + text;
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 10, 10, BaseOrSub: false);
			num3 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Byte Count ( Byc ) :" + Function.ReFormatString(num3, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			b2 = PacketData[Index++];
			text = "Buffer Format :" + Function.ReFormatString(b2, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num = Index;
			text2 = Function.GetUnicodeOrAscii(PacketData, ref Index);
			text = "Path :" + text2;
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: false);
			Function.SetPosition(ref mNode, num2, Index - num2, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserReadFileRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, string CommandName)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		int num = 0;
		byte b = 0;
		ushort num2 = 0;
		string text = "";
		ushort num3 = 0;
		ushort num4 = 0;
		ushort num5 = 0;
		uint num6 = 0u;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num = Index;
			b = PacketData[Index++];
			text = "Word Count (Wct ) :" + Function.ReFormatString(b, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num3 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Fid :" + Function.ReFormatString(num3, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num5 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Read Count :" + Function.ReFormatString(num5, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num6 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Offset :" + Function.ReFormatString(num6, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			num4 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Remaining :" + Function.ReFormatString(num4, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Byte Count ( Byc ) :" + Function.ReFormatString(num2, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserWriteFileRequest(ref TreeNode mNode, ref TreeNode mxNode, ref PACKET_ITEM LItem, byte[] PacketData, ref int Index, string CommandName, ushort Flags)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		int num = 0;
		byte b = 0;
		byte b2 = 0;
		ushort num2 = 0;
		string text = "";
		ushort num3 = 0;
		ushort num4 = 0;
		ushort num5 = 0;
		uint num6 = 0u;
		ushort num7 = 0;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num = Index;
			b = PacketData[Index++];
			text = "Word Count (Wct ) :" + Function.ReFormatString(b, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num3 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Fid :" + Function.ReFormatString(num3, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num5 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Write Count :" + Function.ReFormatString(num5, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num6 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Offset :" + Function.ReFormatString(num6, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			num4 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Remaining :" + Function.ReFormatString(num4, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Byte Count ( Byc ) :" + Function.ReFormatString(num2, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			b2 = PacketData[Index++];
			text = "Buffer Format :" + Function.ReFormatString(b2, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num7 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Data Length :" + Function.ReFormatString(num7, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			if (num2 != 3)
			{
				if (num6 == 0 && (Flags & 1) > 0)
				{
					PacketDCERPC.Parser(ref mxNode, PacketData, ref Index, ref LItem);
				}
				else
				{
					text = "Data ";
					mNode.Nodes.Add(text);
					Function.SetPosition(ref mNode, Index, PacketData.Length - Index, BaseOrSub: false);
				}
			}
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserLockFileRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, string CommandName)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		int num = 0;
		byte b = 0;
		ushort num2 = 0;
		string text = "";
		ushort num3 = 0;
		uint num4 = 0u;
		uint num5 = 0u;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num = Index;
			b = PacketData[Index++];
			text = "Word Count (Wct ) :" + Function.ReFormatString(b, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num3 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Fid :" + Function.ReFormatString(num3, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num5 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Lock Count :" + Function.ReFormatString(num5, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			num4 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Offset :" + Function.ReFormatString(num4, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			num2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Byte Count ( Byc ) :" + Function.ReFormatString(num2, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserCreateTemporaryRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, string CommandName)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		int num = 0;
		int num2 = 0;
		byte b = 0;
		byte b2 = 0;
		ushort num3 = 0;
		string text = "";
		string text2 = "";
		ushort num4 = 0;
		uint num5 = 0u;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num2 = Index;
			b = PacketData[Index++];
			text = "Word Count (Wct ) :" + Function.ReFormatString(b, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num4 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Reserved :" + Function.ReFormatString(num4, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num5 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Creation Time :" + Function.ReFormatString(num5, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			num3 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Byte Count ( Byc ) :" + Function.ReFormatString(num3, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			b2 = PacketData[Index++];
			text = "Buffer Format :" + Function.ReFormatString(b2, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num = Index;
			text2 = Function.GetUnicodeOrAscii(PacketData, ref Index);
			text = "Path :" + text2;
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: false);
			Function.SetPosition(ref mNode, num2, Index - num2, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserSeekFileRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, string CommandName)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		int num = 0;
		byte b = 0;
		ushort num2 = 0;
		string text = "";
		uint num3 = 0u;
		ushort num4 = 0;
		ushort num5 = 0;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num = Index;
			b = PacketData[Index++];
			text = "Word Count (Wct ) :" + Function.ReFormatString(b, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num5 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Fid :" + Function.ReFormatString(num5, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num4 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Seek Mode :" + Function.ReFormatString(num4, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num3 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Offset :" + Function.ReFormatString(num3, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			num2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Byte Count ( Byc ) :" + Function.ReFormatString(num2, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserReadRawRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, string CommandName)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		int num = 0;
		byte b = 0;
		ushort num2 = 0;
		string text = "";
		ushort num3 = 0;
		uint num4 = 0u;
		ushort num5 = 0;
		ushort num6 = 0;
		uint num7 = 0u;
		ushort num8 = 0;
		uint num9 = 0u;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num = Index;
			b = PacketData[Index++];
			text = "Word Count (Wct ) :" + Function.ReFormatString(b, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num3 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Fid :" + Function.ReFormatString(num3, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num4 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Offset :" + Function.ReFormatString(num4, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			num6 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Max Count :" + Function.ReFormatString(num6, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num5 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Min Count :" + Function.ReFormatString(num5, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num7 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Timeout :" + Function.ReFormatString(num7, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			num8 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Reserved :" + Function.ReFormatString(num8, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			if (b == 10)
			{
				num9 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
				text = "High Offset :" + Function.ReFormatString(num9, null);
				mNode.Nodes.Add(text);
				Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			}
			num2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Byte Count ( Byc ) :" + Function.ReFormatString(num2, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserReadMpxRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, string CommandName)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		int num = 0;
		byte b = 0;
		ushort num2 = 0;
		string text = "";
		int num3 = 0;
		ushort num4 = 0;
		uint num5 = 0u;
		ushort num6 = 0;
		ushort num7 = 0;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num = Index;
			b = PacketData[Index++];
			text = "Word Count (Wct ) :" + Function.ReFormatString(b, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num4 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Fid :" + Function.ReFormatString(num4, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num5 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Offset :" + Function.ReFormatString(num5, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			num7 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Max Count :" + Function.ReFormatString(num7, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num6 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Min Count :" + Function.ReFormatString(num6, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			text = "";
			for (num3 = 0; num3 < 6; num3++)
			{
				text += PacketData[Index++].ToString("x02");
			}
			text = "Reserved :" + text;
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 6, 6, BaseOrSub: false);
			num2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Byte Count ( Byc ) :" + Function.ReFormatString(num2, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserWriteRawRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, string CommandName)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		int num = 0;
		byte b = 0;
		ushort num2 = 0;
		string text = "";
		int num3 = 0;
		ushort num4 = 0;
		uint num5 = 0u;
		uint num6 = 0u;
		ushort num7 = 0;
		ushort num8 = 0;
		ushort num9 = 0;
		ushort num10 = 0;
		ushort num11 = 0;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num = Index;
			b = PacketData[Index++];
			text = "Word Count (Wct ) :" + Function.ReFormatString(b, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num4 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Fid :" + Function.ReFormatString(num4, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num11 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Total Data Length :" + Function.ReFormatString(num11, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num7 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Reserved :" + Function.ReFormatString(num7, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num5 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Offset :" + Function.ReFormatString(num5, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			num6 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Timeout :" + Function.ReFormatString(num6, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			num10 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Write Mode :" + Function.ReFormatString(num10, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			text = "";
			for (num3 = 0; num3 < 4; num3++)
			{
				text += PacketData[Index++].ToString("x02");
			}
			text = "Reserved :" + text;
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			num8 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Data Length :" + Function.ReFormatString(num8, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num9 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Data Offset :" + Function.ReFormatString(num9, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Byte Count ( Byc ) :" + Function.ReFormatString(num2, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserWriteMpxRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, string CommandName)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		int num = 0;
		byte b = 0;
		ushort num2 = 0;
		string text = "";
		ushort num3 = 0;
		uint num4 = 0u;
		uint num5 = 0u;
		ushort num6 = 0;
		ushort num7 = 0;
		ushort num8 = 0;
		ushort num9 = 0;
		uint num10 = 0u;
		ushort num11 = 0;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num = Index;
			b = PacketData[Index++];
			text = "Word Count (Wct ) :" + Function.ReFormatString(b, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num3 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Fid :" + Function.ReFormatString(num3, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num11 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Total Data Length :" + Function.ReFormatString(num11, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num6 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Reserved :" + Function.ReFormatString(num6, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num4 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Offset :" + Function.ReFormatString(num4, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			num5 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Timeout :" + Function.ReFormatString(num5, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			num9 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Write Mode :" + Function.ReFormatString(num9, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num10 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Request Mask :" + Function.ReFormatString(num10, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			num8 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Data Length :" + Function.ReFormatString(num8, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num7 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Data Offset :" + Function.ReFormatString(num7, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Byte Count ( Byc ) :" + Function.ReFormatString(num2, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserSetInformation2Request(ref TreeNode mNode, byte[] PacketData, ref int Index, string CommandName)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		int num = 0;
		byte b = 0;
		ushort num2 = 0;
		string text = "";
		ushort num3 = 0;
		uint num4 = 0u;
		uint num5 = 0u;
		uint num6 = 0u;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num = Index;
			b = PacketData[Index++];
			text = "Word Count (Wct ) :" + Function.ReFormatString(b, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num3 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Fid :" + Function.ReFormatString(num3, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num4 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Creation Time :" + Function.ReFormatString(num4, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			num5 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Last Access Time :" + Function.ReFormatString(num5, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			num6 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Last Write Time :" + Function.ReFormatString(num6, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			num2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Byte Count ( Byc ) :" + Function.ReFormatString(num2, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserLockingAndXRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, string CommandName)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		int num = 0;
		byte b = 0;
		ushort num2 = 0;
		string text = "";
		ushort num3 = 0;
		ushort num4 = 0;
		byte b2 = 0;
		ushort num5 = 0;
		byte b3 = 0;
		byte b4 = 0;
		uint num6 = 0u;
		ushort num7 = 0;
		ushort num8 = 0;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num = Index;
			b = PacketData[Index++];
			text = "Word Count (Wct ) :" + Function.ReFormatString(b, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			b2 = PacketData[Index++];
			text = ((b2 == byte.MaxValue) ? ("Next Smb Command :" + Function.ReFormatString(b2, "No further commands")) : ("Next Smb Command :" + Function.ReFormatString(b2, null)));
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num4 = PacketData[Index++];
			text = "Reserved :" + Function.ReFormatString(num4, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num5 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "And X Offset :" + Function.ReFormatString(num5, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num3 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Fid :" + Function.ReFormatString(num3, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			b3 = PacketData[Index++];
			TreeNode mNode2 = new TreeNode();
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: true);
			mNode2.Text = "LockType :" + Function.ReFormatString(b3, null);
			mNode2.Nodes.Add(Function.DecodeBitField(b3, 16, "Large file locking format requested", "Large file locking format not requested"));
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			mNode2.Nodes.Add(Function.DecodeBitField(b3, 8, "Cancel outstanding lock request", "Don't cancel outstanding lock request"));
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			mNode2.Nodes.Add(Function.DecodeBitField(b3, 4, "Change lock type", "Don't change lock type"));
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			mNode2.Nodes.Add(Function.DecodeBitField(b3, 2, "This is an oplock break notification/response", "This is not an oplock break notification/response"));
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			mNode2.Nodes.Add(Function.DecodeBitField(b3, 1, "This is a shared lock", "This is an exclusive lock"));
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			mNode.Nodes.Add(mNode2);
			string[] array = new string[2] { "Client is not holding oplock on this file", "Level 2 oplock currently held by client" };
			b4 = PacketData[Index++];
			text = ((b4 != 0 && b4 != 1) ? ("OpLockLevel :" + Function.ReFormatString(b4, "Unknown")) : ("OpLockLevel :" + Function.ReFormatString(b4, array[b4])));
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
			num6 = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = num6 switch
			{
				uint.MaxValue => "TimeOut :" + Function.ReFormatString(num6, "Wait indefinitely ( - 1 )"), 
				0u => "TimeOut :" + Function.ReFormatString(num6, "Return immediately ( 0 )"), 
				_ => "TimeOut :" + Function.ReFormatString(num6, null), 
			};
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
			num7 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Number Of Unlocks :" + Function.ReFormatString(num7, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num8 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Number Of Locks :" + Function.ReFormatString(num8, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			num2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Byte Count ( Byc ) :" + Function.ReFormatString(num2, null);
			mNode.Nodes.Add(text);
			Function.SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
			_ = 0;
			_ = 0;
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserTransactionRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, byte SmbCommand, string CommandName, ref TreeNode mNodeSubNode1, ref TreeNode mNodeSubNode2)
	{
		int Index2 = 0;
		PACKET_SMB_TRANSACTION_REQUEST pACKET_SMB_TRANSACTION_REQUEST = default(PACKET_SMB_TRANSACTION_REQUEST);
		pACKET_SMB_TRANSACTION_REQUEST.SetupCount = 0;
		pACKET_SMB_TRANSACTION_REQUEST.TransactionName = "";
		mNode.Text = CommandName;
		pACKET_SMB_TRANSACTION_REQUEST.WordCount = 0;
		Function.AddNodeItem(ref mNode, "Word Count ( Wct )", ref pACKET_SMB_TRANSACTION_REQUEST.WordCount, null, PacketData, ref Index);
		if (pACKET_SMB_TRANSACTION_REQUEST.WordCount == 8)
		{
			pACKET_SMB_TRANSACTION_REQUEST.TotalParamaterCount = 0;
			Function.AddNodeItem(ref mNode, "Total Parameter Count", ref pACKET_SMB_TRANSACTION_REQUEST.TotalParamaterCount, null, PacketData, ref Index, Const.CurFileType);
			pACKET_SMB_TRANSACTION_REQUEST.TotalDataCount = 0;
			Function.AddNodeItem(ref mNode, "Total Data Count", ref pACKET_SMB_TRANSACTION_REQUEST.TotalDataCount, null, PacketData, ref Index, Const.CurFileType);
			pACKET_SMB_TRANSACTION_REQUEST.ParameterCount = 0;
			Function.AddNodeItem(ref mNode, "Parameter Count", ref pACKET_SMB_TRANSACTION_REQUEST.ParameterCount, null, PacketData, ref Index, Const.CurFileType);
			pACKET_SMB_TRANSACTION_REQUEST.ParameterOffset = 0;
			Function.AddNodeItem(ref mNode, "Parameter Offset", ref pACKET_SMB_TRANSACTION_REQUEST.ParameterOffset, null, PacketData, ref Index, Const.CurFileType);
			pACKET_SMB_TRANSACTION_REQUEST.ParameterDisplay = 0;
			Function.AddNodeItem(ref mNode, "Parameter Displacement", ref pACKET_SMB_TRANSACTION_REQUEST.ParameterDisplay, null, PacketData, ref Index, Const.CurFileType);
			pACKET_SMB_TRANSACTION_REQUEST.DataCount = 0;
			Function.AddNodeItem(ref mNode, "Data Count", ref pACKET_SMB_TRANSACTION_REQUEST.DataCount, null, PacketData, ref Index, Const.CurFileType);
			pACKET_SMB_TRANSACTION_REQUEST.DataOffset = 0;
			Function.AddNodeItem(ref mNode, "Data Offset", ref pACKET_SMB_TRANSACTION_REQUEST.DataOffset, null, PacketData, ref Index, Const.CurFileType);
			pACKET_SMB_TRANSACTION_REQUEST.DataDisplay = 0;
			Function.AddNodeItem(ref mNode, "Data Displacement", ref pACKET_SMB_TRANSACTION_REQUEST.DataDisplay, null, PacketData, ref Index, Const.CurFileType);
			if (SmbCommand == 50)
			{
				pACKET_SMB_TRANSACTION_REQUEST.FId = 0;
				Function.AddNodeItem(ref mNode, "File Id", ref pACKET_SMB_TRANSACTION_REQUEST.FId, null, PacketData, ref Index, Const.CurFileType);
			}
		}
		else
		{
			pACKET_SMB_TRANSACTION_REQUEST.TotalParamaterCount = 0;
			Function.AddNodeItem(ref mNode, "Total Parameter Count", ref pACKET_SMB_TRANSACTION_REQUEST.TotalParamaterCount, null, PacketData, ref Index, Const.CurFileType);
			pACKET_SMB_TRANSACTION_REQUEST.TotalDataCount = 0;
			Function.AddNodeItem(ref mNode, "Total Data Count", ref pACKET_SMB_TRANSACTION_REQUEST.TotalDataCount, null, PacketData, ref Index, Const.CurFileType);
			pACKET_SMB_TRANSACTION_REQUEST.MaxParameterCount = 0;
			Function.AddNodeItem(ref mNode, "Max Parameter Count", ref pACKET_SMB_TRANSACTION_REQUEST.MaxParameterCount, null, PacketData, ref Index, Const.CurFileType);
			pACKET_SMB_TRANSACTION_REQUEST.MaxDataCount = 0;
			Function.AddNodeItem(ref mNode, "Max Data Count", ref pACKET_SMB_TRANSACTION_REQUEST.MaxDataCount, null, PacketData, ref Index, Const.CurFileType);
			pACKET_SMB_TRANSACTION_REQUEST.MaxSetupCount = 0;
			Function.AddNodeItem(ref mNode, "Max Setup Count", ref pACKET_SMB_TRANSACTION_REQUEST.MaxSetupCount, null, PacketData, ref Index);
			pACKET_SMB_TRANSACTION_REQUEST.Reserved1 = 0;
			Function.AddNodeItem(ref mNode, "Reserved", ref pACKET_SMB_TRANSACTION_REQUEST.Reserved1, null, PacketData, ref Index);
			pACKET_SMB_TRANSACTION_REQUEST.Flags = 0;
			TreeNode mNode2 = Function.AddNodeItem(ref mNode, "Flags", ref pACKET_SMB_TRANSACTION_REQUEST.Flags, null, PacketData, ref Index, Const.CurFileType);
			Function.AddNodeItem(ref mNode2, "", Function.DecodeBitField(pACKET_SMB_TRANSACTION_REQUEST.Flags, 2, "One Way Transaction : One way transaction ( NO RESPONSE )", "One Way Transaction : not one way transaction ( RESPONSE )"), Index - 2, 2);
			Function.AddNodeItem(ref mNode2, "", Function.DecodeBitField(pACKET_SMB_TRANSACTION_REQUEST.Flags, 1, "Disconnect TID : Disconnect TID", "Disconnect TID : Do NOT disconnect TID"), Index - 2, 2);
			pACKET_SMB_TRANSACTION_REQUEST.TimeOut = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			Index -= 4;
			if (pACKET_SMB_TRANSACTION_REQUEST.TimeOut == 0)
			{
				Function.AddNodeItem(ref mNode, "Timeout", ref pACKET_SMB_TRANSACTION_REQUEST.TimeOut, "Timeout: Return immediately (0)", PacketData, ref Index, Const.CurFileType);
			}
			else if (pACKET_SMB_TRANSACTION_REQUEST.TimeOut == uint.MaxValue)
			{
				Function.AddNodeItem(ref mNode, "Timeout", ref pACKET_SMB_TRANSACTION_REQUEST.TimeOut, "Timeout: Wait indefinitely (-1)", PacketData, ref Index, Const.CurFileType);
			}
			else
			{
				Function.AddNodeItem(ref mNode, "Timeout", ref pACKET_SMB_TRANSACTION_REQUEST.TimeOut, " second(s)", PacketData, ref Index, Const.CurFileType);
			}
			pACKET_SMB_TRANSACTION_REQUEST.Reserved2 = 0;
			Function.AddNodeItem(ref mNode, "Reserved", ref pACKET_SMB_TRANSACTION_REQUEST.Reserved2, null, PacketData, ref Index, Const.CurFileType);
			pACKET_SMB_TRANSACTION_REQUEST.ParameterCount = 0;
			Function.AddNodeItem(ref mNode, "Parameter Count", ref pACKET_SMB_TRANSACTION_REQUEST.ParameterCount, null, PacketData, ref Index, Const.CurFileType);
			pACKET_SMB_TRANSACTION_REQUEST.ParameterOffset = 0;
			Function.AddNodeItem(ref mNode, "Parameter Offset", ref pACKET_SMB_TRANSACTION_REQUEST.ParameterOffset, null, PacketData, ref Index, Const.CurFileType);
			pACKET_SMB_TRANSACTION_REQUEST.DataCount = 0;
			Function.AddNodeItem(ref mNode, "Data Count", ref pACKET_SMB_TRANSACTION_REQUEST.DataCount, null, PacketData, ref Index, Const.CurFileType);
			pACKET_SMB_TRANSACTION_REQUEST.DataOffset = 0;
			Function.AddNodeItem(ref mNode, "Data Offset", ref pACKET_SMB_TRANSACTION_REQUEST.DataOffset, null, PacketData, ref Index, Const.CurFileType);
			pACKET_SMB_TRANSACTION_REQUEST.SetupCount = 0;
			Function.AddNodeItem(ref mNode, "SetupCount", ref pACKET_SMB_TRANSACTION_REQUEST.SetupCount, null, PacketData, ref Index);
			pACKET_SMB_TRANSACTION_REQUEST.Reserved3 = 0;
			Function.AddNodeItem(ref mNode, "Reserved", ref pACKET_SMB_TRANSACTION_REQUEST.Reserved3, null, PacketData, ref Index);
		}
		int num = Index;
		if (pACKET_SMB_TRANSACTION_REQUEST.SetupCount > 0)
		{
			byte b = SmbCommand;
			if (b != 37 && b == 50)
			{
				pACKET_SMB_TRANSACTION_REQUEST.SubCmd = 0;
				Function.AddNodeItem(ref mNode, "Sub command", ref pACKET_SMB_TRANSACTION_REQUEST.SubCmd, null, PacketData, ref Index, Const.CurFileType);
			}
		}
		Index += pACKET_SMB_TRANSACTION_REQUEST.SetupCount * 2;
		pACKET_SMB_TRANSACTION_REQUEST.ByteCount = 0;
		Function.AddNodeItem(ref mNode, "Byte Count", ref pACKET_SMB_TRANSACTION_REQUEST.ByteCount, null, PacketData, ref Index, Const.CurFileType);
		while (PacketData[Index] == 0)
		{
			Index++;
		}
		if (pACKET_SMB_TRANSACTION_REQUEST.WordCount != 8 && SmbCommand == 37)
		{
			Function.AddNodeItem(ref mNode, "Transaction Name", ref pACKET_SMB_TRANSACTION_REQUEST.TransactionName, null, PacketData, ref Index, 2, 0, PassNullBytes: true);
		}
		int num2 = num;
		string NodeValue = "";
		int num3 = 0;
		if (pACKET_SMB_TRANSACTION_REQUEST.ParameterOffset > Index)
		{
			num3 = pACKET_SMB_TRANSACTION_REQUEST.ParameterOffset - Index;
			Function.AddNodeItem(ref mNode, "Padding", ref NodeValue, null, PacketData, ref Index, 8, num3, PassNullBytes: true);
		}
		if (pACKET_SMB_TRANSACTION_REQUEST.ParameterCount > 0)
		{
			byte b2 = SmbCommand;
			_ = 50;
		}
		if (pACKET_SMB_TRANSACTION_REQUEST.DataOffset > Index)
		{
			num3 = pACKET_SMB_TRANSACTION_REQUEST.DataOffset - Index;
			Function.AddNodeItem(ref mNode, "Padding", ref NodeValue, null, PacketData, ref Index, 8, num3, PassNullBytes: true);
		}
		if (pACKET_SMB_TRANSACTION_REQUEST.DataCount > 0)
		{
			byte b3 = SmbCommand;
			_ = 50;
		}
		if (pACKET_SMB_TRANSACTION_REQUEST.ParameterCount > 0 && pACKET_SMB_TRANSACTION_REQUEST.TransactionName == "\\MAILSLOT\\")
		{
			PacketSMBMAILSLOT.Parser(ref mNodeSubNode1, ref mNodeSubNode2, PacketData, ref Index2, ref LItem, IsRequest: true, pACKET_SMB_TRANSACTION_REQUEST.TransactionName);
		}
		return true;
	}

	public static bool ParserComCopyRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, string CommandName)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		int num = 0;
		byte NodeValue = 0;
		ushort NodeValue2 = 0;
		byte NodeValue3 = 0;
		ushort NodeValue4 = 0;
		string NodeValue5 = "";
		string NodeValue6 = "";
		ushort NodeValue7 = 0;
		ushort NodeValue8 = 0;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num = Index;
			Function.AddNodeItem(ref mNode, "Word Count ( Wct )", ref NodeValue, null, PacketData, ref Index);
			Function.AddNodeItem(ref mNode, "Target Id", ref NodeValue4, null, PacketData, ref Index, Const.CurFileType);
			Function.AddNodeItem(ref mNode, "Open Function", ref NodeValue7, null, PacketData, ref Index, Const.CurFileType);
			Function.AddNodeItem(ref mNode, "Copy Flags", ref NodeValue8, null, PacketData, ref Index, Const.CurFileType);
			Function.AddNodeItem(ref mNode, "Byte Count", ref NodeValue2, null, PacketData, ref Index, Const.CurFileType);
			Function.AddNodeItem(ref mNode, "Buffer Format", ref NodeValue3, null, PacketData, ref Index);
			Function.AddNodeItem(ref mNode, "Source Name", ref NodeValue5, null, PacketData, ref Index, 2, 0, PassNullBytes: true);
			Function.AddNodeItem(ref mNode, "Buffer Format", ref NodeValue3, null, PacketData, ref Index);
			Function.AddNodeItem(ref mNode, "Destination Name", ref NodeValue6, null, PacketData, ref Index, 2, 0, PassNullBytes: true);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserComMoveRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, string CommandName)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		int num = 0;
		byte NodeValue = 0;
		byte NodeValue2 = 0;
		ushort NodeValue3 = 0;
		ushort NodeValue4 = 0;
		string NodeValue5 = "";
		string NodeValue6 = "";
		ushort NodeValue7 = 0;
		ushort NodeValue8 = 0;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num = Index;
			Function.AddNodeItem(ref mNode, "Word Count ( Wct )", ref NodeValue, null, PacketData, ref Index);
			Function.AddNodeItem(ref mNode, "Target Id", ref NodeValue4, null, PacketData, ref Index, Const.CurFileType);
			Function.AddNodeItem(ref mNode, "Open Function", ref NodeValue7, null, PacketData, ref Index, Const.CurFileType);
			Function.AddNodeItem(ref mNode, "Copy Flags", ref NodeValue8, null, PacketData, ref Index, Const.CurFileType);
			Function.AddNodeItem(ref mNode, "Byte Count", ref NodeValue3, null, PacketData, ref Index, Const.CurFileType);
			Function.AddNodeItem(ref mNode, "Buffer Format", ref NodeValue2, null, PacketData, ref Index);
			Function.AddNodeItem(ref mNode, "Old Name", ref NodeValue6, null, PacketData, ref Index, 2, 0, PassNullBytes: true);
			Function.AddNodeItem(ref mNode, "Buffer Format", ref NodeValue2, null, PacketData, ref Index);
			Function.AddNodeItem(ref mNode, "New Name", ref NodeValue5, null, PacketData, ref Index, 2, 0, PassNullBytes: true);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserComEchoRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, string CommandName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		int num = 0;
		byte NodeValue = 0;
		ushort NodeValue2 = 0;
		ushort NodeValue3 = 0;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num = Index;
			Function.AddNodeItem(ref mNode, "Word Count ( Wct )", ref NodeValue, null, PacketData, ref Index);
			Function.AddNodeItem(ref mNode, "Echo Count", ref NodeValue3, null, PacketData, ref Index, Const.CurFileType);
			Function.AddNodeItem(ref mNode, "Byte Count", ref NodeValue2, null, PacketData, ref Index, Const.CurFileType);
			if (NodeValue2 != 0)
			{
				mNode.Nodes.Add("Data");
				Function.SetPosition(ref mNode, Index, PacketData.Length, BaseOrSub: false);
			}
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserWriteAndCloseRequest(ref TreeNode mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, string CommandName)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		int num = 0;
		byte NodeValue = 0;
		byte NodeValue2 = 0;
		ushort NodeValue3 = 0;
		uint NodeValue4 = 0u;
		uint NodeValue5 = 0u;
		ushort NodeValue6 = 0;
		ushort NodeValue7 = 0;
		string NodeValue8 = "";
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num = Index;
			Function.AddNodeItem(ref mNode, "Word Count ( Wct )", ref NodeValue, null, PacketData, ref Index);
			Function.AddNodeItem(ref mNode, "Fid", ref NodeValue7, null, PacketData, ref Index, Const.CurFileType);
			Function.AddNodeItem(ref mNode, "Write Count", ref NodeValue6, null, PacketData, ref Index, Const.CurFileType);
			Function.AddNodeItem(ref mNode, "Offset", ref NodeValue4, null, PacketData, ref Index, Const.CurFileType);
			Function.AddNodeItem(ref mNode, "Last Write Time", ref NodeValue5, null, PacketData, ref Index, Const.CurFileType);
			if (NodeValue == 12)
			{
				Function.AddNodeItem(ref mNode, "Reserved", ref NodeValue8, null, PacketData, ref Index, 8, 12, PassNullBytes: true);
			}
			Function.AddNodeItem(ref mNode, "Byte Count", ref NodeValue3, null, PacketData, ref Index, Const.CurFileType);
			Function.AddNodeItem(ref mNode, "Padding", ref NodeValue2, null, PacketData, ref Index);
			if (NodeValue3 != 0)
			{
				mNode.Nodes.Add("Data");
				Function.SetPosition(ref mNode, Index, PacketData.Length, BaseOrSub: false);
			}
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserWriteAndCloseResponse(ref TreeNode mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, string CommandName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		int num = 0;
		byte NodeValue = 0;
		ushort NodeValue2 = 0;
		ushort NodeValue3 = 0;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num = Index;
			Function.AddNodeItem(ref mNode, "Word Count ( Wct )", ref NodeValue, null, PacketData, ref Index);
			Function.AddNodeItem(ref mNode, "Write Count", ref NodeValue3, null, PacketData, ref Index, Const.CurFileType);
			Function.AddNodeItem(ref mNode, "Byte Count", ref NodeValue2, null, PacketData, ref Index, Const.CurFileType);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserUnknown(ref TreeNode mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, string CommandName)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		int num = 0;
		byte NodeValue = 0;
		ushort NodeValue2 = 0;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num = Index;
			Function.AddNodeItem(ref mNode, "Word Count ( Wct )", ref NodeValue, null, PacketData, ref Index);
			if (NodeValue != 0)
			{
				mNode.Nodes.Add("Word Parameters");
				Index += NodeValue * 2;
			}
			Function.AddNodeItem(ref mNode, "Byte Count", ref NodeValue2, null, PacketData, ref Index, Const.CurFileType);
			if (NodeValue2 != 0)
			{
				mNode.Nodes.Add("Byte Parameters");
				Index += NodeValue2;
			}
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool ParserEmpty(ref TreeNode mNode, byte[] PacketData, ref int Index, ref ListViewItem LItem, string CommandName)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		int num = 0;
		byte NodeValue = 0;
		ushort NodeValue2 = 0;
		try
		{
			mNode = new TreeNode();
			mNode.Text = CommandName;
			num = Index;
			Function.AddNodeItem(ref mNode, "Word Count ( Wct )", ref NodeValue, null, PacketData, ref Index);
			Function.AddNodeItem(ref mNode, "Byte Count", ref NodeValue2, null, PacketData, ref Index, Const.CurFileType);
			Function.SetPosition(ref mNode, num, Index - num, BaseOrSub: true);
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		//IL_1524: Unknown result type (might be due to invalid IL or missing references)
		//IL_152a: Expected O, but got Unknown
		//IL_1562: Unknown result type (might be due to invalid IL or missing references)
		//IL_1568: Expected O, but got Unknown
		//IL_15a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a6: Expected O, but got Unknown
		//IL_1939: Unknown result type (might be due to invalid IL or missing references)
		//IL_193f: Expected O, but got Unknown
		//IL_15de: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e4: Expected O, but got Unknown
		//IL_161c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1622: Expected O, but got Unknown
		//IL_0a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2a: Expected O, but got Unknown
		//IL_0a63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a69: Expected O, but got Unknown
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa8: Expected O, but got Unknown
		//IL_0acd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad3: Expected O, but got Unknown
		//IL_0b09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0f: Expected O, but got Unknown
		//IL_0b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Expected O, but got Unknown
		//IL_0b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b89: Expected O, but got Unknown
		//IL_0bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc6: Expected O, but got Unknown
		//IL_0bfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c03: Expected O, but got Unknown
		//IL_0c28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2e: Expected O, but got Unknown
		//IL_0c65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6b: Expected O, but got Unknown
		//IL_0c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c96: Expected O, but got Unknown
		//IL_0cc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccb: Expected O, but got Unknown
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d08: Expected O, but got Unknown
		//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d45: Expected O, but got Unknown
		//IL_0d6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d70: Expected O, but got Unknown
		//IL_0da6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dac: Expected O, but got Unknown
		//IL_0de5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0deb: Expected O, but got Unknown
		//IL_0e10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e16: Expected O, but got Unknown
		//IL_0e3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e41: Expected O, but got Unknown
		//IL_0e70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e76: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb3: Expected O, but got Unknown
		//IL_0ed8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ede: Expected O, but got Unknown
		//IL_0f03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f09: Expected O, but got Unknown
		//IL_0f4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f50: Expected O, but got Unknown
		//IL_0f87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8d: Expected O, but got Unknown
		//IL_0fb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb8: Expected O, but got Unknown
		//IL_0fdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe3: Expected O, but got Unknown
		//IL_1014: Unknown result type (might be due to invalid IL or missing references)
		//IL_101a: Expected O, but got Unknown
		//IL_105d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1063: Expected O, but got Unknown
		//IL_1089: Unknown result type (might be due to invalid IL or missing references)
		//IL_108f: Expected O, but got Unknown
		//IL_10b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bb: Expected O, but got Unknown
		//IL_10e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e7: Expected O, but got Unknown
		//IL_111f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1125: Expected O, but got Unknown
		//IL_1137: Unknown result type (might be due to invalid IL or missing references)
		//IL_113d: Expected O, but got Unknown
		//IL_114f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1155: Expected O, but got Unknown
		//IL_1167: Unknown result type (might be due to invalid IL or missing references)
		//IL_116d: Expected O, but got Unknown
		//IL_11a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11aa: Expected O, but got Unknown
		//IL_11db: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e1: Expected O, but got Unknown
		//IL_1224: Unknown result type (might be due to invalid IL or missing references)
		//IL_122a: Expected O, but got Unknown
		//IL_123c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1242: Expected O, but got Unknown
		//IL_165a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1660: Expected O, but got Unknown
		//IL_1698: Unknown result type (might be due to invalid IL or missing references)
		//IL_169e: Expected O, but got Unknown
		//IL_16d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16dc: Expected O, but got Unknown
		//IL_1713: Unknown result type (might be due to invalid IL or missing references)
		//IL_1719: Expected O, but got Unknown
		//IL_127a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1280: Expected O, but got Unknown
		//IL_12b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12be: Expected O, but got Unknown
		//IL_12f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fc: Expected O, but got Unknown
		//IL_1334: Unknown result type (might be due to invalid IL or missing references)
		//IL_133a: Expected O, but got Unknown
		//IL_1372: Unknown result type (might be due to invalid IL or missing references)
		//IL_1378: Expected O, but got Unknown
		//IL_13b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b6: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f4: Expected O, but got Unknown
		//IL_142c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1432: Expected O, but got Unknown
		//IL_146a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1470: Expected O, but got Unknown
		//IL_14a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ae: Expected O, but got Unknown
		//IL_14e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ec: Expected O, but got Unknown
		//IL_1751: Unknown result type (might be due to invalid IL or missing references)
		//IL_1757: Expected O, but got Unknown
		//IL_178e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1794: Expected O, but got Unknown
		//IL_17cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d1: Expected O, but got Unknown
		//IL_1809: Unknown result type (might be due to invalid IL or missing references)
		//IL_180f: Expected O, but got Unknown
		//IL_1847: Unknown result type (might be due to invalid IL or missing references)
		//IL_184d: Expected O, but got Unknown
		//IL_1885: Unknown result type (might be due to invalid IL or missing references)
		//IL_188b: Expected O, but got Unknown
		//IL_18c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c9: Expected O, but got Unknown
		//IL_18fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1904: Expected O, but got Unknown
		bool isUnicode = false;
		bool flag = false;
		TreeNode mNodeSubNode = new TreeNode();
		TreeNode mNodeSubNode2 = new TreeNode();
		string text = "";
		int num = 0;
		int num2 = 0;
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "SMB ( Server Message Block Protocol )";
		try
		{
			num = Index;
			PACKET_SMB_HEADER pACKET_SMB_HEADER = default(PACKET_SMB_HEADER);
			pACKET_SMB_HEADER.ServerComponent = "";
			Index++;
			pACKET_SMB_HEADER.ServerComponent += (char)PacketData[Index++];
			pACKET_SMB_HEADER.ServerComponent += (char)PacketData[Index++];
			pACKET_SMB_HEADER.ServerComponent += (char)PacketData[Index++];
			TreeNode mNode3 = new TreeNode();
			mNode3.Text = "SMB Header";
			text = "Server Component :" + pACKET_SMB_HEADER.ServerComponent;
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
			pACKET_SMB_HEADER.Command = PacketData[Index++];
			text = "Command :" + Function.ReFormatString(pACKET_SMB_HEADER.Command, Const.GetSmbCommandString(pACKET_SMB_HEADER.Command));
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
			Index += 5;
			pACKET_SMB_HEADER.Flags2 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			if ((pACKET_SMB_HEADER.Flags2 & 0x8000) > 0)
			{
				isUnicode = true;
			}
			Index -= 7;
			if ((pACKET_SMB_HEADER.Flags2 & 0x4000) > 0)
			{
				pACKET_SMB_HEADER.NtStatus = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
				text = "NT Status :" + Function.ReFormatString(pACKET_SMB_HEADER.NtStatus, null);
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 4, 4, BaseOrSub: false);
			}
			else
			{
				pACKET_SMB_HEADER.ErrorClass = PacketData[Index++];
				text = "Error Class :" + Function.ReFormatString(pACKET_SMB_HEADER.ErrorClass, null);
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
				pACKET_SMB_HEADER.Reserved1 = PacketData[Index++];
				text = "Reserved :" + Function.ReFormatString(pACKET_SMB_HEADER.Reserved1, null);
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 1, 1, BaseOrSub: false);
				pACKET_SMB_HEADER.ErrorCode = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
				text = "Error Code :" + Function.ReFormatString(pACKET_SMB_HEADER.ErrorCode, null);
				mNode3.Nodes.Add(text);
				Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			}
			pACKET_SMB_HEADER.Flags = PacketData[Index++];
			flag = (pACKET_SMB_HEADER.Flags & 0x80) == 0;
			TreeNode mNode4 = new TreeNode();
			mNode4.Text = "Flags :" + Function.ReFormatString(pACKET_SMB_HEADER.Flags, null);
			Function.SetPosition(ref mNode4, Index - 1, 1, BaseOrSub: true);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_SMB_HEADER.Flags, 128, "Request/Response : Message is a response to the user", "Request/Response : Message is a request to the user"));
			Function.SetPosition(ref mNode4, Index - 1, 1, BaseOrSub: false);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_SMB_HEADER.Flags, 64, "Notify : Notify client", "Notify : Notify client only on open"));
			Function.SetPosition(ref mNode4, Index - 1, 1, BaseOrSub: false);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_SMB_HEADER.Flags, 32, "Oplocks : Oplock requested/granted", "Oplocks : Oplock not requested/granted"));
			Function.SetPosition(ref mNode4, Index - 1, 1, BaseOrSub: false);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_SMB_HEADER.Flags, 16, "Canonicalized Path Names : Path names are canonicalized", "Canonicalized Path Names : Path names are not canonicalized"));
			Function.SetPosition(ref mNode4, Index - 1, 1, BaseOrSub: false);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_SMB_HEADER.Flags, 8, "Path names are not case sensitive", "Case Sensitivity : Path names not case sensitive"));
			Function.SetPosition(ref mNode4, Index - 1, 1, BaseOrSub: false);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_SMB_HEADER.Flags, 2, "Receive Buffer Posted : Receive buffer has been posted", "Receive Buffer Posted : Receive buffer has not been posted"));
			Function.SetPosition(ref mNode4, Index - 1, 1, BaseOrSub: false);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_SMB_HEADER.Flags, 1, "Locak And Read : Lock&Read, Write&Lock are supported", "Locak And Read : Lock&Read, Write&Lock are not supported"));
			Function.SetPosition(ref mNode4, Index - 1, 1, BaseOrSub: false);
			mNode3.Nodes.Add(mNode4);
			Index += 2;
			mNode4 = new TreeNode();
			mNode4.Text = "Flags 2 :" + Function.ReFormatString(pACKET_SMB_HEADER.Flags2, null);
			Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: true);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_SMB_HEADER.Flags2, 32768, "Unicode Strings : Strings are UNICODE", "Unicode Strings : Strings are ASCII"));
			Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_SMB_HEADER.Flags2, 16384, "Error Code Type : Error codes are not DOS error codes", "Error Code Type : Error codes are DOS error codes"));
			Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_SMB_HEADER.Flags2, 8192, "Execute-only Reads : Permit reads", "Execute-only Reads : Don't permit reads if execute only"));
			Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_SMB_HEADER.Flags2, 4096, "Dfs : Resolve pathnames with Dfs", "Dfs : Don't resolve pathnames with Dfs"));
			Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_SMB_HEADER.Flags2, 2048, "Extended Security Negotiation : Extended security negotiation is supported", "Extended Security Negotiation : Extended security negotiation is not supported"));
			Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_SMB_HEADER.Flags2, 64, "Long Names Used : Path names in request are long file names", "Long Names Used : Path names in request are not long file names"));
			Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_SMB_HEADER.Flags2, 4, "Sequrity Signatures : Sequrity signatures are supported", "Sequrity Signatures : Sequrity signatures are not supported"));
			Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_SMB_HEADER.Flags2, 2, "Extended Attributes : Extended attributes are supported", "Extended Attributes : Extended attributes are not supported"));
			Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
			mNode4.Nodes.Add(Function.DecodeBitField(pACKET_SMB_HEADER.Flags2, 1, "Long Names Allowed : Long file names are allowed in response", "Long Names Allowed : Long file names are not allowed in response"));
			Function.SetPosition(ref mNode4, Index - 2, 2, BaseOrSub: false);
			mNode3.Nodes.Add(mNode4);
			pACKET_SMB_HEADER.Reserved2 = "";
			for (num2 = 0; num2 < 12; num2++)
			{
				pACKET_SMB_HEADER.Reserved2 += PacketData[Index++].ToString("x02");
			}
			text = "Reserved :" + pACKET_SMB_HEADER.Reserved2;
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 12, 12, BaseOrSub: false);
			pACKET_SMB_HEADER.TreeId = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Tree Id :" + Function.ReFormatString(pACKET_SMB_HEADER.TreeId, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_SMB_HEADER.ProcessId = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Process Id :" + Function.ReFormatString(pACKET_SMB_HEADER.ProcessId, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_SMB_HEADER.UserId = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "User Id :" + Function.ReFormatString(pACKET_SMB_HEADER.UserId, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			pACKET_SMB_HEADER.MultiplexId = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			text = "Multiplex Id :" + Function.ReFormatString(pACKET_SMB_HEADER.MultiplexId, null);
			mNode3.Nodes.Add(text);
			Function.SetPosition(ref mNode3, Index - 2, 2, BaseOrSub: false);
			mNode2.Nodes.Add(mNode3);
			Function.SetPosition(ref mNode2, num, Index - num, BaseOrSub: true);
			switch (pACKET_SMB_HEADER.Command)
			{
			case 0:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserCreateDirectory(ref mNode3, PacketData, ref Index, "Create Directory", isUnicode);
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 1:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserCreateDirectory(ref mNode3, PacketData, ref Index, "Delete Directory", isUnicode);
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 2:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserOpenFileRequest(ref mNode3, PacketData, ref Index, "Open File Request");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 3:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserCreateFileRequest(ref mNode3, PacketData, ref Index, "Create File Request");
				}
				else
				{
					ParserFid(ref mNode3, PacketData, ref Index, "Create File Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 4:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserCloseFileRequest(ref mNode3, PacketData, ref Index, "Close File");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 5:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserFid(ref mNode3, PacketData, ref Index, "Fid");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 6:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserDeleteFileRequest(ref mNode3, PacketData, ref Index, "Delete File");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 7:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserRenameFileRequest(ref mNode3, PacketData, ref Index, "Rename File");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 8:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserQueryInformationRequest(ref mNode3, PacketData, ref Index, "Query Information Request");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 9:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserSetInformationRequest(ref mNode3, PacketData, ref Index, "Set Information");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 10:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserReadFileRequest(ref mNode3, PacketData, ref Index, "Read File Request");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 11:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserWriteFileRequest(ref mNode3, ref mNode4, ref LItem, PacketData, ref Index, "Write File Request", pACKET_SMB_HEADER.Flags2);
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 12:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserLockFileRequest(ref mNode3, PacketData, ref Index, "Write File");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 13:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserLockFileRequest(ref mNode3, PacketData, ref Index, "Write File");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 14:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserCreateTemporaryRequest(ref mNode3, PacketData, ref Index, "Write File Request");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 15:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserCreateFileRequest(ref mNode3, PacketData, ref Index, "Create New File");
				}
				else
				{
					ParserFid(ref mNode3, PacketData, ref Index, "Fid");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 16:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserCreateDirectory(ref mNode3, PacketData, ref Index, "Check Directory", isUnicode);
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 18:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserSeekFileRequest(ref mNode3, PacketData, ref Index, "Seek File Request");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 19:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserReadFileRequest(ref mNode3, PacketData, ref Index, "Lock And Read Request");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 20:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserWriteFileRequest(ref mNode3, ref mNode4, ref LItem, PacketData, ref Index, "Write File Request", pACKET_SMB_HEADER.Flags2);
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 26:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserReadRawRequest(ref mNode3, PacketData, ref Index, "Read Raw");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 27:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserReadMpxRequest(ref mNode3, PacketData, ref Index, "Read Mpx Request");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 29:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserWriteRawRequest(ref mNode3, PacketData, ref Index, "Write Raw Request");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 30:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserWriteMpxRequest(ref mNode3, PacketData, ref Index, "Write Mpx Request");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 32:
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Request");
				}
				break;
			case 34:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserSetInformation2Request(ref mNode3, PacketData, ref Index, "Set Information 2");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 35:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserFid(ref mNode3, PacketData, ref Index, "Fid");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 36:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserLockingAndXRequest(ref mNode3, PacketData, ref Index, "Locking And X Request");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 37:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserTransactionRequest(ref mNode3, PacketData, ref Index, ref LItem, pACKET_SMB_HEADER.Command, "Transaction Request", ref mNodeSubNode, ref mNodeSubNode2);
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 38:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserTransactionRequest(ref mNode3, PacketData, ref Index, ref LItem, pACKET_SMB_HEADER.Command, "Transaction Request ( Secondary )", ref mNodeSubNode, ref mNodeSubNode2);
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 41:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserComCopyRequest(ref mNode3, PacketData, ref Index, ref LItem, "Com Copy Request");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 42:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserComMoveRequest(ref mNode3, PacketData, ref Index, ref LItem, "Com Move Request");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 43:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserComEchoRequest(ref mNode3, PacketData, ref Index, ref LItem, "Com Echo Request");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 44:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserWriteAndCloseRequest(ref mNode3, PacketData, ref Index, ref LItem, "Write And Close Request");
				}
				else
				{
					ParserWriteAndCloseResponse(ref mNode3, PacketData, ref Index, ref LItem, "Write And Close Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 45:
				mNode3 = new TreeNode();
				mNode2.Nodes.Add(mNode3);
				break;
			case 46:
				mNode3 = new TreeNode();
				mNode2.Nodes.Add(mNode3);
				break;
			case 47:
				mNode3 = new TreeNode();
				mNode2.Nodes.Add(mNode3);
				break;
			case 49:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserCloseFileRequest(ref mNode3, PacketData, ref Index, "Close And Tree Disconnect");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 50:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserTransactionRequest(ref mNode3, PacketData, ref Index, ref LItem, pACKET_SMB_HEADER.Command, "Transaction Request", ref mNodeSubNode, ref mNodeSubNode2);
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 51:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserTransactionRequest(ref mNode3, PacketData, ref Index, ref LItem, pACKET_SMB_HEADER.Command, "Transaction Request ( Secondary )", ref mNodeSubNode, ref mNodeSubNode2);
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 52:
				mNode3 = new TreeNode();
				mNode2.Nodes.Add(mNode3);
				break;
			case 53:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Request");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 112:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 113:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 114:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 115:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 116:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 117:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 128:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 129:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 130:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 131:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 132:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 160:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 161:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 162:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 164:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 165:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 192:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 193:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 194:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserFid(ref mNode3, PacketData, ref Index, "Fid");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 195:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 208:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserSendSingleBlockMessageRequest(ref mNode3, PacketData, ref Index, "Send Single Block Message Request");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 209:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserSendSingleBlockMessageRequest(ref mNode3, PacketData, ref Index, "Send Broadcast Message Request");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 210:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 211:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 212:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 213:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 214:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			case 215:
				mNode3 = new TreeNode();
				if (flag)
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				else
				{
					ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Response");
				}
				mNode2.Nodes.Add(mNode3);
				break;
			default:
				mNode3 = new TreeNode();
				ParserUnknown(ref mNode3, PacketData, ref Index, ref LItem, "Unknown Request");
				mNode2.Nodes.Add(mNode3);
				break;
			}
			LItem.Protocol = "SMB";
			LItem.Info = "SMB protocol";
			mNode.Add(mNode2);
			if (mNodeSubNode.Text != "")
			{
				mNode.Add(mNodeSubNode);
			}
			if (mNodeSubNode2.Text != "")
			{
				mNode.Add(mNodeSubNode2);
			}
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed SMB packet. Remaining bytes don't fit an SMB packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.Info = "[ Malformed SMB packet. Remaining bytes don't fit an SMB packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}
}
