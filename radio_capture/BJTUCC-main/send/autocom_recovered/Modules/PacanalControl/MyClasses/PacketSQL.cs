using System;
using System.Windows.Forms;

namespace MyClasses;

public class PacketSQL
{
	public struct PACKET_SQL
	{
		public byte type;

		public byte responseType;

		public string sql;
	}

	private static string DecodeType(int i)
	{
		string text = "Unknown";
		switch (i)
		{
		case 239:
			return "nchar";
		case 38:
			return "int (check length for type of int)";
		case 48:
			return "tinyint";
		case 56:
			return "int";
		case 34:
			return "image";
		case 35:
			return "text";
		case 108:
			return "numeric";
		case 52:
			return "smallint";
		case 127:
			return "bigint";
		case 111:
			return "datetime (check length for type of datetime)";
		case 58:
			return "smalldatetime";
		case 61:
			return "datetime";
		case 167:
			return "varchar";
		case 175:
			return "char";
		case 50:
		case 104:
			return "bit";
		case 59:
			return "real";
		case 62:
			return "float";
		case 109:
			return "float (check length for type of float)";
		case 165:
			return "varbinary";
		case 122:
			return "smallmoney";
		case 98:
			return "sqlvariant";
		case 106:
			return "decimal";
		case 36:
			return "uniqueidentifier";
		case 60:
			return "money";
		case 99:
			return "ntext";
		case 173:
			return "binary/timestamp";
		case 110:
			return "money (check length for type of money)";
		case 231:
			return "nvarchar";
		default:
			return "Unknown : " + i;
		}
	}

	private static void ProcessCol(ref TreeNode mNodey, byte[] PacketData, ref int Index)
	{
		Dump2ByteInt("Usertype id : ", mNodey, PacketData, ref Index);
		int num = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
		string text = "Flags : ";
		if ((num & 1) != 0)
		{
			text += " nullable,";
		}
		if ((num & 2) != 0)
		{
			text += " case sensitive,";
		}
		if ((num & 4) != 0 || (num & 8) != 0)
		{
			text += " is writable,";
		}
		if ((num & 0x10) != 0)
		{
			text += " auto increment,";
		}
		mNodey.Nodes.Add(text);
		Function.SetPosition(ref mNodey, Index - 2, 2, BaseOrSub: false);
		int num2 = PacketData[Index++];
		string text2 = DecodeType(num2);
		mNodey.Nodes.Add("Datatype : " + text2);
		Function.SetPosition(ref mNodey, Index - 1, 1, BaseOrSub: false);
		switch (num2)
		{
		case 35:
		case 99:
		{
			Dump4ByteInt("Unknown : ", mNodey, PacketData, ref Index);
			Dump1ByteInt("Unknown : ", mNodey, PacketData, ref Index);
			Dump4ByteInt("Column size : ", mNodey, PacketData, ref Index);
			int msglen = Dump2ByteInt("Column table length : ", mNodey, PacketData, ref Index);
			DumpString("Column table name : ", mNodey, PacketData, ref Index, msglen);
			break;
		}
		case 98:
			Dump4ByteInt("Unknown : ", mNodey, PacketData, ref Index);
			break;
		case 34:
		{
			Dump4ByteInt("Column size : ", mNodey, PacketData, ref Index);
			int msglen2 = Dump2ByteInt("Column table length : ", mNodey, PacketData, ref Index);
			DumpString("Column table name : ", mNodey, PacketData, ref Index, msglen2);
			break;
		}
		case 106:
		case 108:
			Dump1ByteInt("Column size : ", mNodey, PacketData, ref Index);
			Dump1ByteInt("Precision : ", mNodey, PacketData, ref Index);
			Dump1ByteInt("Scale : ", mNodey, PacketData, ref Index);
			break;
		case 36:
		case 38:
		case 104:
		case 109:
		case 110:
		case 111:
			Dump1ByteInt("Column size : ", mNodey, PacketData, ref Index);
			break;
		case 165:
		case 173:
			Dump2ByteInt("Column size : ", mNodey, PacketData, ref Index);
			break;
		default:
			if ((num2 & 0x80) != 0)
			{
				Dump2ByteInt("Column size : ", mNodey, PacketData, ref Index);
				Dump4ByteInt("Unknown : ", mNodey, PacketData, ref Index);
				Dump1ByteInt("Unknown : ", mNodey, PacketData, ref Index);
			}
			break;
		}
		int msglen3 = Dump1ByteInt("Column name length : ", mNodey, PacketData, ref Index);
		DumpString("Column name : ", mNodey, PacketData, ref Index, msglen3);
	}

