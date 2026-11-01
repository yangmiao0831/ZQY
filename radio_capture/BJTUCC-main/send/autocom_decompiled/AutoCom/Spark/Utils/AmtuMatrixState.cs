using LibUtils;

namespace Spark.Utils;

public enum AmtuMatrixState
{
	[MyDescription("", "")]
	None,
	[MyDescription("Running", "Running")]
	Running,
	[MyDescription("Pause", "Pause")]
	Pause
}
