using System;

namespace MyClasses;

public class NtddNDish
{
	public struct NDIS_STATISTICS_VALUE
	{
		public ulong Oid;

		public ulong DataLength;

		public char[] Data;
	}

	public struct NET_PNP_ID
	{
		public ulong ClassId;

		public ulong Token;
	}

	public struct NET_PNP_TRANSLATE_LIST
	{
		public ulong BytesNeeded;

		public NET_PNP_ID[] IdArray;
	}

	public struct NDIS_VAR_DATA_DESC
	{
		public ushort Length;

		public ushort MaximumLength;

		public long Offset;
	}

	public enum NDIS_MEDIUM
	{
		NdisMedium802_3,
		NdisMedium802_5,
		NdisMediumFddi,
		NdisMediumWan,
		NdisMediumLocalTalk,
		NdisMediumDix,
		NdisMediumArcnetRaw,
		NdisMediumArcnet878_2,
		NdisMediumAtm,
		NdisMediumWirelessWan,
		NdisMediumIrda,
		NdisMediumMax
	}

	public enum NDIS_HARDWARE_STATUS
	{
		NdisHardwareStatusReady,
		NdisHardwareStatusInitializing,
		NdisHardwareStatusReset,
		NdisHardwareStatusClosing,
		NdisHardwareStatusNotReady
	}

	public struct GEN_GET_TIME_CAPS
	{
		public ulong Flags;

		public ulong ClockPrecision;
	}

	public struct GEN_GET_NETCARD_TIME
	{
		public ulong ReadTime;
	}

	public enum NDIS_FDDI_ATTACHMENT_TYPE
	{
		NdisFddiTypeIsolated = 1,
		NdisFddiTypeLocalA,
		NdisFddiTypeLocalB,
		NdisFddiTypeLocalAB,
		NdisFddiTypeLocalS,
		NdisFddiTypeWrapA,
		NdisFddiTypeWrapB,
		NdisFddiTypeWrapAB,
		NdisFddiTypeWrapS,
		NdisFddiTypeCWrapA,
		NdisFddiTypeCWrapB,
		NdisFddiTypeCWrapS,
		NdisFddiTypeThrough
	}

	public enum NDIS_FDDI_RING_MGT_STATE
	{
		NdisFddiRingIsolated = 1,
		NdisFddiRingNonOperational,
		NdisFddiRingOperational,
		NdisFddiRingDetect,
		NdisFddiRingNonOperationalDup,
		NdisFddiRingOperationalDup,
		NdisFddiRingDirected,
		NdisFddiRingTrace
	}

	public enum NDIS_FDDI_LCONNECTION_STATE
	{
		NdisFddiStateOff = 1,
		NdisFddiStateBreak,
		NdisFddiStateTrace,
		NdisFddiStateConnect,
		NdisFddiStateNext,
		NdisFddiStateSignal,
		NdisFddiStateJoin,
		NdisFddiStateVerify,
		NdisFddiStateActive,
		NdisFddiStateMaintenance
	}

	public enum NDIS_WAN_MEDIUM_SUBTYPE
	{
		NdisWanMediumHub,
		NdisWanMediumX_25,
		NdisWanMediumIsdn,
		NdisWanMediumSerial,
		NdisWanMediumFrameRelay,
		NdisWanMediumAtm,
		NdisWanMediumSonet,
		NdisWanMediumSW56K
	}

	public enum NDIS_WAN_HEADER_FORMAT
	{
		NdisWanHeaderNative,
		NdisWanHeaderEthernet
	}

	public enum NDIS_WAN_QUALITY
	{
		NdisWanRaw,
		NdisWanErrorControl,
		NdisWanReliable
	}

	public enum NDIS_802_5_RING_STATE
	{
		NdisRingStateOpened = 1,
		NdisRingStateClosed,
		NdisRingStateOpening,
		NdisRingStateClosing,
		NdisRingStateOpenFailure,
		NdisRingStateRingFailure
	}

	public enum NDIS_MEDIA_STATE
	{
		NdisMediaStateConnected,
		NdisMediaStateDisconnected
	}

	public struct NDIS_CO_LINK_SPEED
	{
		public ulong Outbound;

		public ulong Inbound;
	}

	public struct NDIS_IRDA_PACKET_INFO
	{
		public uint ExtraBOFs;

		public uint MinTurnAroundTime;
	}

	public enum NDIS_WW_NETWORK_TYPE
	{
		NdisWWGeneric,
		NdisWWMobitex,
		NdisWWPinpoint,
		NdisWWCDPD,
		NdisWWArdis,
		NdisWWDataTAC,
		NdisWWMetricom,
		NdisWWGSM,
		NdisWWCDMA,
		NdisWWTDMA,
		NdisWWAMPS,
		NdisWWInmarsat,
		NdisWWpACT
	}

	public enum NDIS_WW_HEADER_FORMAT
	{
		NdisWWDIXEthernetFrames,
		NdisWWMPAKFrames,
		NdisWWRDLAPFrames,
		NdisWWMDC4800Frames
	}

	public enum NDIS_WW_ENCRYPTION_TYPE
	{
		NdisWWUnknownEncryption = -1,
		NdisWWNoEncryption,
		NdisWWDefaultEncryption
	}

	public struct NDIS_WW_INDICATION_REQUEST
	{
		public ulong Oid;

		public uint uIndicationFlag;

		public uint uApplicationToken;

		public IntPtr hIndicationHandle;

		public int iPollingInterval;

		public NDIS_VAR_DATA_DESC InitialValue;

		public NDIS_VAR_DATA_DESC OIDIndicationValue;

		public NDIS_VAR_DATA_DESC TriggerValue;
	}

	public struct WW_DEVICE_INFO
	{
		public NDIS_VAR_DATA_DESC Manufacturer;

		public NDIS_VAR_DATA_DESC ModelNum;

		public NDIS_VAR_DATA_DESC SWVersionNum;

		public NDIS_VAR_DATA_DESC SerialNum;
	}

	public struct WW_CURRENT_ADDRESS
	{
		public NDIS_WW_HEADER_FORMAT Format;

		public NDIS_VAR_DATA_DESC Address;
	}

	public struct WW_TAC_SETCONFIG
	{
		public NDIS_VAR_DATA_DESC RCV_MODE;

		public NDIS_VAR_DATA_DESC TX_CONTROL;

		public NDIS_VAR_DATA_DESC RX_CONTROL;

		public NDIS_VAR_DATA_DESC FLOW_CONTROL;

		public NDIS_VAR_DATA_DESC RESET_CNF;

		public NDIS_VAR_DATA_DESC READ_CNF;
	}

	public struct WW_TAC_GETSTATUS
	{
		public int Action;

		public NDIS_VAR_DATA_DESC Command;

		public NDIS_VAR_DATA_DESC Option;

		public NDIS_VAR_DATA_DESC Response;
	}

	public struct WW_ARD_SNDCP
	{
		public NDIS_VAR_DATA_DESC Version;

		public int BlockSize;

		public int Window;
	}

	public struct WW_ARD_DATAGRAM
	{
		public int LoadLevel;

		public int SessionTime;

		public NDIS_VAR_DATA_DESC HostAddr;

		public NDIS_VAR_DATA_DESC THostAddr;
	}

	public struct WW_CDPD_SPNI
	{
		public uint[] SPNI;

		public int OperatingMode;
	}

	public struct WW_CDPD_WIDE_AREA_SERVICE_ID
	{
		public int[] WASI;

		public int OperatingMode;
	}

	public struct WW_CDPD_CHANNEL_SELECT
	{
		public uint ChannelID;

