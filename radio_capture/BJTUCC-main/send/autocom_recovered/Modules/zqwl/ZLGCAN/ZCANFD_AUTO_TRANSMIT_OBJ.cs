namespace ZLGCAN;

public struct ZCANFD_AUTO_TRANSMIT_OBJ
{
	public ushort enable;

	public ushort index;

	public uint interval;

	public ZCAN_TransmitFD_Data obj;
}
