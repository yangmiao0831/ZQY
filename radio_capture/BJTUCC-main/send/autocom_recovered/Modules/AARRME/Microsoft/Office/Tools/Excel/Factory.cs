using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Office.Tools.Ribbon;

namespace Microsoft.Office.Tools.Excel;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("71A6F4AE-FF75-472B-8E1C-47F913AA9F3F")]
[TypeIdentifier]
public interface Factory
{
	RibbonFactory GetRibbonFactory();

	ActionsPane CreateActionsPane(IServiceProvider serviceProvider, IHostItemProvider hostItemProvider, string primaryCookie, string identifier, object containerComponent);
}
