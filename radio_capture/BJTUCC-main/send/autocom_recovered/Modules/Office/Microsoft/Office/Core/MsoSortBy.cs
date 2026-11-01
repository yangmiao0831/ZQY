using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[TypeLibType(16)]
public enum MsoSortBy
{
	msoSortByFileName = 1,
	msoSortBySize,
	msoSortByFileType,
	msoSortByLastModified,
	msoSortByNone
}
