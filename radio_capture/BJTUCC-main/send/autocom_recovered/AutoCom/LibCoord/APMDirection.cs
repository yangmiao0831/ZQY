using LibUtils;

namespace LibCoord;

public enum APMDirection
{
	[MyDescription("上行", "Upload")]
	UL,
	[MyDescription("下行", "Download")]
	DL,
	[MyDescription("双向并行", "Bidirectional")]
	Bidirectional
}
