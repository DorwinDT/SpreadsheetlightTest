using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpreadsheetLight;

namespace SpeedLightTestCorrect
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("SpreadSheetLight test app - Correct version");
			using (var sl = new SLDocument(@"reportTemplate1.xlsx"))
			{
				sl.Save();
			}
		}
	}
}
