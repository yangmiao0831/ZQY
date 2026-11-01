using LibUtils;

namespace Spark;

public enum AutoTestWarningEnum
{
	[MyDescription("{0}无测量参数输出，请检查数据线连接或手机状态。", "{0} No measurement parameter output, please check the data line connection or mobile phone status.")]
	NoRSRP,
	[MyDescription("GPS没信号。", "GPS no signal.")]
	NoGPS,
	[MyDescription("连接失败。", "Connect Fail.")]
	OnlyConnectEQFail,
	[MyDescription("主被叫语音计划必须同时为互拨或单拨，请修改通话方式后再行开始测试。", "The MOC and MTC plans must be union call or single call at the same time. Please modify the call mode before start test.")]
	MOMTUnionErr
}
