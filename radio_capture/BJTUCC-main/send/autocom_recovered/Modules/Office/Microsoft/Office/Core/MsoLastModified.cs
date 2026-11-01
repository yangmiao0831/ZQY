using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[TypeLibType(16)]
public enum MsoLastModified
{
	msoLastModifiedYesterday = 1,
	msoLastModifiedToday,
	msoLastModifiedLastWeek,
	msoLastModifiedThisWeek,
	msoLastModifiedLastMonth,
	msoLastModifiedThisMonth,
	msoLastModifiedAnyTime
}
