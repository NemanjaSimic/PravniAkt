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
	public class Odeljak : ElementPravnogAkta
	{
		public Odeljak(int redniBroj,string naslov)
		{
			Naslov = "\n" + redniBroj.ToString() + ". " + naslov;
			Sadrzaj = "";
		}
		public Odeljak()
		{

		}
	}
}
