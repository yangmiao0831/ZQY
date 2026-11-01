using System.Collections;

namespace MyClasses;

public class Packet32h
{
	public const int NDIS_PACKET_TYPE_DIRECTED = 1;

	public const int NDIS_PACKET_TYPE_MULTICAST = 2;

	public const int NDIS_PACKET_TYPE_ALL_MULTICAST = 4;

	public const int NDIS_PACKET_TYPE_BROADCAST = 8;

	public const int NDIS_PACKET_TYPE_SOURCE_ROUTING = 16;

	public const int NDIS_PACKET_TYPE_PROMISCUOUS = 32;

	public const int NDIS_PACKET_TYPE_SMT = 64;

	public const int NDIS_PACKET_TYPE_ALL_LOCAL = 128;

	public const int NDIS_PACKET_TYPE_GROUP = 4096;

	public const int NDIS_PACKET_TYPE_ALL_FUNCTIONAL = 8192;

	public const int NDIS_PACKET_TYPE_FUNCTIONAL = 16384;

	public const int NDIS_PACKET_TYPE_MAC_FRAME = 32768;

	public const int WSADESCRIPTION_LEN = 256;

	public const int WSASYS_STATUS_LEN = 128;

	public static uint PACKET_MODE_CAPT = 0u;

	public static uint PACKET_MODE_STAT = 1u;

	public static uint PACKET_MODE_DUMP = 16u;

	public static uint PACKET_MODE_STAT_DUMP = PACKET_MODE_DUMP | PACKET_MODE_STAT;

	public static uint FILE_DEVICE_PROTOCOL = 32768u;

	public static uint IOCTL_PROTOCOL_QUERY_OID = DeviceIOCtlh.CTL_CODE(FILE_DEVICE_PROTOCOL, 0u, DeviceIOCtlh.METHOD_BUFFERED, DeviceIOCtlh.FILE_ANY_ACCESS);

	public static uint IOCTL_PROTOCOL_SET_OID = DeviceIOCtlh.CTL_CODE(FILE_DEVICE_PROTOCOL, 1u, DeviceIOCtlh.METHOD_BUFFERED, DeviceIOCtlh.FILE_ANY_ACCESS);

	public static uint IOCTL_PROTOCOL_STATISTICS = DeviceIOCtlh.CTL_CODE(FILE_DEVICE_PROTOCOL, 2u, DeviceIOCtlh.METHOD_BUFFERED, DeviceIOCtlh.FILE_ANY_ACCESS);

	public static uint IOCTL_PROTOCOL_RESET = DeviceIOCtlh.CTL_CODE(FILE_DEVICE_PROTOCOL, 3u, DeviceIOCtlh.METHOD_BUFFERED, DeviceIOCtlh.FILE_ANY_ACCESS);

	public static uint IOCTL_PROTOCOL_READ = DeviceIOCtlh.CTL_CODE(FILE_DEVICE_PROTOCOL, 4u, DeviceIOCtlh.METHOD_BUFFERED, DeviceIOCtlh.FILE_ANY_ACCESS);

	public static uint IOCTL_PROTOCOL_WRITE = DeviceIOCtlh.CTL_CODE(FILE_DEVICE_PROTOCOL, 5u, DeviceIOCtlh.METHOD_BUFFERED, DeviceIOCtlh.FILE_ANY_ACCESS);

	public static uint IOCTL_PROTOCOL_MACNAME = DeviceIOCtlh.CTL_CODE(FILE_DEVICE_PROTOCOL, 6u, DeviceIOCtlh.METHOD_BUFFERED, DeviceIOCtlh.FILE_ANY_ACCESS);

	public static uint IOCTL_OPEN = DeviceIOCtlh.CTL_CODE(FILE_DEVICE_PROTOCOL, 7u, DeviceIOCtlh.METHOD_BUFFERED, DeviceIOCtlh.FILE_ANY_ACCESS);

