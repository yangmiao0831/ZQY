using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace PdfToImage;

public class PDFConvert
{
	public const string GhostScriptDLLName = "gsdll32.dll";

	private const string GS_OutputFileFormat = "-sOutputFile={0}";

	private const string GS_DeviceFormat = "-sDEVICE={0}";

	private const string GS_FirstParameter = "pdf2img";

	private const string GS_ResolutionXFormat = "-r{0}";

	private const string GS_ResolutionXYFormat = "-r{0}x{1}";

	private const string GS_GraphicsAlphaBits = "-dGraphicsAlphaBits={0}";

	private const string GS_TextAlphaBits = "-dTextAlphaBits={0}";

	private const string GS_FirstPageFormat = "-dFirstPage={0}";

	private const string GS_LastPageFormat = "-dLastPage={0}";

	private const string GS_FitPage = "-dPDFFitPage";

	private const string GS_PageSizeFormat = "-g{0}x{1}";

	private const string GS_DefaultPaperSize = "-sPAPERSIZE={0}";

	private const string GS_JpegQualityFormat = "-dJPEGQ={0}";

	private const string GS_RenderingThreads = "-dNumRenderingThreads={0}";

	private const string GS_Fixed1stParameter = "-dNOPAUSE";

	private const string GS_Fixed2ndParameter = "-dBATCH";

	private const string GS_Fixed3rdParameter = "-dSAFER";

	private const string GS_FixedMedia = "-dFIXEDMEDIA";

	private const string GS_QuiteOperation = "-q";

	private const string GS_StandardOutputDevice = "-";

	private const string GS_MultiplePageCharacter = "%";

	private const string GS_FontPath = "-sFONTPATH={0}";

	private const string GS_NoPlatformFonts = "-dNOPLATFONTS";

	private const string GS_NoFontMap = "-dNOFONTMAP";

	private const string GS_FontMap = "-sFONTMAP={0}";

	private const string GS_SubstitutionFont = "-sSUBSTFONT={0}";

	private const string GS_FCOFontFile = "-sFCOfontfile={0}";

	private const string GS_FAPIFontMap = "-sFAPIfontmap={0}";

	private const string GS_NoPrecompiledFonts = "-dNOCCFONTS";

	private const int e_Quit = -101;

	private const int e_NeedInput = -106;

	private static bool useSimpleAnsiConversion = true;

	private static Mutex mutex;

	private string _sDeviceFormat;

	private string _sParametersUsed;

	private int _iWidth;

	private int _iHeight;

	private int _iResolutionX = 254;

	private int _iResolutionY;

	private int _iJPEGQuality;

	private int _iFirstPageToConvert = -1;

	private int _iLastPageToConvert = -1;

	private int _iGraphicsAlphaBit = -1;

	private int _iTextAlphaBit = -1;

	private int _iRenderingThreads = -1;

	private bool _bFitPage;

	private bool _bThrowOnlyException = false;

	private bool _bRedirectIO = false;

	private bool _bForcePageSize = false;

	private string _sDefaultPageSize;

	private IntPtr _objHandle;

	private bool _didOutputToMultipleFile = false;

	private Process myProcess;

	public StringBuilder output;

	private List<string> _sFontPath = new List<string>();

	private bool _bDisablePlatformFonts = false;

	private bool _bDisableFontMap = false;

	private List<string> _sFontMap = new List<string>();

	private string _sSubstitutionFont;

	private string _sFCOFontFile;

	private string _sFAPIFontMap;

	private bool _bDisablePrecompiledFonts = false;

	public int RenderingThreads
	{
		get
		{
			return _iRenderingThreads;
		}
		set
		{
			if (value == 0)
			{
				_iRenderingThreads = Environment.ProcessorCount;
			}
			else
			{
				_iRenderingThreads = value;
			}
		}
	}

	public string OutputFormat
	{
		get
		{
			return _sDeviceFormat;
		}
		set
		{
			_sDeviceFormat = value;
		}
	}

