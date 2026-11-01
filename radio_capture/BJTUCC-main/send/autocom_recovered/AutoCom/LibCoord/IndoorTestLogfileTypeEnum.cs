using LibUtils;

namespace LibCoord;

public enum IndoorTestLogfileTypeEnum
{
	[MyDescription("新测", "New test")]
	New,
	[MyDescription("重测", "Retest")]
	Retest,
	[MyDescription("补测", "Supplementary test")]
	Supplementary
}
