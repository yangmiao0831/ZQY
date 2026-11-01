using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LibBase;

public class DebugLog
{
	public static object LockLogObj = new object();

	public static int WriteObjTimes = 0;

	public static object LockTxtObj = new object();

	public static void WriteDebugLog(string debugFile, string logContent)
	{
		try
		{
			lock (LockLogObj)
			{
				string path = Application.StartupPath + "\\System\\Cache\\" + debugFile;
				FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
				fileStream.Seek(0L, SeekOrigin.End);
				string s = string.Format("{0}: {1}\r\n", DateTime.Now.ToString("MM-dd HH:mm:ss.fff:"), logContent);
				byte[] bytes = Encoding.Default.GetBytes(s);
				fileStream.Write(bytes, 0, bytes.Length);
				fileStream.Flush();
				fileStream.Close();
			}
		}
		catch
		{
		}
	}

	public static FileStream OpenDebugLogFile(string debugFile)
	{
		try
		{
			string path = Application.StartupPath + "\\" + debugFile;
			FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
			fileStream.Seek(0L, SeekOrigin.End);
			return fileStream;
		}
		catch
		{
			return null;
		}
	}

	public static void CloseDebugLogFile(FileStream fs)
	{
		if (fs == null)
		{
			return;
		}
		try
		{
			fs.Flush();
			fs.Close();
		}
		catch
		{
		}
	}

	public static void WriteDebugLogObj(FileStream fs, string logContent, bool bFlush)
	{
		if (fs == null)
		{
			return;
		}
		try
		{
			lock (fs)
			{
				string s = string.Format("{0}: {1}\r\n", DateTime.Now.ToString("MM-dd HH:mm:ss.fff:"), logContent);
				byte[] bytes = Encoding.Default.GetBytes(s);
				fs.Write(bytes, 0, bytes.Length);
				WriteObjTimes++;
				if (bFlush || WriteObjTimes % 1000 == 0)
				{
					fs.Flush();
					WriteObjTimes = 0;
				}
			}
		}
		catch
		{
		}
	}

	public static void WriteTextFile(string path, string logContent, bool showTime = true)
	{
		try
		{
			lock (LockTxtObj)
			{
				FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
				fileStream.Seek(0L, SeekOrigin.End);
				string empty = string.Empty;
				empty = ((!showTime) ? $"{logContent}\r\n" : string.Format("{0}: {1}\r\n", DateTime.Now.ToString("MM-dd HH:mm:ss.fff:"), logContent));
				byte[] bytes = Encoding.Default.GetBytes(empty);
				fileStream.Write(bytes, 0, bytes.Length);
				fileStream.Flush();
				fileStream.Close();
			}
		}
		catch
		{
		}
	}
}
