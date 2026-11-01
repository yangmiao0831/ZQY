namespace ZLGCAN;

public struct ZCAN_ReceiveFD_Data
{
	public canfd_frame frame;

	public ulong timestamp;
}
