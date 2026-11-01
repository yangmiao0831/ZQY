using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[TypeLibType(16)]
public enum MsoHTMLProjectState
{
	msoHTMLProjectStateDocumentLocked = 1,
	msoHTMLProjectStateProjectLocked,
	msoHTMLProjectStateDocumentProjectUnlocked
}
