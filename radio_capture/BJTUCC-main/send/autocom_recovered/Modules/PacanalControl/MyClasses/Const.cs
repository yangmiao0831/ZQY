using System;

namespace MyClasses;

public class Const
{
	public const int LIST_VIEW_PACKET_NO_INDEX = 0;

	public const int LIST_VIEW_TIME_INDEX = 1;

	public const int LIST_VIEW_SOURCE_INDEX = 2;

	public const int LIST_VIEW_SOURCE_PORT_INDEX = 3;

	public const int LIST_VIEW_DESTINATION_INDEX = 4;

	public const int LIST_VIEW_DESTINATION_PORT_INDEX = 5;

	public const int LIST_VIEW_PROTOCOL_INDEX = 6;

	public const int LIST_VIEW_SEQUENCE_INDEX = 7;

	public const int LIST_VIEW_ACKNOWLEDGE_INDEX = 8;

	public const int LIST_VIEW_INFO_INDEX = 9;

	public const int STR_ASCII = 0;

	public const int STR_UNICODE = 1;

	public const int STR_ASCII_UNICODE = 2;

	public const int STR_NB_NAME_NULL = 3;

	public const int STR_NB_NAME_NORMAL = 4;

	public const int STR_NB_NAME_DECODE = 5;

	public const int STR_MAC_ADDRESS = 6;

	public const int STR_IP_ADDRESS = 7;

	public const int STR_FORMAT_HEX = 8;

	public const uint TCPDUMP_MAGIC = 2712847316u;

	public const ushort PCAP_VERSION_MAJOR = 2;

	public const ushort PCAP_VERSION_MINOR = 4;

	public const int LENGTH_OF_ARP = 28;

	public const int LENGTH_OF_DCERPC = 67;

	public const int LENGTH_OF_EIGRP = 40;

	public const int LENGTH_OF_ETHERNET = 14;

	public const int LENGTH_OF_INTERNET = 20;

	public const int LENGTH_OF_ICMP = 8;

	public const int LENGTH_OF_IPX = 30;

	public const int LENGTH_OF_UDP = 8;

	public const int LENGTH_OF_TCP = 20;

	public const int LENGTH_OF_STP = 35;

	public const uint VER_PLATFORM_WIN32_NT = 2u;

	public const uint VER_PLATFORM_WIN32_WINDOWS = 1u;

	public const uint VER_PLATFORM_WIN32s = 0u;

	public const int PROTOCOL_TYPE_NONE = 0;

	public const int PROTOCOL_TYPE_ARP = 1;

	public const int PROTOCOL_TYPE_CDP = 2;

	public const int PROTOCOL_TYPE_DCERPC = 3;

	public const int PROTOCOL_TYPE_DLSW = 4;

	public const int PROTOCOL_TYPE_DNS = 5;

	public const int PROTOCOL_TYPE_EIGRP = 6;

	public const int PROTOCOL_TYPE_INTERNET = 7;

	public const int PROTOCOL_TYPE_IPX = 8;

	public const int PROTOCOL_TYPE_LLC = 9;

	public const int PROTOCOL_TYPE_LOOPBACK = 11;

	public const int PROTOCOL_TYPE_MSWBROWSER = 11;

	public const int PROTOCOL_TYPE_MSWLOGON = 12;

	public const int PROTOCOL_TYPE_NBDS = 13;

	public const int PROTOCOL_TYPE_NBNS = 14;

	public const int PROTOCOL_TYPE_NBSS = 15;

	public const int PROTOCOL_TYPE_NETBIOS = 16;

	public const int PROTOCOL_TYPE_SMB = 17;

	public const int PROTOCOL_TYPE_SMBMAILSLOT = 18;

	public const int PROTOCOL_TYPE_STP = 19;

	public const int PROTOCOL_TYPE_TB = 20;

	public const int PROTOCOL_TYPE_TCP = 21;

	public const int PROTOCOL_TYPE_UDP = 22;

	public const int IPPROTO_IP = 0;

	public const int IPPROTO_ICMP = 1;

	public const int IPPROTO_IGMP = 2;

	public const int IPPROTO_GGP = 3;

	public const int IPPROTO_TCP = 6;

	public const int IPPROTO_PUP = 12;

	public const int IPPROTO_UDP = 17;

	public const int IPPROTO_IDP = 22;

	public const int IPPROTO_IPV6 = 41;

	public const int IPPROTO_ND = 77;

	public const int IPPROTO_ICLFXBM = 78;

	public const int IPPROTO_EIGRP = 88;

	public const int IPPROTO_RAW = 255;

	public const int IPPROTO_MAX = 256;

	public const int IPPORT_TIMESERVER = 37;

	public const int IPPORT_NAMESERVER = 42;

	public const int IPPORT_DNS = 43;

	public const int IPPORT_MTP = 57;

	public const int IPPORT_RJE = 77;

	public const int IPPORT_FINGER = 79;

	public const int IPPORT_HTTP2 = 8080;

	public const int IPPORT_SSDP = 1031;

	public const int IPPORT_SSDP2 = 1032;

	public const int IPPORT_SQL = 1433;

	public const int IPPORT_TTYLINK = 87;

	public const int IPPORT_SUPDUP = 95;

	public const int IPPORT_EPMEP = 135;

	public const int IPPORT_NBNS = 137;

	public const int IPPORT_NBDTGRM = 138;

	public const int IPPORT_NBSSN = 139;

	public const int IPPORT_EXECSERVER = 512;

	public const int IPPORT_LOGINSERVER = 513;

	public const int IPPORT_CMDSERVER = 514;

	public const int IPPORT_WHOSERVER = 513;

	public const int IPPORT_ROUTESERVER = 520;

	public const int IPPORT_ECHO = 7;

	public const int IPPORT_DISCARD = 9;

	public const int IPPORT_SYSTAT = 11;

	public const int IPPORT_DAYTIME = 13;

	public const int IPPORT_NETSTAT = 15;

	public const int IPPORT_QOTD = 17;

	public const int IPPORT_CHARGEN = 19;

	public const int IPPORT_FTP_DATA = 20;

	public const int IPPORT_FTP = 21;

	public const int IPPORT_TELNET = 23;

	public const int IPPORT_SMTP = 25;

	public const int IPPORT_TIME = 37;

	public const int IPPORT_RLP = 39;

	public const int IPPORT_NAME = 42;

	public const int IPPORT_WHOIS = 43;

	public const int IPPORT_DOMAIN = 53;

	public const int IPPORT_BOOTP = 67;

	public const int IPPORT_TFTP = 69;

	public const int IPPORT_HTTP = 80;

	public const int IPPORT_LINK = 87;

	public const int IPPORT_HOSTNAMES = 101;

	public const int IPPORT_ISP_TSAP = 102;

	public const int IPPORT_DICTIONARY = 103;

	public const int IPPORT_X400_SND = 104;

	public const int IPPORT_CSNET_NS = 105;

	public const int IPPORT_POP = 109;

	public const int IPPORT_POP3 = 110;

	public const int IPPORT_PORTMAP = 111;

	public const int IPPORT_AUTH = 113;

	public const int IPPORT_SFTP = 115;

	public const int IPPORT_PATH = 117;

	public const int IPPORT_NNTP = 119;

	public const int IPPORT_NTP = 123;

	public const int IPPORT_NB_NAME = 137;

	public const int IPPORT_NB_DATAGRAM = 138;

	public const int IPPORT_NB_SESSION = 139;

	public const int IPPORT_NEWS = 144;

	public const int IPPORT_SGMP = 153;

	public const int IPPORT_TCPREPO = 158;

	public const int IPPORT_SNMP = 161;

	public const int IPPORT_SNMP_TRAP = 162;

	public const int IPPORT_PRINT_SRV = 170;

	public const int IPPORT_VMNET = 175;

	public const int IPPORT_LOAD = 315;

	public const int IPPORT_VMNET0 = 400;

	public const int IPPORT_HTTPS = 443;

	public const int IPPORT_SYTEK = 500;

	public const int IPPORT_EXEC = 512;

	public const int IPPORT_BIFF = 512;

	public const int IPPORT_LOGIN = 513;

	public const int IPPORT_WHO = 513;

	public const int IPPORT_SHEL = 514;

	public const int IPPORT_SYSLOG = 514;

	public const int IPPORT_PRINTER = 515;

	public const int IPPORT_TALK = 517;

	public const int IPPORT_NTALK = 518;

	public const int IPPORT_EFS = 520;

	public const int IPPORT_ROUTE = 520;

	public const int IPPORT_TIMED = 525;

	public const int IPPORT_TEMPO = 526;

	public const int IPPORT_COURIER = 530;

	public const int IPPORT_CONFERENCE = 531;

	public const int IPPORT_RVD_CONTROL = 531;

	public const int IPPORT_NETNEWS = 532;

	public const int IPPORT_NETWALL = 533;

	public const int IPPORT_UUCP = 540;

	public const int IPPORT_KLOGIN = 543;

	public const int IPPORT_KSHEL = 544;

	public const int IPPORT_NEW_RWHO = 550;

	public const int IPPORT_REMOTEFS = 556;

	public const int IPPORT_RMONITOR = 560;

	public const int IPPORT_MONITOR = 561;

	public const int IPPORT_GARCON = 600;

	public const int IPPORT_MAITRD = 601;

	public const int IPPORT_BUSBOY = 602;

	public const int IPPORT_ACCTMASTER = 700;

	public const int IPPORT_ACCTSLAVE = 701;

	public const int IPPORT_ACCT = 702;

	public const int IPPORT_ACCTLOGIN = 703;

	public const int IPPORT_ACCTPRINTER = 704;

	public const int IPPORT_ACCTINFO = 705;

	public const int IPPORT_ACCTSLAVE2 = 706;

	public const int IPPORT_ACCTDISK = 707;

	public const int IPPORT_KERBEROS = 750;

	public const int IPPORT_KERBEROS_MASTER = 751;

	public const int IPPORT_PASSWD_SERVER = 752;

	public const int IPPORT_USERREG_SERVER = 753;

	public const int IPPORT_KRB_PROP = 754;

	public const int IPPORT_ERRLOGIN = 888;

	public const int IPPORT_DLSW_UDP = 2067;

	public const int IPPORT_DLSW_TCP = 2065;

	public const ushort ETHERTYPE_PUP = 512;

	public const ushort ETHERTYPE_SPRITE = 1280;

	public const ushort ETHERTYPE_NS = 1536;

	public const ushort ETHERTYPE_TRAIL = 4096;

	public const ushort ETHERTYPE_MOPDL = 24577;

	public const ushort ETHERTYPE_MOPRC = 24578;

	public const ushort ETHERTYPE_DN = 24579;

	public const ushort ETHERTYPE_LAT = 24580;

	public const ushort ETHERTYPE_SCA = 24583;

	public const ushort ETHERTYPE_IP = 2048;

	public const ushort ETHERTYPE_ARP = 2054;

	public const ushort ETHERTYPE_REVARP = 32821;

	public const ushort ETHERTYPE_LANBRIDGE = 32824;

	public const ushort ETHERTYPE_DECDNS = 32828;

	public const ushort ETHERTYPE_DECDTS = 32830;

	public const ushort ETHERTYPE_VEXP = 32859;

	public const ushort ETHERTYPE_VPROD = 32860;

	public const ushort ETHERTYPE_ATALK = 32923;

	public const ushort ETHERTYPE_AARP = 33011;

