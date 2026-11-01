using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

public static class DataAccessIntf
{
	public const int SQLITE_BLOB = 4;

	public const int SQLITE_DONE = 101;

	public const int SQLITE_FLOAT = 2;

	public const int SQLITE_INTEGER = 1;

	public const int SQLITE_NULL = 5;

	public const int SQLITE_OK = 0;

	public const int SQLITE_ROW = 100;

	public const int SQLITE_TEXT = 3;

	public const string UBDataAccessDll = "AADDCC.dll";

	internal static DataAccessIntf lX5U1IytPbnl54yvH3q;

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC004")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool UBD_SDK_CloseUBFile(IntPtr handle);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC149")]
	public static extern int UBD_SDK_GetFieldInfo(int key, IntPtr tableName, IntPtr fieldName);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "AADDCC002")]
	public static extern IntPtr UBD_SDK_OpenUBFileW(string fileName, int mode);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC132")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool UBD_SDK_SqliteBeginTrans(IntPtr handle);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC129")]
	public static extern int UBD_SDK_SqliteBindDouble(IntPtr handle, IntPtr pStmt, int col, double value);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC127")]
	public static extern int UBD_SDK_SqliteBindInt(IntPtr handle, IntPtr pStmt, int col, int value);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC128")]
	public static extern int UBD_SDK_SqliteBindInt64(IntPtr handle, IntPtr pStmt, int col, long value);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC130")]
	public static extern int UBD_SDK_SqliteBindNull(IntPtr handle, IntPtr pStmt, int col);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC126")]
	public static extern int UBD_SDK_SqliteBindText(IntPtr handle, IntPtr pStmt, int col, byte[] text);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC124")]
	public static extern IntPtr UBD_SDK_SqliteColumnBlob(IntPtr handle, IntPtr stmt, int col);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC125")]
	public static extern int UBD_SDK_SqliteColumnBlobSize(IntPtr handle, IntPtr stmt, int col);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC107")]
	public static extern int UBD_SDK_SqliteColumnCount(IntPtr handle, IntPtr stmt);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC122")]
	public static extern double UBD_SDK_SqliteColumnDouble(IntPtr handle, IntPtr stmt, int col);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC121")]
	public static extern int UBD_SDK_SqliteColumnInt(IntPtr handle, IntPtr stmt, int col);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC120")]
	public static extern long UBD_SDK_SqliteColumnInt64(IntPtr handle, IntPtr stmt, int col);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC108")]
	public static extern IntPtr UBD_SDK_SqliteColumnName(IntPtr handle, IntPtr stmt, int col);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC123")]
	public static extern IntPtr UBD_SDK_SqliteColumnText(IntPtr handle, IntPtr stmt, int col);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC109")]
	public static extern int UBD_SDK_SqliteColumnType(IntPtr handle, IntPtr stmt, int col);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC133")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool UBD_SDK_SqliteCommitTrans(IntPtr handle);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC102")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool UBD_SDK_SqliteExec(IntPtr handle, string sql);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC106")]
	public static extern int UBD_SDK_SqliteFinalize(IntPtr handle, IntPtr stmt);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC103")]
	public static extern IntPtr UBD_SDK_SqlitePrepare(IntPtr handle, IntPtr sql);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC134")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool UBD_SDK_SqliteRollbackTrans(IntPtr handle);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC104")]
	public static extern int UBD_SDK_SqliteStep(IntPtr handle, IntPtr stmt);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC105")]
	public static extern int UBD_SDK_SqliteReset(IntPtr handle, IntPtr stmt);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "AADDCC021")]
	public static extern IntPtr UBD_SDK_OpenBinHandle(IntPtr handle, int binType, int binSize, int valueType, string binFileName);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "AADDCC020")]
	public static extern double UBD_SDK_GetStatistic(IntPtr handle, int paramKey, string condition, string aggType);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "AADDCC137")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool UBD_SDK_AttachUTSW(IntPtr handle, string fileName, string alias);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "AADDCC138")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool UBD_SDK_DetachUTSW(IntPtr handle, string alias);

	[DllImport("AADDCC.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "AADDCC023")]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool UBD_SDK_ConfigFilter(IntPtr handle, bool useFilter, int filterBufferSize, byte[] filterbuffer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	static DataAccessIntf()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 2:
					sY278bypYHjp0oktlrp();
					num2 = 1;
					if (0 == 0)
					{
						continue;
					}
					break;
				default:
					zI3Oy1y4YPQbbiqhNeZ();
					num = 3;
					break;
				case 1:
					b99vLwQv4vNmPibnHM.nIIRTpIJS2();
					num2 = 0;
					if (true)
					{
						continue;
					}
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sY278bypYHjp0oktlrp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zI3Oy1y4YPQbbiqhNeZ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool JUFWjTy67IgY6Zbo3sL()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static DataAccessIntf NPky1oykvqDQBeDEu6q()
	{
		return null;
	}
}
