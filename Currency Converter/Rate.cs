using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
	//Make sure API return value names and where you want to store that name are same. Like in API get response.
	public class Rate
	{
		public double INR { get; set; }
		public double JPY { get; set; }
		public double USD { get; set; }
		public double NZD { get; set; }
		public double EUR { get; set; }
		public double CAD { get; set; }
	}
}
