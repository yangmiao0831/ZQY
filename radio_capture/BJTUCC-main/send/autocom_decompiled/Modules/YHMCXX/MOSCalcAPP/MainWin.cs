using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using LibUtils;
using NetMQ;
using NetMQ.Sockets;

namespace MOSCalcAPP;

public class MainWin : Form
{
	private static string ScriptMsgEndPoint = "tcp://*:46060";

	private static bool HasConnected = false;

	private IContainer components;

	private Button btnTestCTTL;

	public static void CalcMOS(string sJson)
	{
		sJson = sJson.Replace("%", "\"");
		sJson = sJson.Replace("$", " ");
		CalcParamObj calcParamObj = UBFun.JsonToSerialize<CalcParamObj>(sJson);
		if (calcParamObj != null)
		{
			Thread.Sleep(100);
			CalcResultObj calcResultObj = CalcCTTLMos(calcParamObj);
			calcResultObj.RecordName = calcParamObj.RecordName;
			string sCmd = UBFun.SerializeToJson(calcResultObj);
			SendOneEx(sCmd);
		}
	}

	private static void UnInitZSocket()
	{
	}

	private static void SendOne(string sCmd)
	{
	}

	private static void SendOneEx(string sCmd)
	{
		NetMQSocket netMQSocket = new PushSocket();
		netMQSocket.Bind(ScriptMsgEndPoint);
		netMQSocket.SendFrame(sCmd);
		Thread.Sleep(500);
	}

	private static CalcResultObj CalcCTTLMos(CalcParamObj obj)
	{
		if (obj == null)
		{
			return null;
		}
		int RtFrameNum = 0;
		int RtBandType = 0;
		int[] array = new int[500];
		int ErrType = 0;
		CalcResultObj calcResultObj = new CalcResultObj();
		try
		{
			calcResultObj.MOS = CTTLMOSInterface.FinalMos(obj.RecordName, obj.SampleName, ref RtFrameNum, ref RtBandType, array, ref ErrType);
		}
		catch
		{
			calcResultObj.MOS = -99.0;
		}
		calcResultObj.MinDelay = array.Min();
		calcResultObj.MaxDelay = array.Max();
		calcResultObj.AvgDelay = (int)array.Average();
		calcResultObj.Jitter = calcResultObj.MaxDelay - calcResultObj.MinDelay;
		return calcResultObj;
	}

	private void btnTestCTTL_Click(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		CalcParamObj calcParamObj = new CalcParamObj();
		calcParamObj.SampleName = "mos48kSample.wav";
		calcParamObj.RecordName = "mos48kSample.wav";
		CalcResultObj calcResultObj = CalcCTTLMos(calcParamObj);
		MessageBox.Show(calcResultObj.MOS.ToString());
	}

	private static void InitZSocket()
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		btnTestCTTL = new Button();
		((Control)this).SuspendLayout();
		((Control)btnTestCTTL).Location = new Point(72, 55);
		((Control)btnTestCTTL).Name = "btnTestCTTL";
		((Control)btnTestCTTL).Size = new Size(123, 23);
		((Control)btnTestCTTL).TabIndex = 0;
		((Control)btnTestCTTL).Text = "Test CTTL";
		((ButtonBase)btnTestCTTL).UseVisualStyleBackColor = true;
		((Control)btnTestCTTL).Click += btnTestCTTL_Click;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)0;
		((Form)this).ClientSize = new Size(278, 244);
		((Control)this).Controls.Add((Control)(object)btnTestCTTL);
		((Control)this).Name = "MainWin";
		((Control)this).Text = "Calc";
		((Control)this).ResumeLayout(false);
	}
}
