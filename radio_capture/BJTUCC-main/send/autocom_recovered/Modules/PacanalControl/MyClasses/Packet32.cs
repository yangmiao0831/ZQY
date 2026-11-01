using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace MyClasses;

public class Packet32
{
	public struct PACKET_FILE_HEADER
	{
		public uint Magic;

		public ushort MajorVersion;

		public ushort MinorVersion;

		public uint ThisZone;

		public uint SigFigs;

		public uint SnapLen;

		public uint LinkType;
	}

	public struct PACKET_USAGE_ITEM
	{
		public string Name;

		public double Count;

		public double BandWidth;

		public double TotalByte;

		public double StartTime;

		public double StopTime;

		public double TotalTime;

		public double Percantage;

		public string PercantageStr;
	}

	public struct CAPTURE_OPTIONS
	{
		public int AdapterIndex;

		public bool LimitPackets;

		public int PacketSize;

		public bool PromiscuousMode;

		public string Filter;

		public int AdapterBufferSize;

		public int BufferSize;

		public int NumWrites;

		public int ReadTimeOut;

		public int MinBytesToCopy;

		public int CaptureMode;

		public int HardwareFilter;
	}

	public struct DISPLAY_OPTIONS
	{
		public bool UpdateListInRealTime;

		public bool AutomaticScrollInLiveCapture;
	}

	public struct CAPTURE_LIMITS
	{
		public bool LimitToPackets;

		public int PacketSize;

		public bool LimitToKiloBytes;

		public int KilobyteSize;

		public bool LimitToSeconds;

		public int SecondSize;
	}

	public struct NAME_RESOLUTION
	{
		public bool EnableMAC;

		public bool EnableNetwork;

		public bool EnableTransport;

		public bool EnableManufacturer;
	}

	public struct PROTOCOL_ITEM
	{
		public int Count;

		public string CountStr;

		public double Pct;

		public string PctStr;
	}

	public struct PROTOCOL_LIST_ITEM
	{
		public string Name;

		public string Description;

		public bool Enable;

		public int Count;

		public string CountStr;

		public double Pct;

		public string PctStr;
	}

	public struct CAPTURE_STATUS
	{
		public PROTOCOL_ITEM Total;

		public PROTOCOL_ITEM SCPT;

		public PROTOCOL_ITEM TCP;

		public PROTOCOL_ITEM UDP;

		public PROTOCOL_ITEM ICMP;

		public PROTOCOL_ITEM ARP;

		public PROTOCOL_ITEM OSPF;

		public PROTOCOL_ITEM GRE;

		public PROTOCOL_ITEM NetBIOS;

		public PROTOCOL_ITEM IPX;

		public PROTOCOL_ITEM VINES;

		public PROTOCOL_ITEM Other;

		public int Seconds;

		public string SecondsStr;

		public int Kilobytes;

		public string KilobytesStr;
	}

	private CAPTURE_OPTIONS mCaptureOptions;

	private DISPLAY_OPTIONS mDisplayOptions;

	public PACKET_FILE_HEADER PacketFileHeader;

	public uint FirstSeconds;

	public uint FirstMiliSeconds;

	public ulong FirstLongValue;

	public bool PacketOnOff;

	private TreeNode GlobalNode = new TreeNode();

	private ArrayList ReceivedPackets = new ArrayList();

	private ArrayList BandUsage = new ArrayList();

	public PACKET_USAGE_ITEM PacketUsageItem;

	public Packet32h P32h = new Packet32h();

	public PacketParser PParser = new PacketParser();

	private int LastPosition;

	public CAPTURE_OPTIONS CaptureOptions
	{
		get
		{
			return mCaptureOptions;
		}
		set
		{
			mCaptureOptions = value;
		}
	}

	public DISPLAY_OPTIONS DisplayOptions
	{
		get
		{
			return mDisplayOptions;
		}
		set
		{
			mDisplayOptions = value;
		}
	}

	public bool LoadFromFile(string FileName)
	{
		StreamReader streamReader = new StreamReader(FileName);
		int num = 24;
		byte[] array = new byte[num];
		PacketOnOff = false;
		P32h.CapturedPacketArray.Clear();
		ReceivedPackets.Clear();
		Stream baseStream = streamReader.BaseStream;
		byte[] array2 = new byte[(int)baseStream.Length - num];
		baseStream.Read(array, 0, num);
		if (array[0] == 161)
		{
			Const.CurFileType = 0;
		}
		else
		{
			Const.CurFileType = 1;
		}
		baseStream.Read(array2, 0, (int)baseStream.Length - num);
		streamReader.Close();
		P32h.CapturedPacketArray.Add(array2);
		PParser.PacketBufferData = array2;
		return true;
	}

	public int ReadFileIncrement(string FileName, int filePos)
	{
		StreamReader streamReader = new StreamReader(FileName);
		Stream baseStream = streamReader.BaseStream;
		baseStream.Seek(filePos, SeekOrigin.Begin);
		byte[] array = new byte[(int)baseStream.Length - filePos];
		streamReader.BaseStream.Read(array, 0, (int)baseStream.Length - filePos);
		LastPosition = (int)baseStream.Length;
		streamReader.Close();
		if (PParser.CacheDataList.Count > 0)
		{
			PParser.CacheDataList.AddRange(array);
			byte[] array2 = new byte[PParser.CacheDataList.Count];
			PParser.CacheDataList.CopyTo(array2);
			P32h.CapturedPacketArray.Add(array2);
			PParser.PacketBufferData = array2;
			PParser.CacheDataList.Clear();
		}
		else
		{
			P32h.CapturedPacketArray.Add(array);
			PParser.PacketBufferData = array;
		}
		return LastPosition;
	}
}
