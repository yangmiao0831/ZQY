using System;

namespace LibUtils;

public struct usb_relay_device_info
{
	public string serial_number;

	public string device_path;

	public usb_relay_device_type type;

	public IntPtr next;
}
