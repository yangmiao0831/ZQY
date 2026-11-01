using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MyClasses;

public class PacketParser
{
	public struct PACKET_MESSAGE_ITEM
	{
		public string Date;

		public string Time;

		public string SenderIpAddress;

		public string SenderCopmuterName;

		public string ReceiverIpAddress;

		public string ReceiverComputerName;

		public string MessageTime;

		public int MessageLength;

		public string Message;
	}

	public struct PACKET_STATISTIC
	{
		public int Count;

		public string CaptureTimeStr;

		public int CaptureLength;
	}

	public ArrayList PacketCollection;

	public ArrayList MessageCollection;

	public ListView LVw;

	public TreeNodeCollection mNode;

	public RichTextBox Rtx;

	public byte[] PacketBufferData;

	public bool StopCapture;

	public bool PacketOnOff;

	public Packet32.CAPTURE_OPTIONS mCaptureOptions;

	public Packet32.DISPLAY_OPTIONS mDisplayOptions;

	public int CurrentPacketBufferDataIndex;

	public PACKET_ITEM PItem;

	public PACKET_MESSAGE_ITEM PMsgItem;

	private ulong FirstSeconds;

	private ulong FirstMiliSeconds;

	private ulong FirstLongValue;

	public uint PreviousHttpSequence;

	public ushort LastTftpPort;

	public List<byte> CacheDataList;

	public bool hasDone;

	public PacketParser()
	{
		PacketCollection = new ArrayList();
		MessageCollection = new ArrayList();
		CacheDataList = new List<byte>();
	}

	public static int Packet_WORDALIGN(int x)
	{
		return (int)(((long)x + 3L) & 0xFFFFFFFCu);
	}

	public void Parse()
	{
		ParseOff();
	}

	public void ParseOff()
	{
		int Index = 0;
		uint num = 0u;
		uint num2 = 0u;
		ulong num3 = 0uL;
		ulong num4 = 0uL;
		ulong num5 = 0uL;
		int num6 = 0;
		PacketCollection.Clear();
		_ = PacketCollection.Count;
		do
		{
			hasDone = false;
			if (!FRAMEParser(PacketBufferData, ref Index))
			{
				break;
			}
			if (PacketCollection.Count == 0)
			{
				FirstSeconds = PItem.Seconds;
				FirstMiliSeconds = PItem.MicroSeconds;
				FirstLongValue = FirstSeconds;
				FirstLongValue *= 1000000uL;
				FirstLongValue += FirstMiliSeconds;
				PItem.CaptureTimeStr = "0.000000";
				PItem.Time = PItem.CaptureTimeStr;
			}
			else
			{
				num3 = PItem.Seconds;
				num3 *= 1000000;
				num3 += PItem.MicroSeconds;
				num4 = num3 - FirstLongValue;
				num5 = num4 / 1000000;
				num = (uint)num5;
				num5 *= 1000000;
				num5 = num4 - num5;
				PItem.CaptureTimeStr = num + "." + ((uint)num5).ToString("d6");
				PItem.Time = PItem.CaptureTimeStr;
			}
			PItem.TypeInfo = "Other";
			PacketETHERNET.Parser(PItem.Data, ref PItem, ref PItem.TypeInfo, ref PreviousHttpSequence, ref LastTftpPort);
			num6++;
			lock (PacketCollection)
			{
				PacketCollection.Add(PItem);
			}
			_ = PacketCollection.Count;
		}
		while (Index < PacketBufferData.Length);
		hasDone = true;
	}

