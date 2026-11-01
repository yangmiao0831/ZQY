using LibUtils;

namespace LibCoord;

public enum FtpStatus
{
	[MyDescription("FTP密码错误", "FTP password error")]
	Status11 = 11,
	[MyDescription("访问超时", "Timeout")]
	Status28 = 28,
	[MyDescription("服务器拒绝登录", "Server deny login")]
	Status67 = 67,
	[MyDescription("权限不够", "Insufficient privilege")]
	Status78 = 78,
	[MyDescription("访问失败，请检查网络", "Access failed, please check the network")]
	Status10000 = 10000
}
