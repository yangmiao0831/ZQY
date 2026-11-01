using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using LibUtils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class FTPSite
{
	public string DownFile;

	public string UploadPath;

	[CompilerGenerated]
	private string a8ng4ZBHPZK;

	[CompilerGenerated]
	private string yEtg4zVwqgR;

	[CompilerGenerated]
	private int jD3gNC39xTW;

	[CompilerGenerated]
	private bool aUFgNGpEEMu;

	[CompilerGenerated]
	private FTPProtocolENUM HgFgNRU1MG8;

	[CompilerGenerated]
	private bool OdbgNnAZZud;

	[CompilerGenerated]
	private string LdFgNgc2hBP;

	[CompilerGenerated]
	private string U9rgNeFLDVf;

	internal static FTPSite IcFoZ2ZCFgN6CCL6k2r7;

	[ReadOnly(false)]
	[Browsable(false)]
	[MyDisplayName("服务器名称", "Name")]
	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("服务器地址", "Host")]
	[ReadOnly(false)]
	[Editor(typeof(FTPIPHistoryEditor), typeof(UITypeEditor))]
	public string Address
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[MyDisplayName("服务器端口", "Port")]
	public int Port
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[MyDisplayName("被动模式", "Passive mode")]
	public bool Passive
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("FTP协议", "FTP Protocol")]
	[ReadOnly(false)]
	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	public FTPProtocolENUM FTPProtocol
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (FTPProtocolENUM)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("匿名", "Anonymous")]
	[ReadOnly(false)]
	public bool Anonymous
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[MyDisplayName("用户名", "Username")]
	public string User
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MyDisplayName("密码", "Password")]
	[ReadOnly(false)]
	public string Pass
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FTPSite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static FTPSite()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		GVlTPrZCf8fEYay4m1y7();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void apygBrZCg0GFOaugrtft()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EuEVYiZC7vXd0Rf6XxqW()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static FTPSite S2ZTPxZCbH35Vja2tJYN()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GVlTPrZCf8fEYay4m1y7()
	{
	}
}
