using LibUtils;

namespace LibCoord;

public enum IndoorTestBuildingTypeEnum
{
	[MyDescription("高层写字楼", "High rise office building")]
	HighRiseOfficeBuilding = 1,
	[MyDescription("星级酒店", "Star Hotel")]
	StarHotel,
	[MyDescription("大型商场", "Large shopping mall")]
	LargeShoppingMall,
	[MyDescription("居民小区", "Residential area")]
	ResidentialArea,
	[MyDescription("高等院校", "Colleges and Universities")]
	CollegesAndUniversities,
	[MyDescription("旅游景点", "Scenic spot")]
	ScenicSpot,
	[MyDescription("飞机场候机楼", "Airport Terminal")]
	AirportTerminal,
	[MyDescription("火车站候车室", "Railway station waiting room")]
	RailwayStationWaitingRoom,
	[MyDescription("地铁站台", "Subway platform")]
	SubwayPlatform
}
