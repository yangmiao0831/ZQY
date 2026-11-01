namespace MyClasses;

public class PACKET_ITEM
{
	public string Time;

	public string Source;

	public string SourcePort;

	public string Destination;

	public string DestinationPort;

	public string Protocol;

	public string Sequence;

	public string Acknowledge;

	public string Info;

	public uint Seconds;

	public uint MicroSeconds;

	public uint CaptureLength;

	public string CaptureTimeStr;

	public uint PacketLength;

	public uint Reserved;

	public string TypeInfo;

	public byte[] FrameData;

	public byte[] Data;
}