	public string DefaultPageSize
	{
		get
		{
			return _sDefaultPageSize;
		}
		set
		{
			_sDefaultPageSize = value;
		}
	}

	public bool ForcePageSize
	{
		get
		{
			return _bForcePageSize;
		}
		set
		{
			_bForcePageSize = value;
		}
	}

	public string ParametersUsed
	{
		get
		{
			return _sParametersUsed;
		}
		set
		{
			_sParametersUsed = value;
		}
	}

	public int Width
	{
		get
		{
			return _iWidth;
		}
		set
		{
			_iWidth = value;
		}
	}

	public int Height
	{
		get
		{
			return _iHeight;
		}
		set
		{
			_iHeight = value;
		}
	}

	public int ResolutionX
	{
		get
		{
			return _iResolutionX;
		}
		set
		{
			_iResolutionX = value;
		}
	}

	public int ResolutionY
	{
		get
		{
			return _iResolutionY;
		}
		set
		{
			_iResolutionY = value;
		}
	}

	public int GraphicsAlphaBit
	{
		get
		{
			return _iGraphicsAlphaBit;
		}
		set
		{
			if (value > 4 || value == 3)
			{
				throw new ArgumentOutOfRangeException("The Graphics Alpha Bit must have a value between 1 2 and 4, or <= 0 if not set");
			}
			_iGraphicsAlphaBit = value;
		}
	}

	public int TextAlphaBit
	{
		get
		{
			return _iTextAlphaBit;
		}
		set
		{
			if (value > 4 || value == 3)
			{
				throw new ArgumentOutOfRangeException("The Text Alpha Bit must have a value between 1 2 and 4, or <= 0 if not set");
			}
			_iTextAlphaBit = value;
		}
	}

	public bool FitPage
	{
		get
		{
			return _bFitPage;
		}
		set
		{
			_bFitPage = value;
		}
	}

	public int JPEGQuality
	{
		get
		{
			return _iJPEGQuality;
		}
		set
		{
			_iJPEGQuality = value;
		}
	}

	public int FirstPageToConvert
	{
		get
		{
			return _iFirstPageToConvert;
		}
		set
		{
			_iFirstPageToConvert = value;
		}
	}

	public int LastPageToConvert
	{
		get
		{
			return _iLastPageToConvert;
		}
		set
		{
			_iLastPageToConvert = value;
		}
	}

	public bool ThrowOnlyException
	{
		get
		{
			return _bThrowOnlyException;
		}
		set
		{
			_bThrowOnlyException = value;
		}
	}

	public bool RedirectIO
	{
		get
		{
			return _bRedirectIO;
		}
		set
		{
			_bRedirectIO = value;
		}
	}

	public bool OutputToMultipleFile
	{
		get
		{
			return _didOutputToMultipleFile;
		}
		set
		{
			_didOutputToMultipleFile = value;
		}
	}

	public bool UseMutex
	{
		get
		{
			return mutex != null;
		}
		set
		{
			if (!value)
			{
				if (mutex != null)
				{
					mutex.ReleaseMutex();
					mutex.Close();
					mutex = null;
				}
			}
			else if (mutex == null)
			{
				mutex = new Mutex(initiallyOwned: false, "MutexGhostscript");
			}
		}
	}

	public List<string> FontPath
	{
		get
		{
			return _sFontPath;
		}
		set
		{
			_sFontPath = value;
		}
	}

	public bool DisablePlatformFonts
	{
		get
		{
			return _bDisablePlatformFonts;
		}
		set
		{
			_bDisablePlatformFonts = value;
		}
	}

	public bool DisableFontMap
	{
		get
		{
			return _bDisableFontMap;
		}
		set
		{
			_bDisableFontMap = value;
		}
	}

	public List<string> FontMap
	{
		get
		{
			return _sFontMap;
		}
		set
		{
			_sFontMap = value;
		}
	}

	public string SubstitutionFont
	{
		get
		{
			return _sSubstitutionFont;
		}
		set
		{
			_sSubstitutionFont = value;
		}
	}

