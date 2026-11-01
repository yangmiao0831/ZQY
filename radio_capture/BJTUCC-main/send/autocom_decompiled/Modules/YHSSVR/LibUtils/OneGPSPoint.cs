using System.Runtime.InteropServices;

namespace LibUtils;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct OneGPSPoint
{
	public long Time;

	public double Long;

	public double Lat;

	public double Altitude;

	public double Speed;

	public int StatlliteNum;
}
