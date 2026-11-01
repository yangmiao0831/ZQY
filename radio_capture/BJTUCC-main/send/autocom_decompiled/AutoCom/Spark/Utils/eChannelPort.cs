using LibUtils;

namespace Spark.Utils;

public enum eChannelPort
{
	ChannelPort_None,
	[MyDescription("ANT0", "ANT0")]
	ChannelPort_NR_M,
	[MyDescription("ANT1", "ANT1")]
	ChannelPort_NR_M1,
	[MyDescription("ANT2", "ANT2")]
	ChannelPort_NR_M2,
	[MyDescription("ANT3", "ANT3")]
	ChannelPort_NR_DG,
	[MyDescription("ANT0", "ANT0")]
	ChannelPort_LTE_M,
	[MyDescription("ANT3", "ANT3")]
	ChannelPort_LTE_DG
}
