using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace AARRME.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				resourceMan = new ResourceManager("AARRME.Properties.Resources", typeof(Resources).Assembly);
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap AddPlan => (Bitmap)ResourceManager.GetObject("AddPlan", resourceCulture);

	internal static Bitmap Close => (Bitmap)ResourceManager.GetObject("Close", resourceCulture);

	internal static Bitmap CloseHover => (Bitmap)ResourceManager.GetObject("CloseHover", resourceCulture);

	internal static Bitmap DeleteDevice => (Bitmap)ResourceManager.GetObject("DeleteDevice", resourceCulture);

	internal static Bitmap EditMore => (Bitmap)ResourceManager.GetObject("EditMore", resourceCulture);

	internal static Bitmap ExportPlan => (Bitmap)ResourceManager.GetObject("ExportPlan", resourceCulture);

	internal static Bitmap ImportPlan => (Bitmap)ResourceManager.GetObject("ImportPlan", resourceCulture);

	internal static Bitmap Main => (Bitmap)ResourceManager.GetObject("Main", resourceCulture);

	internal static Bitmap Maximize => (Bitmap)ResourceManager.GetObject("Maximize", resourceCulture);

	internal static Bitmap msgSearch16 => (Bitmap)ResourceManager.GetObject("msgSearch16", resourceCulture);

	internal static Bitmap saveproject16 => (Bitmap)ResourceManager.GetObject("saveproject16", resourceCulture);

	internal static Bitmap ThresholdClose => (Bitmap)ResourceManager.GetObject("ThresholdClose", resourceCulture);

	internal static Bitmap ThresholdDelete => (Bitmap)ResourceManager.GetObject("ThresholdDelete", resourceCulture);

	internal static Bitmap ThresholdSort => (Bitmap)ResourceManager.GetObject("ThresholdSort", resourceCulture);

	internal Resources()
	{
	}
}
