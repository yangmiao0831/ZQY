using System;

namespace AsyncIO.Windows;

internal delegate bool ConnectExDelegate(IntPtr socketHandle, byte[] socketAddress, int socketAddressSize, IntPtr buffer, int dataLength, out int bytesSent, IntPtr overlapped);
