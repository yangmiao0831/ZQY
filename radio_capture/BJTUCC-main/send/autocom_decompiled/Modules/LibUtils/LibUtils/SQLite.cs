using System.Data.SQLite;
using System.Runtime.CompilerServices;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public class SQLite
{
	public static string MyIEResDB;

	public static string TmpMyIEResDB;

	public static string IEResDB;

	public static string EQResDB;

	public static string HighSpeedRailResDB;

	public static string HighSpeedRailResDBUEM;

	protected SQLiteConnection Connection;

	protected SQLiteCommand Command;

	protected SQLiteDataReader reader;

	protected SQLiteTransaction Trans;

	internal static SQLite Vhiu1VaBstIBVYQENrS;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SQLite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool OpenDB(string DBName)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool OpenDBWithPass(string DBName)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BeginTransaction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Commit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CloseDB()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool RunSQL(string sql)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool RunSQLFinish()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ReadNext()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int ReadIntValue(int FieldIdx)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public long ReadInt64Value(int FieldIdx)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public double ReadDoubleValue(int FieldIdx)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ReadBoolValue(int FieldIdx)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ReadStringValue(int FieldIdx)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SQLite()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 10;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					VOMIdZaF6FH11MXbFL6();
					num = 9;
					break;
				case 2:
					HighSpeedRailResDBUEM = ls0JmaLsLk7suNXwaC.QnSQxwQdI(ConstUtils.ResPath, (string)nnAdQPa35BQUttZyGcs(20748), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 0;
					if (true)
					{
						num2 = 7;
					}
					continue;
				case 1:
					TmpMyIEResDB = ls0JmaLsLk7suNXwaC.QnSQxwQdI(ConstUtils.ResTempPath, (string)nnAdQPa35BQUttZyGcs(20620), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 5;
					continue;
				case 4:
					MyIEResDB = ls0JmaLsLk7suNXwaC.QnSQxwQdI(ConstUtils.SparkAppDataPath, (string)nnAdQPa35BQUttZyGcs(20620), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 1;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 3:
					wwP1nPaICZ9AeqQ4QOs();
					num2 = 0;
					if (true)
					{
						num2 = 0;
					}
					continue;
				case 8:
					HighSpeedRailResDB = ls0JmaLsLk7suNXwaC.QnSQxwQdI(ConstUtils.ResPath, (string)nnAdQPa35BQUttZyGcs(20716), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 2;
					if (false)
					{
						num2 = 0;
					}
					continue;
				case 9:
					b99vLwQv4vNmPibnHM.nIIRTpIJS2();
					num2 = 3;
					if (1 == 0)
					{
						num2 = 3;
					}
					continue;
				case 7:
					return;
				default:
					rfHY3Aax584AW1puRSH();
					num = 4;
					break;
				case 5:
					IEResDB = ls0JmaLsLk7suNXwaC.QnSQxwQdI(ConstUtils.ResPath, (string)nnAdQPa35BQUttZyGcs(20656), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 6;
					if (false)
					{
						num2 = 1;
					}
					continue;
				case 6:
					EQResDB = ls0JmaLsLk7suNXwaC.QnSQxwQdI(ConstUtils.ResPath, b99vLwQv4vNmPibnHM.iaWRZZUjVH(20686), ls0JmaLsLk7suNXwaC.pMUht99L8);
					num2 = 1;
					if (0 == 0)
					{
						num2 = 8;
					}
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ROG2X9a7E5OGLs94DVA()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void rfHY3Aax584AW1puRSH()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool Sv1vXGaLnh5mL9JhO9G()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static SQLite nCb6a9aZguCHxXw08eM()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object nnAdQPa35BQUttZyGcs(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VOMIdZaF6FH11MXbFL6()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void wwP1nPaICZ9AeqQ4QOs()
	{
	}
}
