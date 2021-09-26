using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
	//Root Class is a main class. API returns rates in a rates it will return all currency name with value.
	public class Root
	{
		//Get all Record in rates and set in Rate class as currency name wise.
		public Rate rates { get; set; }
		public long timestamp;
		public string licence;
	}
}
