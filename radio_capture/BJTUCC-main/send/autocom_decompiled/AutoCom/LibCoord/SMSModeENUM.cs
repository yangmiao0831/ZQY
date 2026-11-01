using LibUtils;

namespace LibCoord;

public enum SMSModeENUM
{
	[MyDescription("仅发送", "Send Only")]
	SendOnly,
	[MyDescription("仅接收", "Receive Only")]
	ReceiveOnly,
	[MyDescription("自发自收", "Send and Receive")]
	SendandReceive
}