		public uint fixedDuration;
	}

	public enum WW_CDPD_CHANNEL_STATE
	{
		CDPDChannelNotAvail,
		CDPDChannelScanning,
		CDPDChannelInitAcquired,
		CDPDChannelAcquired,
		CDPDChannelSleeping,
		CDPDChannelWaking,
		CDPDChannelCSDialing,
		CDPDChannelCSRedial,
		CDPDChannelCSAnswering,
		CDPDChannelCSConnected,
		CDPDChannelCSSuspended
	}

	public enum WW_CDPD_NEI_FORMAT
	{
		CDPDNeiIPv4,
		CDPDNeiCLNP,
		CDPDNeiIPv6
	}

	public enum WW_CDPD_NEI_TYPE
	{
		CDPDNeiIndividual,
		CDPDNeiMulticast,
		CDPDNeiBroadcast
	}

	public struct WW_CDPD_NEI
	{
		public uint uNeiIndex;

		public WW_CDPD_NEI_FORMAT NeiFormat;

		public WW_CDPD_NEI_TYPE NeiType;

		public uint NeiGmid;

		public NDIS_VAR_DATA_DESC NeiAddress;
	}

	public enum WW_CDPD_NEI_STATE
	{
		CDPDUnknown,
		CDPDRegistered,
		CDPDDeregistered
	}

	public enum WW_CDPD_NEI_SUB_STATE
	{
		CDPDPending,
		CDPDNoReason,
		CDPDMDISNotCapable,
		CDPDNEINotAuthorized,
		CDPDInsufficientAuth,
		CDPDUnsupportedAuth,
		CDPDUsageExceeded,
		CDPDDeniedThisNetwork
	}

	public struct WW_CDPD_NEI_REG_STATE
	{
		public uint uNeiIndex;

		public WW_CDPD_NEI_STATE NeiState;

		public WW_CDPD_NEI_SUB_STATE NeiSubState;
	}

	public struct WW_CDPD_SERVICE_PROVIDER_ID
	{
		public uint[] SPI;

		public int OperatingMode;
	}

	public struct WW_CDPD_CIRCUIT_SWITCHED
	{
		public int service_preference;

		public int service_status;

		public int connect_rate;

		public NDIS_VAR_DATA_DESC[] dial_code;

		public uint sid;

		public int a_b_side_selection;

		public int AMPS_channel;

		public uint action;

		public NDIS_VAR_DATA_DESC[] default_dial;

		public NDIS_VAR_DATA_DESC[] call_back;

		public uint[] sid_list;

		public uint inactivity_timer;

		public uint receive_timer;

		public uint conn_resp_timer;

		public uint reconn_resp_timer;

		public uint disconn_timer;

		public uint NEI_reg_timer;

		public uint reconn_retry_timer;

		public uint link_reset_timer;

		public uint link_reset_ack_timer;

		public uint n401_retry_limit;

		public uint n402_retry_limit;

		public uint n404_retry_limit;

		public uint n405_retry_limit;
	}

	public struct WW_PIN_LOCATION
	{
		public int Latitude;

		public int Longitude;

		public int Altitude;

		public int FixTime;

		public int NetTime;

		public int LocQuality;

		public int LatReg;

		public int LongReg;

		public int GMTOffset;
	}

	public struct WW_MBX_PMAN
	{
		public int ACTION;

		public uint MAN;

		public char[] PASSWORD;
	}

	public struct WW_MBX_FLEXLIST
	{
		public int count;

		public uint[] MAN;
	}

	public struct WW_MBX_GROUPLIST
	{
		public int count;

		public uint[] MAN;
	}

	public enum WW_MBX_TRAFFIC_AREA
	{
		unknown_traffic_area,
		in_traffic_area,
		in_auth_traffic_area,
		unauth_traffic_area
	}

	public struct WW_MBX_CHANNEL_PAIR
	{
		public uint Mobile_Tx;

		public uint Mobile_Rx;
	}

	public struct WW_MBX_TEMPDEFAULTLIST
	{
		public uint Length;

		public WW_MBX_CHANNEL_PAIR[] ChannelPair;
	}

	public string DD_NDIS_DEVICE_NAME = "\\Device\\UNKNOWN";

	public static uint IOCTL_NDIS_QUERY_GLOBAL_STATS = NDIS_CONTROL_CODE(0u, DeviceIOCtlh.METHOD_OUT_DIRECT);

	public static uint IOCTL_NDIS_QUERY_ALL_STATS = NDIS_CONTROL_CODE(1u, DeviceIOCtlh.METHOD_OUT_DIRECT);

	public static uint IOCTL_NDIS_ADD_DEVICE = NDIS_CONTROL_CODE(2u, DeviceIOCtlh.METHOD_BUFFERED);

	public static uint IOCTL_NDIS_DELETE_DEVICE = NDIS_CONTROL_CODE(3u, DeviceIOCtlh.METHOD_BUFFERED);

	public static uint IOCTL_NDIS_TRANSLATE_NAME = NDIS_CONTROL_CODE(4u, DeviceIOCtlh.METHOD_BUFFERED);

	public static uint IOCTL_NDIS_ADD_TDI_DEVICE = NDIS_CONTROL_CODE(5u, DeviceIOCtlh.METHOD_BUFFERED);

	public static uint IOCTL_NDIS_NOTIFY_PROTOCOL = NDIS_CONTROL_CODE(6u, DeviceIOCtlh.METHOD_BUFFERED);

	public static uint IOCTL_NDIS_GET_LOG_DATA = NDIS_CONTROL_CODE(7u, DeviceIOCtlh.METHOD_OUT_DIRECT);

	public static uint OID_GEN_BROADCAST_BYTES_RCV = 131595u;

	public static uint OID_GEN_BROADCAST_BYTES_XMIT = 131589u;

	public static uint OID_GEN_BROADCAST_FRAMES_RCV = 131596u;

	public static uint OID_GEN_BROADCAST_FRAMES_XMIT = 131590u;

	public static uint OID_GEN_DIRECTED_BYTES_RCV = 131591u;

	public static uint OID_GEN_DIRECTED_BYTES_XMIT = 131585u;

	public static uint OID_GEN_DRIVER_VERSION = 65808u;

	public static uint OID_GEN_GET_NETCARD_TIME = 131600u;

	public static uint OID_GEN_GET_TIME_CAPS = 131599u;

	public static uint OID_GEN_HARDWARE_STATUS = 65794u;

	public static uint OID_GEN_LINK_SPEED = 65799u;

	public static uint OID_GEN_MAC_OPTIONS = 65811u;

	public static uint OID_GEN_MEDIA_CONNECT_STATUS = 65812u;

	public static uint OID_GEN_MEDIA_IN_USE = 65796u;

	public static uint OID_GEN_MEDIA_SUPPORTED = 65795u;

	public static uint OID_GEN_PROTOCOL_OPTIONS = 65810u;

	public static uint OID_GEN_RCV_CRC_ERROR = 131597u;

	public static uint OID_GEN_RCV_ERROR = 131332u;

	public static uint OID_GEN_RCV_NO_BUFFER = 131333u;

	public static uint OID_GEN_RCV_OK = 131330u;

	public static uint OID_GEN_SUPPORTED_LIST = 65793u;

	public static uint OID_GEN_TRANSMIT_QUEUE_LENGTH = 131598u;

	public static uint OID_GEN_VENDOR_DESCRIPTION = 65805u;

	public static uint OID_GEN_VENDOR_DRIVER_VERSION = 65814u;

	public static uint OID_GEN_VENDOR_ID = 65804u;

	public static uint OID_GEN_XMIT_ERROR = 131331u;

