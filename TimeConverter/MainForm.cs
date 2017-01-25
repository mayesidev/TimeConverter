using System;
using System.Windows.Forms;

namespace TimeConverter
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void _OnAddConverterToolStripMenuItemClick(object sender, EventArgs e)
		{
			//tableLayoutPanel.ColumnCount += 1;

			//var timeConverterControl = new TimeConverterControl();
			//tableLayoutPanel.SetColumn(timeConverterControl, tableLayoutPanel.ColumnCount-1);
			//tableLayoutPanel.Update();
		}

		private void _OnRemoveConverterToolStripMenuItemClick(object sender, EventArgs e)
		{
		}
	}
}
