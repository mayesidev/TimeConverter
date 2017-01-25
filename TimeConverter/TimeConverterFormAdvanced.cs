using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;

using System.Windows.Forms;

namespace TimeConverter
{
	public partial class TimeConverterFormAdvanced : Form
	{
		public TimeConverterFormAdvanced()
		{
			InitializeComponent();
			_SetTimeToNow( 1 );
			_SetTimeToNow( 3 );
			_SetTimeToNow( 5 );
		}

		private TextBox mLastModifiedCol1Box;
		private TextBox mLastModifiedCol2Box;
		private TextBox mLastModifiedCol3Box;

		private void _SetTimeToNow( object sender, EventArgs e )
		{
			_SetTimeToNow( tableLayoutPanel.GetColumn( (Control)sender ) );
		}

		private void _SetTimeToNow( int column )
		{
			var unixTimeBox = _GetTextBoxesForColumn( column ).UnixTimeBox;
			unixTimeBox.Text = Utilities._ConvertDateTimeToUnixTime( DateTime.Now.ToUniversalTime() ).ToString();
			_Synchronize( column );
		}

		private void _Synchronize( object sender, EventArgs args )
		{
			_Synchronize( tableLayoutPanel.GetColumn( (Control)sender ) );
		}

		private TimeBoxColumn _GetTextBoxesForColumn( int column )
		{
			TimeBoxColumn boxColumn;
			switch( column )
			{
				case 0:
				case 1:
					boxColumn = new TimeBoxColumn
					{
						LastModifiedTimeBox = mLastModifiedCol1Box,
						UnixTimeBox = unixTimeCol1Box,
						UtcTimeBox = utcTimeCol1Box,
						LocalTimeBox = localTimeCol1Box
					};
					break;
				case 2:
				case 3:
					boxColumn = new TimeBoxColumn
					{
						LastModifiedTimeBox = mLastModifiedCol2Box,
						UnixTimeBox = unixTimeCol2Box,
						UtcTimeBox = utcTimeCol2Box,
						LocalTimeBox = localTimeCol2Box
					};
					break;
				case 4:
				case 5:
					boxColumn = new TimeBoxColumn
					{
						LastModifiedTimeBox = mLastModifiedCol3Box,
						UnixTimeBox = unixTimeCol3Box,
						UtcTimeBox = utcTimeCol3Box,
						LocalTimeBox = localTimeCol3Box
					};
					break;
				default:
					throw new NotSupportedException( "I don't even know..." );
			}

			return boxColumn;
		}

		private void _Synchronize( int column )
		{
			var timeBoxColumn = _GetTextBoxesForColumn( column );
			var lastModifiedTimeBox = timeBoxColumn.LastModifiedTimeBox;
			var unixTimeBox = timeBoxColumn.UnixTimeBox;
			var utcTimeBox = timeBoxColumn.UtcTimeBox;
			var localTimeBox = timeBoxColumn.LocalTimeBox;

			_SetTimeBoxTextChangedHandlers( false, new[] { unixTimeBox, utcTimeBox, localTimeBox } );

			unixTimeBox.ForeColor = DefaultForeColor;
			utcTimeBox.ForeColor = DefaultForeColor;
			localTimeBox.ForeColor = DefaultForeColor;

			if( lastModifiedTimeBox == unixTimeBox )
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
			else if( lastModifiedTimeBox == utcTimeBox )
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
			else if( lastModifiedTimeBox == localTimeBox )
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

			_SetTimeBoxTextChangedHandlers( true, new[]{ unixTimeBox, utcTimeBox, localTimeBox } );
		}

		private void _SetTimeBoxTextChangedHandlers( bool enabled, IEnumerable<Control> timeBoxes )
		{
			// re-wire event handler so it fires when it should.
			if( enabled )
			{
				foreach( var timeBox in timeBoxes )
				{
					timeBox.TextChanged += _TimeBoxTextChanged;
				}
			}
			// unwire event handler so it doesn't fire when we update the text.
			else
			{
				foreach( var timeBox in timeBoxes )
				{
					timeBox.TextChanged -= _TimeBoxTextChanged;
				}
			}
		}

		private void _TimeBoxTextChanged( object sender, EventArgs e )
		{
			var col = tableLayoutPanel.GetColumn( (Control)sender );
			switch( col )
			{
				case 0:
				case 1:
					mLastModifiedCol1Box = (TextBox)sender;
					break;
				case 2:
				case 3:
					mLastModifiedCol2Box = (TextBox)sender;
					break;
				case 4:
				case 5:
					mLastModifiedCol3Box = (TextBox)sender;
					break;
				default:
					throw new NotSupportedException("Wat.");
			}
		}
	}
}
