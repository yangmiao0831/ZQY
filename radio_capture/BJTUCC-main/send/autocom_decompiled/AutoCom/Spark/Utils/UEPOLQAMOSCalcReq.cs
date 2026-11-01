using System.Runtime.CompilerServices;
using LibCoord;
using LibUtils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace Spark.Utils;

public class UEPOLQAMOSCalcReq
{
	[JsonConverter(typeof(StringEnumConverter))]
	public POLQASWBENUM AlgoMode;

	public string SourceWavFile;

	public string RecordWAVFile;

	[JsonConverter(typeof(StringEnumConverter))]
	public POLQAVerENUM MOSAlgoVersion;

	public int UpdateIndex;

	public int EQIndex;

	[JsonIgnore]
	public Logfile Logfile;

	[JsonIgnore]
	public string RecordWAVFileLocal;

	private static UEPOLQAMOSCalcReq aRbUT9WR4qhFllUEg6GV;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UEPOLQAMOSCalcReq()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static UEPOLQAMOSCalcReq()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		xNOTlSHosQAMkdL3Vlu.wTZEhJwp53d();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GNonkgWRrBHHqIlu7oAo()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UEPOLQAMOSCalcReq Q3O69nWRDEW5D7X5VArF()
	{
		return null;
	}
}
