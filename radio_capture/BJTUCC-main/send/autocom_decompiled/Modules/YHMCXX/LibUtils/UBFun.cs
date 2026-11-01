using Newtonsoft.Json;

namespace LibUtils;

public class UBFun
{
	public static T JsonToSerialize<T>(string json)
	{
		try
		{
			return JsonConvert.DeserializeObject<T>(json);
		}
		catch
		{
			return default(T);
		}
	}

	public static string SerializeToJson(object obj)
	{
		return JsonConvert.SerializeObject(obj);
	}
}