	public static uint IOCTL_CLOSE = DeviceIOCtlh.CTL_CODE(FILE_DEVICE_PROTOCOL, 8u, DeviceIOCtlh.METHOD_BUFFERED, DeviceIOCtlh.FILE_ANY_ACCESS);

	public static uint pBIOCSETBUFFERSIZE = 9592u;

	public static uint pBIOCSETF = 9030u;

	public static uint pBIOCGSTATS = 9031u;

	public static uint pBIOCSRTIMEOUT = 7416u;

	public static uint pBIOCSMODE = 7412u;

	public static uint pBIOCSWRITEREP = 7413u;

	public static uint pBIOCSMINTOCOPY = 7414u;

	public static uint pBIOCSETOID = 2147483648u;

	public static uint pBIOCQUERYOID = 2147483652u;

	public static uint pATTACHPROCESS = 7117u;

	public static uint pDETACHPROCESS = 7118u;

	public static uint pBIOCSETDUMPFILENAME = 9029u;

	public static uint pBIOCEVNAME = 7415u;

	public static uint pBIOCSENDPACKETSNOSYNC = 9032u;

	public static uint pBIOCSENDPACKETSSYNC = 9033u;

	public static uint pBIOCSETDUMPLIMITS = 9034u;

	public static uint pBIOCISDUMPENDED = 7411u;

	public static uint pBIOCSTIMEZONE = 7471u;

	public static uint GMEM_MOVEABLE = 2u;

	public static uint GMEM_ZEROINIT = 64u;

	public static uint GHND = GMEM_MOVEABLE | GMEM_ZEROINIT;

	public static uint GMEM_STANDARD = GMEM_MOVEABLE | GMEM_ZEROINIT;

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

	public static uint Packet_ALIGNMENT = 4u;

	public static uint AF_INET = 2u;

	public static string DOSNAMEPREFIX = "Packet_";

	public static uint MAX_LINK_NAME_LENGTH = 64u;

	public static uint NMAX_PACKET = 65535u;

	public static uint SOCK_STREAM = 1u;

	public static uint SOCK_DGRAM = 2u;

	public static uint SOCK_RAW = 3u;

	public static uint SOCK_RDM = 4u;

	public static uint SOCK_SEQPACKET = 5u;

	public static uint SO_DEBUG = 1u;

	public static uint SO_ACCEPTCONN = 2u;

	public static uint SO_REUSEADDR = 4u;

	public static uint SO_KEEPALIVE = 8u;

	public static uint SO_DONTROUTE = 16u;

	public static uint SO_BROADCAST = 32u;

	public static uint SO_USELOOPBACK = 64u;

	public static uint SO_LINGER = 128u;

	public static uint SO_OOBINLINE = 256u;

	public static uint SO_DONTLINGER = ~SO_LINGER;

	public static uint SO_EXCLUSIVEADDRUSE = ~SO_REUSEADDR;

	public static uint SO_SNDBUF = 4097u;

	public static uint SO_RCVBUF = 4098u;

	public static uint SO_SNDLOWAT = 4099u;

	public static uint SO_RCVLOWAT = 4100u;

	public static uint SO_SNDTIMEO = 4101u;

	public static uint SO_RCVTIMEO = 4102u;

	public static uint SO_ERROR = 4103u;

	public static uint SO_TYPE = 4104u;

	public static uint SO_GROUP_ID = 8193u;

	public static uint SO_GROUP_PRIORITY = 8194u;

	public static uint SO_MAX_MSG_SIZE = 8195u;

	public static uint SO_PROTOCOL_INFOA = 8196u;

	public static uint SO_PROTOCOL_INFOW = 8197u;

	public static uint PVD_CONFIG = 12289u;

	public static uint SO_CONDITIONAL_ACCEPT = 12290u;

	private ArrayList mCapturedPacketArray = new ArrayList();

	public ArrayList CapturedPacketArray => mCapturedPacketArray;
}
