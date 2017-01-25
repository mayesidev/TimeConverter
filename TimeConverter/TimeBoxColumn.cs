using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeConverter
{
	public class TimeBoxColumn
	{
		public TextBox LastModifiedTimeBox
		{
			get;
			set;
		}

		public TextBox UnixTimeBox
		{
			get;
			set;
		}

		public TextBox UtcTimeBox
		{
			get;
			set;
		}

		public TextBox LocalTimeBox
		{
			get;
			set;
		}
	}
}