	public static uint OID_GEN_XMIT_OK = 131329u;

	public static uint OID_GEN_CURRENT_LOOKAHEAD = 65807u;

	public static uint OID_GEN_CURRENT_PACKET_FILTER = 65806u;

	public static uint OID_GEN_DIRECTED_FRAMES_RCV = 131592u;

	public static uint OID_GEN_DIRECTED_FRAMES_XMIT = 131586u;

	public static uint OID_GEN_MAXIMUM_FRAME_SIZE = 65798u;

	public static uint OID_GEN_MAXIMUM_LOOKAHEAD = 65797u;

	public static uint OID_GEN_MAXIMUM_SEND_PACKETS = 65813u;

	public static uint OID_GEN_MAXIMUM_TOTAL_SIZE = 65809u;

	public static uint OID_GEN_MULTICAST_BYTES_RCV = 131593u;

	public static uint OID_GEN_MULTICAST_BYTES_XMIT = 131587u;

	public static uint OID_GEN_MULTICAST_FRAMES_RCV = 131594u;

	public static uint OID_GEN_MULTICAST_FRAMES_XMIT = 131588u;

	public static uint OID_GEN_RECEIVE_BLOCK_SIZE = 65803u;

	public static uint OID_GEN_RECEIVE_BUFFER_SPACE = 65801u;

	public static uint OID_GEN_RESET_COUNTS = 131604u;

	public static uint OID_GEN_TRANSMIT_BLOCK_SIZE = 65802u;

	public static uint OID_GEN_TRANSMIT_BUFFER_SPACE = 65800u;

	public static uint OID_GEN_DEVICE_PROFILE = 131602u;

	public static uint OID_GEN_NETCARD_LOAD = 131601u;

	public static uint OID_GEN_SUPPORTED_GUIDS = 65815u;

	public static uint OID_GEN_FRIENDLY_NAME = 131606u;

	public static uint OID_GEN_INIT_TIME_MS = 131603u;

	public static uint OID_GEN_MEDIA_CAPABILITIES = 66049u;

	public static uint OID_GEN_MEDIA_SENSE_COUNTS = 131605u;

	public static uint OID_GEN_NETWORK_LAYER_ADDRESSES = 65816u;

	public static uint OID_GEN_PHYSICAL_MEDIUM = 66050u;

	public static uint OID_GEN_TRANSPORT_HEADER_OFFSET = 65817u;

	public static uint OID_GEN_CO_SUPPORTED_LIST = 65793u;

	public static uint OID_GEN_CO_HARDWARE_STATUS = 65794u;

	public static uint OID_GEN_CO_MEDIA_SUPPORTED = 65795u;

	public static uint OID_GEN_CO_MEDIA_IN_USE = 65796u;

	public static uint OID_GEN_CO_LINK_SPEED = 65797u;

	public static uint OID_GEN_CO_VENDOR_ID = 65798u;

	public static uint OID_GEN_CO_VENDOR_DESCRIPTION = 65799u;

	public static uint OID_GEN_CO_DRIVER_VERSION = 65800u;

	public static uint OID_GEN_CO_PROTOCOL_OPTIONS = 65801u;

	public static uint OID_GEN_CO_MAC_OPTIONS = 65802u;

	public static uint OID_GEN_CO_MEDIA_CONNECT_STATUS = 65803u;

	public static uint OID_GEN_CO_VENDOR_DRIVER_VERSION = 65804u;

	public static uint OID_GEN_CO_MINIMUM_LINK_SPEED = 65805u;

	public static uint OID_GEN_CO_GET_TIME_CAPS = 66049u;

	public static uint OID_GEN_CO_GET_NETCARD_TIME = 66050u;

	public static uint OID_GEN_CO_XMIT_PDUS_OK = 131329u;

	public static uint OID_GEN_CO_RCV_PDUS_OK = 131330u;

	public static uint OID_GEN_CO_XMIT_PDUS_ERROR = 131331u;

	public static uint OID_GEN_CO_RCV_PDUS_ERROR = 131332u;

	public static uint OID_GEN_CO_RCV_PDUS_NO_BUFFER = 131333u;

	public static uint OID_GEN_CO_RCV_CRC_ERROR = 131585u;

	public static uint OID_GEN_CO_TRANSMIT_QUEUE_LENGTH = 131586u;

	public static uint OID_GEN_CO_BYTES_XMIT = 131587u;

	public static uint OID_GEN_CO_BYTES_RCV = 131588u;

	public static uint OID_GEN_CO_BYTES_XMIT_OUTSTANDING = 131589u;

	public static uint OID_GEN_CO_NETCARD_LOAD = 131590u;

	public static uint OID_CO_ADD_PVC = 4278190081u;

	public static uint OID_CO_DELETE_PVC = 4278190082u;

	public static uint OID_CO_GET_CALL_INFORMATION = 4278190083u;

	public static uint OID_CO_ADD_ADDRESS = 4278190084u;

	public static uint OID_CO_DELETE_ADDRESS = 4278190085u;

	public static uint OID_CO_GET_ADDRESSES = 4278190086u;

	public static uint OID_CO_ADDRESS_CHANGE = 4278190087u;

	public static uint OID_CO_SIGNALING_ENABLED = 4278190088u;

	public static uint OID_CO_SIGNALING_DISABLED = 4278190089u;

	public static uint OID_802_3_PERMANENT_ADDRESS = 16843009u;

	public static uint OID_802_3_CURRENT_ADDRESS = 16843010u;

	public static uint OID_802_3_MULTICAST_LIST = 16843011u;

	public static uint OID_802_3_MAXIMUM_LIST_SIZE = 16843012u;

	public static uint OID_802_3_MAC_OPTIONS = 16843013u;

	public static uint NDIS_802_3_MAC_OPTION_PRIORITY = 1u;

	public static uint OID_802_3_RCV_ERROR_ALIGNMENT = 16908545u;

	public static uint OID_802_3_XMIT_ONE_COLLISION = 16908546u;

	public static uint OID_802_3_XMIT_MORE_COLLISIONS = 16908547u;

	public static uint OID_802_3_XMIT_DEFERRED = 16908801u;

	public static uint OID_802_3_XMIT_MAX_COLLISIONS = 16908802u;

	public static uint OID_802_3_RCV_OVERRUN = 16908803u;

	public static uint OID_802_3_XMIT_UNDERRUN = 16908804u;

	public static uint OID_802_3_XMIT_HEARTBEAT_FAILURE = 16908805u;

	public static uint OID_802_3_XMIT_TIMES_CRS_LOST = 16908806u;

	public static uint OID_802_3_XMIT_LATE_COLLISIONS = 16908807u;

	public static uint OID_802_5_PERMANENT_ADDRESS = 33620225u;

	public static uint OID_802_5_CURRENT_ADDRESS = 33620226u;

	public static uint OID_802_5_CURRENT_FUNCTIONAL = 33620227u;

	public static uint OID_802_5_CURRENT_GROUP = 33620228u;

	public static uint OID_802_5_LAST_OPEN_STATUS = 33620229u;

	public static uint OID_802_5_CURRENT_RING_STATUS = 33620230u;

	public static uint OID_802_5_CURRENT_RING_STATE = 33620231u;

	public static uint OID_802_5_LINE_ERRORS = 33685761u;

	public static uint OID_802_5_LOST_FRAMES = 33685762u;

	public static uint OID_802_5_BURST_ERRORS = 33686017u;

	public static uint OID_802_5_AC_ERRORS = 33686018u;

	public static uint OID_802_5_ABORT_DELIMETERS = 33686019u;

