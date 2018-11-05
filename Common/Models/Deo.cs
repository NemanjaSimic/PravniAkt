using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;

namespace Common.Models
{
	[DataContract]
	public class Deo : ElementPravnogAkta
	{
		public Deo(int redniBroj)
		{
			Naslov = "\nDEO " + IntegerToText.NumberToWord(redniBroj);
			Sadrzaj = "";
			PodElement = false;
		}
		public Deo()
		{

		}
	}
}