	public string FCOFontFile
	{
		get
		{
			return _sFCOFontFile;
		}
		set
		{
			_sFCOFontFile = value;
		}
	}

	public string FAPIFontMap
	{
		get
		{
			return _sFAPIFontMap;
		}
		set
		{
			_sFAPIFontMap = value;
		}
	}

	public bool DisablePrecompiledFonts
	{
		get
		{
			return _bDisablePrecompiledFonts;
		}
		set
		{
			_bDisablePrecompiledFonts = value;
		}
	}

	[DllImport("kernel32.dll", EntryPoint = "RtlMoveMemory")]
	private static extern void CopyMemory(IntPtr Destination, IntPtr Source, uint Length);

	[DllImport("gsdll32.dll")]
	private static extern int gsapi_new_instance(out IntPtr pinstance, IntPtr caller_handle);

	[DllImport("gsdll32.dll")]
	private static extern int gsapi_init_with_args(IntPtr instance, int argc, IntPtr argv);

	[DllImport("gsdll32.dll")]
	private static extern int gsapi_exit(IntPtr instance);

	[DllImport("gsdll32.dll")]
	private static extern void gsapi_delete_instance(IntPtr instance);

	[DllImport("gsdll32.dll")]
	private static extern int gsapi_revision(ref GS_Revision pGSRevisionInfo, int intLen);

	[DllImport("gsdll32.dll")]
	private static extern int gsapi_set_stdio(IntPtr lngGSInstance, StdioCallBack gsdll_stdin, StdioCallBack gsdll_stdout, StdioCallBack gsdll_stderr);

	public PDFConvert(IntPtr objHandle)
	{
		_objHandle = objHandle;
	}

	public PDFConvert()
	{
		_objHandle = IntPtr.Zero;
	}

	public bool Convert(string inputFile, string outputFile)
	{
		return Convert(inputFile, outputFile, _bThrowOnlyException, null);
	}

	public bool Convert(string inputFile, string outputFile, string parameters)
	{
		return Convert(inputFile, outputFile, _bThrowOnlyException, parameters);
	}

	private bool Convert(string inputFile, string outputFile, bool throwException, string options)
	{
		if (string.IsNullOrEmpty(inputFile))
		{
			throw new ArgumentNullException("inputFile");
		}
		if (!File.Exists(inputFile))
		{
			throw new ArgumentException($"The file :'{inputFile}' doesn't exist", "inputFile");
		}
		if (string.IsNullOrEmpty(_sDeviceFormat))
		{
			throw new ArgumentNullException("Device");
		}
		if (mutex != null)
		{
			mutex.WaitOne();
		}
		bool result = false;
		try
		{
			result = ExecuteGhostscriptCommand(GetGeneratedArgs(inputFile, outputFile, options));
		}
		finally
		{
			if (mutex != null)
			{
				mutex.ReleaseMutex();
			}
		}
		return result;
	}

	public bool Print(string inputFile, string printParametersFile)
	{
		if (string.IsNullOrEmpty(inputFile))
		{
			throw new ArgumentNullException("inputFile");
		}
		if (!File.Exists(inputFile))
		{
			throw new ArgumentException($"The file :'{inputFile}' doesn't exist", "inputFile");
		}
		if (string.IsNullOrEmpty(printParametersFile))
		{
			throw new ArgumentNullException("printParametersFile");
		}
		if (!File.Exists(printParametersFile))
		{
			throw new ArgumentException($"The file :'{printParametersFile}' doesn't exist", "printParametersFile");
		}
		List<string> list = new List<string>(7);
		list.Add("printPdf");
		list.Add("-dNOPAUSE");
		list.Add("-dBATCH");
		if (_iFirstPageToConvert > 0)
		{
			list.Add($"-dFirstPage={_iFirstPageToConvert}");
		}
		if (_iLastPageToConvert > 0 && _iLastPageToConvert >= _iFirstPageToConvert)
		{
			list.Add($"-dLastPage={_iLastPageToConvert}");
		}
		list.Add(printParametersFile);
		list.Add(inputFile);
		bool result = false;
		if (mutex != null)
		{
			mutex.WaitOne();
		}
		try
		{
			result = ExecuteGhostscriptCommand(list.ToArray());
		}
		finally
		{
			if (mutex != null)
			{
				mutex.ReleaseMutex();
			}
		}
		return result;
	}