	public static uint OID_802_5_FRAME_COPIED_ERRORS = 33686020u;

	public static uint OID_802_5_FREQUENCY_ERRORS = 33686021u;

	public static uint OID_802_5_TOKEN_ERRORS = 33686022u;

	public static uint OID_802_5_INTERNAL_ERRORS = 33686023u;

	public static uint OID_FDDI_LONG_PERMANENT_ADDR = 50397441u;

	public static uint OID_FDDI_LONG_CURRENT_ADDR = 50397442u;

	public static uint OID_FDDI_LONG_MULTICAST_LIST = 50397443u;

	public static uint OID_FDDI_LONG_MAX_LIST_SIZE = 50397444u;

	public static uint OID_FDDI_SHORT_PERMANENT_ADDR = 50397445u;

	public static uint OID_FDDI_SHORT_CURRENT_ADDR = 50397446u;

	public static uint OID_FDDI_SHORT_MULTICAST_LIST = 50397447u;

	public static uint OID_FDDI_SHORT_MAX_LIST_SIZE = 50397448u;

	public static uint OID_FDDI_ATTACHMENT_TYPE = 50462977u;

	public static uint OID_FDDI_UPSTREAM_NODE_LONG = 50462978u;

	public static uint OID_FDDI_DOWNSTREAM_NODE_LONG = 50462979u;

	public static uint OID_FDDI_FRAME_ERRORS = 50462980u;

	public static uint OID_FDDI_FRAMES_LOST = 50462981u;

	public static uint OID_FDDI_RING_MGT_STATE = 50462982u;

	public static uint OID_FDDI_LCT_FAILURES = 50462983u;

	public static uint OID_FDDI_LEM_REJECTS = 50462984u;

	public static uint OID_FDDI_LCONNECTION_STATE = 50462985u;

	public static uint OID_FDDI_SMT_STATION_ID = 50528769u;

	public static uint OID_FDDI_SMT_OP_VERSION_ID = 50528770u;

	public static uint OID_FDDI_SMT_HI_VERSION_ID = 50528771u;

	public static uint OID_FDDI_SMT_LO_VERSION_ID = 50528772u;

	public static uint OID_FDDI_SMT_MANUFACTURER_DATA = 50528773u;

	public static uint OID_FDDI_SMT_USER_DATA = 50528774u;

	public static uint OID_FDDI_SMT_MIB_VERSION_ID = 50528775u;

	public static uint OID_FDDI_SMT_MAC_CT = 50528776u;

	public static uint OID_FDDI_SMT_NON_MASTER_CT = 50528777u;

	public static uint OID_FDDI_SMT_MASTER_CT = 50528778u;

	public static uint OID_FDDI_SMT_AVAILABLE_PATHS = 50528779u;

	public static uint OID_FDDI_SMT_CONFIG_CAPABILITIES = 50528780u;

	public static uint OID_FDDI_SMT_CONFIG_POLICY = 50528781u;

	public static uint OID_FDDI_SMT_CONNECTION_POLICY = 50528782u;

	public static uint OID_FDDI_SMT_T_NOTIFY = 50528783u;

	public static uint OID_FDDI_SMT_STAT_RPT_POLICY = 50528784u;

	public static uint OID_FDDI_SMT_TRACE_MAX_EXPIRATION = 50528785u;

	public static uint OID_FDDI_SMT_PORT_INDEXES = 50528786u;

	public static uint OID_FDDI_SMT_MAC_INDEXES = 50528787u;

	public static uint OID_FDDI_SMT_BYPASS_PRESENT = 50528788u;

	public static uint OID_FDDI_SMT_ECM_STATE = 50528789u;

	public static uint OID_FDDI_SMT_CF_STATE = 50528790u;

	public static uint OID_FDDI_SMT_HOLD_STATE = 50528791u;

	public static uint OID_FDDI_SMT_REMOTE_DISCONNECT_FLAG = 50528792u;

	public static uint OID_FDDI_SMT_STATION_STATUS = 50528793u;

	public static uint OID_FDDI_SMT_PEER_WRAP_FLAG = 50528794u;

	public static uint OID_FDDI_SMT_MSG_TIME_STAMP = 50528795u;

	public static uint OID_FDDI_SMT_TRANSITION_TIME_STAMP = 50528796u;

	public static uint OID_FDDI_SMT_SET_COUNT = 50528797u;

	public static uint OID_FDDI_SMT_LAST_SET_STATION_ID = 50528798u;

	public static uint OID_FDDI_MAC_FRAME_STATUS_FUNCTIONS = 50528799u;

	public static uint OID_FDDI_MAC_BRIDGE_FUNCTIONS = 50528800u;

	public static uint OID_FDDI_MAC_T_MAX_CAPABILITY = 50528801u;

	public static uint OID_FDDI_MAC_TVX_CAPABILITY = 50528802u;

	public static uint OID_FDDI_MAC_AVAILABLE_PATHS = 50528803u;

	public static uint OID_FDDI_MAC_CURRENT_PATH = 50528804u;

	public static uint OID_FDDI_MAC_UPSTREAM_NBR = 50528805u;

	public static uint OID_FDDI_MAC_DOWNSTREAM_NBR = 50528806u;

	public static uint OID_FDDI_MAC_OLD_UPSTREAM_NBR = 50528807u;

	public static uint OID_FDDI_MAC_OLD_DOWNSTREAM_NBR = 50528808u;

	public static uint OID_FDDI_MAC_DUP_ADDRESS_TEST = 50528809u;

	public static uint OID_FDDI_MAC_REQUESTED_PATHS = 50528810u;

	public static uint OID_FDDI_MAC_DOWNSTREAM_PORT_TYPE = 50528811u;

	public static uint OID_FDDI_MAC_INDEX = 50528812u;

	public static uint OID_FDDI_MAC_SMT_ADDRESS = 50528813u;

	public static uint OID_FDDI_MAC_LONG_GRP_ADDRESS = 50528814u;

	public static uint OID_FDDI_MAC_SHORT_GRP_ADDRESS = 50528815u;

	public static uint OID_FDDI_MAC_T_REQ = 50528816u;

	public static uint OID_FDDI_MAC_T_NEG = 50528817u;

	public static uint OID_FDDI_MAC_T_MAX = 50528818u;

	public static uint OID_FDDI_MAC_TVX_VALUE = 50528819u;

	public static uint OID_FDDI_MAC_T_PRI0 = 50528820u;

	public static uint OID_FDDI_MAC_T_PRI1 = 50528821u;

	public static uint OID_FDDI_MAC_T_PRI2 = 50528822u;

	public static uint OID_FDDI_MAC_T_PRI3 = 50528823u;

	public static uint OID_FDDI_MAC_T_PRI4 = 50528824u;

	public static uint OID_FDDI_MAC_T_PRI5 = 50528825u;

	public static uint OID_FDDI_MAC_T_PRI6 = 50528826u;

	public static uint OID_FDDI_MAC_FRAME_CT = 50528827u;

	public static uint OID_FDDI_MAC_COPIED_CT = 50528828u;

	public static uint OID_FDDI_MAC_TRANSMIT_CT = 50528829u;

	public static uint OID_FDDI_MAC_TOKEN_CT = 50528830u;

	public static uint OID_FDDI_MAC_ERROR_CT = 50528831u;

	public static uint OID_FDDI_MAC_LOST_CT = 50528832u;

	public static uint OID_FDDI_MAC_TVX_EXPIRED_CT = 50528833u;

	public static uint OID_FDDI_MAC_NOT_COPIED_CT = 50528834u;

	public static uint OID_FDDI_MAC_LATE_CT = 50528835u;

