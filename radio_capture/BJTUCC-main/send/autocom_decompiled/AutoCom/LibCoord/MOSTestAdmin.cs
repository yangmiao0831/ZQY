using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using LibBase;
using LibUtils;
using NetMQ.Sockets;
using tcEeYRHYMSOOr5xhr11;

namespace LibCoord;

public class MOSTestAdmin
{
	[CompilerGenerated]
	private sealed class n4T8T0n9pOkWpx3caN2
	{
		public ExeCalcParamObj MIQPBJcOJRn;

		internal static n4T8T0n9pOkWpx3caN2 K7ywtTBS3kWusON3LXtA;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public n4T8T0n9pOkWpx3caN2()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool gR8PB3KKCS0(ExeCalcResultObj t)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static n4T8T0n9pOkWpx3caN2()
		{
			xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
			OyLS12BSgCBbGjimpAeI();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool k1Q5TlBSF8VLRCq8uq3v()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static n4T8T0n9pOkWpx3caN2 cfPaaaBS79C2anYfGCy2()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool eOHq8uBSbeb1wk49Ee6X(object P_0, object P_1)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OyLS12BSgCBbGjimpAeI()
		{
		}
	}

	protected const string CSSampleFile8k = "mos8kSample.wav";

	protected const string CSSampleFile16k = "mos16kSample.wav";

	protected const string CSSampleFile48k = "mos48kSample.wav";

	protected const string CSSampleFile48kMuPQA = "mos48kMuPQASample.wav";

	protected const string CSSampleFile8848 = "8848.wav";

	protected string TAG;

	public static int ErrSucc;

	public static int ErrAccreditId;

	public static int ErrStartCTIFail;

	private static Queue<POLQACalcParamObj> QhaGMVVuiyu;

	public bool mIsPlayAck;

	public bool mIsRecordAck;

	public MOSDeviceTypeENUM deviceType;

	protected WAVReader WaveObj;

	protected uint RecordDuration;

	protected uint RecordSize;

	protected bool HasInit;

	protected bool IsRunning;

	protected bool IsWebCalc;

	protected int RecFileIndex;

	protected RecordModeENUM RecordMode;

	protected string PlayFile;

	public IntPtr POLQAHandle;

	public EQObj CurEQ;

	protected EQObj PlayEQ;

	protected EQObj RecEQ;

	protected int MOSPlayDelay;

	protected int PlayChan;

	protected int RecChan;

	protected CallTypeENUM CallType;

	protected POLQASWBENUM PolqaType;

	protected POLQAVerENUM POLQAVer;

	protected MOSSampleRateENUM MOSSampleRate;

	protected string RecDir;

	protected int mosType;

	protected int algoMode;

	protected int sampleRate;

	protected string CurPlayFile;

	public string CurRecFile;

	public static double CurMOSValue;

	private static string h9kGMXBGQ4s;

	private static ResponseSocket A8TGM29dRis;

	private static bool AtwGMOylW1p;

	protected static bool NeedReInitMOS;

	protected static object ReInitLockObj;

	protected static int PreReInitTick;

	private static object MkVGMMBr8tl;

	private static List<ExeCalcResultObj> vFNGM5CSH6y;

	public static Dictionary<string, CMRIMOSCalcOneRelationObj> dictCMRIMOSCalc;

	public static Dictionary<string, POLQACalcParamObj> dictMOSCalc;

	public static object lockDictObj;

	private static object Ee6GMTxTCer;

