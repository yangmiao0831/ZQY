using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

[Serializable]
public class TaskAdmin
{
	public string PlanVer;

	public string TaskGroupID;

	public string TaskGroupName;

	public int TestPlanID;

	public List<TestPlan> TestPlans;

	internal static TaskAdmin vlHOsvZhEseySjjY953c;

	[JsonIgnore]
	public int LoopTimes
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[JsonIgnore]
	public int LoopInterval
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[JsonIgnore]
	public bool TaskIntervalEnable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return true;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[JsonIgnore]
	public int TaskInterval
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return 0;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[JsonIgnore]
	public TCPIPCaptureInTask TCPIPCapture
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddTestplan()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasSelectTask()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAllTaskDisable()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<TestTask> GetTestTasks()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TestTask GetTestTask(int taskIdx)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetTaskIndex(string taskID)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int TaskTypeToTaskAuthIdx(TaskType taskType)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TestTask NewTask(int eqID, TaskType taskType)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TestTask AddTask(TaskType taskType)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TestTask AddTask(int eqID, TaskType taskType)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddTask(int eqID, TestTask task)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddTaskByElectric(int eqID, TaskType taskType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NbJg6jNcJxm(int P_0, TestTask P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ModifyAllTaskBySpecialEQ(int eqID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddTask(TaskType taskType, string taskName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddTask(TestTask task)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TestTask AddMultiTask(List<TestTask> taskList, string taskName = "")
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DelTask(TestTask task)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DelTask(string sName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearAllTask()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TestTask InsertTask(int eqID, int idx, TaskType taskType)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsertTask(int eqID, int idx, TestTask task)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUEIdx(int UEIdx)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SerialsToObj()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SortTaskID()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TaskContains(TestTask task)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasVirtualNetwork(ref TestTask taskBack)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasATIPCall(ref TestTask taskBack)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasNDIS(ref TestTask taskBack)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TaskAdmin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskAdmin()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		UijnJmZhdpPVF9BS3Nlh();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TSKBkHZhVEJdBYC1PlYG()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static TaskAdmin KDUCVJZhTusP4kP1wcXb()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool CZudaXZhp790bZRkfEMT(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int Noob9NZhQ6L4ZpL3vS1Y(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TEE1bwZhRsdNwAY8UOCI(int P_0, int P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CZah1sZhGc4IKrT5K5cS(Enum P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object XVYBKWZh32vPFMq4KZMB(object P_0, TaskType taskType, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int A5fNRyZhFeMucUaDbuWS(TaskType taskType)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object dUURFnZh7ILoCkaOfQux(object P_0, TaskType taskType, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object CYhrFPZhbILmQHiGMP45()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O4SKQ7ZhgIoxciHxH8F8(object P_0, int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jobCDBZhfDwFiSvtD21q(object P_0, ENUMPowerDeviceType value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool ICvv7VZhja7nULccTXFc(int eqID)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cpnKHJZheK0PMxsCO99u(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MxVkr1Zh0WEkUMeiaMg9(object P_0, ConnectionType value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool q36upOZhPf1XMVdl8Kyx(int eqID)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RwS0fAZhc6iUlZqf3A1m(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object gltYyMZh8C2JxauF2eVU(object P_0, int idx, TaskType taskType, object P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool b5AY7wZhwZJ07LU8vSgE(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vQGoW3ZhhPNe6aDdoeJ8(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ConnectionType XsfyBMZh4DJTTdIOLj20(object P_0)
	{
		return (ConnectionType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HdWtQ3ZhrP8RytNKrmBT()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wIFCfOZhDe44pIOqmaVS(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UijnJmZhdpPVF9BS3Nlh()
	{
	}
}
