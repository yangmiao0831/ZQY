using LibUtils;

namespace LibCoord;

public enum IndoorTestFloorTypeEnum
{
	[MyDescription("楼层", "Floor")]
	Floor = 1,
	[MyDescription("电梯", "Lift")]
	Lift,
	[MyDescription("停车场", "Parking lot")]
	ParkingLot
}
