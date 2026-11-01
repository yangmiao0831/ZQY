using System.Runtime.InteropServices;

namespace Microsoft.Office.Core;

[TypeLibType(16)]
public enum XlErrorBarType
{
	xlErrorBarTypeCustom = -4114,
	xlErrorBarTypeFixedValue = 1,
	xlErrorBarTypePercent = 2,
	xlErrorBarTypeStDev = -4155,
	xlErrorBarTypeStError = 4
}