	public const ushort ETHERTYPE_8021Q = 33024;

	public const ushort ETHERTYPE_IPX = 33079;

	public const ushort ETHERTYPE_IPV6 = 34525;

	public const ushort ETHERTYPE_LOOPBACK = 36864;

	public const int NORMAL = 0;

	public const int VALUE = 1;

	public const uint PACKET_ALIGNMENT = 4u;

	public const ushort ARPHRD_NETROM = 0;

	public const ushort ARPHRD_ETHER = 1;

	public const ushort ARPHRD_EETHER = 2;

	public const ushort ARPHRD_AX25 = 3;

	public const ushort ARPHRD_PRONET = 4;

	public const ushort ARPHRD_CHAOS = 5;

	public const ushort ARPHRD_IEEE802 = 6;

	public const ushort ARPHRD_ARCNET = 7;

	public const ushort ARPHRD_HYPERCH = 8;

	public const ushort ARPHRD_LANSTAR = 9;

	public const ushort ARPHRD_AUTONET = 10;

	public const ushort ARPHRD_LOCALTLK = 11;

	public const ushort ARPHRD_LOCALNET = 12;

	public const ushort ARPHRD_ULTRALNK = 13;

	public const ushort ARPHRD_SMDS = 14;

	public const ushort ARPHRD_DLCI = 15;

	public const ushort ARPHRD_ATM = 16;

	public const ushort ARPHRD_HDLC = 17;

	public const ushort ARPHRD_FIBREC = 18;

	public const ushort ARPHRD_ATM2225 = 19;

	public const ushort ARPHRD_SERIAL = 20;

	public const ushort ARPHRD_ATM2 = 21;

	public const ushort ARPHRD_MS188220 = 22;

	public const ushort ARPHRD_METRICOM = 23;

	public const ushort ARPHRD_IEEE1394 = 24;

	public const ushort ARPHRD_MAPOS = 25;

	public const ushort ARPHRD_TWINAX = 26;

	public const ushort ARPHRD_EUI_64 = 27;

	public const ushort ARPOP_REQUEST = 1;

	public const ushort ARPOP_REPLY = 2;

	public const ushort ARPOP_RREQUEST = 3;

	public const ushort ARPOP_RREPLY = 4;

	public const ushort ARPOP_IREQUEST = 8;

	public const ushort ARPOP_IREPLY = 9;

	public const ushort ATMARPOP_NAK = 10;

	public const string ETHERTYPE_PUP_STR = "PUP";

	public const string ETHERTYPE_IP_STR = "IP ( Internet Protocol )";

	public const string ETHERTYPE_ARP_STR = "ARP ( Address Resolution Protocol )";

	public const string ETHERTYPE_REVARP_STR = "RARP ( Reverse Address Resolution Protocol )";

	public const string ETHERTYPE_NS_STR = "NS ";

	public const string ETHERTYPE_SPRITE_STR = "SPRITE ";

	public const string ETHERTYPE_TRAIL_STR = "TRAIL ";

	public const string ETHERTYPE_MOPDL_STR = "MOPDL ";

	public const string ETHERTYPE_MOPRC_STR = "MOPRC ";

	public const string ETHERTYPE_DN_STR = "DN ";

	public const string ETHERTYPE_LAT_STR = "LAT ";

	public const string ETHERTYPE_SCA_STR = "SCA ";

	public const string ETHERTYPE_LANBRIDGE_STR = "LAN BRIDGE ";

	public const string ETHERTYPE_DECDNS_STR = "DEC DNS ";

	public const string ETHERTYPE_DECDTS_STR = "DEC TS ";

	public const string ETHERTYPE_VEXP_STR = "VEXP ";

	public const string ETHERTYPE_VPROD_STR = "VPROD ";

	public const string ETHERTYPE_ATALK_STR = "ATALK ( Apple Talk )";

	public const string ETHERTYPE_AARP_STR = "AARP ";

	public const string ETHERTYPE_8021Q_STR = "8021Q ";

	public const string ETHERTYPE_IPX_STR = "IPX ( Internet Packet Excahge )";

	public const string ETHERTYPE_IPV6_STR = "IPV6 ";

	public const string ETHERTYPE_LOOPBACK_STR = "LOOPBACK ";

	public const ushort TYPE_DEVICE_ID = 1;

	public const ushort TYPE_ADDRESS = 2;

	public const ushort TYPE_PORT_ID = 3;

	public const ushort TYPE_CAPABILITIES = 4;

	public const ushort TYPE_IOS_VERSION = 5;

	public const ushort TYPE_PLATFORM = 6;

	public const ushort TYPE_IP_PREFIX = 7;

	public const ushort TYPE_VTP_MGMT_DOMAIN = 9;

	public const ushort TYPE_NATIVE_VLAN = 10;

	public const ushort TYPE_DUPLEX = 11;

	public const byte PROTO_TYPE_NLPID = 1;

	public const byte PROTO_TYPE_IEEE_802_2 = 2;

	public const byte NLPID_NULL = 0;

	public const byte NLPID_IPI_T_70 = 1;

	public const byte NLPID_SPI_X_29 = 1;

	public const byte NLPID_X_633 = 3;

	public const byte NLPID_Q_931 = 8;

	public const byte NLPID_Q_2931 = 9;

	public const byte NLPID_Q_2119 = 12;

	public const byte NLPID_SNAP = 128;

	public const byte NLPID_ISO8473_CLNP = 129;

	public const byte NLPID_ISO9542_ESIS = 130;

	public const byte NLPID_ISO10589_ISIS = 131;

	public const byte NLPID_ISO10747_IDRP = 133;

	public const byte NLPID_ISO9542X25_ESIS = 138;

	public const byte NLPID_ISO10030 = 140;

	public const byte NLPID_ISO11577 = 141;

	public const byte NLPID_IP6 = 142;

	public const byte NLPID_COMPRESSED = 176;

	public const byte NLPID_SNDCF = 193;

	public const byte NLPID_IP = 204;

	public const byte NLPID_PPP = 207;

	public const ushort FLAGS_RESPONSE = 32768;

	public const ushort FLAGS_TRUNCATED = 512;

	public const ushort FLAGS_RECURSION_DESIRED = 256;

	public const ushort FLAGS_BROADCAST = 16;

	public const ushort FLAGS_AUTHORITATIVE = 1024;

	public const ushort FLAGS_RECURSION_AVAILABLE = 128;

	public const int IPPORT_NETBIOS_NS = 137;

	public const int IPPORT_NETBIOS_DATAGRAM = 138;

	public const int IPPORT_NETBIOS_SSN = 139;

	public const ushort SOCKET_TYPE_SAP = 1106;

	public const byte PACKET_TYPE_SPX = 5;

	public const byte PACKET_TYPE_NCP = 17;

	public const int UDP_PORT_LLC1 = 12000;

	public const int UDP_PORT_LLC2 = 12001;

	public const int UDP_PORT_LLC3 = 12002;

	public const int UDP_PORT_LLC4 = 12003;

	public const int UDP_PORT_LLC5 = 12004;

	public const byte SAP_MASK = 254;

	public const byte DSAP_GI_BIT = 1;

	public const byte SSAP_CR_BIT = 1;

	public const byte XDLC_I = 0;

	public const byte XDLC_S = 1;

	public const byte XDLC_U = 3;

	public const byte XDLC_U_MODIFIER_MASK = 236;

	public const byte XDLC_UI = 0;

	public const byte XDLC_UP = 32;

	public const byte XDLC_DISC = 64;

	public const byte XDLC_RD = 64;

	public const byte XDLC_UA = 96;

	public const byte XDLC_SNRM = 128;

	public const byte XDLC_TEST = 224;

	public const byte XDLC_SIM = 4;

	public const byte XDLC_RIM = 4;

	public const byte XDLC_FRMR = 132;

	public const byte XDLC_CFGR = 196;

	public const byte XDLC_SARM = 12;

	public const byte XDLC_DM = 12;

	public const byte XDLC_SABM = 44;

	public const byte XDLC_SARME = 76;

	public const byte XDLC_SABME = 108;

	public const byte XDLC_RESET = 140;

	public const byte XDLC_XID = 172;

	public const byte XDLC_SNRME = 204;

	public const byte XDLC_BCN = 236;

	public const ushort XDLC_N_R_MASK = 224;

	public const ushort XDLC_N_R_SHIFT = 5;

	public const ushort XDLC_N_R_EXT_MASK = 65024;

	public const ushort XDLC_N_R_EXT_SHIFT = 9;

	public const ushort XDLC_N_S_MASK = 14;

	public const ushort XDLC_N_S_SHIFT = 1;

	public const ushort XDLC_N_S_EXT_MASK = 254;

	public const ushort XDLC_N_S_EXT_SHIFT = 1;

	public const ushort XDLC_P_F = 16;

	public const ushort XDLC_P_F_EXT = 256;

	public const ushort XDLC_S_FTYPE_MASK = 12;

	public const ushort XDLC_RR = 0;

	public const ushort XDLC_RNR = 4;

	public const ushort XDLC_REJ = 8;

	public const ushort XDLC_SREJ = 12;

	public const uint OUI_ENCAP_ETHER = 0u;

	public const uint OUI_CISCO = 12u;

	public const uint OUI_CISCO_90 = 248u;

	public const uint OUI_BRIDGED = 32962u;

	public const uint OUI_ATM_FORUM = 41022u;

	public const uint OUI_CABLE_BPDU = 57391u;

	public const uint OUI_APPLE_ATALK = 524295u;

	public const byte LLCSAP_NULL = 0;

	public const byte LLCSAP_GLOBAL = byte.MaxValue;

	public const byte LLCSAP_8021B_I = 2;

	public const byte LLCSAP_8021B_G = 3;

	public const byte LLCSAP_IP = 6;

	public const byte LLCSAP_PROWAYNM = 14;

	public const byte LLCSAP_8021D = 66;

	public const byte LLCSAP_RS511 = 78;

	public const byte LLCSAP_ISO8208 = 126;

	public const byte LLCSAP_PROWAY = 142;

	public const byte LLCSAP_SNAP = 170;

	public const byte LLCSAP_IPX = 224;

	public const byte LLCSAP_NETBEUI = 240;

	public const byte LLCSAP_ISONS = 254;

	public const byte LLC_TYPE_LSAP = 0;

	public const byte LLC_TYPE_SMAN_FUNCTION_I = 2;

	public const byte LLC_TYPE_SMAN_FUNCTION_G = 3;

	public const byte LLC_TYPE_IBM_SNA_PATH_CTRL_I = 4;

	public const byte LLC_TYPE_IBM_SNA_PATH_CTRL_G = 5;

	public const byte LLC_TYPE_ARPANET_IP = 6;

	public const byte LLC_TYPE_SNA_CSNA_EPROWAY = 8;

	public const byte LLC_TYPE_TEXAS_INSTRUMENTS = 24;

	public const byte LLC_TYPE_STP = 66;

	public const byte LLC_TYPE_EIA_MMS = 78;

	public const byte LLC_TYPE_X25_OVER_LLC2 = 126;

	public const byte LLC_TYPE_XNS = 128;

	public const byte LLC_TYPE_NESTAR = 134;

	public const byte LLC_TYPE_PROWAY = 142;

	public const byte LLC_TYPE_ARPANET_ARP = 152;

	public const byte LLC_TYPE_BANYAN_VINES = 188;

	public const byte LLC_TYPE_SNAP = 170;

