using System;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MyClasses;

public class Function
{
	public struct COLUMN_DEFAULT_OPTIONS
	{
		public int No;

		public int Time;

		public int Source;

		public int SourcePort;

		public int Destination;

		public int DestinationPort;

		public int Protocol;

		public int Sequence;

		public int Acknowledge;

		public int Info;
	}

	public const int ANSI_CHARSET = 0;

	public const int ANSI_FIXED_FONT = 11;

	public const int OEM_CHARSET = 255;

	public const int OEM_FIXED_FONT = 10;

	public const int OUT_CHARACTER_PRECIS = 2;

	public const int OUT_DEFAULT_PRECIS = 0;

	public const int OUT_DEVICE_PRECIS = 5;

	public const int OUT_OUTLINE_PRECIS = 8;

	public const int OUT_PS_ONLY_PRECIS = 10;

	public const int OUT_RASTER_PRECIS = 6;

	public const int OUT_SCREEN_OUTLINE_PRECIS = 9;

	public const int OUT_STRING_PRECIS = 1;

	public const int OUT_STROKE_PRECIS = 3;

	public const int OUT_TT_ONLY_PRECIS = 7;

	public const int OUT_TT_PRECIS = 4;

	public const int CLIP_CHARACTER_PRECIS = 1;

	public const int CLIP_DEFAULT_PRECIS = 0;

	public const int CLIP_EMBEDDED = 128;

	public const int CLIP_LH_ANGLES = 16;

	public const int CLIP_MASK = 15;

	public const int CLIP_NOT = 0;

	public const int CLIP_STROKE_PRECIS = 2;

	public const int CLIP_SUS = 32;

	public const int CLIP_TO_PATH = 4097;

	public const int CLIP_TT_ALWAYS = 32;

	public const int DEFAULT_PRECIS = 0;

	public const int DEFAULT_QUALITY = 0;

	public const int FIXED_PITCH = 1;

	public const int FF_DECORATIVE = 80;

	public const int FF_DONTCARE = 0;

	public const int FF_MODERN = 48;

	public const int FF_ROMAN = 16;

	public const int FF_SCRIPT = 64;

	public const int FF_SWISS = 32;

	public const int LOGPIXELSX = 88;

	public const int LOGPIXELSY = 90;

	public const int WM_SETFONT = 48;

	public const int WM_GETFONT = 49;

	public const int EM_SETSEL = 177;

	public const int NORMAL = 0;

	public const int VALUE = 1;

	public const int WS_EX_LAYERED = 524288;

	public const int LWA_COLORKEY = 1;

	public const int LWA_ALPHA = 2;

	public const int GWL_EXSTYLE = -20;

	public static uint FORMAT_MESSAGE_ALLOCATE_BUFFER = 256u;

	public static uint FORMAT_MESSAGE_ARGUMENT_ARRAY = 8192u;

	public static uint FORMAT_MESSAGE_FROM_HMODULE = 2048u;

	public static uint FORMAT_MESSAGE_FROM_STRING = 1024u;

	public static uint FORMAT_MESSAGE_FROM_SYSTEM = 4096u;

	public static uint FORMAT_MESSAGE_IGNORE_INSERTS = 512u;

	public static uint FORMAT_MESSAGE_MAX_WIDTH_MASK = 255u;

	public static uint LANG_BULGARIAN = 2u;

	public static uint LANG_CHINESE = 4u;

	public static uint LANG_CROATIAN = 26u;

	public static uint LANG_CZECH = 5u;

	public static uint LANG_DANISH = 6u;

	public static uint LANG_DUTCH = 19u;

	public static uint LANG_ENGLISH = 9u;

	public static uint LANG_FINNISH = 11u;

	public static uint LANG_FRENCH = 12u;

	public static uint LANG_GERMAN = 7u;

	public static uint LANG_GREEK = 8u;

	public static uint LANG_HUNGARIAN = 14u;

	public static uint LANG_ICELANDIC = 15u;

	public static uint LANG_ITALIAN = 16u;

	public static uint LANG_JAPANESE = 17u;

	public static uint LANG_KOREAN = 18u;

	public static uint LANG_NEUTRAL = 0u;

	public static uint LANG_NORWEGIAN = 20u;

	public static uint LANG_POLISH = 21u;

	public static uint LANG_PORTUGUESE = 22u;

	public static uint LANG_ROMANIAN = 24u;

	public static uint LANG_RUSSIAN = 25u;

	public static uint LANG_SLOVAK = 27u;

	public static uint LANG_SLOVENIAN = 36u;

	public static uint LANG_SPANISH = 10u;

	public static uint LANG_SWEDISH = 29u;

	public static uint LANG_TURKISH = 31u;

	public static uint SUBLANG_CHINESE_HONGKONG = 3u;

	public static uint SUBLANG_CHINESE_SIMPLIFIED = 2u;

	public static uint SUBLANG_CHINESE_SINGAPORE = 4u;

	public static uint SUBLANG_CHINESE_TRADITIONAL = 1u;

	public static uint SUBLANG_DEFAULT = 1u;

	public static uint SUBLANG_DUTCH = 1u;

	public static uint SUBLANG_DUTCH_BELGIAN = 2u;

	public static uint SUBLANG_ENGLISH_AUS = 3u;

	public static uint SUBLANG_ENGLISH_CAN = 4u;

	public static uint SUBLANG_ENGLISH_EIRE = 6u;

	public static uint SUBLANG_ENGLISH_NZ = 5u;

	public static uint SUBLANG_ENGLISH_UK = 2u;

