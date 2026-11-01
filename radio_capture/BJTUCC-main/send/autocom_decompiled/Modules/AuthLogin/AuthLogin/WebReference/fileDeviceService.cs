using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using kn7vxUjABsPwyhovZQ;

namespace AuthLogin.WebReference;

[XmlInclude(typeof(login))]
[XmlInclude(typeof(downloadFile))]
[WebServiceBinding(Name = "fileDeviceServiceSoapBinding", Namespace = "http://service.webservice.cj.com")]
[XmlInclude(typeof(downloadFileResponse))]
[XmlInclude(typeof(helloResponse))]
[XmlInclude(typeof(logoutResponse))]
[XmlInclude(typeof(logout))]
[GeneratedCode("System.Web.Services", "4.8.4084.0")]
[XmlInclude(typeof(hello))]
[XmlInclude(typeof(loginResponse))]
[DesignerCategory("code")]
[XmlInclude(typeof(getDogListResponse))]
[DebuggerStepThrough]
[XmlInclude(typeof(getDogList))]
public class fileDeviceService : SoapHttpClientProtocol
{
	private SendOrPostCallback QwIqeJNfl6;

	private SendOrPostCallback bGPqo9WYEa;

	private SendOrPostCallback oSdqOZvnOc;

	private SendOrPostCallback Gu7qfselu6;

	private SendOrPostCallback hF1qnGjSvw;

	private bool qLhqCTj4ll;

	private getDogListCompletedEventHandler xipqgshRwh;

	private downloadFileCompletedEventHandler Ig0qBq2T57;

	private helloCompletedEventHandler q2WqPKXPQM;

	private logoutCompletedEventHandler hA8qd7N6D7;

	private loginCompletedEventHandler t5GqELyvCL;

	private static fileDeviceService lvVZsctO1ZUH1woNTwv;

	public string Url
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

	public bool UseDefaultCredentials
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

	public event getDogListCompletedEventHandler getDogListCompleted
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
		}
	}

	public event downloadFileCompletedEventHandler downloadFileCompleted
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
		}
	}

	public event helloCompletedEventHandler helloCompleted
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
		}
	}

	public event logoutCompletedEventHandler logoutCompleted
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
		}
	}

	public event loginCompletedEventHandler loginCompleted
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public fileDeviceService(string sIP, string sPort)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public fileDeviceService()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlArray(/*Could not decode attribute arguments.*/)]
	[return: XmlArrayItem(/*Could not decode attribute arguments.*/)]
	public getDogListResponseEntry[] getDogList([XmlElement(/*Could not decode attribute arguments.*/)] string password, [XmlElement(/*Could not decode attribute arguments.*/)] string customid)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void getDogListAsync(string password, string customid)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void getDogListAsync(string password, string customid, object userState)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void YxrqGT5EsB(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlElement(/*Could not decode attribute arguments.*/)]
	public object downloadFile([XmlElement(/*Could not decode attribute arguments.*/)] string token)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void downloadFileAsync(string token)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void downloadFileAsync(string token, object userState)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void QFlqQSUPjC(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlElement(/*Could not decode attribute arguments.*/)]
	public string hello([XmlElement(/*Could not decode attribute arguments.*/)] string name)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void helloAsync(string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void helloAsync(string name, object userState)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RlXq2CtWUZ(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlArrayItem(/*Could not decode attribute arguments.*/)]
	[return: XmlArray(/*Could not decode attribute arguments.*/)]
	public logoutResponseEntry[] logout([XmlElement(/*Could not decode attribute arguments.*/)] string token)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void logoutAsync(string token)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void logoutAsync(string token, object userState)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void pJUqadqmGC(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	[return: XmlArray(/*Could not decode attribute arguments.*/)]
	[return: XmlArrayItem(/*Could not decode attribute arguments.*/)]
	public loginResponseEntry[] login([XmlElement(/*Could not decode attribute arguments.*/)] string customid, [XmlElement(/*Could not decode attribute arguments.*/)] string password, [XmlElement(/*Could not decode attribute arguments.*/)] string dogid, [XmlElement(/*Could not decode attribute arguments.*/)] string WinUserName, [XmlElement(/*Could not decode attribute arguments.*/)] int TimeZone, [XmlElement(/*Could not decode attribute arguments.*/)] string email, [XmlElement(/*Could not decode attribute arguments.*/)] string lastLogIp)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void loginAsync(string customid, string password, string dogid, string WinUserName, int TimeZone, string email, string lastLogIp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void loginAsync(string customid, string password, string dogid, string WinUserName, int TimeZone, string email, string lastLogIp, object userState)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void rvjqv6tHpT(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CancelAsync(object userState)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool DqgqcsACAq(string P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static fileDeviceService()
	{
		fVtHZV1TbvaedI4eu9.cgb5CAbRe5();
		int num = 2;
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0017:
				switch (num2)
				{
				default:
					return;
				case 2:
					break;
				case 1:
					uZQ27ytmumWtEudtKPt();
					num2 = 3;
					goto IL_0017;
				case 3:
					Un5oOktQlYjmiI4bAwK();
					num2 = 0;
					if (1 == 0)
					{
						num2 = 0;
					}
					goto IL_0017;
				case 0:
					return;
				}
				fVtHZV1TbvaedI4eu9.qvN5HbupkB();
				num2 = 1;
			}
			while (true);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VTABb3tJIrr1CaG5Ogi()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object rqEoIZtYUqQDkQyjQYC(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ULkZ9NtHxHxafhCyJsg(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool RMlxUatMUlMlnb4LvqH()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static fileDeviceService ffmR0atPe6LOkjgw2dK()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void uZQ27ytmumWtEudtKPt()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object twEOb1t9xY1xSNUIGVD(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void oiFeXgtslt7Vfrfn494(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void M36HwltasbEcMofcAZN(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LqEghhtxoO2TRgZmIm1(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void l27o6WtvFRv35FGNWSD(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void sGs7A2tN19AT0ZqStWK(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void Un5oOktQlYjmiI4bAwK()
	{
	}
}