	public const byte LLC_TYPE_NOVELL_NETWARE = 224;

	public const byte LLC_TYPE_IBM_NETBIOS = 240;

	public const byte LLC_TYPE_IBM_LANMAN_I = 244;

	public const byte LLC_TYPE_IBM_LANMAN_G = 245;

	public const byte LLC_TYPE_IBM_RPL = 248;

	public const byte LLC_TYPE_UNGERMANN_BASS = 250;

	public const byte LLC_TYPE_ISO_NLP = 254;

	public const byte LLC_TYPE_GLOBAL_LSAP = byte.MaxValue;

	public const int PACKET_ORGANIZATION_CISCO = 12;

	public const byte NBDS_DIRECT_UNIQUE = 16;

	public const byte NBDS_DIRECT_GROUP = 17;

	public const byte NBDS_BROADCAST = 18;

	public const byte NBDS_ERROR = 19;

	public const byte NBDS_QUERY_REQUEST = 20;

	public const byte NBDS_POS_QUERY_RESPONSE = 21;

	public const byte NBDS_NEG_QUERY_RESPONSE = 22;

	public const ushort UDP_PORT_NBNS = 137;

	public const ushort UDP_PORT_NBDGM = 138;

	public const ushort TCP_PORT_NBSS = 139;

	public const ushort TCP_PORT_CIFS = 445;

	public const ushort FLAGS_OP_CODE = 30720;

	public const ushort OPCODE_SHIFT = 11;

	public const ushort FLAGS_REPLY_CODE = 15;

	public const ushort TYPE_NB = 32;

	public const ushort TYPE_NBSTAT = 33;

	public const ushort CLASS_INET = 1;

	public const ushort CLASS_CSNET = 2;

	public const ushort CLASS_CHAOS = 3;

	public const ushort CLASS_HESIOD = 4;

	public const ushort CLASS_NONE = 254;

	public const ushort CLASS_ANY = 255;

	public const ushort CLASS_FLUSH = 32768;

	public const byte OPCODE_QUERY = 0;

	public const byte OPCODE_REGISTRATION = 5;

	public const byte OPCODE_RELEASE = 6;

	public const byte OPCODE_WACK = 7;

	public const byte OPCODE_REFRESH = 8;

	public const byte OPCODE_REFRESHALT = 9;

	public const byte OPCODE_MHREGISTRATION = 15;

	public const byte RCODE_NOERROR = 0;

	public const byte RCODE_FMTERROR = 1;

	public const byte RCODE_SERVFAIL = 2;

	public const byte RCODE_NAMEERROR = 3;

	public const byte RCODE_NOTIMPL = 4;

	public const byte RCODE_REFUSED = 5;

	public const byte RCODE_ACTIVE = 6;

	public const byte RCODE_CONFLICT = 7;

	public const ushort NB_FLAGS_MASK = 24576;

	public const ushort NB_FLAGS_B_NODE = 0;

	public const ushort NB_FLAGS_P_NODE = 1;

	public const ushort NB_FLAGS_M_NODE = 2;

	public const ushort NB_FLAGS_H_NODE = 3;

	public const ushort NB_FLAGS_G = 32768;

	public const ushort NAME_FLAGS_PRM = 512;

	public const ushort NAME_FLAGS_ACT = 1024;

	public const ushort NAME_FLAGS_CNF = 2048;

	public const ushort NAME_FLAGS_DRG = 4096;

	public const ushort NAME_FLAGS_MASK = 24576;

	public const ushort NAME_FLAGS_B_NODE = 0;

	public const ushort NAME_FLAGS_P_NODE = 1;

	public const ushort NAME_FLAGS_M_NODE = 2;

	public const ushort NAME_FLAGS_G = 32768;

	public const byte SESSION_MESSAGE = 0;

	public const byte SESSION_REQUEST = 129;

	public const byte POSITIVE_SESSION_RESPONSE = 130;

	public const byte NEGATIVE_SESSION_RESPONSE = 131;

	public const byte RETARGET_SESSION_RESPONSE = 132;

	public const byte SESSION_KEEP_ALIVE = 133;

	public const byte NBSS_FLAGS_E = 1;

	public const byte T_NB = 32;

	public const byte T_NBSTAT = 33;

	public const int F_OPCODE = 30720;

	public const byte NB_ADD_GROUP = 0;

	public const byte NB_ADD_NAME = 1;

	public const byte NB_NAME_IN_CONFLICT = 2;

	public const byte NB_STATUS_QUERY = 3;

	public const byte NB_TERMINATE_TRACE_R = 7;

	public const byte NB_DATAGRAM = 8;

	public const byte NB_DATAGRAM_BCAST = 9;

	public const byte NB_NAME_QUERY = 10;

	public const byte NB_ADD_NAME_RESP = 13;

	public const byte NB_NAME_RESP = 14;

	public const byte NB_STATUS_RESP = 15;

	public const byte NB_TERMINATE_TRACE_LR = 19;

	public const byte NB_DATA_ACK = 20;

	public const byte NB_DATA_FIRST_MIDDLE = 21;

	public const byte NB_DATA_ONLY_LAST = 22;

	public const byte NB_SESSION_CONFIRM = 23;

	public const byte NB_SESSION_END = 24;

	public const byte NB_SESSION_INIT = 25;

	public const byte NB_NO_RECEIVE = 26;

	public const byte NB_RECEIVE_OUTSTANDING = 27;

	public const byte NB_RECEIVE_CONTINUE = 28;

	public const byte NB_KEEP_ALIVE = 31;

	public const byte SMB_CMD_CREATE_DIR = 0;

	public const byte SMB_CMD_DELETE_DIR = 1;

	public const byte SMB_CMD_OPEN_FILE = 2;

	public const byte SMB_CMD_CREATE_FILE = 3;

	public const byte SMB_CMD_CLOSE_FILE = 4;

	public const byte SMB_CMD_COMMIT_ALL_FILES = 5;

	public const byte SMB_CMD_DELETE_FILE = 6;

	public const byte SMB_CMD_RENAME_FILE = 7;

	public const byte SMB_CMD_GET_FILE_ATTRIBUTE = 8;

	public const byte SMB_CMD_SET_FILE_ATTRIBUTE = 9;

	public const byte SMB_CMD_READ_BYTE_BLOCK = 10;

	public const byte SMB_CMD_WRITE_BYTE_BLOCK = 11;

	public const byte SMB_CMD_LOCK_BYTE_BLOCK = 12;

	public const byte SMB_CMD_UNLOCK_BYTE_BLOCK = 13;

	public const byte SMB_CMD_CREATE_NEW_FILE = 15;

	public const byte SMB_CMD_CHECK_DIR = 16;

	public const byte SMB_CMD_END_OF_PROCESS = 17;

	public const byte SMB_CMD_LSEEK = 18;

	public const byte SMB_CMD_START_CONNECTION = 112;

	public const byte SMB_CMD_END_CONNECTION = 113;

	public const byte SMB_CMD_VERIFY_DIALECT = 114;

	public const byte SMB_CMD_GET_DISK_ATTRIBUTES = 128;

	public const byte SMB_CMD_SEARCH_MULTIPLE_FILES = 129;

	public const byte SMB_CMD_CREATE_SPOOL_FILE = 192;

	public const byte SMB_CMD_SPOOL_BYTE_BLOCK = 193;

	public const byte SMB_CMD_CLOSE_SPOOL_FILE = 194;

	public const byte SMB_CMD_RETURN_PRINT_QUEUE = 195;

	public const byte SMB_CMD_SEND_MESSAGE = 208;

	public const byte SMB_CMD_SEND_BROADCAST = 209;

	public const byte SMB_CMD_FORWARD_USER_NAME = 210;

	public const byte SMB_CMD_CANCEL_FORWARD = 211;

	public const byte SMB_CMD_GET_MACHINE_NAME = 212;

	public const byte SMB_CMD_START_MULTI_BLOCK_MESSAGE = 213;

	public const byte SMB_CMD_END_MULTI_BLOCK_MESSAGE = 214;

	public const byte SMB_CMD_MULTI_BLOCK_MESSAGE_TEXT = 215;

	public const byte SMB_CMD_INVALID = 254;

	public const byte SMB_CMD_IMPLEMENTATION_DEPENDENT = byte.MaxValue;

	public const byte SMB_CMD_LOCAK_THEN_READ_DATA = 19;

	public const byte SMB_CMD_WRITE_THEN_UNLOCK_DATA = 20;

	public const byte SMB_CMD_READ_BLOCK_RAW = 26;

	public const byte SMB_CMD_WRITE_BLOCK_RAW = 29;

	public const byte SMB_CMD_READ_BLOCK_MULTIPLEXED = 27;

	public const byte SMB_CMD_READ_BLOCK_SR = 28;

	public const byte SMB_CMD_WRITE_BLOCK_MULTIPLEXED = 30;

	public const byte SMB_CMD_WRITE_BLOCK_SR = 31;

	public const byte SMB_CMD_WRITE_COMPLETE_RESPONSE = 32;

	public const byte SMB_CMD_SET_FILE_ATTRIBUTES_EXPANDED = 34;

	public const byte SMB_CMD_GET_FILE_ATTRIBUTES_EXPANDED = 35;

	public const byte SMB_CMD_LOCK_UNLOCK_BYTE_RANGES_AND_X = 36;

	public const byte SMB_CMD_TRANSACTION = 37;

	public const byte SMB_CMD_TRANSACTION_SECONDARY = 38;

	public const byte SMB_CMD_PASS_IOCTL_TO_SERVER = 39;

	public const byte SMB_CMD_IOCTL = 40;

	public const byte SMB_CMD_COPY = 41;

	public const byte SMB_CMD_MOVE = 42;

	public const byte SMB_CMD_ECHO = 43;

	public const byte SMB_CMD_WRITE_AND_CLOSE = 44;

	public const byte SMB_CMD_OPEN_AND_X = 45;

	public const byte SMB_CMD_READ_AND_X = 46;

	public const byte SMB_CMD_WRITE_AND_X = 47;

	public const byte SMB_CMD_SESSION_SETUP_AND_X = 115;

	public const byte SMB_CMD_TREE_CONNECT_AND_X = 117;

	public const byte SMB_CMD_FIND_FIRST = 130;

	public const byte SMB_CMD_FIND_UNIQUE = 131;

	public const byte SMB_CMD_FIND_CLOSE = 132;

	public const byte SMB_ERROR_CLASS_SUCCESS = 0;

	public const byte SMB_ERROR_CLASS_ERRSRV = 2;

	public const byte SMB_ERROR_CLASS_SUCCESS_BUFFERED = 84;

	public const byte SMB_ERROR_CLASS_SUCCESS_LOGGED = 85;

	public const byte SMB_ERROR_CLASS_SUCCESS_DISPLAYED = 86;

	public const byte SMB_ERROR_CLASS_ERRSRV_ERRerror = 1;

	public const byte SMB_ERROR_CLASS_ERRSRV_ERRbadpw = 2;

	public const byte SMB_ERROR_CLASS_ERRSRV_ERRbadtype = 3;

	public const byte SMB_COMMAND_SEND_SINGLE_BLOCK_MESSAGE = 208;

	public const byte SMB_COMMAND_TRANSACTION_REQUEST = 37;

	public const ushort FLAGS_TRANSACTION_ONEWAY = 2;

	public const ushort FLAGS_TRANSACTION_DISCONNECT = 1;

