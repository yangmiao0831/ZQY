using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[ComImport]
[Guid("000CDB05-0000-0000-C000-000000000046")]
[CoClass(typeof(CustomXMLPartClass))]
public interface CustomXMLPart : _CustomXMLPart, _CustomXMLPartEvents_Event
{
}
