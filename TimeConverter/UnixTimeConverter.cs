using System;

namespace TimeConverter
{
	public static class UnixTimeConverter
	{
		/// <summary>
		/// Takes a Universal <see cref="DateTime"/> and converts it into the equivalent Unix timestamp.
		/// </summary>
		/// <param name="convertDate">The Universal <see cref="DateTime"/> to convert.</param>
		/// <returns>An <see cref="int"/> representing the Unix timestamp equivalent.</returns>
		public static int ConvertDateTimeToUnixTime( DateTime convertDate )
		{
			return (int)convertDate.Subtract( epochTime ).TotalSeconds;
		}

		/// <summary>
		/// Takes an <see cref="int"/> representing a Unix timestamp and converts it into the equivalent Universal <see cref="DateTime"/>.
		/// </summary>
		/// <param name="convertDate">The <see cref="int"/> representing a valid Unix timestamp.</param>
		/// <returns>A <see cref="DateTime"/> representing the equivalent Universal timestamp.</returns>
		public static DateTime ConvertUnixTimeToDateTime( int convertDate )
		{
			return epochTime.AddSeconds( convertDate );
		}

		private static DateTime epochTime = new DateTime(1970, 1, 1);
	}
}
