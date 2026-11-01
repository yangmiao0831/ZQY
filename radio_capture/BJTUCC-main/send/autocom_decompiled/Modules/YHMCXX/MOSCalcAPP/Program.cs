using System;

namespace MOSCalcAPP;

internal static class Program
{
	[STAThread]
	private static void Main(string[] args)
	{
		if (args != null && args.Length != 0)
		{
			MainWin.CalcMOS(args[0]);
		}
	}
}
