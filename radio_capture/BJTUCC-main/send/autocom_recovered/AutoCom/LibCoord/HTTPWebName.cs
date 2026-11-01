using LibUtils;

namespace LibCoord;

public enum HTTPWebName
{
	[MyDescription("自定义网址", "Custom Web")]
	custom,
	[MyDescription("随机网页", "Random Web")]
	random,
	[MyDescription("新浪", "Sina")]
	sina,
	[MyDescription("搜狐", "Sohu")]
	sohu,
	[MyDescription("百度", "Baidu")]
	baidu,
	[MyDescription("京东", "Jingdong")]
	jingdong,
	[MyDescription("淘宝", "Taobao")]
	taobao,
	[MyDescription("网易", "NetEase")]
	netease,
	[MyDescription("凤凰", "ifeng")]
	ifeng,
	[MyDescription("微博", "Weibo")]
	weibo,
	[MyDescription("哔哩哔哩", "Bilibili")]
	bilibili,
	[MyDescription("腾讯", "Tencent")]
	tencent,
	[MyDescription("知乎", "Zhihu")]
	zhihu
}
