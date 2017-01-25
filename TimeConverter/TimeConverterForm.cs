using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace TimeConverter
{
	public partial class TimeConverterForm : Form
	{
		public TimeConverterForm()
		{
			InitializeComponent();
			_SetTimeToNow();
		}

		private TextBox mLastModifiedBox;

		private void _SetTimeToNow( object sender = null, EventArgs e = null )
		{
			unixTimeBox.Text = Utilities._ConvertDateTimeToUnixTime( DateTime.Now.ToUniversalTime() ).ToString();
			_Synchronize();
		}

		private void _Synchronize( object sender = null, EventArgs e = null )
		{
			_SetTimeBoxTextChangedHandlers( false );

			unixTimeBox.ForeColor = DefaultForeColor;
			utcTimeBox.ForeColor = DefaultForeColor;
			localTimeBox.ForeColor = DefaultForeColor;

			if( mLastModifiedBox == unixTimeBox )
			{
				int unixTime;
				if( int.TryParse( unixTimeBox.Text, out unixTime ) )
				{
					var unixDateTime = Utilities._ConvertUnixTimeToDateTime( unixTime );
					utcTimeBox.Text = unixDateTime.ToString( CultureInfo.InvariantCulture );
					localTimeBox.Text = unixDateTime.ToLocalTime().ToString( CultureInfo.InvariantCulture );
				}
				else
				{
					unixTimeBox.ForeColor = Color.Firebrick;
					utcTimeBox.Text = @"Unable to parse Unix Time value";
					localTimeBox.Text = @"Unable to parse Unix Time value";
				}
			}
			else if( mLastModifiedBox == utcTimeBox )
			{
				DateTime utcTime;
				if( DateTime.TryParse( utcTimeBox.Text, out utcTime ) )
				{
					unixTimeBox.Text = Utilities._ConvertDateTimeToUnixTime( utcTime ).ToString();
					localTimeBox.Text = utcTime.ToLocalTime().ToString( CultureInfo.InvariantCulture );
				}
				else
				{
					utcTimeBox.ForeColor = Color.Firebrick;
					unixTimeBox.Text = @"Unable to parse UTC Time value";
					localTimeBox.Text = @"Unable to parse UTC Time value";
				}
			}
			else if( mLastModifiedBox == localTimeBox )
			{
				DateTime localTime;
				if( DateTime.TryParse( localTimeBox.Text, out localTime ) )
				{
					var utcTime = localTime.ToUniversalTime();
					unixTimeBox.Text = Utilities._ConvertDateTimeToUnixTime( utcTime ).ToString();
					utcTimeBox.Text = utcTime.ToString( CultureInfo.InvariantCulture );
				}
				else
				{
					localTimeBox.ForeColor = Color.Firebrick;
					unixTimeBox.Text = @"Unable to parse Local Time value";
					utcTimeBox.Text = @"Unable to parse Local Time value";
				}
			}

			_SetTimeBoxTextChangedHandlers( true );
		}

		private void _SetTimeBoxTextChangedHandlers( bool enabled )
		{
			// re-wire event handler so it fires when it should.
			if( enabled )
			{
				unixTimeBox.TextChanged += _TimeBoxTextChanged;
				utcTimeBox.TextChanged += _TimeBoxTextChanged;
				localTimeBox.TextChanged += _TimeBoxTextChanged;
			}
			// unwire event handler so it doesn't fire when we update the text.
			else
			{
				unixTimeBox.TextChanged -= _TimeBoxTextChanged;
				utcTimeBox.TextChanged -= _TimeBoxTextChanged;
				localTimeBox.TextChanged -= _TimeBoxTextChanged;
			}
		}

		private void _TimeBoxTextChanged( object sender, EventArgs e )
		{
			mLastModifiedBox = (TextBox)sender;
		}
	}
}