	public const byte FLAGS_REQUEST_RESPONSE = 128;

	public const byte FLAGS_NOTIFY = 64;

	public const byte FLAGS_OPLOCKS = 32;

	public const byte FLAGS_CANONICALIZED_PATH_NAMES = 16;

	public const byte FLAGS_CASE_SENSITIVITY = 8;

	public const byte FLAGS_RECEIVE_BUFFER_POSTED = 2;

	public const byte FLAGS_LOCK_AND_READ = 1;

	public const ushort FLAGS2_UNICODE_STRINGS = 32768;

	public const ushort FLAGS2_ERROR_CODE_TYPE = 16384;

	public const ushort FLAGS2_EXECUTE_ONLY_READS = 8192;

	public const ushort FLAGS2_DFS = 4096;

	public const ushort FLAGS2_EXTENDED_SECURITY_NEGOTIATION = 2048;

	public const ushort FLAGS2_LONG_NAMES_USED = 64;

	public const ushort FLAGS2_SECUTIRY_SIGNATURES = 4;

	public const ushort FLAGS2_EXTENDED_ATTRIBUTES = 2;

	public const ushort FLAGS2_LONG_NAMES_ALLOWED = 1;

	public const byte FORMAT_TYPE_ASCII = 4;

	public const byte FORMAT_TYPE_DATA_BLOCK = 1;

	public const byte RAWMODE_READ = 1;

	public const byte RAWMODE_WRITE = 2;

	public const byte SECURITY_MODE_MODE = 1;

	public const byte SECURITY_MODE_PASSWORD = 2;

	public const byte SECURITY_MODE_SIGNATURES = 4;

	public const byte SECURITY_MODE_SIG_REQUIRED = 8;

	public const ushort SMB_SIF_TID_IS_IPC = 1;

	public const byte SMB_FLAGS_DIRN = 128;

	public const uint SMB_FILE_ATTRIBUTE_READ_ONLY = 1u;

	public const uint SMB_FILE_ATTRIBUTE_HIDDEN = 2u;

	public const uint SMB_FILE_ATTRIBUTE_SYSTEM = 4u;

	public const uint SMB_FILE_ATTRIBUTE_VOLUME = 8u;

	public const uint SMB_FILE_ATTRIBUTE_DIRECTORY = 16u;

	public const uint SMB_FILE_ATTRIBUTE_ARCHIVE = 32u;

	public const uint SMB_FILE_ATTRIBUTE_DEVICE = 64u;

	public const uint SMB_FILE_ATTRIBUTE_NORMAL = 128u;

	public const uint SMB_FILE_ATTRIBUTE_TEMPORARY = 256u;

	public const uint SMB_FILE_ATTRIBUTE_SPARSE = 512u;

	public const uint SMB_FILE_ATTRIBUTE_REPARSE = 1024u;

	public const uint SMB_FILE_ATTRIBUTE_COMPRESSED = 2048u;

	public const uint SMB_FILE_ATTRIBUTE_OFFLINE = 4096u;

	public const uint SMB_FILE_ATTRIBUTE_NOT_CONTENT_INDEXED = 8192u;

	public const uint SMB_FILE_ATTRIBUTE_ENCRYPTED = 16384u;

	public const uint SERVER_CAP_RAW_MODE = 1u;

	public const uint SERVER_CAP_MPX_MODE = 2u;

	public const uint SERVER_CAP_UNICODE = 4u;

	public const uint SERVER_CAP_LARGE_FILES = 8u;

	public const uint SERVER_CAP_NT_SMBS = 16u;

	public const uint SERVER_CAP_RPC_REMOTE_APIS = 32u;

	public const uint SERVER_CAP_STATUS32 = 64u;

	public const uint SERVER_CAP_LEVEL_II_OPLOCKS = 128u;

	public const uint SERVER_CAP_LOCK_AND_READ = 256u;

	public const uint SERVER_CAP_NT_FIND = 512u;

	public const uint SERVER_CAP_DFS = 4096u;

	public const uint SERVER_CAP_INFOLEVEL_PASSTHRU = 8192u;

	public const uint SERVER_CAP_LARGE_READX = 16384u;

	public const uint SERVER_CAP_LARGE_WRITEX = 32768u;

	public const uint SERVER_CAP_UNIX = 8388608u;

	public const uint SERVER_CAP_RESERVED = 33554432u;

	public const uint SERVER_CAP_BULK_TRANSFER = 536870912u;

	public const uint SERVER_CAP_COMPRESSED_DATA = 1073741824u;

	public const uint SERVER_CAP_EXTENDED_SECURITY = 2147483648u;

	public const ushort PROTOCOL_ID_STP = 0;

	public const byte PROTOCOL_VERSION_ID_ST = 0;

	public const byte BPDU_TYPE_CONFIGURATION = 0;

	public const byte FLAGS_TOPOLOGY_CHANGE = 1;

	public const byte FLAGS_TOPOLOGY_CHANGE_ACKNOWLEDGMENT = 129;

	public const byte NT_TRANS_CREATE = 1;

	public const byte NT_TRANS_IOCTL = 2;

	public const byte NT_TRANS_SSD = 3;

	public const byte NT_TRANS_NOTIFY = 4;

	public const byte NT_TRANS_RENAME = 5;

	public const byte NT_TRANS_QSD = 6;

	public const byte NT_TRANS_GET_USER_QUOTA = 7;

	public const byte NT_TRANS_SET_USER_QUOTA = 8;

	public const byte NT_IOCTL_FLAGS_ROOT_HANDLE = 1;

	public const uint NT_NOTIFY_STREAM_WRITE = 2048u;

	public const uint NT_NOTIFY_STREAM_SIZE = 1024u;

	public const uint NT_NOTIFY_STREAM_NAME = 512u;

	public const uint NT_NOTIFY_SECURITY = 256u;

	public const uint NT_NOTIFY_EA = 128u;

	public const uint NT_NOTIFY_CREATION = 64u;

	public const uint NT_NOTIFY_LAST_ACCESS = 32u;

	public const uint NT_NOTIFY_LAST_WRITE = 16u;

	public const uint NT_NOTIFY_SIZE = 8u;

	public const uint NT_NOTIFY_ATTRIBUTES = 4u;

	public const uint NT_NOTIFY_DIR_NAME = 2u;

	public const uint NT_NOTIFY_FILE_NAME = 1u;

	public const uint NT_QSD_OWNER = 1u;

	public const uint NT_QSD_GROUP = 2u;

	public const uint NT_QSD_DACL = 4u;

	public const uint NT_QSD_SACL = 8u;

	public const byte SMB_COM_CREATE_DIRECTORY = 0;

	public const byte SMB_COM_DELETE_DIRECTORY = 1;

	public const byte SMB_COM_OPEN = 2;

	public const byte SMB_COM_CREATE = 3;

	public const byte SMB_COM_CLOSE = 4;

	public const byte SMB_COM_FLUSH = 5;

	public const byte SMB_COM_DELETE = 6;

	public const byte SMB_COM_RENAME = 7;

	public const byte SMB_COM_QUERY_INFORMATION = 8;

	public const byte SMB_COM_SET_INFORMATION = 9;

	public const byte SMB_COM_READ = 10;

	public const byte SMB_COM_WRITE = 11;

	public const byte SMB_COM_LOCK_BYTE_RANGE = 12;

	public const byte SMB_COM_UNLOCK_BYTE_RANGE = 13;

	public const byte SMB_COM_CREATE_TEMPORARY = 14;

	public const byte SMB_COM_CREATE_NEW = 15;

	public const byte SMB_COM_CHECK_DIRECTORY = 16;

	public const byte SMB_COM_PROCESS_EXIT = 17;

	public const byte SMB_COM_SEEK = 18;

	public const byte SMB_COM_LOCK_AND_READ = 19;

	public const byte SMB_COM_WRITE_AND_UNLOCK = 20;

	public const byte SMB_COM_READ_RAW = 26;

	public const byte SMB_COM_READ_MPX = 27;

	public const byte SMB_COM_READ_MPX_SECONDARY = 28;

	public const byte SMB_COM_WRITE_RAW = 29;

	public const byte SMB_COM_WRITE_MPX = 30;

	public const byte SMB_COM_WRITE_MPX_SECONDARY = 31;

	public const byte SMB_COM_WRITE_COMPLETE = 32;

	public const byte SMB_COM_QUERY_SERVER = 33;

	public const byte SMB_COM_SET_INFORMATION2 = 34;

	public const byte SMB_COM_QUERY_INFORMATION2 = 35;

	public const byte SMB_COM_LOCKING_ANDX = 36;

	public const byte SMB_COM_TRANSACTION = 37;

	public const byte SMB_COM_TRANSACTION_SECONDARY = 38;

	public const byte SMB_COM_IOCTL = 39;

	public const byte SMB_COM_IOCTL_SECONDARY = 40;

	public const byte SMB_COM_COPY = 41;

	public const byte SMB_COM_MOVE = 42;

	public const byte SMB_COM_ECHO = 43;

	public const byte SMB_COM_WRITE_AND_CLOSE = 44;

	public const byte SMB_COM_OPEN_ANDX = 45;

	public const byte SMB_COM_READ_ANDX = 46;

	public const byte SMB_COM_WRITE_ANDX = 47;

	public const byte SMB_COM_NEW_FILE_SIZE = 48;

	public const byte SMB_COM_CLOSE_AND_TREE_DISC = 49;

	public const byte SMB_COM_TRANSACTION2 = 50;

	public const byte SMB_COM_TRANSACTION2_SECONDARY = 51;

	public const byte SMB_COM_FIND_CLOSE2 = 52;

	public const byte SMB_COM_FIND_NOTIFY_CLOSE = 53;

	public const byte SMB_COM_TREE_CONNECT = 112;

	public const byte SMB_COM_TREE_DISCONNECT = 113;

	public const byte SMB_COM_NEGOTIATE = 114;

	public const byte SMB_COM_SESSION_SETUP_ANDX = 115;

	public const byte SMB_COM_LOGOFF_ANDX = 116;

	public const byte SMB_COM_TREE_CONNECT_ANDX = 117;

	public const byte SMB_COM_QUERY_INFORMATION_DISK = 128;

	public const byte SMB_COM_SEARCH = 129;

	public const byte SMB_COM_FIND = 130;

	public const byte SMB_COM_FIND_UNIQUE = 131;

	public const byte SMB_COM_FIND_CLOSE = 132;

	public const byte SMB_COM_NT_TRANSACT = 160;

	public const byte SMB_COM_NT_TRANSACT_SECONDARY = 161;

	public const byte SMB_COM_NT_CREATE_ANDX = 162;

	public const byte SMB_COM_NT_CANCEL = 164;

	public const byte SMB_COM_NT_RENAME = 165;

	public const byte SMB_COM_OPEN_PRINT_FILE = 192;

	public const byte SMB_COM_WRITE_PRINT_FILE = 193;

	public const byte SMB_COM_CLOSE_PRINT_FILE = 194;

	public const byte SMB_COM_GET_PRINT_QUEUE = 195;

	public const byte SMB_SEND_SINGLE_BLOCK_MESSAGE = 208;

	public const byte SMB_SEND_BROADCAST_MESSAGE = 209;

	public const byte SMB_FORWARD_USER_NAME = 210;

	public const byte SMB_CANCEL_FORWARD = 211;

	public const byte SMB_GET_MACHINE_NAME = 212;