	public static uint SUBLANG_ENGLISH_US = 1u;

	public static uint SUBLANG_FRENCH = 1u;

	public static uint SUBLANG_FRENCH_BELGIAN = 2u;

	public static uint SUBLANG_FRENCH_CANADIAN = 3u;

	public static uint SUBLANG_FRENCH_SWISS = 4u;

	public static uint SUBLANG_GERMAN = 1u;

	public static uint SUBLANG_GERMAN_AUSTRIAN = 3u;

	public static uint SUBLANG_GERMAN_SWISS = 2u;

	public static uint SUBLANG_ITALIAN = 1u;

	public static uint SUBLANG_ITALIAN_SWISS = 2u;

	public static uint SUBLANG_NEUTRAL = 0u;

	public static uint SUBLANG_NORWEGIAN_BOKMAL = 1u;

	public static uint SUBLANG_NORWEGIAN_NYNORSK = 2u;

	public static uint SUBLANG_PORTUGUESE = 2u;

	public static uint SUBLANG_PORTUGUESE_BRAZILIAN = 1u;

	public static uint SUBLANG_SPANISH = 1u;

	public static uint SUBLANG_SPANISH_MEXICAN = 2u;

	public static uint SUBLANG_SPANISH_MODERN = 3u;

	public static uint SUBLANG_SYS_DEFAULT = 2u;

	public static uint SUCCESSFUL_ACCESS_ACE_FLAG = 64u;

	public static uint LMEM_ZEROINIT = 64u;

	public static uint LOAD_LIBRARY_AS_DATAFILE = 2u;

	public static uint RT_ACCELERATOR = 9u;

	public static uint RT_BITMAP = 2u;

	public static uint RT_CURSOR = 1u;

	public static uint RT_DIALOG = 5u;

	public static uint RT_FONT = 8u;

	public static uint RT_FONTDIR = 7u;

	public static uint RT_ICON = 3u;

	public static uint RT_MENU = 4u;

	public static uint RT_RCDATA = 10u;

	public static uint RT_STRING = 6u;

	public static uint RT_MESSAGETABLE = 11u;

	public static uint ERROR_ALREADY_EXISTS = 183u;

	public static uint INFINITE = 65535u;

	public static uint MOVEFILE_REPLACE_EXISTING = 1u;

	public static uint FILE_ATTRIBUTE_TEMPORARY = 256u;

	public static uint FILE_BEGIN = 0u;

	public static uint FILE_SHARE_READ = 1u;

	public static uint FILE_SHARE_WRITE = 2u;

	public static uint CREATE_NEW = 1u;

	public static uint OPEN_EXISTING = 3u;

	public static uint GENERIC_READ = 2147483648u;

	public static uint GENERIC_WRITE = 1073741824u;

	[DllImport("user32.dll")]
	public static extern int ReleaseDC(int hWnd, int hDC);

	[DllImport("gdi32.dll")]
	public static extern int DeleteObject(int hObject);

	[DllImport("user32.dll")]
	public static extern int GetDC(int hWnd);

	[DllImport("gdi32.dll")]
	public static extern int GetDeviceCaps(int hdc, int nIndex);

	[DllImport("gdi32.dll")]
	public static extern int CreateFont(int nHeight, int nWidth, int nEscapement, int nOrientation, int fnWeight, uint fdwItalic, uint fdwUnderline, uint fdwStrikeOut, uint fdwCharSet, uint fdwOutputPrecision, uint fdwClipPrecision, uint fdwQuality, uint fdwPitchAndFamily, int lpszFace);

	[DllImport("kernel32.dll")]
	public static extern int MulDiv(int nNumber, int nNumerator, int nDenominator);

	[DllImport("user32.dll")]
	public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

	public static string ReturnErrorMessage(Exception Ex)
	{
		string text = "";
		text = "Error Type is " + Ex.GetType().ToString() + '\r' + '\n';
		object obj = text;
		text = string.Concat(obj, "Error Source is ", Ex.Source, '\r', '\n');
		object obj2 = text;
		text = string.Concat(obj2, "Error Trace is ", Ex.StackTrace, '\r', '\n');
		return text + "Error Message is " + Ex.Message;
	}

	public static ushort Get2Bytes(byte[] ptr, ref int Index, int Type)
	{
		ushort result = 0;
		switch (Type)
		{
		case 0:
			result = ptr[Index++];
			result *= 256;
			result += ptr[Index++];
			break;
		case 1:
			result = ptr[++Index];
			result *= 256;
			Index--;
			result += ptr[Index++];
			Index++;
			break;
		}
		return result;
	}

	public static uint Get3Bytes(byte[] ptr, ref int Index, int Type)
	{
		uint result = 0u;
		if (Type == 0)
		{
			result = (uint)(ptr[Index++] << 16);
			result += (uint)(ptr[Index++] << 8);
			result += ptr[Index++];
		}
		return result;
	}

	public static uint Get4Bytes(byte[] ptr, ref int Index, int Type)
	{
		uint result = 0u;
		switch (Type)
		{
		case 0:
			result = (uint)(ptr[Index++] << 24);
			result += (uint)(ptr[Index++] << 16);
			result += (uint)(ptr[Index++] << 8);
			result += ptr[Index++];
			break;
		case 1:
			result = (uint)(ptr[Index + 3] << 24);
			result += (uint)(ptr[Index + 2] << 16);
			result += (uint)(ptr[Index + 1] << 8);
			result += ptr[Index];
			Index += 4;
			break;
		}
		return result;
	}

