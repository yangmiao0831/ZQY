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
public class AutoAPPTestContent
{
	private ConnectionSetup DmSgW1gCvvo;

	private string p0ggWdABJNy;

	[CompilerGenerated]
	private int UDSgWWqiCTA;

	[CompilerGenerated]
	private DataTestMode P6wgW4TGKH1;

	private static AutoAPPTestContent mDMYYnZdJeBixRmwnpqZ;

	[MyDisplayName("网络连接配置", "Network Connection Config")]
	[ReadOnly(false)]
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

	[MyDisplayName("测试配置文件路径", "Test File Path")]
	[ReadOnly(false)]
	[Editor(typeof(PythonFileEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	public string ScriptFilePath
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

	[ReadOnly(false)]
	[MyDisplayName("测试超时时长(s)", "Timeout(s)")]
	public int Timeout
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

	[MyDisplayName("测试模式", "Test type")]
	[JsonConverter(typeof(StringEnumConverter))]
	[ReadOnly(false)]
	[TypeConverter(typeof(EnumConverter))]
	[Browsable(true)]
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
	public AutoAPPTestContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static AutoAPPTestContent()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		QgVE4RZdxs9aOlPYr3Gv();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void j296LgZdZtN5hqgBOVx3()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UCdhO3ZdoMfoFrMiHRuM(object P_0, ConnectionType value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fBoCfXZdMQNgy0TN00Yy()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static AutoAPPTestContent BPIX78ZdKMpQAvrtt65D()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QgVE4RZdxs9aOlPYr3Gv()
	{
	}
}