	internal static MOSTestAdmin OHEuiFu4qcbGQGIHQ6nI;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string TAGDebugFileName()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UpdateMOSMuteCount(EQObj eq, bool isMute, bool mosInternal)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitZSocketPull()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	private static void QCgGMdheRJX(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void catGMWC1lmw(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static string RecvZSocket()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DoMOSStateCheck()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int InitMOS()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CheckMOSState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetPlayFile(int chan1, int chan2, MOSSampleRateENUM sampleRate, CallNotify callNotify, bool needSetPlayFile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UnInitMOS(bool force)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnlyStartPlay(EQObj playEQ, int playChannel, int playIdx, string sPlayFile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnlyStartRec(EQObj recEQ, int recChannel, string sPlayFile, string sRecordName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnlyEndPlay(EQObj playEQ, string sPlayFile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnlyEndRec(EQObj playEQ, EQObj recEQ, string sPlayFile, string sRecFile, bool isFinishRecord, CallNotify content, string sPcRecPath = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetRecDir(string sDir)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DoStartPlayAndRecordNew(object sender, DoWorkEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DoStartPlayAndRecordRemote(object sender, DoWorkEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartPlayAndRecord(int chan1, int chan2, RecordModeENUM recordMode, string sDir, POLQASWBENUM polqaType, POLQAVerENUM polqaVer, CallTypeENUM callType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StopPlayAndRecord()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DoCMRIMOSRecvResult(CMRIMOSCalcRecvResultList list)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void mykGM4DAbCA(EQObj P_0, EQObj P_1, CMRIMOSCalcOneRelationObj P_2, CallNotify P_3, string P_4, string P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void DoRecEndCMRIMOS(object state)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoUERecFinish(SendOperUEMos mos)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void DoMOSCalcByObjThread(POLQACalcParamObj obj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	protected void PullUeWav(string adbPort, string fileName, string sPcRecPath)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void WebMOSCalcInit(bool needWaitWhenGetWavList)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void eq0GMNX3RJH(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void hxUGMitHO4p(bool P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void DoCalcPOLQA(EQObj recEQ, string sPlayFileFullName, string sRecordName, int updateIndex, bool mosInternal, MOSSampleRateENUM sampleRate)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void CheckWavLess8Sec(string sRecordName, double mos)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool DoCalcMPQ(EQObj recEQ, string sPlayFileFullName, string sRecordName, int updateIndex, bool mosInternal, MOSSampleRateENUM sampleRate)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void DoCalcCTMOSLocal(EQObj recEQ, string sPlayFileFullName, string sRecordName, int updateIndex, bool mosInternal, MOSSampleRateENUM sampleRate)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DoPullUEWave(POLQACalcParamObj obj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DoCalcPOLQAbyObj(object state)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DoCalcPOLQAbyMOSUE(object state)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	protected virtual void DoCalcCTTLMOSbyObj(object state)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	protected virtual void DoCalcCTTLMOSbyObjOld(object state)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MaWGMFB1vFa()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DoCalcMPQMOSbyObj(object state)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DoCalcCTMOSbyObj(object state)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void DoCalcPESQ(object state)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void CheckMOSChannelExchange(DateTime volteStartTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MOSTestAdmin()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void Q7AGMbXL5DT()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MOSTestAdmin()
	{
		xNOTlSHosQAMkdL3Vlu.rLMEhDBNiDZ();
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					AtwGMOylW1p = false;
					num2 = 5;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 5:
					ReInitLockObj = new object();
					num2 = 10;
					continue;
				case 2:
					UDSbfuurDeY2ugQaeSfV();
					num2 = 2;
					if (true)
					{
						num2 = 7;
					}
					continue;
				case 6:
					ErrStartCTIFail = -2;
					num2 = 0;
					if (0 == 0)
					{
						num2 = 1;
					}
					continue;
				case 12:
					ErrAccreditId = -1;
					num2 = 6;
					continue;
				case 11:
					lockDictObj = new object();
					num2 = 8;
					continue;
				default:
					h9kGMXBGQ4s = (string)PFH3bZu4pIq8SEdJ0XDP(116656);
					num2 = 9;
					if (false)
					{
						num2 = 9;
					}
					continue;
				case 4:
					return;
				case 10:
					PreReInitTick = RJwH9ZurLAeahq1tx7Mt();
					num2 = 11;
					continue;
				case 3:
					JMBV7aurCncpdXBxZETJ();
					num2 = 2;
					continue;
				case 1:
					CurMOSValue = -16777215.0;
					num2 = 0;
					if (0 == 0)
					{
						continue;
					}
					break;
				case 8:
					Ee6GMTxTCer = new object();
					num2 = 4;
					continue;
				case 7:
					ErrSucc = 0;
					num2 = 12;
					if (0 == 0)
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
	internal static DateTime FjPLnMu4TGy2Mb91LGMK()
	{
		return (DateTime)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PFH3bZu4pIq8SEdJ0XDP(int P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Y4v9ITu4QH4EHXNjdtML(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool c6ZEwiu4EyVG1JsNEUuB()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static MOSTestAdmin D9PHEmu4VgAtdliySDiX()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object qytj5au4R55uhbL5gsPp()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vqh8ulu4GqisGn71cNtm(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zAvOQtu43iKEQRiRTaVA(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object K209Rou4FLp60ssOGX1Q()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PGmEgZu47sPY4ondiqem(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tOpSVxu4bWVxjmHPgmNB(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eaqRWPu4g0OlUNgDgna3(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object IaTawxu4f5JdQqMjXJiB(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vHpWBTu4jPWcdmfVXpiA(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object WJpXeSu4ewFScDRIYcBS(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool TO02Nru40wQyJNRhs59P(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void nqqMBMu4PcCL4igToakt(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object ngGc5eu4c2elO8urv29F()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void emN5Vvu480np3jsAgmPd(object P_0, object P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object tMGhNUu4wIT9gl78561J()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void yAPcQ3u4hn0uOVTf7mSi(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool qcJtkcu44HoJxJXHT8et(IntPtr P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static uint A1mv2Zu4rA1yXn2bYQ7j(IntPtr P_0)
	{
		return 0u;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object wDCha5u4DMCAtjuOrOZd(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void KrHHZlu4dBbmmvh6OK7x(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void mEv5RKu4CkZJdHMEce1A(object P_0, int type, int pointIndex, double score, int reason, float meanDelay, float minDelay, float maxDelay, int jitter, object P_9, object P_10, object P_11)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object cdtP4ju4nPAlYXnbHGrP(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object zSXoVHu4a3lOx5Grji8j(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vi75bGu4HjcK18TAlomK(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object QTSHFwu4scIeGhB00AAv(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool LaB1QVu4lsEAis6owOaJ(object P_0, object P_1, object P_2, int timeOut)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MIjAoju49UAKPq9mQR04(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object fv3bBhu4kTRfingcPZPB(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object U14LmQu41wIx5ttZGtOF(object P_0, object P_1, int eqIndex)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object d7oiApu4vM0mOyJ7K3cT(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object vbjshnu4S30xPoeVanv9(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void t4HyO2u4mtq1lT46Sq1Q(object P_0, int tipCode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void p9W1sru4Ij1faLQ9jhkN(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WJRSt2u4XMtg7X526h94(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool v5jFdvu4UjaDBEJ2k5Ia(object P_0, object P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object Kc1YXau4O66ZxCVOkegW(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool WOXLbOu45CFynHoyxnPi(object P_0, int P_1, int P_2)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool O9qscau4ipkEyov1N9ZW(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long RoRfd2u4zF0NksV952dc(object P_0)
	{
		return 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int RJwH9ZurLAeahq1tx7Mt()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool k9h0ekurNJT57KIIbMFg(int P_0, int P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object SK9KZHurYdv70qnXHy8x(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void hHj1g3uru57mMMTXQf4C(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void G1ogEnuryZ1D8gmh42cw(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int CK1CfEur6gHCS6aHUelj(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void cvgTggur2LgjT1xdtBDx(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void YN4a1lurJ1E8quyU84uF(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void tDyF9iurMg6knljn179I(object P_0, bool isMute, bool mosInternal)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool GmaYtwurK6iSB2sZkTfO(IntPtr P_0, IntPtr P_1)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void gar9KVurZd3CtmV5Th7i(object P_0, FlashInfoPosition P_1, int P_2, int P_3, int P_4, int P_5)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static IntPtr rKwd1curo5hDYvuBasey(IntPtr P_0, object P_1, object P_2)
	{
		return (IntPtr)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NprnEyurxl94RWjLJRpl(IntPtr P_0, Type P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CbH68vurA4LrHOx13bLW(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double jvNTrAurtlClRkjK7XCE(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool fUMsdOurWkAYWl1W5ePB(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void lrLDmmurB9NX8gg2Jy20(object P_0, object P_1, bool P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double p9rAZYurqW82jYqJLu65(object P_0)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void dUDvjIurEZUjTLpQBxfY(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object c9OT5FurVKV4qfRyXsFt(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void jUIPelurTmEKQuushbqJ(object P_0, POLQASWBENUM PolqaType, POLQAVerENUM POLQAVer, bool needPushSampleWave)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double x1gQZSurpFj6vMHRYYxG(object P_0, object P_1)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vCTBcyurQbZLEUblQLUx()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool aHDKW6urR7PBOayToBEe(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object geiAQfurGUcMvob5dxEY(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object MMhoSLur3c8Dfhq99ixR(object P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object xHuJTGurF9CMePuVFdbQ(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void zIVIWIur7J8BhjWMGO5c(object P_0, object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VdNxYburb90eoDXIFUvp(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool VmFlPCurg0I6HHE4cgWA(object P_0)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void O9I8D3urfVraa1U8gdqL(object P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vix5phurjSMas5wjnXeL(object P_0, bool P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object UiLKc6ureL3atHK7acdW()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object PjpJ35ur00Cineb2bSKG(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NOwq7JurPQx4QsgNCyIg(Enum P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int E72EBdurcXXeKdEUvADE(object P_0, long P_1)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int VGXjWjur8vrlSptbKw0h(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static NetType Q24qUUurw34E4iY4QYHn(object P_0, int iPointIdx)
	{
		return (NetType)(object)null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static double RWHRChurh7ShnPlw9ycE(object P_0, int P_1, object P_2, object P_3)
	{
		return 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object EQauJ4ur4TRBfHbjP1Sk(object P_0, object P_1, object P_2, object P_3)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void HnU9ZCurrpsmEJ0niUsp(object P_0, int tagType, int pointIdx, object P_3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UDSbfuurDeY2ugQaeSfV()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static int sGoCOEurdqT1QrE9vvwr(object P_0)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void JMBV7aurCncpdXBxZETJ()
	{
	}
}