	public void ParseNetSend()
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		uint num4 = 0u;
		uint num5 = 0u;
		int num6 = 0;
		int num7 = 0;
		ushort num8 = 0;
		byte b = 0;
		string text = "";
		string text2 = "";
		ushort num9 = 0;
		ushort num10 = 0;
		byte b2 = 0;
		ushort num11 = 0;
		string text3 = "";
		byte b3 = 0;
		string text4 = "";
		string text5 = "";
		ushort num12 = 0;
		string text6 = "";
		string text7 = "";
		string text8 = "";
		num2 = 0;
		do
		{
			num4 = Function.Get4Bytes(PacketBufferData, ref num2, Const.CurFileType);
			Function.Get4Bytes(PacketBufferData, ref num2, Const.CurFileType);
			num5 = Function.Get4Bytes(PacketBufferData, ref num2, Const.CurFileType);
			Function.Get4Bytes(PacketBufferData, ref num2, Const.CurFileType);
			Function.Get4Bytes(PacketBufferData, ref num2, Const.CurFileType);
			byte[] array = new byte[num5];
			num6 = 0;
			for (num6 = 0; num6 < num5; num6++)
			{
				array[num6] = PacketBufferData[num2++];
			}
			if (num5 >= 130)
			{
				num7 = 12;
				num8 = Function.Get2Bytes(array, ref num7, Const.CurFileType);
				if (num8 == 2048)
				{
					b = array[23];
					if (b == 6)
					{
						num7 = 26;
						text = Function.GetIpAddress(array, ref num7);
						num7 = 30;
						text2 = Function.GetIpAddress(array, ref num7);
						num7 = 34;
						num9 = Function.Get2Bytes(array, ref num7, Const.CurFileType);
						num7 = 36;
						num10 = Function.Get2Bytes(array, ref num7, Const.CurFileType);
						if ((num9 == 139 || num10 == 139) && array[54] == 0)
						{
							num7 = 56;
							num11 = Function.Get2Bytes(array, ref num7, Const.CurFileType);
							if (num11 > 0)
							{
								text3 = "";
								text3 += (char)array[59];
								text3 += (char)array[60];
								text3 += (char)array[61];
								if (text3 == "SMB")
								{
									b3 = array[62];
									if (b3 == 208)
									{
										num7 = 94;
										text4 = Function.GetString(array, ref num7);
										num7++;
										text5 = Function.GetString(array, ref num7);
										num7++;
										num12 = Function.Get2Bytes(array, ref num7, Const.CurFileType);
										text6 = Function.GetString(array, ref num7, num12);
										Function.GetDateTime(num4, ref PMsgItem.Date, ref PMsgItem.Time);
										PMsgItem.Message = text6;
										PMsgItem.MessageLength = text6.Length;
										PMsgItem.MessageTime = "";
										PMsgItem.ReceiverComputerName = text5;
										PMsgItem.ReceiverIpAddress = text2;
										PMsgItem.SenderCopmuterName = text4;
										PMsgItem.SenderIpAddress = text;
										text7 = "";
										text8 = "";
										Function.GetDateTime(num4, ref text7, ref text8);
										ListViewItem val = LVw.Items.Add(num3.ToString());
										val.Text = text7;
										val.SubItems.Add(text8);
										val.SubItems.Add(PMsgItem.SenderCopmuterName);
										val.SubItems.Add(PMsgItem.SenderIpAddress);
										val.SubItems.Add(PMsgItem.ReceiverComputerName);
										val.SubItems.Add(PMsgItem.ReceiverIpAddress);
										val.SubItems.Add(PMsgItem.MessageLength.ToString());
										val.SubItems.Add(PMsgItem.Message);
										num3 = LVw.Items.Count - 1;
										if (mDisplayOptions.UpdateListInRealTime)
										{
											LVw.EnsureVisible(num3);
										}
										((Control)Rtx).Text = PMsgItem.Message;
										MessageCollection.Add(PMsgItem);
										_ = MessageCollection.Count;
									}
								}
							}
						}
					}
				}
			}
			num = (int)(20 + num5);
			num = Packet_WORDALIGN(num);
			num -= (int)(20 + num5);
			num2 += num;
		}
		while (num2 < PacketBufferData.Length);
	}

	public bool WriteFRAMENode(ref TreeNodeCollection mNode, PACKET_ITEM PItem, ref PACKET_ITEM LItem)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		string text = "";
		mNode.Clear();
		TreeNode val = new TreeNode();
		try
		{
			text = " Seconds : " + PItem.Seconds;
			val.Nodes.Add(text);
			text = " Microseconds : " + PItem.MicroSeconds;
			val.Nodes.Add(text);
			text = " Captured Length : " + PItem.CaptureLength;
			val.Nodes.Add(text);
			text = " Packet Length : " + PItem.PacketLength;
			val.Nodes.Add(text);
			text = "FRAME ( Captured : " + PItem.CaptureLength + " , Original : " + PItem.PacketLength + " )";
			val.Text = text;
			val.Tag = "0," + PItem.CaptureLength;
			mNode.Add(val);
		}
		catch
		{
			mNode.Add(val);
			text = "[ Malformed FRAME packet. Remaining bytes don't fit an FRAME packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			LItem.Info = "[ Malformed FRAME packet. Remaining bytes don't fit an FRAME packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public void ParseSingle(ref PACKET_ITEM LItem)
	{
		if (PacketCollection != null && PacketCollection.Count != 0)
		{
			((Control)Rtx).Text = "";
			((TextBoxBase)Rtx).AppendText(Function.GetHexString(LItem.Data));
			WriteFRAMENode(ref mNode, LItem, ref LItem);
			PacketETHERNET.Parser(ref mNode, LItem.Data, ref LItem, ref PreviousHttpSequence, ref LastTftpPort);
			Function.ArrangeText(ref mNode, ":");
		}
	}

	public bool FRAMEParser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref ListViewItem LItem)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		string text = "";
		int num = 0;
		mNode.Clear();
		TreeNode val = new TreeNode();
		try
		{
			PItem.Seconds = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType) + Const.TimeZone8HourSecs;
			text = " Seconds : " + PItem.Seconds;
			val.Nodes.Add(text);
			PItem.MicroSeconds = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = " Microseconds : " + PItem.MicroSeconds;
			val.Nodes.Add(text);
			PItem.CaptureLength = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = " Captured Length : " + PItem.CaptureLength;
			val.Nodes.Add(text);
			PItem.PacketLength = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			text = " Packet Length : " + PItem.PacketLength;
			val.Nodes.Add(text);
			PItem.Reserved = 0u;
			if (PacketOnOff)
			{
				PItem.Reserved = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			}
			text = "FRAME ( Captured : " + PItem.CaptureLength + " , Original : " + PItem.PacketLength + " )";
			val.Text = text;
			val.Tag = "0," + PItem.CaptureLength;
			PItem.CaptureTimeStr = "";
			if (!PacketOnOff)
			{
				Index -= 16;
				PItem.FrameData = new byte[16];
				for (num = 0; num < 16; num++)
				{
					PItem.FrameData[num] = PacketData[Index++];
				}
			}
			else
			{
				Index -= 20;
				PItem.FrameData = new byte[20];
				for (num = 0; num < 20; num++)
				{
					PItem.FrameData[num] = PacketData[Index++];
				}
			}
			PItem.Data = new byte[PItem.CaptureLength];
			for (num = 0; num < PItem.CaptureLength; num++)
			{
				PItem.Data[num] = PacketData[Index++];
			}
			LItem.SubItems[9].Text = "Fram Data";
			mNode.Add(val);
		}
		catch (Exception ex)
		{
			mNode.Add(val);
			text = "[ Malformed FRAME packet. Remaining bytes don't fit an FRAME packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.SubItems[9].Text = "[ Malformed FRAME packet. Remaining bytes don't fit an FRAME packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public bool FRAMEParser(byte[] PacketData, ref int Index)
	{
		int num = 0;
		int num2 = Index;
		try
		{
			PItem = new PACKET_ITEM();
			PItem.Seconds = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType) + Const.TimeZone8HourSecs;
			PItem.MicroSeconds = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			PItem.CaptureLength = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			PItem.PacketLength = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			if (PItem.CaptureLength > 10000000)
			{
				return false;
			}
			PItem.Reserved = 0u;
			if (PacketOnOff)
			{
				PItem.Reserved = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
			}
			PItem.CaptureTimeStr = "";
			if (!PacketOnOff)
			{
				Index -= 16;
				PItem.FrameData = new byte[16];
				for (num = 0; num < 16; num++)
				{
					PItem.FrameData[num] = PacketData[Index++];
				}
			}
			else
			{
				Index -= 20;
				PItem.FrameData = new byte[20];
				for (num = 0; num < 20; num++)
				{
					PItem.FrameData[num] = PacketData[Index++];
				}
			}
			PItem.Data = new byte[PItem.CaptureLength];
			for (num = 0; num < PItem.CaptureLength; num++)
			{
				PItem.Data[num] = PacketData[Index++];
			}
		}
		catch (Exception)
		{
			byte[] array = new byte[PacketData.Length - num2];
			Array.Copy(PacketData, num2, array, 0, PacketData.Length - num2);
			CacheDataList.AddRange(array);
			return false;
		}
		return true;
	}

	public string ReadManufacturer(string Srch)
	{
		StreamReader streamReader = new StreamReader("WellKnown.txt");
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		int num = 0;
		while (streamReader.Peek() != -1)
		{
			text = streamReader.ReadLine();
			if (text.IndexOf(Srch) >= 0)
			{
				num = Srch.Length;
				text2 = text.Substring(num, text.Length - num);
				streamReader.Close();
				return text2;
			}
		}
		streamReader.Close();
		if (text2 == "")
		{
			text3 = Srch.Substring(0, 8);
			text4 = Srch.Substring(9, 8);
			streamReader = new StreamReader("Manufacturers.txt");
			while (streamReader.Peek() != -1)
			{
				text = streamReader.ReadLine();
				if (text.IndexOf(text3) >= 0)
				{
					num = text.IndexOf("#");
					num = ((num <= 0) ? (text.Length - 9) : (num - 9));
					text2 = text.Substring(9, num);
					text2 = text2 + "_" + text4;
					streamReader.Close();
					return text2;
				}
			}
		}
		streamReader.Close();
		return Srch;
	}
}
