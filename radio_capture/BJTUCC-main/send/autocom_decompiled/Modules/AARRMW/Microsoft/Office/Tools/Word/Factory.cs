using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Office.Tools.Ribbon;

namespace Microsoft.Office.Tools.Word;

[ComImport]
[CompilerGenerated]
[Guid("DC85BAC7-611E-4138-AC2E-6DD213400575")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface Factory
{
	RibbonFactory GetRibbonFactory();

	ActionsPane CreateActionsPane(IServiceProvider serviceProvider, IHostItemProvider hostItemProvider, string primaryCookie, string identifier, object containerComponent);
}
