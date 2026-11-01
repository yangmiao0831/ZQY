using LibUtils;

namespace Spark.Utils;

public enum ReasonCode
{
	[MyDescription("成功", "success")]
	Result0 = 0,
	[MyDescription("失败", "fail")]
	Result1 = -1,
	[MyDescription("传入句柄为空", "handle is empty")]
	Result2 = -2,
	[MyDescription("衰减器连接失败", "connect fail")]
	Result3 = -3,
	[MyDescription("发送/接收超时", "send/receive timeout")]
	Result4 = -4,
	[MyDescription("发送失败", "send fail")]
	Result5 = -5,
	[MyDescription("接收失败", "receive fail")]
	Result6 = -6,
	[MyDescription("响应失败", "response fail")]
	Result7 = -7,
	[MyDescription("入参超出范围", "parameter out of range")]
	Result8 = -8,
	[MyDescription("读取配置文件失败,Config.ini文件是否与dll同目录.", "")]
	Result9 = -9,
	[MyDescription("不存在小区组,检查入参信息小区ID/UE ID/网络类型.", "")]
	Result10 = -10,
	[MyDescription("通讯异常", "Communication error")]
	Result11 = -11,
	[MyDescription("Socket创建失败", "create socket fail")]
	Result12 = -12
}