	private static int ProcessTable(ref TreeNode mNodex, byte[] PacketData, ref int Index)
	{
		int num = Dump2ByteInt("Table name length : ", mNodex, PacketData, ref Index);
		DumpString("Table name : ", mNodex, PacketData, ref Index, num);
		return 2 + num * 2 + 1;
	}

	private static int Dump1ByteInt(string desc, TreeNode mNodex, byte[] PacketData, ref int Index)
	{
		int result = PacketData[Index++];
		mNodex.Nodes.Add(desc + result);
		Function.SetPosition(ref mNodex, Index - 1, 1, BaseOrSub: false);
		return result;
	}

	private static int Dump2ByteInt(string desc, TreeNode mNodex, byte[] PacketData, ref int Index)
	{
		int result = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
		mNodex.Nodes.Add(desc + result);
		Function.SetPosition(ref mNodex, Index - 2, 2, BaseOrSub: false);
		return result;
	}

	private static ulong Dump4ByteInt(string desc, TreeNode mNodex, byte[] PacketData, ref int Index)
	{
		ulong result = Function.Get4Bytes(PacketData, ref Index, Const.CurFileType);
		mNodex.Nodes.Add(desc + result);
		Function.SetPosition(ref mNodex, Index - 4, 4, BaseOrSub: false);
		return result;
	}

	private static string DumpString(string desc, TreeNode mNodex, byte[] PacketData, ref int Index, int msglen)
	{
		string text = Function.GetString(PacketData, ref Index, IsUnicode: true, msglen * 2);
		mNodex.Nodes.Add(desc + text);
		Function.SetPosition(ref mNodex, Index - msglen * 2, msglen * 2, BaseOrSub: false);
		return text;
	}

