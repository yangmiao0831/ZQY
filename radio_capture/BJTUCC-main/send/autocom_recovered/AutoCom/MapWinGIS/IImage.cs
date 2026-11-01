using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MapWinGIS;

[ComImport]
[TypeIdentifier]
[Guid("79C5F83E-FB53-4189-9EC4-4AC25440D825")]
[CompilerGenerated]
public interface IImage
{
	[DispId(1)]
	bool Open([In][MarshalAs(UnmanagedType.BStr)] string ImageFileName, [In] ImageType FileType = ImageType.USE_FILE_EXTENSION, [In] bool InRam = false, [Optional][In][MarshalAs(UnmanagedType.Interface)] ICallback cBack);
}