	private bool ExecuteGhostscriptCommand(string[] sArgs)
	{
		IntPtr pinstance = IntPtr.Zero;
		int num = sArgs.Length;
		object[] array = new object[num];
		IntPtr[] array2 = new IntPtr[num];
		GCHandle[] aGCHandle = new GCHandle[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = StringToAnsiZ(sArgs[i]);
			ref GCHandle reference = ref aGCHandle[i];
			reference = GCHandle.Alloc(array[i], GCHandleType.Pinned);
			ref IntPtr reference2 = ref array2[i];
			reference2 = aGCHandle[i].AddrOfPinnedObject();
		}
		GCHandle gchandleArgs = GCHandle.Alloc(array2, GCHandleType.Pinned);
		IntPtr argv = gchandleArgs.AddrOfPinnedObject();
		int num2 = -1;
		try
		{
			num2 = gsapi_new_instance(out pinstance, _objHandle);
			if (num2 < 0)
			{
				ClearParameters(ref aGCHandle, ref gchandleArgs);
				throw new ApplicationException("I can't create a new istance of Ghostscript please verify no other istance are running!");
			}
		}
		catch (BadImageFormatException)
		{
			ClearParameters(ref aGCHandle, ref gchandleArgs);
			if (IntPtr.Size == 8)
			{
				throw new ApplicationException($"The gsdll32.dll you provide is not compatible with the current architecture that is 64bit,Please download any version above version 8.64 from the original website in the 64bit or x64 or AMD64 version!");
			}
			if (IntPtr.Size == 4)
			{
				throw new ApplicationException($"The gsdll32.dll you provide is not compatible with the current architecture that is 32bit,Please download any version above version 8.64 from the original website in the 32bit or x86 or i386 version!");
			}
		}
		catch (DllNotFoundException)
		{
			ClearParameters(ref aGCHandle, ref gchandleArgs);
			throw new ApplicationException("The gsdll32.dll wasn't found in default dlls search pathor is not in correct version (doesn't expose the required methods). Please download at least the version 8.64 from the original website");
		}
		IntPtr zero = IntPtr.Zero;
		if (_bRedirectIO)
		{
			StdioCallBack stdioCallBack = gsdll_stdin;
			StdioCallBack stdioCallBack2 = gsdll_stdout;
			StdioCallBack stdioCallBack3 = gsdll_stderr;
			num2 = gsapi_set_stdio(pinstance, stdioCallBack, stdioCallBack2, stdioCallBack3);
			if (output == null)
			{
				output = new StringBuilder();
			}
			else
			{
				output.Remove(0, output.Length);
			}
			myProcess = Process.GetCurrentProcess();
			myProcess.OutputDataReceived += SaveOutputToImage;
		}
		num2 = -1;
		try
		{
			num2 = gsapi_init_with_args(pinstance, num, argv);
		}
		catch (Exception ex3)
		{
			throw new ApplicationException(ex3.Message, ex3);
		}
		finally
		{
			ClearParameters(ref aGCHandle, ref gchandleArgs);
			gsapi_exit(pinstance);
			gsapi_delete_instance(pinstance);
			if (myProcess != null && _bRedirectIO)
			{
				myProcess.OutputDataReceived -= SaveOutputToImage;
			}
		}
		return num2 == 0 || num2 == -101;
	}

	private void ClearParameters(ref GCHandle[] aGCHandle, ref GCHandle gchandleArgs)
	{
		for (int i = 0; i < aGCHandle.Length; i++)
		{
			aGCHandle[i].Free();
		}
		gchandleArgs.Free();
	}

