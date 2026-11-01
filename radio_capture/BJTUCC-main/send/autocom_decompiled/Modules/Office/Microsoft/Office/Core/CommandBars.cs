using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[ComImport]
[CoClass(typeof(CommandBarsClass))]
[Guid("000C0302-0000-0000-C000-000000000046")]
public interface CommandBars : _CommandBars, _CommandBarsEvents_Event
{
}