	private static bool Process4(ref TreeNode mNodex, byte[] PacketData, ref int Index)
	{
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected O, but got Unknown
		int num = PacketData[Index++];
		string empty = string.Empty;
		empty = num switch
		{
			33 => "language packet", 
			113 => "Logout", 
			121 => "TDS_RETURNSTATUS", 
			124 => "process id", 
			129 => "TDS_COLMETADATA", 
			136 => "TDS_ALTCOLMETADATA", 
			160 => "Column name", 
			161 => "Column info", 
			164 => "TDS_TABNAME", 
			165 => "Column info 2", 
			167 => "Compute related", 
			168 => "Colimn Info - Compute result", 
			169 => "TDS_ORDER", 
			170 => "TDS_ERROR", 
			171 => "TDS_INFO", 
			172 => "TDS_PARAM", 
			173 => "TDS_LOGINACK", 
			174 => "Control", 
			209 => "TDS_ROW", 
			211 => "TDS_ALTROW", 
			215 => "Param packet", 
			226 => "Capability packet", 
			227 => "TDS_ENVCHANGE", 
			229 => "Extended error message", 
			230 => "DBRPC", 
			236 => "Param format packet", 
			238 => "Result set", 
			253 => "TDS_DONE", 
			254 => "TDS_DONEPROC", 
			255 => "TDS_DONEINPROC", 
			_ => "Unkown " + num, 
		};
		mNodex.Nodes.Add("Response Type : " + empty);
		Function.SetPosition(ref mNodex, Index - 1, 1, BaseOrSub: false);
		switch (num)
		{
		case 253:
		case 254:
		case 255:
		{
			int num10 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			string text = "Flags : ";
			if ((num10 & 1) != 0)
			{
				text += " More Results,";
			}
			if ((num10 & 2) != 0)
			{
				text += " Error,";
			}
			if ((num10 & 0x10) != 0)
			{
				text += " SELECT/INSERT/UPDATE(?),";
			}
			if ((num10 & 0x20) != 0)
			{
				text += " Cancel ack,";
			}
			mNodex.Nodes.Add(text);
			Function.SetPosition(ref mNodex, Index - 2, 2, BaseOrSub: false);
			int num11 = Function.Get2Bytes(PacketData, ref Index, Const.CurFileType);
			string empty2 = string.Empty;
			empty2 = num11 switch
			{
				185 => "IMPLICIT TRANSACTION ON", 
				186 => "IMPLICIT TRANSACTION OFF", 
				192 => "IF (block start)(?)", 
				193 => "SELECT", 
				195 => "INSERT", 
				197 => "UPDATE", 
				198 => "CREATE TABLE", 
				199 => "DROP TABLE FAILED", 
				202 => "ENDIF (block end)(?)", 
				210 => "ROLLBACK", 
				213 => "COMMIT", 
				222 => "CREATE PROCEDURE", 
				223 => "DROP PROCEDURE", 
				224 => "END PROCEDURE", 
				226 => "USE (database change)", 
				249 => "SET", 
				253 => "Syntac error or batch execution interupted (?)", 
				_ => "Unkown " + num11, 
			};
			mNodex.Nodes.Add("Operation : " + empty2);
			Function.SetPosition(ref mNodex, Index - 2, 2, BaseOrSub: false);
			Dump4ByteInt("Affected rows : ", mNodex, PacketData, ref Index);
			break;
		}
		case 209:
			mNodex.Nodes.Add("Parsing abandoned as TDS_ROW data is too hard");
			return false;
		case 129:
		{
			int num6 = Dump2ByteInt("Columns : ", mNodex, PacketData, ref Index);
			for (int l = 0; l < num6; l++)
			{
				int num7 = Index;
				TreeNode mNodey = new TreeNode();
				mNodey.Text = "SQL ( COL" + l + " )";
				ProcessCol(ref mNodey, PacketData, ref Index);
				mNodex.Nodes.Add(mNodey);
				Function.SetPosition(ref mNodex, num7, Index - num7, BaseOrSub: false);
			}
			break;
		}
		case 121:
			Dump4ByteInt("Return status : ", mNodex, PacketData, ref Index);
			break;
		case 165:
		{
			int num12 = Dump2ByteInt("PacketSize : ", mNodex, PacketData, ref Index);
			int num13 = 0;
			int num14 = 1;
			while (num13 < num12)
			{
				int num15 = PacketData[Index];
				if (num15 != num14)
				{
					int num16 = Dump1ByteInt("Col name length(?) : ", mNodex, PacketData, ref Index);
					DumpString("Col name : ", mNodex, PacketData, ref Index, num16);
					num13 += 2;
					num13 += 2 * num16;
				}
				if (num13 < num12)
				{
					Dump1ByteInt("Col(?) : ", mNodex, PacketData, ref Index);
					Dump2ByteInt("(?) : ", mNodex, PacketData, ref Index);
					num13 += 3;
					num14++;
				}
			}
			break;
		}
		case 164:
		{
			int num8 = Dump2ByteInt("PacketSize : ", mNodex, PacketData, ref Index);
			Dump1ByteInt("Unknown : ", mNodex, PacketData, ref Index);
			int num9 = 0;
			while (num9 < num8)
			{
				num9 += ProcessTable(ref mNodex, PacketData, ref Index);
				if (num9 < num8)
				{
					Dump1ByteInt("Unknown : ", mNodex, PacketData, ref Index);
				}
			}
			break;
		}
		case 169:
		{
			int num5 = Dump2ByteInt("PacketSize : ", mNodex, PacketData, ref Index);
			for (int k = 0; k < num5; k += 2)
			{
				Dump2ByteInt("Order col : ", mNodex, PacketData, ref Index);
			}
			break;
		}
		case 173:
		{
			Dump2ByteInt("PacketSize : ", mNodex, PacketData, ref Index);
			Dump1ByteInt("Unknown : ", mNodex, PacketData, ref Index);
			Dump4ByteInt("TDS Version : ", mNodex, PacketData, ref Index);
			int msglen7 = Dump1ByteInt("Database product name length : ", mNodex, PacketData, ref Index);
			DumpString("Database product name : ", mNodex, PacketData, ref Index, msglen7);
			Dump4ByteInt("Database Version : ", mNodex, PacketData, ref Index);
			break;
		}
		case 172:
		{
			int num3 = Dump2ByteInt("PacketSize : ", mNodex, PacketData, ref Index);
			int num4 = Dump1ByteInt("Param name length : ", mNodex, PacketData, ref Index);
			DumpString("Parameter name : ", mNodex, PacketData, ref Index, num4);
			Dump1ByteInt("Unknown : ", mNodex, PacketData, ref Index);
			int i2 = PacketData[Index];
			Dump1ByteInt("Formal type(?) : " + DecodeType(i2) + " : ", mNodex, PacketData, ref Index);
			Dump2ByteInt("Unknown : ", mNodex, PacketData, ref Index);
			Dump1ByteInt("Unknown : ", mNodex, PacketData, ref Index);
			i2 = PacketData[Index];
			Dump1ByteInt("Actual type : " + DecodeType(i2) + " : ", mNodex, PacketData, ref Index);
			mNodex.Nodes.Add("Parsing abandoned as TDS_PARAM is too hard");
			for (int j = 1 + num4 + 1 + 1 + 2 + 1 + 1; j < num3; j++)
			{
				Dump1ByteInt("Unknown : ", mNodex, PacketData, ref Index);
			}
			break;
		}
		case 227:
		{
			int num2 = Dump2ByteInt("PacketSize : ", mNodex, PacketData, ref Index);
			switch (Dump1ByteInt("Change type : ", mNodex, PacketData, ref Index))
			{
			case 1:
			{
				int msglen4 = Dump1ByteInt("Database name len : ", mNodex, PacketData, ref Index);
				DumpString("Database name : ", mNodex, PacketData, ref Index, msglen4);
				msglen4 = Dump1ByteInt("Old database name len : ", mNodex, PacketData, ref Index);
				DumpString("Old database name : ", mNodex, PacketData, ref Index, msglen4);
				break;
			}
			case 3:
			{
				int msglen6 = Dump1ByteInt("Charset len : ", mNodex, PacketData, ref Index);
				DumpString("Charset : ", mNodex, PacketData, ref Index, msglen6);
				Dump2ByteInt("Charset : ", mNodex, PacketData, ref Index);
				msglen6 = Dump1ByteInt("Old charset len : ", mNodex, PacketData, ref Index);
				DumpString("Old charset : ", mNodex, PacketData, ref Index, msglen6);
				break;
			}
			case 4:
			{
				int msglen5 = Dump1ByteInt("Block size len : ", mNodex, PacketData, ref Index);
				DumpString("Blocksize : ", mNodex, PacketData, ref Index, msglen5);
				msglen5 = Dump1ByteInt("Old blocksize len : ", mNodex, PacketData, ref Index);
				DumpString("Old block size : ", mNodex, PacketData, ref Index, msglen5);
				break;
			}
			default:
			{
				mNodex.Nodes.Add("Unrecognised ENVCHANGE parsing abandoned ");
				for (int i = 1; i < num2; i++)
				{
					Dump1ByteInt("Unknown : ", mNodex, PacketData, ref Index);
				}
				break;
			}
			}
			break;
		}
		case 170:
		case 171:
		{
			Dump2ByteInt("PacketSize : ", mNodex, PacketData, ref Index);
			Dump4ByteInt("Error message number : ", mNodex, PacketData, ref Index);
			Dump1ByteInt("State : ", mNodex, PacketData, ref Index);
			Dump1ByteInt("Severity : ", mNodex, PacketData, ref Index);
			int msglen = Dump2ByteInt("Message length : ", mNodex, PacketData, ref Index);
			DumpString("Message : ", mNodex, PacketData, ref Index, msglen);
			int msglen2 = Dump1ByteInt("Server name length : ", mNodex, PacketData, ref Index);
			DumpString("Server name : ", mNodex, PacketData, ref Index, msglen2);
			int msglen3 = Dump1ByteInt("Procedure name length : ", mNodex, PacketData, ref Index);
			DumpString("Procedure name : ", mNodex, PacketData, ref Index, msglen3);
			Dump2ByteInt("Line num : ", mNodex, PacketData, ref Index);
			break;
		}
		default:
			mNodex.Nodes.Add("Unrecognised TDS_* parsing abandoned");
			return false;
		}
		return true;
	}