	public static uint OID_FDDI_MAC_RING_OP_CT = 50528836u;

	public static uint OID_FDDI_MAC_FRAME_ERROR_THRESHOLD = 50528837u;

	public static uint OID_FDDI_MAC_FRAME_ERROR_RATIO = 50528838u;

	public static uint OID_FDDI_MAC_NOT_COPIED_THRESHOLD = 50528839u;

	public static uint OID_FDDI_MAC_NOT_COPIED_RATIO = 50528840u;

	public static uint OID_FDDI_MAC_RMT_STATE = 50528841u;

	public static uint OID_FDDI_MAC_DA_FLAG = 50528842u;

	public static uint OID_FDDI_MAC_UNDA_FLAG = 50528843u;

	public static uint OID_FDDI_MAC_FRAME_ERROR_FLAG = 50528844u;

	public static uint OID_FDDI_MAC_NOT_COPIED_FLAG = 50528845u;

	public static uint OID_FDDI_MAC_MA_UNITDATA_AVAILABLE = 50528846u;

	public static uint OID_FDDI_MAC_HARDWARE_PRESENT = 50528847u;

	public static uint OID_FDDI_MAC_MA_UNITDATA_ENABLE = 50528848u;

	public static uint OID_FDDI_PATH_INDEX = 50528849u;

	public static uint OID_FDDI_PATH_RING_LATENCY = 50528850u;

	public static uint OID_FDDI_PATH_TRACE_STATUS = 50528851u;

	public static uint OID_FDDI_PATH_SBA_PAYLOAD = 50528852u;

	public static uint OID_FDDI_PATH_SBA_OVERHEAD = 50528853u;

	public static uint OID_FDDI_PATH_CONFIGURATION = 50528854u;

	public static uint OID_FDDI_PATH_T_R_MODE = 50528855u;

	public static uint OID_FDDI_PATH_SBA_AVAILABLE = 50528856u;

	public static uint OID_FDDI_PATH_TVX_LOWER_BOUND = 50528857u;

	public static uint OID_FDDI_PATH_T_MAX_LOWER_BOUND = 50528858u;

	public static uint OID_FDDI_PATH_MAX_T_REQ = 50528859u;

	public static uint OID_FDDI_PORT_MY_TYPE = 50528860u;

	public static uint OID_FDDI_PORT_NEIGHBOR_TYPE = 50528861u;

	public static uint OID_FDDI_PORT_CONNECTION_POLICIES = 50528862u;

	public static uint OID_FDDI_PORT_MAC_INDICATED = 50528863u;

	public static uint OID_FDDI_PORT_CURRENT_PATH = 50528864u;

	public static uint OID_FDDI_PORT_REQUESTED_PATHS = 50528865u;

	public static uint OID_FDDI_PORT_MAC_PLACEMENT = 50528866u;

	public static uint OID_FDDI_PORT_AVAILABLE_PATHS = 50528867u;

	public static uint OID_FDDI_PORT_MAC_LOOP_TIME = 50528868u;

	public static uint OID_FDDI_PORT_PMD_CLASS = 50528869u;

	public static uint OID_FDDI_PORT_CONNECTION_CAPABILITIES = 50528870u;

	public static uint OID_FDDI_PORT_INDEX = 50528871u;

	public static uint OID_FDDI_PORT_MAINT_LS = 50528872u;

	public static uint OID_FDDI_PORT_BS_FLAG = 50528873u;

	public static uint OID_FDDI_PORT_PC_LS = 50528874u;

	public static uint OID_FDDI_PORT_EB_ERROR_CT = 50528875u;

	public static uint OID_FDDI_PORT_LCT_FAIL_CT = 50528876u;

	public static uint OID_FDDI_PORT_LER_ESTIMATE = 50528877u;

	public static uint OID_FDDI_PORT_LEM_REJECT_CT = 50528878u;

	public static uint OID_FDDI_PORT_LEM_CT = 50528879u;

	public static uint OID_FDDI_PORT_LER_CUTOFF = 50528880u;

	public static uint OID_FDDI_PORT_LER_ALARM = 50528881u;

	public static uint OID_FDDI_PORT_CONNNECT_STATE = 50528882u;

	public static uint OID_FDDI_PORT_PCM_STATE = 50528883u;

	public static uint OID_FDDI_PORT_PC_WITHHOLD = 50528884u;

	public static uint OID_FDDI_PORT_LER_FLAG = 50528885u;

	public static uint OID_FDDI_PORT_HARDWARE_PRESENT = 50528886u;

	public static uint OID_FDDI_SMT_STATION_ACTION = 50528887u;

	public static uint OID_FDDI_PORT_ACTION = 50528888u;

	public static uint OID_FDDI_IF_DESCR = 50528889u;

	public static uint OID_FDDI_IF_TYPE = 50528890u;

	public static uint OID_FDDI_IF_MTU = 50528891u;

	public static uint OID_FDDI_IF_SPEED = 50528892u;

	public static uint OID_FDDI_IF_PHYS_ADDRESS = 50528893u;

	public static uint OID_FDDI_IF_ADMIN_STATUS = 50528894u;

	public static uint OID_FDDI_IF_OPER_STATUS = 50528895u;

	public static uint OID_FDDI_IF_LAST_CHANGE = 50528896u;

	public static uint OID_FDDI_IF_IN_OCTETS = 50528897u;

	public static uint OID_FDDI_IF_IN_UCAST_PKTS = 50528898u;

	public static uint OID_FDDI_IF_IN_NUCAST_PKTS = 50528899u;

	public static uint OID_FDDI_IF_IN_DISCARDS = 50528900u;

	public static uint OID_FDDI_IF_IN_ERRORS = 50528901u;

	public static uint OID_FDDI_IF_IN_UNKNOWN_PROTOS = 50528902u;

	public static uint OID_FDDI_IF_OUT_OCTETS = 50528903u;

	public static uint OID_FDDI_IF_OUT_UCAST_PKTS = 50528904u;

	public static uint OID_FDDI_IF_OUT_NUCAST_PKTS = 50528905u;

	public static uint OID_FDDI_IF_OUT_DISCARDS = 50528906u;

	public static uint OID_FDDI_IF_OUT_ERRORS = 50528907u;

	public static uint OID_FDDI_IF_OUT_QLEN = 50528908u;

	public static uint OID_FDDI_IF_SPECIFIC = 50528909u;

	public static uint OID_WAN_PERMANENT_ADDRESS = 67174657u;

	public static uint OID_WAN_CURRENT_ADDRESS = 67174658u;

	public static uint OID_WAN_QUALITY_OF_SERVICE = 67174659u;

	public static uint OID_WAN_PROTOCOL_TYPE = 67174660u;

	public static uint OID_WAN_MEDIUM_SUBTYPE = 67174661u;

	public static uint OID_WAN_HEADER_FORMAT = 67174662u;

	public static uint OID_WAN_GET_INFO = 67174663u;

	public static uint OID_WAN_SET_LINK_INFO = 67174664u;

	public static uint OID_WAN_GET_LINK_INFO = 67174665u;

	public static uint OID_WAN_LINE_COUNT = 67174666u;

	public static uint OID_WAN_GET_BRIDGE_INFO = 67174922u;

	public static uint OID_WAN_SET_BRIDGE_INFO = 67174923u;

	public static uint OID_WAN_GET_COMP_INFO = 67174924u;

	public static uint OID_WAN_SET_COMP_INFO = 67174925u;

	public static uint OID_WAN_GET_STATS_INFO = 67174926u;

	public static uint OID_LTALK_CURRENT_NODE_ID = 83951874u;

