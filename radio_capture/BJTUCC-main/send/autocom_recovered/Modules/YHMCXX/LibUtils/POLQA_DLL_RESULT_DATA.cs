using System;
using System.Runtime.InteropServices;

namespace LibUtils;

public struct POLQA_DLL_RESULT_DATA
{
	public float mfVersion;

	public float mfP863Version;

	public uint mulMode;

	public uint mulSampleRate;

	public float mfMOSLQO;

	public float mfMinDelay;

	public float mfMaxDelay;

	public float mfAvgDelay;

	public float mfEModelRValue;

	public float mfPitchReference;

	public float mfPitchDegraded;

	public float mfEstimatedSampleRate;

	public int miResamplingApplied;

	public float mfLevelReference;

	public float mfLevelDegraded;

	public float mfP56ActiveSpeechLevelRefdB;

	public float mfP56ActiveSpeechLevelDegdB;

	public float mfP56PauseLevelRefdB;

	public float mfP56PauseLevelDegdB;

	public float mfAttenuation;

	public float mfSnrReference;

	public float mfSnrDegraded;

	public float mfActiveSpeechRatioRef;

	public float mfActiveSpeechRatioDeg;

	public uint mulElementsInVADVectors;

	public IntPtr mpiVADSpeechStartRef;

	public IntPtr mpiVADSpeechStartDeg;

	public IntPtr mpiVADSpeechLengthRef;

	public IntPtr mpiVADSpeechLengthDeg;

	public uint mulElementsInDelayBuffer;

	public IntPtr mpfDelayVsTimeBufferInp;

	public IntPtr mpfDelayVsTimeBufferRes;

	public uint mulElementsInRefAlignedTimeBuffer;

	public IntPtr mpfRefAlignedTimeBuffer;

	public uint mulElementsInDegAlignedTimeBuffer;

	public IntPtr mpfDegAlignedTimeBuffer;

	public uint mulMOSPerFrameBufferSize;

	public IntPtr mfpMOSPerFrame;

	public uint mulFrameSize;

	public uint mulNrFramesInSpectrogram;

	public uint mulNrLinesInSpectra;

	public IntPtr mppfSpectrumRef;

	public IntPtr mppfSpectrumDeg;

	public uint mulNrBarkBands;

	public IntPtr mppfLoudnessDensityRef;

	public IntPtr mppfLoudnessDensityDeg;

	public IntPtr mppfNoiseLoudnessGraph;

	public uint mulWarningStatus;

	public double dDeltaTime;

	public int ForFutureExtensions2;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
	public float[] ForFutureExtensions1;
}
