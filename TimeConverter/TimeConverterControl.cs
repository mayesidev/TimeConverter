using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace TimeConverter
{
	public partial class TimeConverterControl : UserControl
	{
		public TimeConverterControl()
		{
			InitializeComponent();
			_ResetTimeBoxes();
		}

		private TextBox mLastModifiedTimeBox;

		private void _OnSychronizeClick(object sender, EventArgs e)
		{
			_Synchronize();
		}

		private void _OnResetClick(object sender, EventArgs e)
		{
			_ResetTimeBoxes();
		}

		private void _ResetTimeBoxes()
		{
			universalTimeBox.Text = DateTime.UtcNow.ToString(CultureInfo.InvariantCulture);
			_Synchronize();
		}

		private void _ResetTimeBoxesFormatting()
		{
			unixTimeBox.ForeColor = DefaultForeColor;
			universalTimeBox.ForeColor = DefaultForeColor;
			localTimeBox.ForeColor = DefaultForeColor;
		}

		private void _Synchronize()
		{
			_ResetTimeBoxesFormatting();

			switch (mLastModifiedTimeBox.Tag.ToString())
			{
				case "unix":
					_SyncToUnixTime();
					break;
				case "universal":
					_SyncToUniversalTime();
					break;
				case "local":
					_SyncToLocalTime();
					break;
				default:
					throw new InvalidOperationException(
						string.Format(
							"mLastModifiedTimeBox was set to an invalid control. Please update _Synchronize() with a case for handling the field '{0}', with the Tag '{1}'.",
							mLastModifiedTimeBox.Name, mLastModifiedTimeBox.Tag));
			}
		}

		private void _SyncToLocalTime()
		{
			DateTime localTime;
			if (DateTime.TryParse(localTimeBox.Text, out localTime))
			{

				var universalTime = localTime.ToUniversalTime();

				unixTimeBox.Text = UnixTimeConverter.ConvertDateTimeToUnixTime(universalTime).ToString(CultureInfo.InvariantCulture);
				universalTimeBox.Text = universalTime.ToString(CultureInfo.InvariantCulture);
				localTimeBox.Text = localTime.ToString(CultureInfo.InvariantCulture);
			}
			else
			{
				localTimeBox.ForeColor = Color.Firebrick;
				unixTimeBox.Text = @"Unable to parse Local Time value";
				universalTimeBox.Text = @"Unable to parse Local Time value";
			}
		}

		private void _SyncToUniversalTime()
		{
			DateTime universalTime;
			if (DateTime.TryParse(universalTimeBox.Text, out universalTime))
			{
				unixTimeBox.Text = UnixTimeConverter.ConvertDateTimeToUnixTime(universalTime).ToString();
				universalTimeBox.Text = universalTime.ToString(CultureInfo.InvariantCulture);
				localTimeBox.Text = universalTime.ToLocalTime().ToString(CultureInfo.InvariantCulture);
			}
			else
			{
				universalTimeBox.ForeColor = Color.Firebrick;
				unixTimeBox.Text = @"Unable to parse Universal Time value";
				localTimeBox.Text = @"Unable to parse Universal Time value";
			}
		}

		private void _SyncToUnixTime()
		{
			int unixTimestamp;
			if (int.TryParse(unixTimeBox.Text, out unixTimestamp))
			{
				// We don't re-set the unixTimeBox text here, because it would never
				// undergo additional formatting like the other two may in their cases.

				var unixDateTime = UnixTimeConverter.ConvertUnixTimeToDateTime(unixTimestamp);
				universalTimeBox.Text = unixDateTime.ToString(CultureInfo.InvariantCulture);
				localTimeBox.Text = unixDateTime.ToLocalTime().ToString(CultureInfo.InvariantCulture);
			}
			else
			{
				unixTimeBox.ForeColor = Color.Firebrick;
				universalTimeBox.Text = @"Unable to parse Unix Time value";
				localTimeBox.Text = @"Unable to parse Unix Time value";
			}
		}

		private void _TimeBoxTextChanged(object sender, EventArgs e)
		{
			var timeBox = sender as TextBox;
			if (timeBox != null)
			{
				mLastModifiedTimeBox = timeBox;
			}
		}
	}
}
