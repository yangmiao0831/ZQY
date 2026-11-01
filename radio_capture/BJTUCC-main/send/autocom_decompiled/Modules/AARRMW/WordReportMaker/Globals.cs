using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Microsoft.Office.Tools.Word;

namespace WordReportMaker;

[DebuggerNonUserCode]
[GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
internal sealed class Globals
{
	private static ThisDocument _ThisDocument;

	private static Factory _factory;

	private static ThisRibbonCollection _ThisRibbonCollection;

	internal static ThisDocument ThisDocument
	{
		get
		{
			return _ThisDocument;
		}
		set
		{
			if (_ThisDocument == null)
			{
				_ThisDocument = value;
				return;
			}
			throw new NotSupportedException();
		}
	}

	internal static Factory Factory
	{
		get
		{
			return _factory;
		}
		set
		{
			if (_factory == null)
			{
				_factory = value;
				return;
			}
			throw new NotSupportedException();
		}
	}

	internal static ThisRibbonCollection Ribbons
	{
		get
		{
			if (_ThisRibbonCollection == null)
			{
				_ThisRibbonCollection = new ThisRibbonCollection(_factory.GetRibbonFactory());
			}
			return _ThisRibbonCollection;
		}
	}

	private Globals()
	{
	}
}
