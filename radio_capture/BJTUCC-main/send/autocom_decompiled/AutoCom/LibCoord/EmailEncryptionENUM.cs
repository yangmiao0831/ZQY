using LibUtils;

namespace LibCoord;

public enum EmailEncryptionENUM
{
	[MyDescription("无", "None")]
	None,
	[MyDescription("SSL", "SSL")]
	SSL,
	[MyDescription("TLS", "TLS")]
	TLS
}