	public const byte SMB_SEND_START_MULTI_BLOCK_MESSAGE = 213;

	public const byte SMB_SEND_END_MULTI_BLOCK_MESSAGE = 214;

	public const byte SMB_SEND_TEXT_MULTI_BLOCK_MESSAGE = 215;

	public const byte SMB_COM_READ_BULK = 216;

	public const byte SMB_COM_WRITE_BULK = 217;

	public const byte SMB_COM_WRITE_BULK_DATA = 218;

	public const byte SMB_SUCCESS = 0;

	public const byte SMB_ERRDOS = 1;

	public const byte SMB_ERRSRV = 2;

	public const byte SMB_ERRHRD = 3;

	public const byte SMB_ERRCMD = 4;

	public const ushort SMBE_badfunc = 1;

	public const ushort SMBE_badfile = 2;

	public const ushort SMBE_badpath = 3;

	public const ushort SMBE_nofids = 4;

	public const ushort SMBE_noaccess = 5;

	public const ushort SMBE_badfid = 6;

	public const ushort SMBE_badmcb = 7;

	public const ushort SMBE_nomem = 8;

	public const ushort SMBE_badmem = 9;

	public const ushort SMBE_badenv = 10;

	public const ushort SMBE_badformat = 11;

	public const ushort SMBE_badaccess = 12;

	public const ushort SMBE_baddata = 13;

	public const ushort SMBE_res = 14;

	public const ushort SMBE_baddrive = 15;

	public const ushort SMBE_remcd = 16;

	public const ushort SMBE_diffdevice = 17;

	public const ushort SMBE_nofiles = 18;

	public const ushort SMBE_badshare = 32;

	public const ushort SMBE_lock = 33;

	public const ushort SMBE_unsup = 50;

	public const ushort SMBE_nosuchshare = 67;

	public const ushort SMBE_filexists = 80;

	public const ushort SMBE_invalidparam = 87;

	public const ushort SMBE_cannotopen = 110;

	public const ushort SMBE_insufficientbuffer = 122;

	public const ushort SMBE_invalidname = 123;

	public const ushort SMBE_unknownlevel = 124;

	public const ushort SMBE_alreadyexists = 183;

	public const ushort SMBE_badpipe = 230;

	public const ushort SMBE_pipebusy = 231;

	public const ushort SMBE_pipeclosing = 232;

	public const ushort SMBE_notconnected = 233;

	public const ushort SMBE_moredata = 234;

	public const ushort SMBE_nomoreitems = 259;

	public const ushort SMBE_baddirectory = 267;

	public const ushort SMBE_eas_didnt_fit = 275;

	public const ushort SMBE_eas_nsup = 282;

	public const ushort SMBE_notify_buf_small = 1022;

	public const ushort SMBE_serverunavailable = 1722;

	public const ushort SMBE_unknownipc = 2142;

	public const ushort SMBE_noipc = 66;

	public const ushort SMBE_invalidowner = 1307;

	public const ushort SMBE_invalidsecuritydescriptor = 1338;

	public const ushort SMBE_unknownprinterdriver = 1797;

	public const ushort SMBE_invalidprintername = 1801;

	public const ushort SMBE_printeralreadyexists = 1802;

	public const ushort SMBE_invaliddatatype = 1804;

	public const ushort SMBE_invalidenvironment = 1805;

	public const ushort SMBE_invalidformsize = 1903;

	public const ushort SMBE_printerdriverinuse = 3001;

	public const ushort SMBE_error = 1;

	public const ushort SMBE_badpw = 2;

	public const ushort SMBE_badtype = 3;

	public const ushort SMBE_access = 4;

	public const ushort SMBE_invnid = 5;

	public const ushort SMBE_invnetname = 6;

	public const ushort SMBE_invdevice = 7;

	public const ushort SMBE_qfull = 49;

	public const ushort SMBE_qtoobig = 50;

	public const ushort SMBE_qeof = 51;

	public const ushort SMBE_invpfid = 52;

	public const ushort SMBE_smbcmd = 64;

	public const ushort SMBE_srverror = 65;

	public const ushort SMBE_filespecs = 67;

	public const ushort SMBE_badlink = 68;

	public const ushort SMBE_badpermits = 69;

	public const ushort SMBE_badpid = 70;

	public const ushort SMBE_setattrmode = 71;

	public const ushort SMBE_paused = 81;

	public const ushort SMBE_msgoff = 82;

	public const ushort SMBE_noroom = 83;

	public const ushort SMBE_rmuns = 87;

	public const ushort SMBE_timeout = 88;

	public const ushort SMBE_noresource = 89;

	public const ushort SMBE_toomanyuids = 90;

	public const ushort SMBE_baduid = 91;

	public const ushort SMBE_useMPX = 250;

	public const ushort SMBE_useSTD = 251;

	public const ushort SMBE_contMPX = 252;

	public const ushort SMBE_badPW = 253;

	public const ushort SMBE_nosupport = ushort.MaxValue;

	public const ushort SMBE_unknownsmb = 22;

	public const byte SMBE_nowrite = 19;

	public const byte SMBE_badunit = 20;

	public const byte SMBE_notready = 21;

	public const byte SMBE_badcmd = 22;

	public const byte SMBE_data = 23;

	public const byte SMBE_badreq = 24;

	public const byte SMBE_seek = 25;

	public const byte SMBE_badmedia = 26;

	public const byte SMBE_badsector = 27;

	public const byte SMBE_nopaper = 28;

	public const byte SMBE_write = 29;

	public const byte SMBE_read = 30;

	public const byte SMBE_general = 31;

	public const byte SMBE_wrongdisk = 34;

	public const byte SMBE_FCBunavail = 35;

	public const byte SMBE_sharebufexc = 36;

	public const byte SMBE_diskfull = 39;

	public const byte TRANSACTION_PIPE = 0;

	public const byte TRANSACTION_MAILSLOT = 1;

	public const byte TID_NORMAL = 1;

	public const byte TID_IPC = 2;

	public const uint GENERIC_RIGHTS_MASK = 4026531840u;

	public const uint GENERIC_ALL_ACCESS = 268435456u;

	public const uint GENERIC_EXECUTE_ACCESS = 536870912u;

	public const uint GENERIC_WRITE_ACCESS = 1073741824u;

	public const uint GENERIC_READ_ACCESS = 2147483648u;

	public const uint ACCESS_SACL_ACCESS = 8388608u;

	public const uint SYSTEM_SECURITY_ACCESS = 16777216u;

	public const uint MAXIMUM_ALLOWED_ACCESS = 33554432u;

	public const uint STANDARD_RIGHTS_MASK = 16711680u;

	public const uint DELETE_ACCESS = 65536u;

	public const uint READ_CONTROL_ACCESS = 131072u;

	public const uint WRITE_DAC_ACCESS = 262144u;

	public const uint WRITE_OWNER_ACCESS = 524288u;

	public const uint SYNCHRONIZE_ACCESS = 1048576u;

	public const uint SPECIFIC_RIGHTS_MASK = 65535u;

	public const ushort TFTP_RRQ = 1;

	public const ushort TFTP_WRQ = 2;

	public const ushort TFTP_DATA = 3;

	public const ushort TFTP_ACK = 4;

	public const ushort TFTP_ERROR = 5;

	public const ushort TFTP_OACK = 6;

	public const byte AR_HRD = 0;

	public const byte AR_PRO = 2;

	public const byte AR_HLN = 4;

	public const byte AR_PLN = 5;

	public const byte AR_OP = 6;

	public const byte MIN_AARP_HEADER_SIZE = 8;

	public const ushort AARP_REQUEST = 1;

	public const ushort AARP_REPLY = 2;

	public const ushort AARP_PROBE = 3;

	public const ushort AARP_REQUEST_SWAPPED = 256;

	public const ushort AARP_REPLY_SWAPPED = 512;

	public const ushort AARP_PROBE_SWAPPED = 768;

	public const ushort AARPHRD_ETHER = 1;

	public const ushort AARPHRD_TR = 2;

	public const byte DLSW_CANUREACH = 3;

	public const byte DLSW_ICANREACH = 4;

	public const byte DLSW_REACH_ACK = 5;

	public const byte DLSW_DGRMFRAME = 6;

	public const byte DLSW_XIDFRAME = 7;

	public const byte DLSW_CONTACT = 8;

	public const byte DLSW_CONTACTED = 9;

	public const byte DLSW_RESTART_DL = 16;

	public const byte DLSW_DL_RESTARTED = 17;

	public const byte DLSW_ENTER_BUSY = 12;

	public const byte DLSW_EXIT_BUSY = 13;

	public const byte DLSW_INFOFRAME = 10;

	public const byte DLSW_HALT_DL = 14;

	public const byte DLSW_DL_HALTED = 15;

	public const byte DLSW_NETBIOS_NQ = 18;

	public const byte DLSW_NETBIOS_NR = 19;

	public const byte DLSW_DATAFRAME = 20;

	public const byte DLSW_HALT_DL_NOACK = 25;

	public const byte DLSW_NETBIOS_ANQ = 26;

	public const byte DLSW_NETBIOS_ANR = 27;

	public const byte DLSW_KEEPALIVE = 29;

	public const byte DLSW_CAP_EXCHANGE = 32;

	public const byte DLSW_IFCM = 33;

	public const byte DLSW_TEST_CIRCUIT_REQ = 122;

	public const byte DLSW_TEST_CIRCUIT_RSP = 123;

	public const byte DLSW_INFO_HEADER = 16;

	public const byte DLSW_CMD_HEADER = 72;

	public const ushort DLSW_GDSID_SEND = 5408;

	public const ushort DLSW_GDSID_ACK = 5409;

	public const ushort DLSW_GDSID_REF = 5410;

	public const byte MAILSLOT_UNKNOWN = 0;

	public const byte MAILSLOT_BROWSE = 1;

	public const byte MAILSLOT_LANMAN = 2;

	public const byte MAILSLOT_NET = 3;

	public const byte MAILSLOT_TEMP_NETLOGON = 4;

	public const byte MAILSLOT_MSSP = 5;

