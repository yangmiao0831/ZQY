using LibUtils;

namespace LibCoord;

public enum EmailModeENUM
{
	[MyDescription("仅发件", "Send Only")]
	SendOnly,
	[MyDescription("仅接件", "Receive Only")]
	ReceiveOnly,
	[MyDescription("自发自收", "Send and Receive")]
	SendandReceive
}
