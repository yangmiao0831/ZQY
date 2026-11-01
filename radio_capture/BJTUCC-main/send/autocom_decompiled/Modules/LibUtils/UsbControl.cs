using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using wDVvxYYcyxdvVsBwKm;

public class UsbControl
{
	public struct USB_CYCLE_PORT_PARAMS
	{
		public uint ConnectionIndex;

		public uint StatusReturned;
	}

	private static Guid NZC7Sa3NM6;

	private static UsbControl WUterDciXB9qOGZps8x;

	[DllImport("cfgmgr32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int CM_Locate_DevNode(ref int devInst, string pszDeviceId, int flags);

	[DllImport("cfgmgr32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int CM_Get_DevNode_Registry_Property(int devInst, uint property, ref uint propertyType, StringBuilder propertyBuffer, ref uint propertyBufferSize, int flags);

	[DllImport("cfgmgr32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int CM_Get_Parent(ref int devInstParent, int devInst, int flags);

	[DllImport("cfgmgr32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int CM_Get_Device_ID(int devInst, StringBuilder deviceId, int deviceIdSize, int flags);

	[DllImport("cfgmgr32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int CM_Get_Device_Interface_List(ref Guid interfaceClassGuid, string deviceId, StringBuilder devicePath, int devicePathSize, int flags);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool DeviceIoControl(IntPtr hDevice, uint dwIoControlCode, IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize, ref uint lpBytesReturned, IntPtr lpOverlapped);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool CloseHandle(IntPtr hObject);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CycleUsbDevice(string pszUsbDeviceId)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool USBReset(string vid, string pid, string adbport)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool USBResetMate40(string adbport)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool USBResetZTEA40(string adbport)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UsbControl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static UsbControl()
	{
		b99vLwQv4vNmPibnHM.mVERxIi6QN();
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					b99vLwQv4vNmPibnHM.CO84lAqjUl();
					num2 = 0;
					if (true)
					{
						continue;
					}
					break;
				default:
					iorjtLcjZuACxIPfxwM();
					num2 = 5;
					continue;
				case 4:
					return;
				case 2:
					hrQ9MPcMMvdLYL1q4H7();
					num2 = 3;
					if (true)
					{
						continue;
					}
					break;
				case 5:
					w0LIWOcY95rNJbsa0dl();
					num2 = 2;
					if (false)
					{
						num2 = 2;
					}
					continue;
				case 3:
					NZC7Sa3NM6 = new Guid((string)UyugiEcnj0Jrvcp9Ei6(10240));
					num2 = 4;
					if (true)
					{
						continue;
					}
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UyugiEcnj0Jrvcp9Ei6(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool gtStsVcr9ltrDFZYshd()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static UsbControl bw60gFcK7TWKfa9wLKY()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool jKNAR2cWkKc38iAw2pu(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void iorjtLcjZuACxIPfxwM()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hrQ9MPcMMvdLYL1q4H7()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void w0LIWOcY95rNJbsa0dl()
	{
	}
}
