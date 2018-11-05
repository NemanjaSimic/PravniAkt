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
	public class Clan : ElementPravnogAkta
	{
		[DataMember]
		public int BrojStavova { get; set; }
		[DataMember]
		public int BrojTacaka { get; set; }
		public Clan(int redniBroj, string naslov)
		{
			Naslov = "\n" + naslov + "\n" + redniBroj.ToString() + "Clan";
			Sadrzaj = "";
			BrojStavova = 0;
			BrojTacaka = 0;
		}

		public Clan()
		{

		}
	}
}
