using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MapWinGIS;

[ComImport]
[Guid("74F07889-1380-43EE-837A-BBB268311005")]
[CompilerGenerated]
[TypeIdentifier]
public interface IPoint
{
	double x
	{
		[DispId(1)]
		get;
		[DispId(1)]
		[param: In]
		set;
	}

	double y
	{
		[DispId(2)]
		get;
		[DispId(2)]
		[param: In]
		set;
	}
}
