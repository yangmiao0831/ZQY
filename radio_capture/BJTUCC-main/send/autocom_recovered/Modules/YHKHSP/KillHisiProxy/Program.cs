using System;
using System.Diagnostics;
using System.Threading;

namespace KillHisiProxy;

internal static class Program
{
	public static void KillProcess(string processName, bool killMulti = true)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(processName);
			foreach (Process process in processesByName)
			{
				process.Kill();
				if (!killMulti)
				{
					break;
				}
			}
		}
		catch
		{
		}
	}

	[STAThread]
	private static void Main()
	{
		KillProcess("SS_HiAP");
		Thread.Sleep(2000);
		KillProcess("HiAP");
	}
}
