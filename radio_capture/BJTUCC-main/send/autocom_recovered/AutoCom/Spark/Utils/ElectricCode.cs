using LibUtils;

namespace Spark.Utils;

public enum ElectricCode
{
	[MyDescription("成功", "success")]
	Result0 = 0,
	[MyDescription("失败", "fail")]
	Result1 = -1,
	[MyDescription("无效端口号", "Invalid port")]
	Result2 = -2,
	[MyDescription("连接失败", "Connection failed")]
	Result3 = -3,
	[MyDescription("未连接", "Not connected")]
	Result4 = -4,
	[MyDescription("参数超出范围", "Parameter out of range")]
	Result5 = -5,
	[MyDescription("入参错误", "Input parameter error")]
	Result6 = -6,
	[MyDescription("端口断开", "Port disconnected")]
	Result7 = -7,
	[MyDescription("设备状态获取失败", "Device status acquisition failed")]
	Result8 = -8,
	[MyDescription("查找UE失败", "Failed to find UE")]
	Result9 = -9
}
