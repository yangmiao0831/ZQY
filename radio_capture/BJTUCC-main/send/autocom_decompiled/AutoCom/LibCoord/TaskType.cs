using System.ComponentModel;
using LibUtils;

namespace LibCoord;

public enum TaskType
{
	[MyDescription("空闲", "Idle")]
	idle = 1,
	[MyDescription("语音", "Call")]
	call = 2,
	[MyDescription("FTP下载", "FTP Download")]
	ftpdl = 4,
	[MyDescription("FTP上传", "FTP Upload")]
	ftpul = 5,
	[Description("Attach")]
	attach = 6,
	[Description("Ping")]
	ping = 7,
	[MyDescription("HTTP网页", "HTTP Page")]
	http = 9,
	[MyDescription("HTTP Video", "HTTP Video")]
	httpvideo = 17,
	[MyDescription("HTTP下载", "HTTP Download")]
	httpdl = 11,
	[MyDescription("HTTP上传", "HTTP Upload")]
	httpul = 12,
	[MyDescription("Multi FTP下载", "Multi FTP Download")]
	mftpdl = 13,
	[MyDescription("Multi FTP上传", "Multi FTP Upload")]
	mftpul = 14,
	[Description("Bandwidth Test")]
	iperf = 8,
	[MyDescription("Speed Test", "Speed Test")]
	speedtest = 15,
	[MyDescription("APM", "APM")]
	apm = 16,
	[MyDescription("Email", "Email")]
	email = 18,
	[MyDescription("SMS", "SMS")]
	sms = 19,
	[MyDescription("开关机", "PowerOn/Off")]
	power = 24,
	[MyDescription("微信消息", "WeChat Message")]
	wechat = 20,
	[MyDescription("微信语音", "WeChat Call")]
	wechatcall = 26,
	[MyDescription("短视频", "Short Video")]
	douyin = 21,
	[MyDescription("视频直播", "LivePlay")]
	liveplay = 28,
	[MyDescription("王者荣耀", "Honor of Kings")]
	honorkings = 22,
	[MyDescription("云游戏", "Cloud Game")]
	cloudgaming = 23,
	[MyDescription("视频监控", "Video Monitor")]
	videomonitor = 25,
	[MyDescription("并发业务", "Parallel")]
	parallel = 200,
	[MyDescription("时延测试", "Delay")]
	delay = 10,
	[MyDescription("测试时段", "Test period")]
	testperiod = 501,
	[MyDescription("信号衰减", "Signal attenuation")]
	attenuator = 500,
	[MyDescription("小区切换控制", "Cell handover control")]
	hocontrol = 502,
	[MyDescription("语音(被叫)", "Call(MTC)")]
	mtc = 3,
	[MyDescription("微信语音(被叫)", "WeChat Call(MTC)")]
	wechatcallmtc = 27,
	[MyDescription("视频直播(观看)", "LivePlay(Watch)")]
	liveplaymtc = 29,
	[MyDescription("应用商店", "App Store")]
	appstore = 32,
	[MyDescription("Trace Route", "Trace Route")]
	traceroute = 33,
	[MyDescription("自定义APP", "Auto APP")]
	autoapp = 35,
	[MyDescription("云盘下载", "Cloud Download")]
	clouddl = 37,
	[MyDescription("云盘上传", "Cloud Upload")]
	cloudul = 38,
	[MyDescription("增强网络性能测试", "Enhanced Network Test")]
	netperf = 39,
	checkupfile = 90001,
	[Description("TopN")]
	topnpctel = 1014,
	[Description("TopN NR5G")]
	topnnr5g = 1009,
	[Description("TopN LTE")]
	topnlte = 1006,
	[Description("TopN NB-IoT")]
	topn = 1000,
	[Description("TopN WCDMA")]
	topnwcdma = 1007,
	[Description("TopN GSM")]
	colorcode = 1008,
	[Description("TopN")]
	topntranscom = 1018,
	[Description("UserList")]
	userlistpctel = 1016,
	[Description("UserList NB-IoT")]
	userlist = 1001,
	[Description("CW")]
	cw = 1002,
	[Description("UserList NR5G")]
	userlistnr5g = 1010,
	[Description("UserList LTE")]
	userlistlte = 1011,
	[Description("PowerAnalysis LTE")]
	poweranalysislte = 1012,
	[Description("Blind")]
	blind = 1013,
	[Description("Blind Cell Search NB-IoT")]
	blindscan = 1004,
	[Description("EPS")]
	epspctel = 1015,
	[Description("CW")]
	cwtranscom = 1019,
	[Description("Spectrum")]
	spectrum = 1003,
	[Description("UserDefine")]
	userdefinepctel = 1017,
	[Description("GPS")]
	gps = 1005,
	[Description("TopN")]
	ERadioTopN = 1020,
	[Description("Spectrum")]
	ERadioSpectrum = 1021,
	[Description("Blind5G")]
	ERadioBlind = 1022,
	[Description("Spectrum")]
	spectrumpctel = 1023,
	[Description("DonaTopN")]
	DonaTopN = 1024
}