	public static bool Parser(ref TreeNodeCollection mNode, byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, bool DisplayData)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		string text = "";
		int num = 0;
		num = PacketData.GetLength(0) - Index;
		TreeNode mNode2 = new TreeNode();
		mNode2.Text = "SQL ( SQL )";
		Function.SetPosition(ref mNode2, Index, PacketData.Length - Index, BaseOrSub: true);
		if (Index >= PacketData.GetLength(0))
		{
			mNode2.Nodes.Add("No data.");
			return false;
		}
		if (PacketData.GetLength(0) == 1514)
		{
			mNode2.Nodes.Add("Packet is very likely fragmented so parsing is unlikely to work.");
		}
		try
		{
			PACKET_SQL pACKET_SQL = default(PACKET_SQL);
			pACKET_SQL.type = PacketData[Index++];
			string empty = string.Empty;
			empty = pACKET_SQL.type switch
			{
				1 => "Query from client", 
				2 => "Login from client", 
				3 => "Stored procedure call from client", 
				4 => "Reply from server", 
				6 => "Cancel query from client", 
				7 => "Bulk", 
				15 => "Query from client 2", 
				16 => "Login from client 2", 
				_ => "Unkown " + pACKET_SQL.type, 
			};
			mNode2.Nodes.Add("Type : " + empty);
			Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			int num2 = PacketData[Index++];
			if (num2 == 1)
			{
				mNode2.Nodes.Add("Last packet");
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			}
			else
			{
				mNode2.Nodes.Add("More packets to come");
				Function.SetPosition(ref mNode2, Index - 1, 1, BaseOrSub: false);
			}
			Dump2ByteInt("Packet Size : ", mNode2, PacketData, ref Index);
			Dump4ByteInt("Unknown : ", mNode2, PacketData, ref Index);
			if (pACKET_SQL.type == 1)
			{
				int num3 = Index;
				pACKET_SQL.sql = Function.GetString(PacketData, ref Index, IsUnicode: true, num - 8);
				mNode2.Nodes.Add("SQL : " + pACKET_SQL.sql);
				Function.SetPosition(ref mNode2, num3, Index - num3, BaseOrSub: false);
			}
			else if (pACKET_SQL.type != 2)
			{
				if (pACKET_SQL.type == 3)
				{
					int msglen = Dump2ByteInt("Proc name length : ", mNode2, PacketData, ref Index);
					DumpString("Proc name : ", mNode2, PacketData, ref Index, msglen);
				}
				else if (pACKET_SQL.type == 4)
				{
					bool flag = true;
					while (flag && Index < PacketData.GetLength(0))
					{
						int num4 = Index;
						TreeNode mNodex = new TreeNode();
						mNodex.Text = "SQL ( SERVER RESPONSE )";
						flag = Process4(ref mNodex, PacketData, ref Index);
						mNode2.Nodes.Add(mNodex);
						Function.SetPosition(ref mNode2, num4, Index - num4, BaseOrSub: false);
					}
				}
			}
			LItem.Protocol = "SQL";
			LItem.Info = "TDS Protocol";
			mNode.Add(mNode2);
		}
		catch (Exception ex)
		{
			mNode.Add(mNode2);
			text = "[ Malformed SQL packet. Remaining bytes don't fit an SQL packet. Possibly due to bad decoding ]";
			mNode.Add(text);
			text = "[ Exception raised is <" + ex.GetType().ToString() + "> at packet index <" + Index + "> ]";
			mNode.Add(text);
			LItem.Info = "[ Malformed SQL packet. Remaining bytes don't fit an SQL packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}

	public static bool Parser(byte[] PacketData, ref int Index, ref PACKET_ITEM LItem, bool DisplayData)
	{
		try
		{
			PacketData.GetLength(0);
			_ = PacketData[Index++];
			LItem.Protocol = "SQL";
			LItem.Info = "TDS Protocol";
		}
		catch
		{
			LItem.Info = "[ Malformed SQL packet. Remaining bytes don't fit an SQL packet. Possibly due to bad decoding ]";
			return false;
		}
		return true;
	}
}
