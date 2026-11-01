namespace ZLGCAN;

public struct ZCAN_AUTO_TRANSMIT_OBJ
{
	public ushort enable;

	public ushort index;

	public uint interval;

	public ZCAN_Transmit_Data obj;
}
