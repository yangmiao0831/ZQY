using System.Collections;
using System.Windows.Forms;

namespace MyClasses;

public class ColumnSorter : IComparer
{
	public int CurrentColumn;

	public int Direction;

	public int ColumnType;

	public bool CaseSensitivity = true;

	public bool Enabled = true;

	public int Compare(object x, object y)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		int num = 0;
		int num2 = 0;
		double num3 = 0.0;
		double num4 = 0.0;
		if (!Enabled)
		{
			return 0;
		}
		try
		{
			ListViewItem val = (ListViewItem)x;
			ListViewItem val2 = (ListViewItem)y;
			if (ColumnType <= 0)
			{
				num = int.Parse(val.SubItems[CurrentColumn].Text);
				num2 = int.Parse(val2.SubItems[CurrentColumn].Text);
				if (Direction == 0)
				{
					if (num < num2)
					{
						return -1;
					}
					if (num == num2)
					{
						return 0;
					}
					return 1;
				}
				if (num < num2)
				{
					return 1;
				}
				if (num == num2)
				{
					return 0;
				}
				return -1;
			}
			if (ColumnType == 1)
			{
				num3 = double.Parse(val.SubItems[CurrentColumn].Text);
				num4 = double.Parse(val2.SubItems[CurrentColumn].Text);
				if (Direction == 0)
				{
					if (num3 < num4)
					{
						return -1;
					}
					if (num3 == num4)
					{
						return 0;
					}
					return 1;
				}
				if (num3 < num4)
				{
					return 1;
				}
				if (num3 == num4)
				{
					return 0;
				}
				return -1;
			}
			if (Direction == 0)
			{
				return string.Compare(val.SubItems[CurrentColumn].Text, val2.SubItems[CurrentColumn].Text, CaseSensitivity);
			}
			return -1 * string.Compare(val.SubItems[CurrentColumn].Text, val2.SubItems[CurrentColumn].Text, CaseSensitivity);
		}
		catch
		{
			return -1;
		}
	}
}
