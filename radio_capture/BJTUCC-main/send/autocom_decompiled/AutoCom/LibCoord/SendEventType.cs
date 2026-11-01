namespace LibCoord;

public enum SendEventType
{
	RemoveEQ = 0,
	AddEQ = 1,
	RemoveGPS = 2,
	AddGPS = 3,
	GPSLocationFail = 4,
	FlushData = 5,
	SendChipInfo = 6,
	ReSendLogmask = 7,
	ReplayRafPause = 8,
	ReplayRafResume = 9,
	TraceNoData = 100
}
