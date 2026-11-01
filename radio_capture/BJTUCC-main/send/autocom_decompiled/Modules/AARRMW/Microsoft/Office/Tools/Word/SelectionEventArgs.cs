using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Word;

namespace Microsoft.Office.Tools.Word;

[ComImport]
[CompilerGenerated]
[Guid("1669c37b-2ce5-4924-ac10-2e50a5b95901")]
[TypeIdentifier]
public interface SelectionEventArgs
{
	Selection Selection { get; }
}
