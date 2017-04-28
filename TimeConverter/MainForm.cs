using System;
using System.Windows.Forms;

namespace TimeConverter
{
	public partial class MainForm : Form
	{
		#region Public Constructors

		public MainForm()
		{
			InitializeComponent();
		}

		#endregion Public Constructors

		#region Protected Methods

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			bool success;
			switch (keyData)
			{
				case (Keys.Control | Keys.R):
					_ResetControl();
					success = true;
					break;

				case (Keys.Control | Keys.S):
				case (Keys.F5):
					_SynchronizeControl();
					success = true;
					break;

				default:
					success = base.ProcessCmdKey(ref msg, keyData);
					break;
			}

			return success;
		}

		#endregion Protected Methods

		#region Private Methods

		private void _ResetControl()
		{
			timeConverterControl.ResetTimeBoxes();
		}

		private void _ResetControl(object sender, EventArgs e)
		{
			_ResetControl();
		}

		private void _SynchronizeControl()
		{
			timeConverterControl.Synchronize();
		}

		private void _SynchronizeControl(object sender, EventArgs e)
		{
			_SynchronizeControl();
		}

		#endregion Private Methods
	}
}