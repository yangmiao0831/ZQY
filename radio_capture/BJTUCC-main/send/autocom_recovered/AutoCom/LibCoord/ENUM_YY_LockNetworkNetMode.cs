using LibUtils;

namespace LibCoord;

public enum ENUM_YY_LockNetworkNetMode
{
	[MyDescription("eMTC", "eMTC")]
	eMTC,
	[MyDescription("NB-IoT", "NB-IoT")]
	NB,
	[MyDescription("eMTC和NB-IoT", "eMTC and NB-IoT")]
	Both
}
