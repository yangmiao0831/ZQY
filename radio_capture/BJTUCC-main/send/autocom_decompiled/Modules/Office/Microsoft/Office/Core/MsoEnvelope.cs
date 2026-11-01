using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[ComImport]
[CoClass(typeof(MsoEnvelopeClass))]
[Guid("000672AC-0000-0000-C000-000000000046")]
public interface MsoEnvelope : IMsoEnvelopeVB, IMsoEnvelopeVBEvents_Event
{
}
