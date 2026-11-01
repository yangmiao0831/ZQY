using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketHTTP
{
	public struct PACKET_HTTP
	{
		public string[] Contents;
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, bool DisplayData)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		string text = "";
		int num = 0;
		int num2 = 0;
		char[] separator = new char[2] { '\r', '\n' };
		num = PacketData.GetLength(0) - Index;
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "HTTP ( Hyper Text Transfer Protocol )";
		Function.SetPosition(ref mNode2, Index, PacketData.Length - Index, BaseOrSub: true);
		try
		{
			for (num2 = 0; num2 < num; num2++)
			{
				text = ((!((PacketData[Index] > 31) | (PacketData[Index] < 129) | (PacketData[Index] == 13) | (PacketData[Index] == 10))) ? (text + " ") : (text + (char)PacketData[Index]));
				Index++;
			}
			PACKET_HTTP pACKET_HTTP = default(PACKET_HTTP);
			pACKET_HTTP.Contents = text.Split(separator);
			if (DisplayData)
			{
				for (num2 = 0; num2 < pACKET_HTTP.Contents.GetLength(0); num2++)
				{
					text = (string)pACKET_HTTP.Contents.GetValue(num2);
					text = text.Trim();
					if (text != "")
					{
						mNode2.Nodes.Add(text + "\\r\\n");
					}
				}
			}
			else
			{
				mNode2.Nodes.Add("Continutiation Message");
			}
			LItem.Protocol = "HTTP";
			LItem.Info = pACKET_HTTP.Contents[0];
			mNode.Add(mNode2);
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed HTTP packet. Remaining bytes don't fit an HTTP packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.Info = "[ Malformed HTTP packet. Remaining bytes don't fit an HTTP packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, bool DisplayData)
	{
		string text = "";
		int num = 0;
		int num2 = 0;
		char[] separator = new char[2] { '\r', '\n' };
		num = PacketData.GetLength(0) - Index;
		try
		{
			for (num2 = 0; num2 < num; num2++)
			{
				text = ((!((PacketData[Index] > 31) | (PacketData[Index] < 129) | (PacketData[Index] == 13) | (PacketData[Index] == 10))) ? (text + " ") : (text + (char)PacketData[Index]));
				Index++;
			}
			PACKET_HTTP pACKET_HTTP = default(PACKET_HTTP);
			pACKET_HTTP.Contents = text.Split(separator);
			LItem.Protocol = "HTTP";
			LItem.Info = pACKET_HTTP.Contents[0];
		}
		catch
		{
			text = "[ Malformed HTTP packet. Remaining bytes don't fit an HTTP packet. Possibly due to bad decoding ]";
			LItem.Info = "[ Malformed HTTP packet. Remaining bytes don't fit an HTTP packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}
}
