using System;

namespace AsyncIO.Windows;

internal delegate bool AcceptExDelegate(IntPtr listenSocketHandle, IntPtr acceptSocketHandle, IntPtr buffer, int len, int localAddressLength, int remoteAddressLength, out int bytesReceived, IntPtr overlapped);
