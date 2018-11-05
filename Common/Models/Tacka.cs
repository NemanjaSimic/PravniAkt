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
	public class Tacka : ElementPravnogAkta
	{
		public Tacka(int redniBroj, string sadrzaj)
		{
			Naslov = "";
			Sadrzaj ="\n" + redniBroj.ToString() + ") " + sadrzaj; 
		}
		public Tacka()
		{

		}
	}
}
