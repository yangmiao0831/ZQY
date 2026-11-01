namespace ZLGCAN;

public struct CANFD
{
	public uint acc_code;

	public uint acc_mask;

	public uint abit_timing;

	public uint dbit_timing;

	public uint brp;

	public byte filter;

	public byte mode;

	public ushort pad;

	public uint reserved;
}