	public static uint TimeZone8HourSecs = (uint)(TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).Hours * 60 * 60);

	public static int CurFileType = 1;

	public static string GetETHERTYPEStr(uint EType)
	{
		string text = "";
		return EType switch
		{
			512u => "PUP", 
			2048u => "IP ( Internet Protocol )", 
			2054u => "ARP ( Address Resolution Protocol )", 
			32821u => "RARP ( Reverse Address Resolution Protocol )", 
			1536u => "NS ", 
			1280u => "SPRITE ", 
			4096u => "TRAIL ", 
			24577u => "MOPDL ", 
			24578u => "MOPRC ", 
			24579u => "DN ", 
			24580u => "LAT ", 
			24583u => "SCA ", 
			32824u => "LAN BRIDGE ", 
			32828u => "DEC DNS ", 
			32830u => "DEC TS ", 
			32859u => "VEXP ", 
			32860u => "VPROD ", 
			32923u => "ATALK ( Apple Talk )", 
			33011u => "AARP ", 
			33024u => "8021Q ", 
			33079u => "IPX ( Internet Packet Excahge )", 
			34525u => "IPV6 ", 
			36864u => "LOOPBACK ", 
			_ => "Unkwon", 
		};
	}

	public static string GetProtocolStr(int Prtcl)
	{
		string text = "";
		return Prtcl switch
		{
			0 => "IP Protocol", 
			1 => "ICMP Protocol", 
			2 => "IGMP Protocol", 
			3 => "GGP Protocol", 
			6 => "TCP Protocol", 
			12 => "PUP Protocol", 
			17 => "UDP Protocol", 
			22 => "IDP Protocol", 
			41 => "IPV6 Protocol", 
			77 => "ND Protocol", 
			78 => "ICLFXBM Protocol", 
			88 => "EIGRP Protocol", 
			255 => "RAW Protocol", 
			256 => "MAX Protocol", 
			_ => "Unknown Protocol", 
		};
	}

	public static string GetPortStr(int Prt)
	{
		string text = "";
		return Prt switch
		{
			7 => "ECHO", 
			9 => "DISCARD", 
			11 => "SYSTAT", 
			13 => "DAYTIME", 
			15 => "NETSTAT", 
			21 => "FTP", 
			23 => "TELNET", 
			25 => "SMPTP", 
			37 => "TIMESERVER", 
			42 => "NAMESERVER", 
			43 => "DNS", 
			57 => "MTP", 
			69 => "TFTP", 
			77 => "RJE", 
			79 => "FINGER", 
			80 => "HTTP", 
			1433 => "SQL", 
			8080 => "HTTP", 
			1031 => "SSDP", 
			87 => "TTYLINK", 
			95 => "SUPDUP", 
			135 => "EPMEP", 
			137 => "NETBIOS NAME SERVICE", 
			138 => "NETBIOS DATAGRAM", 
			139 => "NETBIOS SSN", 
			512 => "EXECSERVER", 
			514 => "CMDSERVER", 
			513 => "WHOSERVER", 
			520 => "ROUTESERVER", 
			_ => "Unknown Port", 
		};
	}

	public static string GetNetBiosNames(byte b)
	{
		int num = 0;
		string[] array = new string[256];
		for (num = 0; num < 256; num++)
		{
			array[num] = "Unknown";
		}
		array[0] = "Workstation Service or base computer name";
		array[32] = "Server Service";
		array[27] = "Domain Master Browser";
		array[3] = "Messenger Service";
		array[3] = "Messenger Service";
		array[29] = "Master Browser";
		array[6] = "Remote Access Server Service";
		array[31] = "NetDDE Service";
		array[33] = "RAS Client Service";
		array[190] = "Network Monitor Agent";
		array[191] = "Network Monitor Application";
		array[0] = "Domain Name";
		array[28] = "Domain Controller";
		array[27] = "Domain Controller";
		array[30] = "Browser Service Elections";
		return array[b];
	}

	public static bool XDLC_IS_INFORMATION(byte control)
	{
		if ((control & 1) == 0 || control == 3)
		{
			return true;
		}
		return false;
	}

	public static int GetXdlcControlLegth(byte control, bool is_extended)
	{
		if ((control & 3) == 3 || !is_extended)
		{
			return 1;
		}
		return 2;
	}

	public static ushort GetXdlcControl(byte Value, byte Value2, ref bool IsExtended)
	{
		int num = 0;
		switch (Value & 3)
		{
		default:
			num = ((!IsExtended) ? Value : (Value * 256 + Value2));
			break;
		case 3:
			num = Value;
			break;
		case 1:
			break;
		}
		return (ushort)num;
	}

	public static string GetSTypeString(ushort u)
	{
		string result = "";
		switch (u)
		{
		case 0:
			result = "Receiver ready";
			break;
		case 4:
			result = "Receiver not ready";
			break;
		case 8:
			result = "Selective reject";
			break;
		}
		return result;
	}

	public static string GetShortValueCommandString(ushort u)
	{
		string result = "";
		switch (u)
		{
		case 0:
			result = "UI";
			break;
		case 32:
			result = "UP";
			break;
		case 64:
			result = "DISC";
			break;
		case 96:
			result = "UA";
			break;
		case 128:
			result = "SNRM";
			break;
		case 204:
			result = "SNRME";
			break;
		case 224:
			result = "TEST";
			break;
		case 4:
			result = "SIM";
			break;
		case 132:
			result = "FRMR";
			break;
		case 196:
			result = "CFGR";
			break;
		case 12:
			result = "SARM";
			break;
		case 44:
			result = "SABM";
			break;
		case 76:
			result = "SARME";
			break;
		case 108:
			result = "SABME";
			break;
		case 140:
			result = "RESET";
			break;
		case 172:
			result = "XID";
			break;
		case 236:
			result = "BCN";
			break;
		}
		return result;
	}

	public static string GetShortValueResponseString(ushort u)
	{
		string result = "";
		switch (u)
		{
		case 0:
			result = "UI";
			break;
		case 32:
			result = "UP";
			break;
		case 64:
			result = "DISC";
			break;
		case 96:
			result = "UA";
			break;
		case 128:
			result = "SNRM";
			break;
		case 204:
			result = "SNRME";
			break;
		case 224:
			result = "TEST";
			break;
		case 4:
			result = "SIM";
			break;
		case 132:
			result = "FRMR";
			break;
		case 196:
			result = "CFGR";
			break;
		case 12:
			result = "SARM";
			break;
		case 44:
			result = "SABM";
			break;
		case 76:
			result = "SARME";
			break;
		case 108:
			result = "SABME";
			break;
		case 140:
			result = "RESET";
			break;
		case 172:
			result = "XID";
			break;
		case 236:
			result = "BCN";
			break;
		}
		return result;
	}

	public static string GetValueCommandString(ushort u)
	{
		string result = "";
		switch (u)
		{
		case 0:
			result = "Unnumbered Information";
			break;
		case 32:
			result = "Unnumbered Poll";
			break;
		case 64:
			result = "Disconnect";
			break;
		case 96:
			result = "Unnumbered Acknowledge";
			break;
		case 128:
			result = "Set Normal Response Mode";
			break;
		case 204:
			result = "Set Normal Response Mode Extended";
			break;
		case 224:
			result = "Test";
			break;
		case 4:
			result = "Set Initialization Mode";
			break;
		case 132:
			result = "Frame reject";
			break;
		case 196:
			result = "Configure";
			break;
		case 12:
			result = "Set Asynchronous Response Mode";
			break;
		case 44:
			result = "Set Asynchronous Balanced Mode";
			break;
		case 76:
			result = "Set Asynchronous Response Mode Extended";
			break;
		case 108:
			result = "Set Asynchronous Balanced Mode Extended";
			break;
		case 140:
			result = "Reset";
			break;
		case 172:
			result = "Exchange identification";
			break;
		case 236:
			result = "Beacon";
			break;
		}
		return result;
	}

	public static string GetValueResponseString(ushort u)
	{
		string result = "";
		switch (u)
		{
		case 0:
			result = "Unnumbered Information";
			break;
		case 32:
			result = "Unnumbered Poll";
			break;
		case 64:
			result = "Disconnect";
			break;
		case 96:
			result = "Unnumbered Acknowledge";
			break;
		case 128:
			result = "Set Normal Response Mode";
			break;
		case 204:
			result = "Set Normal Response Mode Extended";
			break;
		case 224:
			result = "Test";
			break;
		case 4:
			result = "Set Initialization Mode";
			break;
		case 132:
			result = "Frame reject";
			break;
		case 196:
			result = "Configure";
			break;
		case 12:
			result = "Set Asynchronous Response Mode";
			break;
		case 44:
			result = "Set Asynchronous Balanced Mode";
			break;
		case 76:
			result = "Set Asynchronous Response Mode Extended";
			break;
		case 108:
			result = "Set Asynchronous Balanced Mode Extended";
			break;
		case 140:
			result = "Reset";
			break;
		case 172:
			result = "Exchange identification";
			break;
		case 236:
			result = "Beacon";
			break;
		}
		return result;
	}

	public static string GetOUIString(uint Value)
	{
		string result = "";
		switch (Value)
		{
		case 12u:
			result = "Cisco";
			break;
		case 248u:
			result = "Cisco IOS 9.0 Compatible";
			break;
		case 32962u:
			result = "Frame Relay or ATM bridged frames";
			break;
		case 41022u:
			result = "ATM Forum";
			break;
		case 57391u:
			result = "DOCSIS Spanning Tree";
			break;
		case 524295u:
			result = "Apple (AppleTalk)";
			break;
		}
		return result;
	}

	public static string GetMaxFrameSizeList(byte b)
	{
		return (new string[8] { "516", "1500", "2052", "4472", "8144", "11407", "17800", "65535" })[b];
	}

	public static string GetStatusList(byte b)
	{
		return (new string[2] { "Add name not in process", "Add name in process" })[b];
	}

	public static string GetTerminationIndicatorList(byte b)
	{
		return (new string[2] { "Normal session end", "Abnormal session end" })[b];
	}

	public static string NbVersionList(byte b)
	{
		return (new string[2] { "2.00 or higher", "1.xx" })[b];
	}

	public static string GetFlagsYesNoList(byte b)
	{
		return (new string[2] { "Yes", "No" })[b];
	}

	public static string GetFlagsAllowedList(byte b)
	{
		return (new string[2] { "Allowed", "Not allowed" })[b];
	}

	public static string GetFlagsSetList(byte b)
	{
		return (new string[2] { "Set", "Not set" })[b];
	}

	public static string GetNameTypeList(byte b)
	{
		return (new string[2] { "Unique name", "Group name" })[b];
	}

	public static string GetCommandList(byte b)
	{
		int num = 0;
		string[] array = new string[256];
		for (num = 0; num < 256; num++)
		{
			array[num] = "Unkbown";
		}
		array[0] = "Add Group Name Query";
		array[1] = "Add Name Query";
		array[2] = "Name In Conflict";
		array[3] = "Status Query";
		array[7] = "Terminate Trace";
		array[8] = "Datagram";
		array[9] = "Broadcast Datagram";
		array[10] = "Name Query";
		array[13] = "Add Name Response";
		array[14] = "Name Recognized";
		array[15] = "Status Response";
		array[19] = "Terminate Trace";
		array[20] = "Data Ack";
		array[21] = "Data First Middle";
		array[22] = "Data Only Last";
		array[23] = "Session Confirm";
		array[24] = "Session End";
		array[25] = "Session Initialize";
		array[26] = "No Receive";
		array[27] = "Receive Outstanding";
		array[28] = "Receive Continue";
		array[31] = "Session Alive";
		return array[b];
	}

	public static string GetNbNameTypeList(byte b)
	{
		string[] array = new string[256];
		int num = 0;
		for (num = 0; num < 256; num++)
		{
			array[num] = "Unknown";
		}
		array[0] = "Workstation/Redirector";
		array[1] = "Browser";
		array[2] = "Workstation/Redirector";
		array[3] = "Messenger service/Main name";
		array[5] = "Forwarded name";
		array[6] = "RAS Server service";
		array[27] = "Domain Master Browser";
		array[28] = "Domain Controllers";
		array[29] = "Local Master Browser";
		array[30] = "Browser Election Service";
		array[31] = "Net DDE Service";
		array[32] = "Server service";
		array[33] = "RAS client service";
		array[34] = "Exchange Interchange (MSMail Connector)";
		array[35] = "Exchange Store";
		array[36] = "Exchange Directory";
		array[43] = "Lotus Notes Server service";
		array[48] = "Modem sharing server service";
		array[49] = "Modem sharing client service";
		array[67] = "SMS Clients Remote Control";
		array[68] = "SMS Administrators Remote Control Tool";
		array[69] = "SMS Clients Remote Chat";
		array[70] = "SMS Clients Remote Transfer";
		array[76] = "DEC Pathworks TCP/IP Service on Windows NT";
		array[82] = "DEC Pathworks TCP/IP Service on Windows NT";
		array[106] = "Microsoft Exchange IMC";
		array[135] = "Microsoft Exchange MTA";
		array[190] = "Network Monitor Agent";
		array[191] = "Network Monitor Analyzer";
		return array[b];
	}

	public static string GetSmbCommandString(byte b)
	{
		string[] array = new string[256];
		int num = 0;
		for (num = 0; num < 256; num++)
		{
			array[num] = "Unknown-" + num.ToString("x02");
		}
		array[0] = "Create Directory";
		array[1] = "Delete Directory";
		array[2] = "Open";
		array[3] = "Create";
		array[4] = "Close";
		array[5] = "Flush";
		array[6] = "Delete";
		array[7] = "Rename";
		array[8] = "Query Information";
		array[9] = "Set Information";
		array[10] = "Read";
		array[11] = "Write";
		array[12] = "Lock Byte Range";
		array[13] = "Unlock Byte Range";
		array[14] = "Create Temp";
		array[15] = "Create New";
		array[16] = "Check Directory";
		array[17] = "Process Exit";
		array[18] = "Seek";
		array[19] = "Lock And Read";
		array[20] = "Write And Unlock";
		array[26] = "Read Raw";
		array[27] = "Read MPX";
		array[28] = "Read MPX Secondary";
		array[29] = "Write Raw";
		array[30] = "Write MPX";
		array[31] = "Write MPX Secondary";
		array[32] = "Write Complete";
		array[34] = "Set Information2";
		array[35] = "Query Information2";
		array[36] = "Locking AndX";
		array[37] = "Transaction";
		array[38] = "Transaction Secondary";
		array[39] = "IOCTL";
		array[40] = "IOCTL Secondary";
		array[41] = "Copy";
		array[42] = "Move";
		array[43] = "Echo";
		array[44] = "Write And Close";
		array[45] = "Open AndX";
		array[46] = "Read AndX";
		array[47] = "Write AndX";
		array[49] = "Close And Tree Disconnect";
		array[50] = "Transaction2";
		array[51] = "Transaction2 Secondary";
		array[52] = "Find Close2";
		array[53] = "Find Notify Close";
		array[112] = "Tree Connect";
		array[113] = "Tree Disconnect";
		array[114] = "Negotiate Protocol";
		array[115] = "Session Setup AndX";
		array[116] = "Logoff AndX";
		array[117] = "Tree Connect AndX";
		array[128] = "Query Information Disk";
		array[129] = "Search";
		array[130] = "Find";
		array[131] = "Find Unique";
		array[132] = "Find Close";
		array[160] = "NT Transact";
		array[161] = "NT Transact Secondary";
		array[162] = "NT Create AndX";
		array[164] = "NT Cancel";
		array[165] = "NT Rename";
		array[192] = "Open Print File";
		array[193] = "Write Print File";
		array[194] = "Close Print File";
		array[195] = "Get Print Queue";
		array[208] = "Send Single Block Message";
		array[209] = "Send Broadcast Message";
		array[210] = "Forward User Name";
		array[211] = "Cancel Forward";
		array[212] = "Get Machine Name";
		array[213] = "Send Start of Multi-block Message";
		array[214] = "Send End of Multi-block Message";
		array[215] = "Send Text of Multi-block Message";
		array[216] = "SMBreadbulk";
		array[217] = "SMBwritebulk";
		array[218] = "SMBwritebulkdata";
		array[254] = "SMBinvalid";
		return array[b];
	}

	public static string GetSmbBufferFormatString(byte b)
	{
		string[] array = new string[6] { "Unknown", "Data Block", "Dialect", "Pathname", "ASCII", "Variable Block" };
		if (b > 5)
		{
			return "Unknown";
		}
		return array[b];
	}

	public static string GetSmbDaAccessString(byte b)
	{
		string[] array = new string[4] { "Open for reading", "Open for writing", "Open for reading and writing", "Open for execute" };
		if (b > 3)
		{
			return "Unknown";
		}
		return array[b];
	}

	public static string GetSmbDaSharingString(byte b)
	{
		string[] array = new string[5] { "Compatibility mode", "Deny read/write/execute (exclusive)", "Deny write", "Deny read/execute", "Deny none" };
		if (b > 4)
		{
			return "Unknown";
		}
		return array[b];
	}

	public static string GetSmbDaLocalityString(byte b)
	{
		string[] array = new string[4] { "Locality of reference unknown", "Mainly sequential access", "Mainly random access", "Random access with some locality" };
		if (b > 3)
		{
			return "Unknown";
		}
		return array[b];
	}

	public static string GetSmbNtCommandString(byte b)
	{
		string[] array = new string[9] { null, "NT CREATE", "NT IOCTL", "NT SET SECURITY DESC", "NT NOTIFY", "NT RENAME", "NT QUERY SECURITY DESC", "NT GET USER QUOTA", "NT SET USER QUOTA" };
		if (b > 8)
		{
			return "Unknown";
		}
		return array[b];
	}

	public static string GetSmbNtIoctlString(byte b)
	{
		string[] array = new string[2] { "Device IOCTL", "FS control : FSCTL" };
		if (b > 1)
		{
			return "Unknown";
		}
		return array[b];
	}

	public static string GetSmbNtNotifyActionString(byte b)
	{
		string[] array = new string[9] { null, "ADDED (object was added", "REMOVED (object was removed)", "MODIFIED (object was modified)", "RENAMED_OLD_NAME (this is the old name of object)", "RENAMED_NEW_NAME (this is the new name of object)", "ADDED_STREAM (a stream was added)", "REMOVED_STREAM (a stream was removed)", "MODIFIED_STREAM (a stream was modified)" };
		if (b == 0 || b > 9)
		{
			return "Unknown";
		}
		return array[b];
	}

	public static string GetSmbWatchTreeString(byte b)
	{
		string[] array = new string[3] { null, "Current directory only", "Subdirectories also" };
		if (b == 0 || b > 2)
		{
			return "Unknown";
		}
		return array[b];
	}

	public static string GetSmbCreateDispositionString(byte b)
	{
		string[] array = new string[6] { "Supersede (supersede existing file (if it exists))", "Open (if file exists open it, else fail)", "Create (if file exists fail, else create it)", "Open If (if file exists open it, else create it)", "Overwrite (if file exists overwrite, else fail)", "Overwrite If (if file exists overwrite, else create it)" };
		if (b > 5)
		{
			return "Unknown";
		}
		return array[b];
	}

	public static string GetSmbImpersonationLevelString(byte b)
	{
		string[] array = new string[4] { "Anonymous", "Identification", "Impersonation", "Delegation" };
		if (b > 3)
		{
			return "Unknown";
		}
		return array[b];
	}

	public static string GetSmbOplockLevelString(byte b)
	{
		string[] array = new string[4] { "No oplock granted", "Exclusive oplock granted", "Batch oplock granted", "Level II oplock granted" };
		if (b > 3)
		{
			return "Unknown";
		}
		return array[b];
	}

	public static string GetSmbDeviceTypeString(uint b)
	{
		string[] array = new string[45]
		{
			null, "Beep", "CDROM", "CDROM Filesystem", "Controller", "Datalink", "Dfs", "Disk", "Disk Filesystem", "Filesystem",
			"Inport Port", "Keyboard", "Mailslot", "MIDI-In", "MIDI-Out", "Mouse", "Multi UNC Provider", "Named Pipe", "Network", "Network Browser",
			"Network Filesystem", "NULL", "Parallel Port", "Physical card", "Printer", "Scanner", "Serial Mouse port", "Serial port", "Screen", "Sound",
			"Streams", "Tape", "Tape Filesystem", "Transport", "Unknown", "Video", "Virtual Disk", "WAVE-In", "WAVE-Out", "8042 Port",
			"Network Redirector", "Battery", "Bus Extender", "Modem", "VDM"
		};
		if (b > 44)
		{
			return "Unknown";
		}
		return array[b];
	}

	public static string GetSmbPrintModeString(byte b)
	{
		string[] array = new string[2] { "Text Mode", "Graphics Mode" };
		if (b > 1)
		{
			return "Unknown";
		}
		return array[b];
	}

	public static string GetSmbPrintStatusString(byte b)
	{
		string[] array = new string[7] { null, "Held or Stopped", "Printing", "Awaiting print", "In intercept", "File had error", "Printer error" };
		if (b == 0 || b > 6)
		{
			return "Unknown";
		}
		return array[b];
	}

	public static string GetSmbTrans2CommandString(ushort b)
	{
		string[] array = new string[18]
		{
			"OPEN2", "FIND_FIRST2", "FIND_NEXT2", "QUERY_FS_INFORMATION", "SET_FS_QUOTA", "QUERY_PATH_INFORMATION", "SET_PATH_INFORMATION", "QUERY_FILE_INFORMATION", "SET_FILE_INFORMATION", "FSCTL",
			"IOCTL2", "FIND_NOTIFY_FIRST", "FIND_NOTIFY_NEXT", "CREATE_DIRECTORY", "SESSION_SETUP", null, "GET_DFS_REFERRAL", "REPORT_DFS_INCONSISTENCY"
		};
		if (b > 17)
		{
			return "Unknown";
		}
		return array[b];
	}

	public static string GetSmbFf2IlString(ushort b)
	{
		string text = "";
		return b switch
		{
			1 => "Info Standard  (4.3.4.1)", 
			2 => "Info Query EA Size  (4.3.4.2)", 
			3 => "Info Query EAs From List  (4.3.4.2)", 
			257 => "Find File Directory Info  (4.3.4.4)", 
			258 => "Find File Full Directory Info  (4.3.4.5)", 
			259 => "Find File Names Info  (4.3.4.7)", 
			260 => "Find File Both Directory Info  (4.3.4.6)", 
			514 => "Find File UNIX  (4.3.4.8)", 
			_ => "Unknown", 
		};
	}

	public static string GetSmbQpiLoiString(ushort b)
	{
		string[] array = new string[1038];
		array[1] = "Info Standard  (4.2.14.1)";
		array[2] = "Info Query EA Size  (4.2.14.1)";
		array[3] = "Info Query EAs From List  (4.2.14.2)";
		array[4] = "Info Query All EAs  (4.2.14.2)";
		array[6] = "Info Is Name Valid  (4.2.14.3)";
		array[257] = "Query File Basic Info  (4.2.14.4)";
		array[258] = "Query File Standard Info  (4.2.14.5)";
		array[259] = "Query File EA Info  (4.2.14.6)";
		array[260] = "Query File Name Info  (4.2.14.7)";
		array[263] = "Query File All Info  (4.2.14.8)";
		array[264] = "Query File Alt Name Info  (4.2.14.7)";
		array[265] = "Query File Stream Info  (4.2.14.10)";
		array[267] = "Query File Compression Info  (4.2.14.11)";
		array[512] = "Set File Unix Basic";
		array[513] = "Set File Unix Link";
		array[514] = "Set File Unix HardLink";
		array[1004] = "Query File Basic Info  (4.2.14.4)";
		array[1005] = "Query File Standard Info  (4.2.14.5)";
		array[1006] = "Query File Internal Info  (4.2.14.?)";
		array[1007] = "Query File EA Info  (4.2.14.6)";
		array[1009] = "Query File Name Info  (4.2.14.7)";
		array[1010] = "Query File Rename Info  (4.2.14.?)";
		array[1011] = "Query File Link Info  (4.2.14.?)";
		array[1012] = "Query File Names Info  (4.2.14.?)";
		array[1013] = "Query File Disposition Info  (4.2.14.?)";
		array[1014] = "Query File Position Info  (4.2.14.?)";
		array[1015] = "Query File Full EA Info  (4.2.14.?)";
		array[1016] = "Query File Mode Info  (4.2.14.?)";
		array[1017] = "Query File Alignment Info  (4.2.14.?)";
		array[1018] = "Query File All Info  (4.2.14.8)";
		array[1019] = "Query File Allocation Info  (4.2.14.?)";
		array[1020] = "Query File End of File Info  (4.2.14.?)";
		array[1021] = "Query File Alt Name Info  (4.2.14.7)";
		array[1022] = "Query File Stream Info  (4.2.14.10)";
		array[1023] = "Query File Pipe Info  (4.2.14.?)";
		array[1024] = "Query File Pipe Local Info  (4.2.14.?)";
		array[1025] = "Query File Pipe Remote Info  (4.2.14.?)";
		array[1026] = "Query File Mailslot Query Info  (4.2.14.?)";
		array[1027] = "Query File Mailslot Set Info  (4.2.14.?)";
		array[1028] = "Query File Compression Info  (4.2.14.11)";
		array[1029] = "Query File ObjectID Info  (4.2.14.?)";
		array[1030] = "Query File Completion Info  (4.2.14.?)";
		array[1031] = "Query File Move Cluster Info  (4.2.14.?)";
		array[1032] = "Query File Quota Info  (4.2.14.?)";
		array[1033] = "Query File Reparsepoint Info  (4.2.14.?)";
		array[1034] = "Query File Network Open Info  (4.2.14.?)";
		array[1035] = "Query File Attribute Tag Info  (4.2.14.?)";
		array[1036] = "Query File Tracking Info  (4.2.14.?)";
		array[1037] = "Query File Maximum Info  (4.2.14.?)";
		if (b == 0 || b > 1037)
		{
			return "Unknown";
		}
		return array[b];
	}

	public static string GetSmbQfsiString(ushort b)
	{
		string text = "";
		return b switch
		{
			1 => "Info Allocation", 
			2 => "Info Volume", 
			257 => "Query FS Label Info", 
			258 => "Query FS Volume Info", 
			259 => "Query FS Size Info", 
			260 => "Query FS Device Info", 
			261 => "Query FS Attribute Info", 
			769 => "Mac Query FS INFO", 
			1001 => "Query FS Label Info", 
			1002 => "Query FS Volume Info", 
			1003 => "Query FS Size Info", 
			1004 => "Query FS Device Info", 
			1005 => "Query FS Attribute Info", 
			1006 => "Query FS Quota Info", 
			1007 => "Query Full FS Size Info", 
			_ => "Unknown", 
		};
	}

	public static string GetSmbNtRenameString(ushort b)
	{
		string text = "";
		ushort num = b;
		if (num == 259)
		{
			return "Create Hard Link";
		}
		return "Unknown";
	}

	public static string GetSmbAlignmentString(ushort b)
	{
		string text = "";
		return b switch
		{
			0 => "Byte alignment", 
			1 => "Word (16bit) alignment", 
			3 => "Long (32bit) alignment", 
			7 => "8 byte boundary alignment", 
			15 => "16 byte boundary alignment", 
			31 => "32 byte boundary alignment", 
			63 => "64 byte boundary alignment", 
			127 => "128 byte boundary alignment", 
			255 => "256 byte boundary alignment", 
			511 => "512 byte boundary alignment", 
			_ => "Unknown", 
		};
	}

	public static string GetSmbDfsReferralServerTypeString(ushort b)
	{
		string text = "";
		return b switch
		{
			0 => "Don't know", 
			1 => "SMB Server", 
			2 => "Netware Server", 
			3 => "Domain Server", 
			_ => "Unknown", 
		};
	}

	public static string GetTftpOpCodeString(ushort b)
	{
		string text = "";
		return b switch
		{
			1 => "Read Request", 
			2 => "Write Request", 
			3 => "Data Packet", 
			4 => "Acknowledgement", 
			5 => "Error Code", 
			6 => "Option Acknowledgement", 
			_ => "Unknown", 
		};
	}

	public static string GetTftpErrorCodeString(byte b)
	{
		string text = "";
		return b switch
		{
			0 => "Not defined", 
			1 => "File not found", 
			2 => "Access violation", 
			3 => "Disk full or allocation exceeded", 
			4 => "Illegal TFTP Operation", 
			5 => "Unknown transfer ID", 
			6 => "File already exists", 
			7 => "No such user", 
			8 => "Option negotiation failed", 
			_ => "Unknown", 
		};
	}

	public static string GetAarpOptionString(ushort b)
	{
		string text = "";
		return b switch
		{
			1 => "request", 
			2 => "reply", 
			3 => "probe", 
			256 => "request", 
			512 => "reply", 
			768 => "probe", 
			_ => "Unknown", 
		};
	}

	public static string GetAarpHardwareString(ushort b)
	{
		string text = "";
		return b switch
		{
			1 => "Ethernet", 
			2 => "Token Ring", 
			_ => "Unknown", 
		};
	}

	public static bool AARP_HW_IS_ETHER(ushort ar_hrd, byte ar_hln)
	{
		if (ar_hrd == 1 || (ar_hrd == 2 && ar_hln == 6))
		{
			return true;
		}
		return false;
	}

	public static bool AARP_PRO_IS_ATALK(ushort ar_pro, byte ar_pln)
	{
		if (ar_pro == 32923 && ar_pln == 4)
		{
			return true;
		}
		return false;
	}

	public static string GetAarpHardwareAddress(byte[] PacketData, ref int Index, byte Len, ushort Type)
	{
		int num = 0;
		string text = "";
		if (AARP_HW_IS_ETHER(Type, Len))
		{
			return Function.GetMACAddress(PacketData, ref Index);
		}
		for (num = 0; num < Len; num++)
		{
			text += (char)PacketData[Index++];
		}
		return text;
	}

	public static string GetAarpIpAddress(byte[] PacketData, ref int Index, byte Len, ushort Type)
	{
		int num = 0;
		string text = "";
		if (AARP_PRO_IS_ATALK(Type, Len))
		{
			return Function.GetMACAddress(PacketData, ref Index);
		}
		for (num = 0; num < Len; num++)
		{
			text += (char)PacketData[Index++];
		}
		return text;
	}

	public static string GetDlswTypeString(byte b)
	{
		string[] array = new string[256];
		int num = 0;
		for (num = 0; num < 256; num++)
		{
			array[num] = "Unknown";
		}
		array[3] = "Can U Reach Station-circuit start";
		array[4] = "I Can Reach Station-circuit start";
		array[5] = "Reach Acknowledgment";
		array[6] = "Datagram Frame";
		array[7] = "XID Frame";
		array[8] = "Contact Remote Station";
		array[9] = "Remote Station Contacted";
		array[16] = "Restart Data Link";
		array[17] = "Data Link Restarted";
		array[12] = "Enter Busy";
		array[13] = "Exit Busy";
		array[10] = "Information (I) Frame";
		array[14] = "Halt Data Link";
		array[15] = "Data Link Halted";
		array[18] = "NETBIOS Name Query-circuit setup";
		array[19] = "NETBIOS Name Recog-circuit setup";
		array[20] = "Data Frame";
		array[25] = "Halt Data Link with no Ack";
		array[26] = "NETBIOS Add Name Query";
		array[27] = "NETBIOS Add Name Response";
		array[29] = "Transport Keepalive Message";
		array[32] = "Capabilities Exchange";
		array[33] = "Independent Flow Control Message";
		array[122] = "Test Circuit Request";
		array[123] = "Test Circuit Response";
		return array[b];
	}

	public static string GetDlswVersionString(byte b)
	{
		string text = "";
		return b switch
		{
			49 => "Version 1 (RFC 1795)", 
			50 => "Version 2 (RFC 2166)", 
			51 => "Vendor Specific", 
			52 => "Vendor Specific", 
			53 => "Vendor Specific", 
			54 => "Vendor Specific", 
			55 => "Vendor Specific", 
			56 => "Vendor Specific", 
			57 => "Vendor Specific", 
			58 => "Vendor Specific", 
			59 => "Vendor Specific", 
			60 => "Vendor Specific", 
			61 => "Vendor Specific", 
			62 => "Vendor Specific", 
			63 => "Vendor Specific", 
			75 => "Pre 1 (RFC 1434)", 
			_ => "Unknown", 
		};
	}

	public static string GetDlswVectorString(byte b)
	{
		string text = "";
		return b switch
		{
			129 => "Vendor ID Control Vector", 
			130 => "DLSw Version Control Vector", 
			131 => "Initial Pacing Window Control Vector", 
			132 => "Version String Control Vector", 
			133 => "Mac Address Exclusivity Control Vector", 
			134 => "Supported SAP List Control Vector", 
			135 => "TCP Connections Control Vector", 
			136 => "NetBIOS Name Exclusivity Control Vector", 
			137 => "MAC Address List Control Vector", 
			138 => "NetBIOS Name List Control Vector", 
			139 => "Vendor Context Control Vector", 
			140 => "Multicast Capabilities Control Vector", 
			141 => "Reserved for future use", 
			142 => "Reserved for future use", 
			143 => "Reserved for future use", 
			144 => "Reserved for future use", 
			145 => " Control Vector", 
			146 => " Control Vector", 
			147 => " Control Vector", 
			148 => " Control Vector", 
			149 => " Control Vector", 
			150 => " Control Vector", 
			_ => "Unknown", 
		};
	}

	public static string GetDlswPriorityString(byte b)
	{
		string text = "";
		return b switch
		{
			0 => "Unsupported", 
			1 => "Low Priority", 
			2 => "Medium Priority", 
			3 => "High Priority", 
			4 => "Highest Priority", 
			5 => "Reserved", 
			6 => "Reserved", 
			7 => "Reserved", 
			_ => "Unknown", 
		};
	}

	public static string GetDlswGdSidString(ushort b)
	{
		string text = "";
		return b switch
		{
			5408 => "Request Capabilities GDS", 
			5409 => "Response Capabilities GDS", 
			5410 => "Refuse Capabilities GDS", 
			_ => "Unknown", 
		};
	}

	public static string GetDlswRefuseString(byte b)
	{
		string text = "";
		return b switch
		{
			1 => "invalid GDS length for a DLWs Capabilities Exchange Request", 
			2 => "invalid GDS id for a DLSw Capabilities Exchange Request", 
			3 => "vendor Id control vector is missing", 
			4 => "DLSw Version control vector is missing", 
			5 => "initial Pacing Window control vector is missing", 
			6 => "length of control vectors doewn't correlate to the length of the GDS variable", 
			7 => "invalid control vector id", 
			8 => "length of control vector invalid", 
			9 => "invalid control vector data value", 
			10 => "duplicate control vector", 
			11 => "out-of-sequence control vector", 
			12 => "DLSw Supported SAP List control vector is missing", 
			13 => "inconsistent DLSw Version, Multicast Capabilities,and TCP Connections CV received on the inbound Capabilities exchange", 
			_ => "Unknown", 
		};
	}
}
