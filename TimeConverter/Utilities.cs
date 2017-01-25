using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConverter
{
	public static class Utilities
	{
		public static int _ConvertDateTimeToUnixTime( DateTime convertDate )
		{
			var epochTime = new DateTime( 1970, 1, 1 );
			return (int)convertDate.Subtract( epochTime ).TotalSeconds;
		}

		public static DateTime _ConvertUnixTimeToDateTime( int convertDate )
		{
			var epochTime = new DateTime( 1970, 1, 1 );
			return epochTime.AddSeconds( convertDate );
		}
	}
}