	private void SaveOutputToImage(object sender, DataReceivedEventArgs e)
	{
		output.Append(e.Data);
	}

	private string[] GetGeneratedArgs(string inputFile, string outputFile, string otherParameters)
	{
		if (!string.IsNullOrEmpty(otherParameters))
		{
			return GetGeneratedArgs(inputFile, outputFile, otherParameters.Split(new string[1] { " " }, StringSplitOptions.RemoveEmptyEntries));
		}
		return GetGeneratedArgs(inputFile, outputFile, (string[])null);
	}

	private string[] GetGeneratedArgs(string inputFile, string outputFile, string[] presetParameters)
	{
		ArrayList arrayList = new ArrayList();
		string[] array;
		if (presetParameters == null || presetParameters.Length == 0)
		{
			if (_sDeviceFormat == "jpeg" && _iJPEGQuality > 0 && _iJPEGQuality < 101)
			{
				arrayList.Add($"-dJPEGQ={_iJPEGQuality}");
			}
			if (_iWidth > 0 && _iHeight > 0)
			{
				arrayList.Add($"-g{_iWidth}x{_iHeight}");
			}
			else if (!string.IsNullOrEmpty(_sDefaultPageSize))
			{
				arrayList.Add($"-sPAPERSIZE={_sDefaultPageSize}");
				if (_bForcePageSize)
				{
					arrayList.Add("-dFIXEDMEDIA");
				}
			}
			if (_iGraphicsAlphaBit > 0)
			{
				arrayList.Add($"-dGraphicsAlphaBits={_iGraphicsAlphaBit}");
			}
			if (_iTextAlphaBit > 0)
			{
				arrayList.Add($"-dTextAlphaBits={_iTextAlphaBit}");
			}
			if (_bFitPage)
			{
				arrayList.Add("-dPDFFitPage");
			}
			if (_iResolutionX > 0)
			{
				if (_iResolutionY > 0)
				{
					arrayList.Add($"-r{_iResolutionX}x{_iResolutionY}");
				}
				else
				{
					arrayList.Add($"-r{_iResolutionX}");
				}
			}
			if (_iFirstPageToConvert > 0)
			{
				arrayList.Add($"-dFirstPage={_iFirstPageToConvert}");
			}
			if (_iLastPageToConvert > 0)
			{
				if (_iFirstPageToConvert > 0 && _iFirstPageToConvert > _iLastPageToConvert)
				{
					throw new ArgumentOutOfRangeException($"The 1st page to convert ({_iFirstPageToConvert}) can't be after then the last one ({_iLastPageToConvert})");
				}
				arrayList.Add($"-dLastPage={_iLastPageToConvert}");
			}
			if (_iRenderingThreads > 0)
			{
				arrayList.Add($"-dNumRenderingThreads={_iRenderingThreads}");
			}
			if (_bRedirectIO)
			{
			}
			if (_sFontPath != null && _sFontPath.Count > 0)
			{
				arrayList.Add(string.Format("-sFONTPATH={0}", string.Join(";", _sFontPath.ToArray())));
			}
			if (_bDisablePlatformFonts)
			{
				arrayList.Add("-dNOPLATFONTS");
			}
			if (_bDisableFontMap)
			{
				arrayList.Add("-dNOFONTMAP");
			}
			if (_sFontMap != null && _sFontMap.Count > 0)
			{
				arrayList.Add(string.Format("-sFONTMAP={0}", string.Join(";", _sFontMap.ToArray())));
			}
			if (!string.IsNullOrEmpty(_sSubstitutionFont))
			{
				arrayList.Add($"-sSUBSTFONT={_sSubstitutionFont}");
			}
			if (!string.IsNullOrEmpty(_sFCOFontFile))
			{
				arrayList.Add($"-sFCOfontfile={_sFCOFontFile}");
			}
			if (!string.IsNullOrEmpty(_sFAPIFontMap))
			{
				arrayList.Add($"-sFAPIfontmap={_sFAPIFontMap}");
			}
			if (_bDisablePrecompiledFonts)
			{
				arrayList.Add("-dNOCCFONTS");
			}
			int num = 7;
			int count = arrayList.Count;
			array = new string[num + arrayList.Count];
			array[1] = "-dNOPAUSE";
			array[2] = "-dBATCH";
			array[3] = "-dSAFER";
			array[4] = $"-sDEVICE={_sDeviceFormat}";
			for (int i = 0; i < count; i++)
			{
				array[5 + i] = (string)arrayList[i];
			}
		}
		else
		{
			array = new string[presetParameters.Length + 3];
			for (int i = 1; i <= presetParameters.Length; i++)
			{
				array[i] = presetParameters[i - 1];
			}
		}
		array[0] = "pdf2img";
		if (_didOutputToMultipleFile && !outputFile.Contains("%"))
		{
			int num2 = outputFile.LastIndexOf('.');
			if (num2 > 0)
			{
				outputFile = outputFile.Insert(num2, "%d");
			}
		}
		_sParametersUsed = string.Empty;
		for (int i = 1; i < array.Length - 2; i++)
		{
			_sParametersUsed = _sParametersUsed + " " + array[i];
		}
		array[^2] = $"-sOutputFile={outputFile}";
		array[^1] = $"{inputFile}";
		string sParametersUsed = _sParametersUsed;
		_sParametersUsed = sParametersUsed + " " + $"-sOutputFile={$"\"{outputFile}\""}" + " " + $"\"{inputFile}\"";
		return array;
	}

	private static byte[] StringToAnsiZ(string str)
	{
		if (str == null)
		{
			str = string.Empty;
		}
		return Encoding.Default.GetBytes(str);
	}

	public static string AnsiZtoString(IntPtr strz)
	{
		if (strz != IntPtr.Zero)
		{
			return Marshal.PtrToStringAnsi(strz);
		}
		return string.Empty;
	}

	public static bool CheckDll()
	{
		return File.Exists("gsdll32.dll");
	}

	public int gsdll_stdin(IntPtr intGSInstanceHandle, IntPtr strz, int intBytes)
	{
		if (intBytes == 0)
		{
			return 0;
		}
		int num = Console.Read();
		if (num == -1)
		{
			return 0;
		}
		byte b = (byte)num;
		GCHandle gCHandle = GCHandle.Alloc(b, GCHandleType.Pinned);
		IntPtr source = gCHandle.AddrOfPinnedObject();
		CopyMemory(strz, source, 1u);
		source = IntPtr.Zero;
		gCHandle.Free();
		return 1;
	}

	public int gsdll_stdout(IntPtr intGSInstanceHandle, IntPtr strz, int intBytes)
	{
		byte[] array = new byte[intBytes];
		GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
		IntPtr destination = gCHandle.AddrOfPinnedObject();
		CopyMemory(destination, strz, (uint)intBytes);
		destination = IntPtr.Zero;
		gCHandle.Free();
		string text = "";
		for (int i = 0; i < intBytes; i++)
		{
			text += (char)array[i];
		}
		output.Append(text);
		return intBytes;
	}

	public int gsdll_stderr(IntPtr intGSInstanceHandle, IntPtr strz, int intBytes)
	{
		return gsdll_stdout(intGSInstanceHandle, strz, intBytes);
	}

	public GhostScriptRevision GetRevision()
	{
		GS_Revision pGSRevisionInfo = default(GS_Revision);
		GCHandle gCHandle = GCHandle.Alloc(pGSRevisionInfo, GCHandleType.Pinned);
		int num = gsapi_revision(ref pGSRevisionInfo, 16);
		GhostScriptRevision result = default(GhostScriptRevision);
		result.intRevision = pGSRevisionInfo.intRevision;
		result.intRevisionDate = pGSRevisionInfo.intRevisionDate;
		result.ProductInformation = AnsiZtoString(pGSRevisionInfo.strProduct);
		result.CopyrightInformations = AnsiZtoString(pGSRevisionInfo.strCopyright);
		gCHandle.Free();
		return result;
	}
}
