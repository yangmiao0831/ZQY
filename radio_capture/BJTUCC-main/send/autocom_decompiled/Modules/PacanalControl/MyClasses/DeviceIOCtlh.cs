namespace MyClasses;

public class DeviceIOCtlh
{
	public static uint FILE_DEVICE_BEEP = 1u;

	public static uint FILE_DEVICE_CD_ROM = 2u;

	public static uint FILE_DEVICE_CD_ROM_FILE_SYSTEM = 3u;

	public static uint FILE_DEVICE_CONTROLLER = 4u;

	public static uint FILE_DEVICE_DATALINK = 5u;

	public static uint FILE_DEVICE_DFS = 6u;

	public static uint FILE_DEVICE_DISK = 7u;

	public static uint FILE_DEVICE_DISK_FILE_SYSTEM = 8u;

	public static uint FILE_DEVICE_FILE_SYSTEM = 9u;

	public static uint FILE_DEVICE_INPORT_PORT = 10u;

	public static uint FILE_DEVICE_KEYBOARD = 11u;

	public static uint FILE_DEVICE_MAILSLOT = 12u;

	public static uint FILE_DEVICE_MIDI_IN = 13u;

	public static uint FILE_DEVICE_MIDI_OUT = 14u;

	public static uint FILE_DEVICE_MOUSE = 15u;

	public static uint FILE_DEVICE_MULTI_UNC_PROVIDER = 16u;

	public static uint FILE_DEVICE_NAMED_PIPE = 17u;

	public static uint FILE_DEVICE_NETWORK = 18u;

	public static uint FILE_DEVICE_NETWORK_BROWSER = 19u;

	public static uint FILE_DEVICE_NETWORK_FILE_SYSTEM = 20u;

	public static uint FILE_DEVICE_NULL = 21u;

	public static uint FILE_DEVICE_PARALLEL_PORT = 22u;

	public static uint FILE_DEVICE_PHYSICAL_NETCARD = 23u;

	public static uint FILE_DEVICE_PRINTER = 24u;

	public static uint FILE_DEVICE_SCANNER = 25u;

	public static uint FILE_DEVICE_SERIAL_MOUSE_PORT = 26u;

	public static uint FILE_DEVICE_SERIAL_PORT = 27u;

	public static uint FILE_DEVICE_SCREEN = 28u;

	public static uint FILE_DEVICE_SOUND = 29u;

	public static uint FILE_DEVICE_STREAMS = 30u;

	public static uint FILE_DEVICE_TAPE = 31u;

	public static uint FILE_DEVICE_TAPE_FILE_SYSTEM = 32u;

	public static uint FILE_DEVICE_TRANSPORT = 33u;

	public static uint FILE_DEVICE_UNKNOWN = 34u;

	public static uint FILE_DEVICE_VIDEO = 35u;

	public static uint FILE_DEVICE_VIRTUAL_DISK = 36u;

	public static uint FILE_DEVICE_WAVE_IN = 37u;

	public static uint FILE_DEVICE_WAVE_OUT = 38u;

	public static uint FILE_DEVICE_8042_PORT = 39u;

	public static uint FILE_DEVICE_NETWORK_REDIRECTOR = 40u;

	public static uint FILE_DEVICE_BATTERY = 41u;

	public static uint FILE_DEVICE_BUS_EXTENDER = 42u;

	public static uint FILE_DEVICE_MODEM = 43u;

	public static uint FILE_DEVICE_VDM = 44u;

	public static uint FILE_DEVICE_MASS_STORAGE = 45u;

	public static uint METHOD_BUFFERED = 0u;

	public static uint METHOD_IN_DIRECT = 1u;

	public static uint METHOD_OUT_DIRECT = 2u;

	public static uint METHOD_NEITHER = 3u;

	public static uint FILE_ANY_ACCESS = 0u;

	public static uint FILE_READ_ACCESS = 1u;

	public static uint FILE_WRITE_ACCESS = 2u;

	public static uint CTL_CODE(uint DeviceType, uint Function, uint Method, uint Access)
	{
		return (DeviceType << 16) | (Access << 14) | (Function << 2) | Method;
	}
}
