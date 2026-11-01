using LibUtils;

namespace LibCoord;

public enum LogmaskType
{
	[MyDescription("使用软件默认值", "Use software defaults")]
	Default,
	[MyDescription("导入Logmask文件", "Import Logmask file")]
	ImportFile,
	[MyDescription("自定义勾选信令类型", "Custom check message type")]
	Custom,
	[MyDescription("软件默认配置+扩展信令", "Software default+extended message")]
	Extend
}
