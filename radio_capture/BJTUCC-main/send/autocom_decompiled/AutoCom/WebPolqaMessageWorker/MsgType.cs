namespace WebPolqaMessageWorker;

public enum MsgType
{
	MsgType_SYS_Timing = 16,
	MsgType_POLQA_Calc = 258,
	MsgType_POLQA_Query = 259,
	MsgType_POLQA_Sample = 260,
	MsgType_MOMT_Match = 272,
	MsgType_TestData_Process = 273,
	MsgType_Device_Register = 274,
	MsgType_File_Normal = 513,
	MsgType_File_Resume = 514,
	MsgType_Unkonwn = 32767
}
