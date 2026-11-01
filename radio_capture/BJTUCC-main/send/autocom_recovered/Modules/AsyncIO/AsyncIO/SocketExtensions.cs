using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace AsyncIO;

public static class SocketExtensions
{
	public static void Bind(this AsyncSocket socket, IPAddress ipAddress, int port)
	{
		socket.Bind(new IPEndPoint(ipAddress, port));
	}

	public static void Connect(this AsyncSocket socket, IPAddress ipAddress, int port)
	{
		socket.Connect(new IPEndPoint(ipAddress, port));
	}

	public static void Connect(this AsyncSocket socket, string host, int port)
	{
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		if (port < 0 || port > 65535)
		{
			throw new ArgumentOutOfRangeException("port");
		}
		IPAddress iPAddress = Dns.GetHostAddresses(host).FirstOrDefault((IPAddress ip) => ip.AddressFamily == socket.AddressFamily || (socket.AddressFamily == AddressFamily.InterNetworkV6 && socket.DualMode && ip.AddressFamily == AddressFamily.InterNetwork));
		if (iPAddress != null)
		{
			socket.Connect(iPAddress, port);
			return;
		}
		throw new ArgumentException("invalid host", "host");
	}

	public static void Send(this AsyncSocket socket, byte[] buffer)
	{
		socket.Send(buffer, 0, buffer.Length, SocketFlags.None);
	}

	public static void Receive(this AsyncSocket socket, byte[] buffer)
	{
		socket.Receive(buffer, 0, buffer.Length, SocketFlags.None);
	}
}