	public static uint OID_LTALK_IN_BROADCASTS = 84017409u;

	public static uint OID_LTALK_IN_LENGTH_ERRORS = 84017410u;

	public static uint OID_LTALK_OUT_NO_HANDLERS = 84017665u;

	public static uint OID_LTALK_COLLISIONS = 84017666u;

	public static uint OID_LTALK_DEFERS = 84017667u;

	public static uint OID_LTALK_NO_DATA_ERRORS = 84017668u;

	public static uint OID_LTALK_RANDOM_CTS_ERRORS = 84017669u;

	public static uint OID_LTALK_FCS_ERRORS = 84017670u;

	public static uint OID_ARCNET_PERMANENT_ADDRESS = 100729089u;

	public static uint OID_ARCNET_CURRENT_ADDRESS = 100729090u;

	public static uint OID_ARCNET_RECONFIGURATIONS = 100794881u;

	public static uint OID_TAPI_ACCEPT = 117637377u;

	public static uint OID_TAPI_ANSWER = 117637378u;

	public static uint OID_TAPI_CLOSE = 117637379u;

	public static uint OID_TAPI_CLOSE_CALL = 117637380u;

	public static uint OID_TAPI_CONDITIONAL_MEDIA_DETECTION = 117637381u;

	public static uint OID_TAPI_CONFIG_DIALOG = 117637382u;

	public static uint OID_TAPI_DEV_SPECIFIC = 117637383u;

	public static uint OID_TAPI_DIAL = 117637384u;

	public static uint OID_TAPI_DROP = 117637385u;

	public static uint OID_TAPI_GET_ADDRESS_CAPS = 117637386u;

	public static uint OID_TAPI_GET_ADDRESS_ID = 117637387u;

	public static uint OID_TAPI_GET_ADDRESS_STATUS = 117637388u;

	public static uint OID_TAPI_GET_CALL_ADDRESS_ID = 117637389u;

	public static uint OID_TAPI_GET_CALL_INFO = 117637390u;

	public static uint OID_TAPI_GET_CALL_STATUS = 117637391u;

	public static uint OID_TAPI_GET_DEV_CAPS = 117637392u;

	public static uint OID_TAPI_GET_DEV_CONFIG = 117637393u;

	public static uint OID_TAPI_GET_EXTENSION_ID = 117637394u;

	public static uint OID_TAPI_GET_ID = 117637395u;

	public static uint OID_TAPI_GET_LINE_DEV_STATUS = 117637396u;

	public static uint OID_TAPI_MAKE_CALL = 117637397u;

	public static uint OID_TAPI_NEGOTIATE_EXT_VERSION = 117637398u;

	public static uint OID_TAPI_OPEN = 117637399u;

	public static uint OID_TAPI_PROVIDER_INITIALIZE = 117637400u;

	public static uint OID_TAPI_PROVIDER_SHUTDOWN = 117637401u;

	public static uint OID_TAPI_SECURE_CALL = 117637402u;

	public static uint OID_TAPI_SELECT_EXT_VERSION = 117637403u;

	public static uint OID_TAPI_SEND_USER_USER_INFO = 117637404u;

	public static uint OID_TAPI_SET_APP_SPECIFIC = 117637405u;

	public static uint OID_TAPI_SET_CALL_PARAMS = 117637406u;

	public static uint OID_TAPI_SET_DEFAULT_MEDIA_DETECTION = 117637407u;

	public static uint OID_TAPI_SET_DEV_CONFIG = 117637408u;

	public static uint OID_TAPI_SET_MEDIA_MODE = 117637409u;

	public static uint OID_TAPI_SET_STATUS_MESSAGES = 117637410u;

	public static uint OID_ATM_SUPPORTED_VC_RATES = 134283521u;

	public static uint OID_ATM_SUPPORTED_SERVICE_CATEGORY = 134283522u;

	public static uint OID_ATM_SUPPORTED_AAL_TYPES = 134283523u;

	public static uint OID_ATM_HW_CURRENT_ADDRESS = 134283524u;

	public static uint OID_ATM_MAX_ACTIVE_VCS = 134283525u;

	public static uint OID_ATM_MAX_ACTIVE_VCI_BITS = 134283526u;

	public static uint OID_ATM_MAX_ACTIVE_VPI_BITS = 134283527u;

	public static uint OID_ATM_MAX_AAL0_PACKET_SIZE = 134283528u;

	public static uint OID_ATM_MAX_AAL1_PACKET_SIZE = 134283529u;

	public static uint OID_ATM_MAX_AAL34_PACKET_SIZE = 134283530u;

	public static uint OID_ATM_MAX_AAL5_PACKET_SIZE = 134283531u;

	public static uint OID_ATM_SIGNALING_VPIVCI = 134283777u;

	public static uint OID_ATM_ASSIGNED_VPI = 134283778u;

	public static uint OID_ATM_ACQUIRE_ACCESS_NET_RESOURCES = 134283779u;

	public static uint OID_ATM_RELEASE_ACCESS_NET_RESOURCES = 134283780u;

	public static uint OID_ATM_ILMI_VPIVCI = 134283781u;

	public static uint OID_ATM_DIGITAL_BROADCAST_VPIVCI = 134283782u;

	public static uint OID_ATM_GET_NEAREST_FLOW = 134283783u;

	public static uint OID_ATM_ALIGNMENT_REQUIRED = 134283784u;

	public static uint OID_ATM_RCV_CELLS_OK = 134349057u;

	public static uint OID_ATM_XMIT_CELLS_OK = 134349058u;

	public static uint OID_ATM_RCV_CELLS_DROPPED = 134349059u;

	public static uint OID_ATM_RCV_INVALID_VPI_VCI = 134349313u;

	public static uint OID_ATM_CELLS_HEC_ERROR = 134349314u;

	public static uint OID_ATM_RCV_REASSEMBLY_ERROR = 134349315u;

	public static uint OID_WW_GEN_NETWORK_TYPES_SUPPORTED = 151060737u;

	public static uint OID_WW_GEN_NETWORK_TYPE_IN_USE = 151060738u;

	public static uint OID_WW_GEN_HEADER_FORMATS_SUPPORTED = 151060739u;

	public static uint OID_WW_GEN_HEADER_FORMAT_IN_USE = 151060740u;

	public static uint OID_WW_GEN_INDICATION_REQUEST = 151060741u;

	public static uint OID_WW_GEN_DEVICE_INFO = 151060742u;

	public static uint OID_WW_GEN_OPERATION_MODE = 151060743u;

	public static uint OID_WW_GEN_LOCK_STATUS = 151060744u;

	public static uint OID_WW_GEN_DISABLE_TRANSMITTER = 151060745u;

	public static uint OID_WW_GEN_NETWORK_ID = 151060746u;

	public static uint OID_WW_GEN_PERMANENT_ADDRESS = 151060747u;

	public static uint OID_WW_GEN_CURRENT_ADDRESS = 151060748u;

	public static uint OID_WW_GEN_SUSPEND_DRIVER = 151060749u;

	public static uint OID_WW_GEN_BASESTATION_ID = 151060750u;

	public static uint OID_WW_GEN_CHANNEL_ID = 151060751u;

	public static uint OID_WW_GEN_ENCRYPTION_SUPPORTED = 151060752u;

	public static uint OID_WW_GEN_ENCRYPTION_IN_USE = 151060753u;

	public static uint OID_WW_GEN_ENCRYPTION_STATE = 151060754u;

	public static uint OID_WW_GEN_CHANNEL_QUALITY = 151060755u;

	public static uint OID_WW_GEN_REGISTRATION_STATUS = 151060756u;

