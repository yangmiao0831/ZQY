using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Tools;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("D576C22C-643C-4FB7-B8F1-2B9091456358")]
[TypeIdentifier]
public interface ICachedDataProvider
{
	bool IsCacheInitialized { get; }

	void FillCachedData(object hostItem);

	void StopCaching(object hostItem, string fieldOrPropertyName);

	void StartCaching(object hostItem, string fieldOrPropertyName);

	bool IsCached(object hostItem, string fieldOrPropertyName);

	bool NeedsFill(object hostItem, string fieldOrPropertyName);
}