	public static string GetIpAddress(byte[] ptr, ref int Index)
	{
		string text = "";
		text = text + ptr[Index++] + ".";
		text = text + ptr[Index++] + ".";
		text = text + ptr[Index++] + ".";
		return text + ptr[Index++];
	}

	public static string GetIpAddress(byte[] ptr, ref int Index, int Length)
	{
		string text = "";
		int num = 0;
		for (num = 0; num < Length - 1; num++)
		{
			text = text + ptr[Index++] + ".";
		}
		return text + ptr[Index++];
	}

	public static int MakeFont(int Handle)
	{
		int nNumber = 10;
		int num = 0;
		int num2 = 0;
		int dC = GetDC(Handle);
		int nHeight = -MulDiv(nNumber, GetDeviceCaps(dC, 90), 72);
		ReleaseDC(Handle, dC);
		int fdwCharSet = 0;
		num2 = SendMessage(Handle, 49u, 0, 0);
		num = CreateFont(nHeight, 0, 0, 0, 700, 0u, 0u, 0u, (uint)fdwCharSet, 0u, 0u, 0u, 1u, 0);
		SendMessage(Handle, 48u, num, 65536);
		if (num2 > 0)
		{
			DeleteObject(num2);
		}
		return 1;
	}

	private static string PadZeros(int inInt)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string text = Convert.ToString(inInt, 16);
		if (text.Length < 8)
		{
			int num = 8 - text.Length;
			for (int i = 0; i < num; i++)
			{
				stringBuilder.Append("0");
			}
		}
		stringBuilder.Append(text);
		return stringBuilder.ToString().ToUpper();
	}

	private static string ConvertByteToHexString(byte inByte)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string text = Convert.ToString(inByte, 16);
		if (text.Length == 1)
		{
			stringBuilder.Append("0");
		}
		stringBuilder.Append(text);
		return stringBuilder.ToString().ToLower();
	}

	public static string GetHexString(byte[] mData)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		string text = "";
		string text2 = "";
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		string text3 = " ";
		string text4 = " ";
		string text5 = "";
		int num4 = mData.GetLength(0) / 16;
		int num5 = num4 * 16 - mData.GetLength(0);
		if (num5 < 0)
		{
			num4++;
			num5 += 16;
		}
		byte[] array = new byte[num4 * 16];
		for (num = 0; num < mData.Length; num++)
		{
			array[num] = mData[num];
		}
		text = " Offset   ";
		text2 = " ---------";
		for (num = 0; num < 16; num++)
		{
			text = text + " " + num.ToString("d02");
			text2 += "---";
		}
		stringBuilder.Append(text + "                  \n");
		stringBuilder.Append(text2 + "-------------------\n");
		for (num = 0; num < array.Length; num++)
		{
			if (num2 == 0)
			{
				text4 = PadZeros(num3);
				stringBuilder.Append(" " + text4 + " ");
				num3 += 16;
			}
			text3 = ConvertByteToHexString(array[num]);
			stringBuilder.Append(" " + text3);
			int num6 = array[num];
			if (num6 > 31 && num6 < 127)
			{
				stringBuilder2.Append((char)array[num]);
			}
			else
			{
				stringBuilder2.Append(".");
			}
			num2++;
			if (num2 >= 16)
			{
				stringBuilder.Append("   " + stringBuilder2.ToString() + "\n");
				stringBuilder2 = new StringBuilder();
				num2 = 0;
			}
		}
		stringBuilder.Append("\n\n");
		return stringBuilder.ToString();
	}

	public static string ReFormatString(object Value, object AdditionalValue)
	{
		string text = Value.GetType().ToString();
		string text2 = "";
		string text3 = "";
		byte b = 0;
		ushort num = 0;
		short num2 = 0;
		uint num3 = 0u;
		int num4 = 0;
		ulong num5 = 0uL;
		long num6 = 0L;
		if (AdditionalValue != null)
		{
			text3 = (string)AdditionalValue;
		}
		switch (text)
		{
		case "System.Byte":
			b = (byte)Value;
			text2 = " 0x" + b.ToString("x02") + "( " + b + " ) ";
			break;
		case "System.UInt16":
			num = (ushort)Value;
			text2 = " 0x" + num.ToString("x04") + "( " + num + " ) ";
			break;
		case "System.Int16":
			num2 = (short)Value;
			text2 = " 0x" + num2.ToString("x04") + "( " + num2 + " ) ";
			break;
		case "System.UInt32":
			num3 = (uint)Value;
			text2 = " 0x" + num3.ToString("x08") + "( " + num3 + " ) ";
			break;
		case "System.Int32":
			num4 = (int)Value;
			text2 = " 0x" + num4.ToString("x08") + "( " + num4 + " ) ";
			break;
		case "System.UInt64":
			num5 = (ulong)Value;
			text2 = " 0x" + num5.ToString("x16") + "( " + num5 + " ) ";
			break;
		case "System.Int64":
			num6 = (long)Value;
			text2 = " 0x" + num6.ToString("x16") + "( " + num6 + " ) ";
			break;
		}
		if (text3 != "")
		{
			text2 += text3;
		}
		return text2;
	}

	public static string GetNetBiosName(byte[] Data, ref int Index, ref byte NameNumber)
	{
		string text = "";
		byte b = 0;
		byte b2 = 0;
		int num = 0;
		while (Data[Index] == 0)
		{
			Index++;
		}
		if (Data[Index] == 32)
		{
			Index++;
		}
		for (num = 0; num < 15; num++)
		{
			Index++;
			if (Index < Data.Length)
			{
				b = Data[Index];
				break;
			}
			Index++;
			if (Index < Data.Length)
			{
				b2 = Data[Index++];
				break;
			}
			b &= 0xF;
			b2 &= 0xF;
			b <<= 4;
			b += b2;
			b -= 17;
			text += (char)b;
		}
		text = text.Trim();
		b = Data[Index++];
		b2 = Data[Index++];
		b &= 0xF;
		b2 &= 0xF;
		b <<= 4;
		b += b2;
		b -= 17;
		string text2 = text;
		text = text2 + "<" + b.ToString("x02") + ":" + b + ">";
		Index++;
		NameNumber = b;
		return text;
	}

	public static string GetNetBiosNameSerial(byte[] Data, ref int Index, ref byte NameNumber)
	{
		string text = "";
		byte b = 0;
		int num = 0;
		while (Data[Index] == 0)
		{
			Index++;
		}
		for (num = 0; num < 15; num++)
		{
			text += (char)Data[Index++];
		}
		text = text.Trim();
		b = Data[Index++];
		string text2 = text;
		text = text2 + "<" + b.ToString("x02") + ":" + b + ">";
		NameNumber = b;
		return text;
	}

	public static string DecodeBitField(byte Value, uint Mask, string TrueText, string FalseText)
	{
		int num = 0;
		byte b = 0;
		byte b2 = 0;
		byte b3 = 0;
		string text = "";
		string text2 = "";
		int num2 = 0;
		int num3 = 0;
		num = 2;
		b = Value;
		b2 = (byte)Mask;
		byte[] array = new byte[num * 4];
		for (num2 = 0; num2 < array.GetLength(0); num2++)
		{
			array[num2] = 46;
		}
		text = (((b & b2) <= 0) ? FalseText : TrueText);
		num2 = 0;
		for (b3 = b2; b3 > 0; b3 >>= 1)
		{
			num2++;
		}
		array[array.GetLength(0) - num2] = (byte)(((b & b2) > 0) ? 49 : 48);
		num3 = 0;
		text2 = "";
		for (num2 = 0; num2 < array.GetLength(0); num2++)
		{
			if (num3 == 3)
			{
				text2 = text2 + (char)array[num2] + " ";
				num3 = 0;
			}
			else
			{
				text2 += (char)array[num2];
				num3++;
			}
		}
		return text2 + "= " + text;
	}

	public static string DecodeBitField(byte Value, int Mask, string TrueText, string FalseText)
	{
		return DecodeBitField(Value, (uint)Mask, TrueText, FalseText);
	}

	public static string DecodeBitField(ushort Value, uint Mask, string TrueText, string FalseText)
	{
		int num = 0;
		ushort num2 = 0;
		ushort num3 = 0;
		ushort num4 = 0;
		string text = "";
		string text2 = "";
		int num5 = 0;
		int num6 = 0;
		num = 4;
		num2 = Value;
		num3 = (ushort)Mask;
		byte[] array = new byte[num * 4];
		for (num5 = 0; num5 < array.GetLength(0); num5++)
		{
			array[num5] = 46;
		}
		text = (((num2 & num3) <= 0) ? FalseText : TrueText);
		num5 = 0;
		for (num4 = num3; num4 != 0; num4 >>= 1)
		{
			num5++;
		}
		array[array.GetLength(0) - num5] = (byte)(((num2 & num3) > 0) ? 49 : 48);
		num6 = 0;
		text2 = "";
		for (num5 = 0; num5 < array.GetLength(0); num5++)
		{
			if (num6 == 3)
			{
				text2 = text2 + (char)array[num5] + " ";
				num6 = 0;
			}
			else
			{
				text2 += (char)array[num5];
				num6++;
			}
		}
		return text2 + "= " + text;
	}

	public static string DecodeBitField(ushort Value, int Mask, string TrueText, string FalseText)
	{
		return DecodeBitField(Value, (uint)Mask, TrueText, FalseText);
	}

	public static string DecodeBitField(uint Value, uint Mask, string TrueText, string FalseText)
	{
		int num = 0;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		string text = "";
		string text2 = "";
		int num5 = 0;
		int num6 = 0;
		num = 8;
		num2 = Value;
		num3 = Mask;
		byte[] array = new byte[num * 4];
		for (num5 = 0; num5 < array.GetLength(0); num5++)
		{
			array[num5] = 46;
		}
		text = (((num2 & num3) == 0) ? FalseText : TrueText);
		num5 = 0;
		for (num4 = num3; num4 != 0; num4 >>= 1)
		{
			num5++;
		}
		array[array.GetLength(0) - num5] = (byte)(((num2 & num3) != 0) ? 49 : 48);
		num6 = 0;
		text2 = "";
		for (num5 = 0; num5 < array.GetLength(0); num5++)
		{
			if (num6 == 3)
			{
				text2 = text2 + (char)array[num5] + " ";
				num6 = 0;
			}
			else
			{
				text2 += (char)array[num5];
				num6++;
			}
		}
		return text2 + "= " + text;
	}

	public static string DecodeBitField(uint Value, int Mask, string TrueText, string FalseText)
	{
		return DecodeBitField(Value, (uint)Mask, TrueText, FalseText);
	}

	public static string DecodeBitField(byte Value, uint Mask, string ValueText)
	{
		int num = 0;
		byte b = 0;
		byte b2 = 0;
		byte b3 = 0;
		string text = "";
		int num2 = 0;
		int num3 = 0;
		num = 2;
		b = Value;
		b2 = (byte)Mask;
		b &= b2;
		byte[] bytes = GetBytes(b2);
		byte[] array = new byte[num * 4];
		for (num2 = 0; num2 < array.GetLength(0); num2++)
		{
			array[num2] = 46;
		}
		num2 = 0;
		b3 = b2;
		for (num2 = 0; num2 < 8; num2++)
		{
			if (bytes[num2] == 1)
			{
				b3 = (byte)(1 << num2);
				if ((b3 & b) > 0)
				{
					array[num2] = 49;
				}
				else
				{
					array[num2] = 48;
				}
			}
		}
		num3 = 0;
		text = "";
		for (num2 = 0; num2 < array.GetLength(0); num2++)
		{
			if (num3 == 3)
			{
				text = text + (char)array[num2] + " ";
				num3 = 0;
			}
			else
			{
				text += (char)array[num2];
				num3++;
			}
		}
		text = text + "= " + b;
		return text + " ( " + ValueText + " )";
	}

	public static string DecodeBitField(byte Value, int Mask, string ValueText)
	{
		return DecodeBitField(Value, (uint)Mask, ValueText);
	}

	public static string DecodeBitField(ushort Value, uint Mask, string[] ValueText)
	{
		int num = 0;
		ushort num2 = 0;
		ushort num3 = 0;
		ushort num4 = 0;
		string text = "";
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		num = 4;
		num2 = Value;
		num3 = (ushort)Mask;
		num2 &= num3;
		num6 = num3;
		while ((num6 & 1) == 0)
		{
			num7++;
			num6 >>= 1;
		}
		byte[] bytes = GetBytes(num3);
		byte[] array = new byte[num * 4];
		for (num5 = 0; num5 < array.GetLength(0); num5++)
		{
			array[num5] = 46;
		}
		num5 = 0;
		num4 = num3;
		for (num5 = 0; num5 < 16; num5++)
		{
			if (bytes[num5] == 1)
			{
				num4 = (ushort)(1 << num5);
				if ((num4 & num2) > 0)
				{
					array[num5] = 49;
				}
				else
				{
					array[num5] = 48;
				}
			}
		}
		num6 = 0;
		text = "";
		for (num5 = 0; num5 < array.GetLength(0); num5++)
		{
			if (num6 == 3)
			{
				text = text + (char)array[num5] + " ";
				num6 = 0;
			}
			else
			{
				text += (char)array[num5];
				num6++;
			}
		}
		string text2 = text;
		return text2 + "= " + num2 + " ( " + ValueText[num2 >> num7] + " )";
	}

	public static string DecodeBitField(ushort Value, int Mask, string[] ValueText)
	{
		return DecodeBitField(Value, (uint)Mask, ValueText);
	}

	public static byte[] GetBytes(byte val)
	{
		byte[] array = new byte[8];
		int num = 0;
		int num2 = val & 0xFF;
		for (num = 0; num < 8; num++)
		{
			if (((num2 >> num) & 1) > 0)
			{
				array[7 - num] = 1;
			}
			else
			{
				array[7 - num] = 0;
			}
		}
		return array;
	}

	public static byte[] GetBytes(short val)
	{
		byte[] array = new byte[16];
		int num = 0;
		int num2 = val & 0xFFFF;
		for (num = 0; num < 16; num++)
		{
			if (((num2 >> num) & 1) > 0)
			{
				array[15 - num] = 1;
			}
			else
			{
				array[15 - num] = 0;
			}
		}
		return array;
	}

	public static byte[] GetBytes(ushort val)
	{
		return GetBytes((short)val);
	}

	public static string GetMACAddress(byte[] PacketData, ref int Index)
	{
		string text = "";
		int num = 0;
		for (num = 0; num < 5; num++)
		{
			text = text + PacketData[Index++].ToString("x02") + ":";
		}
		return text + PacketData[Index++].ToString("x02");
	}

	public static void HighlightText(RichTextBox Rtx, TreeNode MNode, ref StatusBar SBar)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		((TextBoxBase)Rtx).SelectionStart = 0;
		((TextBoxBase)Rtx).SelectionLength = ((Control)Rtx).Text.Length;
		Rtx.SelectionColor = Color.Black;
		int[] array;
		try
		{
			array = (int[])MNode.Tag;
			if (array == null)
			{
				return;
			}
		}
		catch
		{
			return;
		}
		SBar.Panels[0].Text = "Index : " + array[0] + " , Length : " + array[1];
		for (num = 2; num < array.Length; num += 4)
		{
			num2 = array[num];
			num3 = array[num + 1];
			num4 = array[num + 2];
			num5 = array[num + 3];
			((TextBoxBase)Rtx).SelectionStart = num2;
			((TextBoxBase)Rtx).SelectionLength = num3;
			Rtx.SelectionColor = Color.Blue;
			((TextBoxBase)Rtx).SelectionStart = num4;
			((TextBoxBase)Rtx).SelectionLength = num5;
			Rtx.SelectionColor = Color.Red;
		}
	}

	public static void AddNodeToTheList(TreeNode mNode, ref ArrayList aList)
	{
		int num = 0;
		for (num = 0; num < mNode.Nodes.Count; num++)
		{
			TreeNode val = mNode.Nodes[num];
			aList.Add(val);
			if (val.Nodes.Count > 0)
			{
				AddNodeToTheList(val, ref aList);
			}
		}
	}

	public static void ReverseHighlightText(RichTextBox Rtx, TreeView Tnc, Point Pt, ref StatusBar SBar)
	{
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		int num = 0;
		TreeNode val = null;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		ArrayList aList = new ArrayList();
		num2 = ((TextBoxBase)Rtx).GetCharIndexFromPosition(Pt);
		if (num2 < 167)
		{
			return;
		}
		num3 = num2 / 78;
		num4 = num2 - num3 * 78;
		num4 -= 11;
		if (num4 > 48)
		{
			num4 -= 48;
			num2 = num3 * 78 + 11 + num4 * 3 - 1;
		}
		for (num = 1; num < Tnc.Nodes.Count; num++)
		{
			val = Tnc.Nodes[num];
			aList.Add(val);
			if (val.Nodes.Count > 0)
			{
				AddNodeToTheList(val, ref aList);
			}
		}
		for (num = 0; num < aList.Count; num++)
		{
			val = (TreeNode)aList[num];
			try
			{
				int[] array = (int[])val.Tag;
				if (array != null && num2 >= array[2] && num2 <= array[^4] + array[^3] && val.Nodes.Count == 0)
				{
					Tnc.SelectedNode = val;
					HighlightText(Rtx, val, ref SBar);
					break;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ReturnErrorMessage(ex));
				break;
			}
		}
	}

	public static int[] FindHighlightPos(int SPos, int SLen)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		int num11 = 0;
		int num12 = 0;
		int num13 = 0;
		ArrayList arrayList = new ArrayList();
		num = SPos;
		num2 = SLen;
		arrayList.Add(SPos);
		arrayList.Add(SLen);
		num9 = num / 16;
		num10 = num - num9 * 16;
		num5 = 166 + 78 * num9 + num10 * 3;
		num7 = 216 + 78 * num9 + num10;
		num13 = num9;
		num4 = num10 + num2;
		if (num4 <= 16)
		{
			num6 = num2 * 3;
			num8 = num2;
			arrayList.Add(num5);
			arrayList.Add(num6);
			arrayList.Add(num7);
			arrayList.Add(num8);
		}
		else
		{
			num4 = 16 - num10;
			num2 -= num4;
			num6 = num4 * 3;
			num8 = num4;
			arrayList.Add(num5);
			arrayList.Add(num6);
			arrayList.Add(num7);
			arrayList.Add(num8);
			num13++;
			num11 = num2 / 16;
			num12 = num2 - num11 * 16;
			for (num3 = 0; num3 < num11; num3++)
			{
				num5 = 166 + 78 * num13;
				num7 = 216 + 78 * num13;
				num6 = 48;
				num8 = 16;
				arrayList.Add(num5);
				arrayList.Add(num6);
				arrayList.Add(num7);
				arrayList.Add(num8);
				num13++;
			}
			if (num12 > 0)
			{
				num5 = 166 + 78 * num13;
				num7 = 216 + 78 * num13;
				num6 = num12 * 3;
				num8 = num12;
				arrayList.Add(num5);
				arrayList.Add(num6);
				arrayList.Add(num7);
				arrayList.Add(num8);
			}
		}
		int[] array = new int[arrayList.Count];
		for (num3 = 0; num3 < arrayList.Count; num3++)
		{
			array[num3] = (int)arrayList[num3];
		}
		return array;
	}

	public static bool CheckBytesForZero(byte[] PacketData, int Index, int len)
	{
		bool result = true;
		int num = 0;
		for (num = 0; num < 10; num++)
		{
			if (PacketData[Index + num] != 0)
			{
				return false;
			}
		}
		return result;
	}

	public static int FindListIndex(ListViewItem LItem)
	{
		int num = -1;
		string text = "";
		text = LItem.Text;
		return int.Parse(text);
	}

	public static string FindString(byte[] PacketData, ref int Index)
	{
		string text = "";
		while (PacketData[Index] != 0)
		{
			text += (char)PacketData[Index++];
		}
		Index++;
		return text;
	}

	public static string GetString(byte[] PacketData, ref int Index, string FormatText, int len)
	{
		string text = "";
		int num = 0;
		for (num = 0; num < len; num++)
		{
			text += PacketData[Index++].ToString(FormatText);
		}
		return text;
	}

	public static string GetString(byte[] PacketData, ref int Index, int len)
	{
		string text = "";
		int num = 0;
		for (num = 0; num < len; num++)
		{
			text += (char)PacketData[Index++];
		}
		return text;
	}

	public static string GetString(byte[] PacketData, ref int Index)
	{
		string text = "";
		while (PacketData[Index] != 0)
		{
			text += (char)PacketData[Index++];
		}
		Index++;
		return text;
	}

	public static string GetString(byte[] PacketData, ref int Index, bool IsUnicode, int len)
	{
		string text = "";
		int i = 0;
		if (IsUnicode)
		{
			for (; i < len; i += 2)
			{
				if (PacketData[Index] == 0)
				{
					break;
				}
				if (PacketData[Index + 1] != 0)
				{
					break;
				}
				text += (char)PacketData[Index++];
				Index++;
			}
			if (i != len)
			{
				Index += 2;
			}
		}
		else
		{
			for (; i < len; i++)
			{
				if (PacketData[Index] == 0)
				{
					break;
				}
				text += (char)PacketData[Index++];
			}
			if (i != len)
			{
				Index++;
			}
		}
		return text;
	}

	public static string GetString(byte[] PacketData, ref int Index, bool IsUnicode)
	{
		string text = "";
		if (IsUnicode)
		{
			while (PacketData[Index] != 0 && PacketData[Index + 1] == 0)
			{
				text += (char)PacketData[Index++];
				Index++;
			}
			Index += 2;
		}
		else
		{
			while (PacketData[Index] != 0)
			{
				text += (char)PacketData[Index++];
			}
			Index++;
		}
		return text;
	}

	public static string GetUnicodeOrAscii(byte[] PacketData, ref int Index)
	{
		string text = "";
		if (PacketData[Index + 1] == 0)
		{
			return GetString(PacketData, ref Index, IsUnicode: true);
		}
		return GetString(PacketData, ref Index, IsUnicode: false);
	}

	public static void SetPosition(ref TreeNode mNode, int Start, int Len, bool BaseOrSub)
	{
		if (BaseOrSub)
		{
			mNode.Tag = FindHighlightPos(Start, Len);
		}
		else
		{
			mNode.Nodes[mNode.Nodes.Count - 1].Tag = FindHighlightPos(Start, Len);
		}
	}

	public static void ArrangeText(ref TreeNode mNode, string ArrangeToThis)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		string text = "";
		string text2 = "";
		for (num = 0; num < mNode.Nodes.Count; num++)
		{
			TreeNode mNode2 = mNode.Nodes[num];
			text = mNode2.Text;
			num3 = text.IndexOf(ArrangeToThis, 0);
			if (num4 < num3)
			{
				num4 = num3;
			}
			if (mNode2.Nodes.Count > 0)
			{
				ArrangeText(ref mNode2, ArrangeToThis);
			}
		}
		if (num4 <= 0)
		{
			return;
		}
		for (num = 0; num < mNode.Nodes.Count; num++)
		{
			TreeNode mNode2 = mNode.Nodes[num];
			text = mNode2.Text;
			num3 = text.IndexOf(ArrangeToThis, 0);
			if (num3 > 0)
			{
				text2 = text.Substring(0, num3);
				text2 = text2.Trim();
				for (num2 = text2.Length; num2 < num4; num2++)
				{
					text2 += " ";
				}
				text2 += ": ";
				text = text.Substring(num3 + 1, text.Length - num3 - 1);
				text2 += text.Trim();
				mNode2.Text = text2;
			}
		}
	}

	public static void ArrangeText(ref TreeNodeCollection Tnc, string ArrangeToThis)
	{
		int num = 0;
		for (num = 0; num < Tnc.Count; num++)
		{
			TreeNode mNode = Tnc[num];
			if (mNode.Nodes.Count > 0)
			{
				ArrangeText(ref mNode, ArrangeToThis);
			}
		}
	}

	public static string GetTimeStr(uint TimeValue)
	{
		string text = "";
		uint num = TimeValue;
		uint num2 = num / 60;
		uint num3 = num2 / 60;
		uint num4 = num3 / 24;
		uint num5 = num4 / 30;
		uint num6 = num5 / 12;
		num -= num2 * 60;
		num2 -= num3 * 60;
		num3 -= num4 * 24;
		num4 -= num5 * 30;
		num5 = num6 * 12;
		switch (num6)
		{
		case 1u:
			text = text + num6 + " years , ";
			break;
		default:
			text = text + num6 + " years , ";
			break;
		case 0u:
			break;
		}
		switch (num5)
		{
		case 1u:
			text = text + num5 + " month , ";
			break;
		default:
			text = text + num5 + " months , ";
			break;
		case 0u:
			break;
		}
		switch (num4)
		{
		case 1u:
			text = text + num4 + " day , ";
			break;
		default:
			text = text + num4 + " days , ";
			break;
		case 0u:
			break;
		}
		switch (num3)
		{
		case 1u:
			text = text + num3 + " hour , ";
			break;
		default:
			text = text + num3 + " hours , ";
			break;
		case 0u:
			break;
		}
		switch (num2)
		{
		case 1u:
			text = text + num2 + " minute , ";
			break;
		default:
			text = text + num2 + " minutes , ";
			break;
		case 0u:
			break;
		}
		switch (num)
		{
		case 1u:
			text = text + num + " second , ";
			break;
		default:
			text = text + num + " seconds , ";
			break;
		case 0u:
			break;
		}
		text = text.Trim();
		if (text[text.Length - 1] == ","[0])
		{
			text = text.Substring(0, text.Length - 1);
		}
		return text;
	}

	public static string AnalyzeSmbMessage(string AStr)
	{
		string text = "";
		byte b = 0;
		int num = 0;
		for (num = 0; num < AStr.Length; num++)
		{
			b = (byte)AStr[num];
			text = ((b >= 32 && b <= 128) ? (text + AStr[num]) : (text + "\\" + b + "\\"));
		}
		return text;
	}

	public static TreeNode AddNodeItem(string NodeName, string NodeValue, int IndexOfNode, int LengthOfNode)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		TreeNode mNode = new TreeNode();
		if (NodeName != "")
		{
			if (NodeValue != "")
			{
				mNode.Text = NodeName + " : " + NodeValue;
			}
			else
			{
				mNode.Text = NodeName;
			}
		}
		else
		{
			mNode.Text = NodeValue;
		}
		if (IndexOfNode != -1 && LengthOfNode != -1)
		{
			SetPosition(ref mNode, IndexOfNode, LengthOfNode, BaseOrSub: true);
		}
		return mNode;
	}

	public static void AddNodeItem(ref TreeNode mNode, string NodeName, string NodeValue, int IndexOfNode, int LengthOfNode)
	{
		if (NodeName != "")
		{
			if (NodeValue != "")
			{
				mNode.Nodes.Add(NodeName + " : " + NodeValue);
			}
			else
			{
				mNode.Nodes.Add(NodeName);
			}
		}
		else
		{
			mNode.Nodes.Add(NodeValue);
		}
		if (IndexOfNode != -1 && LengthOfNode != -1)
		{
			SetPosition(ref mNode, IndexOfNode, LengthOfNode, BaseOrSub: false);
		}
	}

	public static TreeNode AddNodeItem(ref TreeNode mNode, string NodeName, ref string NodeValue, object NodeOptionalValue, byte[] Data, ref int Index, int ReadType, int ReadLength, bool PassNullBytes)
	{
		string text = "";
		byte NameNumber = 0;
		int num = 0;
		num = Index;
		switch (ReadType)
		{
		case 0:
			text = GetString(Data, ref Index, IsUnicode: false);
			break;
		case 1:
			text = GetString(Data, ref Index, IsUnicode: true);
			break;
		case 2:
			text = GetUnicodeOrAscii(Data, ref Index);
			break;
		case 4:
			text = GetNetBiosNameSerial(Data, ref Index, ref NameNumber);
			break;
		case 5:
			text = GetNetBiosName(Data, ref Index, ref NameNumber);
			break;
		case 6:
			text = GetIpAddress(Data, ref Index);
			break;
		case 7:
			text = GetIpAddress(Data, ref Index);
			break;
		case 8:
			text = GetString(Data, ref Index, "x02", ReadLength);
			break;
		}
		NodeValue = text;
		text = NodeName + " : " + text;
		mNode.Nodes.Add(text);
		SetPosition(ref mNode, num, Index - num, BaseOrSub: false);
		return mNode.Nodes[mNode.Nodes.Count - 1];
	}

	public static TreeNode AddNodeItem(ref TreeNode mNode, string NodeName, ref byte NodeValue, object NodeOptionalValue, byte[] Data, ref int Index)
	{
		string text = "";
		if (Index == Data.Length)
		{
			text = "[ Malformed Data. There is nothing to get more fielfs from the captured data. Parsed the end of data. The current data index  is " + Index;
			mNode.Text = text;
			Index = -1;
			return mNode;
		}
		NodeValue = Data[Index++];
		text = NodeName + " : " + ReFormatString(NodeValue, NodeOptionalValue);
		mNode.Nodes.Add(text);
		SetPosition(ref mNode, Index - 1, 1, BaseOrSub: false);
		return mNode.Nodes[mNode.Nodes.Count - 1];
	}

	public static TreeNode AddNodeItem(ref TreeNode mNode, string NodeName, ref ushort NodeValue, object NodeOptionalValue, byte[] Data, ref int Index, int Type)
	{
		string text = "";
		if (Index + 2 > Data.Length)
		{
			text = "[ Malformed Data. There is nothing to get more fielfs from the captured data. Parsed the end of data. The current data index  is " + Index;
			mNode.Text = text;
			Index = -1;
			return mNode;
		}
		NodeValue = Get2Bytes(Data, ref Index, Type);
		text = NodeName + " : " + ReFormatString(NodeValue, NodeOptionalValue);
		mNode.Nodes.Add(text);
		SetPosition(ref mNode, Index - 2, 2, BaseOrSub: false);
		return mNode.Nodes[mNode.Nodes.Count - 1];
	}

	public static TreeNode AddNodeItem(ref TreeNode mNode, string NodeName, ref uint NodeValue, object NodeOptionalValue, byte[] Data, ref int Index, int Type)
	{
		string text = "";
		if (Index + 4 > Data.Length)
		{
			text = "[ Malformed Data. There is nothing to get more fielfs from the captured data. Parsed the end of data. The current data index  is " + Index;
			mNode.Text = text;
			Index = -1;
			return mNode;
		}
		NodeValue = Get4Bytes(Data, ref Index, Type);
		text = NodeName + " : " + ReFormatString(NodeValue, NodeOptionalValue);
		mNode.Nodes.Add(text);
		SetPosition(ref mNode, Index - 4, 4, BaseOrSub: false);
		return mNode.Nodes[mNode.Nodes.Count - 1];
	}

	public static void GetDateTime(uint Seconds, ref string Date, ref string Time)
	{
		string[] array = new string[13];
		string[] array2 = new string[8];
		uint num = 31536000u;
		uint num2 = 2628000u;
		uint num3 = 86400u;
		uint num4 = 3600u;
		uint num5 = 60u;
		array[0] = "";
		array[1] = "January";
		array[2] = "February";
		array[3] = "March";
		array[4] = "April";
		array[5] = "May";
		array[6] = "June";
		array[7] = "July";
		array[8] = "August";
		array[9] = "September";
		array[10] = "October";
		array[11] = "November";
		array[12] = "December";
		array2[0] = "";
		array2[1] = "Monday";
		array2[2] = "Tuesday";
		array2[3] = "Wednesday";
		array2[4] = "Thursday";
		array2[5] = "Friday";
		array2[6] = "Saturday";
		array2[7] = "Sunday";
		uint num6 = Seconds / num;
		Seconds -= num6 * num - num6 / 4;
		num6 += 1970;
		uint num7 = Seconds / num2;
		Seconds -= num7 * num2 - num7 * 4 / 10;
		uint num8 = Seconds / num3;
		Seconds -= num8 * num3;
		uint num9 = Seconds / num4;
		Seconds -= num9 * num4;
		uint num10 = Seconds / num5;
		Seconds -= num10 * num5;
		Date = array2[num8 / 7] + " " + array[num7] + " " + num8 + ", " + num6;
		Time = num9 + ":" + num10;
	}
}
