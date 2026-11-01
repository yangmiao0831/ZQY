using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MapWinGIS;

[ComImport]
[TypeIdentifier]
[CompilerGenerated]
[Guid("EC7866BE-AE6C-46D6-8E9A-1F55D166F440")]
public interface IOgrDatasource
{
	void _VtblGap1_7();

	[DispId(6)]
	bool Open([In][MarshalAs(UnmanagedType.BStr)] string connectionString);

	void _VtblGap2_1();

	[DispId(8)]
	[return: MarshalAs(UnmanagedType.Interface)]
	OgrLayer GetLayer([In] int Index, [In] bool forUpdate = false);
}
