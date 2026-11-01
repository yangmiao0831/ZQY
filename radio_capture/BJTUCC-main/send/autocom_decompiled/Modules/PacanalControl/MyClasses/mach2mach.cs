using System.Collections;

namespace MyClasses;

public class mach2mach
{
	private static Hashtable counters = new Hashtable();

	private static Hashtable ips = new Hashtable();

	public static Hashtable Stats => counters;

	public static string GetSourceIP(string key)
	{
		string source = GetSource(key);
		string text = source;
		try
		{
			if (ips.ContainsKey(key))
			{
				text = (string)ips[source];
			}
		}
		catch
		{
		}
		if (text == null)
		{
			text = source;
		}
		return text;
	}

	public static string GetDestinationIP(string key)
	{
		string destination = GetDestination(key);
		string text = destination;
		try
		{
			text = (string)ips[destination];
		}
		catch
		{
		}
		if (text == null)
		{
			text = destination;
		}
		return text;
	}

	public static string GetSource(string key)
	{
		return key.Substring(0, key.IndexOf("|"));
	}

	public static void Clear()
	{
		counters.Clear();
	}

	public static string GetDestination(string key)
	{
		return key.Substring(key.IndexOf("|") + 1);
	}

	private static string MakeKey(string s1, string s2)
	{
		return s1 + "|" + s2;
	}

	public static void Add(string mac, string ip)
	{
		if (!ips.Contains(mac))
		{
			ips.Add(mac, ip);
		}
	}

	public static void Add(string source, string dest, long size)
	{
		long num = 0L;
		string key = MakeKey(source, dest);
		try
		{
			if (counters.ContainsKey(key))
			{
				num = (long)counters[key];
			}
			else
			{
				counters.Add(key, num);
			}
		}
		catch
		{
		}
		num += size;
		counters[key] = num;
	}
}