	public static uint OID_WW_GEN_RADIO_LINK_SPEED = 151060757u;

	public static uint OID_WW_GEN_LATENCY = 151060758u;

	public static uint OID_WW_GEN_BATTERY_LEVEL = 151060759u;

	public static uint OID_WW_GEN_EXTERNAL_POWER = 151060760u;

	public static uint OID_WW_MBX_SUBADDR = 151322881u;

	public static uint OID_WW_MBX_FLEXLIST = 151322883u;

	public static uint OID_WW_MBX_GROUPLIST = 151322884u;

	public static uint OID_WW_MBX_TRAFFIC_AREA = 151322885u;

	public static uint OID_WW_MBX_LIVE_DIE = 151322886u;

	public static uint OID_WW_MBX_TEMP_DEFAULTLIST = 151322887u;

	public static uint OID_WW_PIN_LOC_AUTHORIZE = 151585025u;

	public static uint OID_WW_PIN_LAST_LOCATION = 151585026u;

	public static uint OID_WW_PIN_LOC_FIX = 151585027u;

	public static uint OID_WW_CDPD_SPNI = 151847169u;

	public static uint OID_WW_CDPD_WASI = 151847170u;

	public static uint OID_WW_CDPD_AREA_COLOR = 151847171u;

	public static uint OID_WW_CDPD_TX_POWER_LEVEL = 151847172u;

	public static uint OID_WW_CDPD_EID = 151847173u;

	public static uint OID_WW_CDPD_HEADER_COMPRESSION = 151847174u;

	public static uint OID_WW_CDPD_DATA_COMPRESSION = 151847175u;

	public static uint OID_WW_CDPD_CHANNEL_SELECT = 151847176u;

	public static uint OID_WW_CDPD_CHANNEL_STATE = 151847177u;

	public static uint OID_WW_CDPD_NEI = 151847178u;

	public static uint OID_WW_CDPD_NEI_STATE = 151847179u;

	public static uint OID_WW_CDPD_SERVICE_PROVIDER_IDENTIFIER = 151847180u;

	public static uint OID_WW_CDPD_SLEEP_MODE = 151847181u;

	public static uint OID_WW_CDPD_CIRCUIT_SWITCHED = 151847182u;

	public static uint OID_WW_CDPD_TEI = 151847183u;

	public static uint OID_WW_CDPD_RSSI = 151847184u;

	public static uint OID_WW_ARD_SNDCP = 152109313u;

	public static uint OID_WW_ARD_TMLY_MSG = 152109314u;

	public static uint OID_WW_ARD_DATAGRAM = 152109315u;

	public static uint OID_WW_TAC_COMPRESSION = 152371457u;

	public static uint OID_WW_TAC_SET_CONFIG = 152371458u;

	public static uint OID_WW_TAC_GET_STATUS = 152371459u;

	public static uint OID_WW_TAC_USER_HEADER = 152371460u;

	public static uint OID_WW_MET_FUNCTION = 152633601u;

	public static uint OID_IRDA_RECEIVING = 167837952u;

	public static uint OID_IRDA_TURNAROUND_TIME = 167837953u;

	public static uint OID_IRDA_SUPPORTED_SPEEDS = 167837954u;

	public static uint OID_IRDA_LINK_SPEED = 167837955u;

	public static uint OID_IRDA_MEDIA_BUSY = 167837956u;

	public static uint OID_IRDA_EXTRA_RCV_BOFS = 167838208u;

	public static uint OID_IRDA_RATE_SNIFF = 167838209u;

	public static uint OID_IRDA_UNICAST_LIST = 167838210u;

	public static uint OID_IRDA_MAX_UNICAST_LIST_SIZE = 167838211u;

	public static uint OID_IRDA_MAX_RECEIVE_WINDOW_SIZE = 167838212u;

	public static uint OID_IRDA_MAX_SEND_WINDOW_SIZE = 167838213u;

	public static int READABLE_LOCAL_CLOCK = 1;

	public static int CLOCK_NETWORK_DERIVED = 2;

	public static int CLOCK_PRECISION = 4;

	public static int RECEIVE_TIME_INDICATION_CAPABLE = 8;

	public static int TIMED_SEND_CAPABLE = 16;

	public static int TIME_STAMP_CAPABLE = 32;

	public static uint NDIS_PACKET_TYPE_DIRECTED = 1u;

	public static uint NDIS_PACKET_TYPE_MULTICAST = 2u;

	public static uint NDIS_PACKET_TYPE_ALL_MULTICAST = 4u;

	public static uint NDIS_PACKET_TYPE_BROADCAST = 8u;

	public static uint NDIS_PACKET_TYPE_SOURCE_ROUTING = 16u;

	public static uint NDIS_PACKET_TYPE_PROMISCUOUS = 32u;

	public static uint NDIS_PACKET_TYPE_SMT = 64u;

	public static uint NDIS_PACKET_TYPE_ALL_LOCAL = 128u;

	public static uint NDIS_PACKET_TYPE_MAC_FRAME = 32768u;

	public static uint NDIS_PACKET_TYPE_FUNCTIONAL = 16384u;

	public static uint NDIS_PACKET_TYPE_ALL_FUNCTIONAL = 8192u;

	public static uint NDIS_PACKET_TYPE_GROUP = 4096u;

	public static uint NDIS_RING_SIGNAL_LOSS = 32768u;

	public static uint NDIS_RING_HARD_ERROR = 16384u;

	public static uint NDIS_RING_SOFT_ERROR = 8192u;

	public static uint NDIS_RING_TRANSMIT_BEACON = 4096u;

	public static uint NDIS_RING_LOBE_WIRE_FAULT = 2048u;

	public static uint NDIS_RING_AUTO_REMOVAL_ERROR = 1024u;

	public static uint NDIS_RING_REMOVE_RECEIVED = 512u;

	public static uint NDIS_RING_COUNTER_OVERFLOW = 256u;

	public static uint NDIS_RING_SINGLE_STATION = 128u;

	public static uint NDIS_RING_RING_RECOVERY = 64u;

	public static uint NDIS_PROT_OPTION_ESTIMATED_LENGTH = 1u;

	public static uint NDIS_PROT_OPTION_NO_LOOPBACK = 2u;

	public static uint NDIS_PROT_OPTION_NO_RSVD_ON_RCVPKT = 4u;

	public static int NDIS_MAC_OPTION_COPY_LOOKAHEAD_DATA = 1;

	public static int NDIS_MAC_OPTION_RECEIVE_SERIALIZED = 2;

	public static int NDIS_MAC_OPTION_TRANSFERS_NOT_PEND = 4;

	public static int NDIS_MAC_OPTION_NO_LOOPBACK = 8;

	public static int NDIS_MAC_OPTION_FULL_DUPLEX = 16;

	public static int NDIS_MAC_OPTION_EOTX_INDICATION = 32;

	public static uint NDIS_MAC_OPTION_RESERVED = 2147483648u;

	public static uint NDIS_CO_MAC_OPTION_DYNAMIC_LINK_SPEED = 1u;

	public static uint OID_INDICATION_REQUEST_ENABLE = 0u;

	public static uint OID_INDICATION_REQUEST_CANCEL = 1u;

