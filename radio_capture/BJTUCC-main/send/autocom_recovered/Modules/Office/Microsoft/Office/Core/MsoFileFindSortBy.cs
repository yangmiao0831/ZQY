using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[TypeLibType(16)]
public enum MsoFileFindSortBy
{
	msoFileFindSortbyAuthor = 1,
	msoFileFindSortbyDateCreated,
	msoFileFindSortbyLastSavedBy,
	msoFileFindSortbyDateSaved,
	msoFileFindSortbyFileName,
	msoFileFindSortbySize,
	msoFileFindSortbyTitle
}
