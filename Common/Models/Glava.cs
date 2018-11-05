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
	public class Glava : ElementPravnogAkta
	{
		public Glava(int redniBroj,string naslov)
		{
			Naslov = "GLAVA " + IntegerToRoman.ToRomanNumber(redniBroj)+ "\n" + naslov + "\n";
			Sadrzaj = "";
			PodElement = false;
		}

		public Glava()
		{

		}
	}
}
