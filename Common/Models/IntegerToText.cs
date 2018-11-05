using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
	public class IntegerToText
	{
		public static string NumberToWord(int number)
		{
			string words = "";

			if (number > 0 && number < 100)
			{

				var unitsMap = new[] { "NULA", "PRVI", "DRUGI", "TRECI", "CETVRTI", "PETI", "SESTI", "SEDMI", "OSMI", "DEVETI", "DESETI", "JEDANAESTI", "DVANAESTI", "TRINEAESTI", "CETRNAESTI", "PETNAESTI", "SESNAESTI", "SEDAMNAESTI", "OSAMNAESTI", "DEVETNAESTI" };
				var tensMap = new[] { "NULA", "DESET", "DVADESET", "TRIDESET", "CETRDESET", "PEDESET", "SEZDESET", "SEDAMDESET", "OSAMDESET", "DEVEDESET" };

				if (number < 20)
					words += unitsMap[number];
				else
				{
					words += tensMap[number / 10];
					if ((number % 10) > 0)
						words += unitsMap[number % 10];
					else
					{
						words += "i";
					}
				}
			}
			else
			{
				words += "i";
			}

			return words;
		}
	}
}
