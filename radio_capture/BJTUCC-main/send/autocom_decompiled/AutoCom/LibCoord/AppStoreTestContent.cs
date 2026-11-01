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
public class AppStoreTestContent
{
	private ConnectionSetup lc8gd3UrE3y;

	[CompilerGenerated]
	private AppStoreNameEnum DVUgdJmpj9R;

	[CompilerGenerated]
	private FileSelectList JBfgdr4w2bT;

	[CompilerGenerated]
	private DataTestMode KLxgd9VbaRb;

	internal static AppStoreTestContent X2aOGJZDUKLadxuisHoJ;

	[ReadOnly(false)]
	[MyDisplayName("网络连接配置", "Network Connection Config")]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public ConnectionSetup ConnectionSetup
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[JsonConverter(typeof(StringEnumConverter))]
	[TypeConverter(typeof(EnumConverter))]
	[ReadOnly(false)]
	[MyDisplayName("应用商店名称", "AppStore Name")]
	public AppStoreNameEnum APPStoreName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (AppStoreNameEnum)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[ReadOnly(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[MyDisplayName("App名称", "App Name")]
	[Editor(typeof(FileSelectEditor), typeof(UITypeEditor))]
	public FileSelectList FileList
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
	[MyDisplayName("测试模式", "Test type")]
	[TypeConverter(typeof(EnumConverter))]
	[JsonConverter(typeof(StringEnumConverter))]
	public DataTestMode TestMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			return (DataTestMode)(object)null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AppStoreTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AppStoreTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		BWg20SZdL2H51CM0hRaT();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DgpJMqZDiCt65swd3V4q()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void bUDebCZDzjRIAWJ03cdE(object P_0, ConnectionType value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool MNAfSqZDOB3FaUQ37WQv()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AppStoreTestContent epdxyfZD5VqFPwrtmcUp()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BWg20SZdL2H51CM0hRaT()
	{
	}
}
