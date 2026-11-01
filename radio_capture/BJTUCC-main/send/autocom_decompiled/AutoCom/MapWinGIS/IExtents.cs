using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MapWinGIS;

[ComImport]
[CompilerGenerated]
[TypeIdentifier]
[Guid("A5692259-035E-487A-8D89-509DD6DD0F64")]
public interface IExtents
{
	void _VtblGap1_2();

	double xMin
	{
		[DispId(3)]
		get;
	}

	double xMax
	{
		[DispId(4)]
		get;
	}

	double yMin
	{
		[DispId(5)]
		get;
	}

	double yMax
	{
		[DispId(6)]
		get;
	}
}
