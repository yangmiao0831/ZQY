using System;
using System.IO;
using System.Runtime.CompilerServices;
using wDVvxYYcyxdvVsBwKm;

namespace LibUtils;

[Serializable]
public class ATUUploadFileInfo
{
	public string FullFileName;

	public string FileName;

	public long UploadFileTotalSize;

	public long UploadFileCurSize;

	public int ProtocolType;

	public int Status;

	public long Progress;

	public bool IsTestingLog;

	public bool IsTempLog;

	public int MSIndex;

	public bool HasUploadInfo;

	public long UploadEventFileCurSize;

	public uint PackDataIndex;

	public bool RecvUploadFileEof;

	public string StartTestKey;

	[NonSerialized]
	public LogfileUtils Logfile;

	[NonSerialized]
	public bool Started;

	[NonSerialized]
	public byte[] TriDESBytes;

	[NonSerialized]
	public uint FileID;

	[NonSerialized]
	public byte[] DTLogDataBuff;

	[NonSerialized]
	public byte[] SendDataBuff;

	[NonSerialized]
	public int DTLogDataBuffSize;

	[NonSerialized]
	public int DTLogDataBuffLastEnterIdx;

	[NonSerialized]
	public long ServerFileSize;

	[NonSerialized]
	public bool UploadInterupt;

	[NonSerialized]
	public int UploadInteruptTick;

	[NonSerialized]
	public bool RecvUploadOK;

	[NonSerialized]
	public int RecvUploadNACCode;

	[NonSerialized]
	public int UploadStep;

	[NonSerialized]
	public FileStream DebugLogFS;

	[NonSerialized]
	public bool NeedUploadFromFirstPack;

	[NonSerialized]
	public int OperatorCheckTimes;

	[NonSerialized]
	public int UploadFailTimes;

	[NonSerialized]
	public string KeyInfo;

	internal static ATUUploadFileInfo HN2niXlbS7CoPTSUhV;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ATUUploadFileInfo()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ATUUploadFileInfo()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0017:
				switch (num2)
				{
				case 3:
					return;
				case 2:
					iFiL0osvtiqyHZ2YEu();
					num2 = 3;
					goto IL_0017;
				case 1:
					GUZrBV876Ej70KZybU();
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					goto IL_0017;
				}
				cbbQEDwPwMVp6a6hrk();
				num2 = 2;
			}
			while (0 == 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cbbQEDwPwMVp6a6hrk()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void X04eaJe7hyjt0j0n1I()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool j9Lq3mVTB4xJ3ZlK98()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ATUUploadFileInfo iuP6T6XpDOSKuYCmsW()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GUZrBV876Ej70KZybU()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iFiL0osvtiqyHZ2YEu()
	{
	}
}