	public static string GetMediaInUseString(int Value)
	{
		string result = "";
		switch (Value)
		{
		case 0:
			result = "Medium in use is 802.3 : Ethernet";
			break;
		case 1:
			result = "Medium in use is 802.5 : Token Ring";
			break;
		case 7:
			result = "Medium in use is Arcnet 878.2";
			break;
		case 6:
			result = "Medium in use is Arcnet Raw";
			break;
		case 8:
			result = "Medium in use is Atm";
			break;
		case 5:
			result = "Medium in use is Dix";
			break;
		case 2:
			result = "Medium in use is Fddi";
			break;
		case 10:
			result = "Medium in use is Irda";
			break;
		case 4:
			result = "Medium in use is Local Talk";
			break;
		case 11:
			result = "Medium in use is Max";
			break;
		case 3:
			result = "Medium in use is Wan";
			break;
		case 9:
			result = "Medium in use is Wireless Wan";
			break;
		}
		return result;
	}

	public static string GetHardwareStatusString(int Value)
	{
		string result = "";
		switch (Value)
		{
		case 0:
			result = "Hardware is Ready";
			break;
		case 1:
			result = "Hardware is Initializing";
			break;
		case 2:
			result = "Hardware is Reset";
			break;
		case 3:
			result = "Hardware is Closing";
			break;
		case 4:
			result = "Hardware is Not Ready";
			break;
		}
		return result;
	}

	public static string GetTimeCapsString(GEN_GET_TIME_CAPS Value)
	{
		string text = "";
		if (((int)Value.Flags & READABLE_LOCAL_CLOCK) == READABLE_LOCAL_CLOCK)
		{
			text += "Readable local clock,";
		}
		if (((int)Value.Flags & CLOCK_NETWORK_DERIVED) == CLOCK_NETWORK_DERIVED)
		{
			text += "Clock network derived,";
		}
		if (((int)Value.Flags & CLOCK_PRECISION) == CLOCK_PRECISION)
		{
			text += "Clock precision,";
		}
		if (((int)Value.Flags & RECEIVE_TIME_INDICATION_CAPABLE) == RECEIVE_TIME_INDICATION_CAPABLE)
		{
			text += "Receive time indication capable,";
		}
		if (((int)Value.Flags & TIMED_SEND_CAPABLE) == TIMED_SEND_CAPABLE)
		{
			text += "Timed send capable,";
		}
		if (((int)Value.Flags & TIME_STAMP_CAPABLE) == TIME_STAMP_CAPABLE)
		{
			text += "Time stamp capable,";
		}
		if (text.Length > 0)
		{
			text = text.Substring(0, text.Length - 1);
		}
		return text;
	}

	public static string GetMediaStateString(int Value)
	{
		string result = "";
		switch (Value)
		{
		case 0:
			result = "Media is connected";
			break;
		case 1:
			result = "Media is disconnected";
			break;
		}
		return result;
	}

	public static string GetCurrentPacketFilterString(int Value)
	{
		string text = "";
		if ((Value & NDIS_PACKET_TYPE_DIRECTED) == NDIS_PACKET_TYPE_DIRECTED)
		{
			text += "Directed,";
		}
		if ((Value & NDIS_PACKET_TYPE_MULTICAST) == NDIS_PACKET_TYPE_MULTICAST)
		{
			text += "Multicast,";
		}
		if ((Value & NDIS_PACKET_TYPE_ALL_MULTICAST) == NDIS_PACKET_TYPE_ALL_MULTICAST)
		{
			text += "All multicast,";
		}
		if ((Value & NDIS_PACKET_TYPE_BROADCAST) == NDIS_PACKET_TYPE_BROADCAST)
		{
			text += "Broadcast,";
		}
		if ((Value & NDIS_PACKET_TYPE_SOURCE_ROUTING) == NDIS_PACKET_TYPE_SOURCE_ROUTING)
		{
			text += "Source routing,";
		}
		if ((Value & NDIS_PACKET_TYPE_PROMISCUOUS) == NDIS_PACKET_TYPE_PROMISCUOUS)
		{
			text += "Promiscous,";
		}
		if ((Value & NDIS_PACKET_TYPE_SMT) == NDIS_PACKET_TYPE_SMT)
		{
			text += "Smt,";
		}
		if ((Value & NDIS_PACKET_TYPE_ALL_LOCAL) == NDIS_PACKET_TYPE_ALL_LOCAL)
		{
			text += "All local,";
		}
		if ((Value & NDIS_PACKET_TYPE_MAC_FRAME) == NDIS_PACKET_TYPE_MAC_FRAME)
		{
			text += "Mac frame,";
		}
		if ((Value & NDIS_PACKET_TYPE_FUNCTIONAL) == NDIS_PACKET_TYPE_FUNCTIONAL)
		{
			text += "Functional,";
		}
		if ((Value & NDIS_PACKET_TYPE_ALL_FUNCTIONAL) == NDIS_PACKET_TYPE_ALL_FUNCTIONAL)
		{
			text += "All functional,";
		}
		if ((Value & NDIS_PACKET_TYPE_GROUP) == NDIS_PACKET_TYPE_GROUP)
		{
			text += "Group,";
		}
		if (text.Length > 0)
		{
			text = text.Substring(0, text.Length - 1);
		}
		return text;
	}

	public static string GetProtocolOptionsString(int Value)
	{
		string text = "";
		if ((Value & NDIS_PROT_OPTION_ESTIMATED_LENGTH) == NDIS_PROT_OPTION_ESTIMATED_LENGTH)
		{
			text += "Estimated length,";
		}
		if ((Value & NDIS_PROT_OPTION_NO_LOOPBACK) == NDIS_PROT_OPTION_NO_LOOPBACK)
		{
			text += "No loopback,";
		}
		if ((Value & NDIS_PROT_OPTION_NO_RSVD_ON_RCVPKT) == NDIS_PROT_OPTION_NO_RSVD_ON_RCVPKT)
		{
			text += "No reserved on receive packet,";
		}
		if (text.Length > 0)
		{
			text = text.Substring(0, text.Length - 1);
		}
		return text;
	}

	public static string GetMacOptionsString(int Value)
	{
		string text = "";
		if ((Value & NDIS_MAC_OPTION_COPY_LOOKAHEAD_DATA) == NDIS_MAC_OPTION_COPY_LOOKAHEAD_DATA)
		{
			text += "Copy lookahead data,";
		}
		if ((Value & NDIS_MAC_OPTION_RECEIVE_SERIALIZED) == NDIS_MAC_OPTION_RECEIVE_SERIALIZED)
		{
			text += "Receive serialized,";
		}
		if ((Value & NDIS_MAC_OPTION_TRANSFERS_NOT_PEND) == NDIS_MAC_OPTION_TRANSFERS_NOT_PEND)
		{
			text += "Transfers not pend,";
		}
		if ((Value & NDIS_MAC_OPTION_NO_LOOPBACK) == NDIS_MAC_OPTION_NO_LOOPBACK)
		{
			text += "no loopback,";
		}
		if ((Value & NDIS_MAC_OPTION_FULL_DUPLEX) == NDIS_MAC_OPTION_FULL_DUPLEX)
		{
			text += "full duplex,";
		}
		if ((Value & NDIS_MAC_OPTION_EOTX_INDICATION) == NDIS_MAC_OPTION_EOTX_INDICATION)
		{
			text += "End of transmit indication,";
		}
		if ((Value & NDIS_MAC_OPTION_RESERVED) == NDIS_MAC_OPTION_RESERVED)
		{
			text += "reserved,";
		}
		if (text.Length > 0)
		{
			text = text.Substring(0, text.Length - 1);
		}
		return text;
	}

	public static uint NDIS_CONTROL_CODE(uint request, uint method)
	{
		return DeviceIOCtlh.CTL_CODE(DeviceIOCtlh.FILE_DEVICE_PHYSICAL_NETCARD, request, method, DeviceIOCtlh.FILE_ANY_ACCESS);
	}
}
