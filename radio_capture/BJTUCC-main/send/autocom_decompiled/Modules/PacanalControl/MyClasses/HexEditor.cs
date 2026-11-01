using System.Windows.Forms;

namespace MyClasses;

public class HexEditor
{
	public RichTextBox Rtx;

	private int CurrentLine;

	private int CurrentRow;

	private int CurrentSubRow;

	private int FirstLine = 2;

	private int FirstRow;

	private int LastRow;

	private int LastLine;

	private int DataIndexPos;

	private bool DoKeyDown()
	{
		if (CurrentLine == LastLine)
		{
			return false;
		}
		CurrentLine++;
		DataIndexPos += 16;
		return true;
	}

	private bool DoKeyUp()
	{
		if (CurrentLine == FirstLine)
		{
			return false;
		}
		CurrentLine--;
		DataIndexPos -= 16;
		return true;
	}

	private bool DoKeyLeft()
	{
		if (CurrentSubRow == 1)
		{
			CurrentSubRow--;
			return true;
		}
		CurrentSubRow = 1;
		if (CurrentRow > FirstRow)
		{
			CurrentRow--;
			DataIndexPos--;
			return true;
		}
		if (CurrentLine > FirstLine)
		{
			CurrentLine--;
			CurrentRow = 15;
			DataIndexPos--;
			return true;
		}
		CurrentSubRow = 0;
		return true;
	}

	private bool DoKeyRight()
	{
		if (CurrentSubRow == 0)
		{
			CurrentSubRow++;
			return true;
		}
		if (CurrentRow < LastRow)
		{
			CurrentRow++;
			DataIndexPos++;
			return true;
		}
		if (CurrentLine < LastLine)
		{
			CurrentLine++;
			CurrentRow = 0;
			DataIndexPos++;
			return true;
		}
		CurrentSubRow = 1;
		return true;
	}

	private bool DoKeyPageUp()
	{
		return true;
	}

	private bool DoKeyPageDown()
	{
		return true;
	}

	private bool DoKeyHome()
	{
		CurrentLine = 2;
		CurrentRow = 0;
		CurrentSubRow = 0;
		DataIndexPos = 0;
		return true;
	}

	private bool DoKeyEnd()
	{
		CurrentLine = LastLine;
		CurrentRow = LastRow;
		CurrentSubRow = 15;
		return true;
	}

	private bool DoKeyCtrlHome()
	{
		return true;
	}

	private bool DoKeyCtrlEnd()
	{
		return true;
	}

	private bool DoNothing()
	{
		return true;
	}

	public bool ProcessKeyStroke(KeyEventArgs KeyPress)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected I4, but got Unknown
		Keys keyCode = KeyPress.KeyCode;
		switch (keyCode - 33)
		{
		case 7:
			DoKeyDown();
			break;
		case 5:
			DoKeyUp();
			break;
		case 4:
			DoKeyLeft();
			break;
		case 6:
			DoKeyRight();
			break;
		case 3:
			if (KeyPress.Control)
			{
				DoKeyCtrlHome();
			}
			else
			{
				DoKeyHome();
			}
			break;
		case 2:
			if (KeyPress.Control)
			{
				DoKeyCtrlEnd();
			}
			else
			{
				DoKeyEnd();
			}
			break;
		case 1:
			DoKeyPageDown();
			break;
		case 0:
			DoKeyPageUp();
			break;
		default:
			DoNothing();
			break;
		}
		return true;
	}
}
