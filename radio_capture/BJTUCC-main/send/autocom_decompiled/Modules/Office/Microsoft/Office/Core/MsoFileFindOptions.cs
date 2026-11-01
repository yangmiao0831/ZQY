using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[TypeLibType(16)]
public enum MsoFileFindOptions
{
	msoOptionsNew = 1,
	msoOptionsAdd,
	msoOptionsWithin
}
