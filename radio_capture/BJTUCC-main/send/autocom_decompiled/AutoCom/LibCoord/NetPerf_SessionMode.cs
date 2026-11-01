using LibUtils;

namespace LibCoord;

public enum NetPerf_SessionMode
{
	[MyDescription("自定义", "Custom")]
	Custom,
	[MyDescription("文件上传", "TCPULStream")]
	TCPULStream,
	[MyDescription("文件下载", "TCPDLStream")]
	TCPDLStream,
	[MyDescription("仅实时流上传(UDP)", "UDPULStream")]
	UDPULStream,
	[MyDescription("实时流下载(UDP)", "UDPDLStream")]
	UDPDLStream,
	[MyDescription("周期数据上报(UDP)", "UDPULTrigger")]
	UDPULTrigger,
	[MyDescription("远程信息同步(UDP)", "UDPDLTrigger")]
	UDPDLTrigger
}
