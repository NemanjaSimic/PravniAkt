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
	public class Stav : ElementPravnogAkta
	{
		[DataMember]
		public int BrojTacaka { get; set; }
		public Stav(string sadrzaj)
		{
			Naslov = "";
			Sadrzaj = "\n" + sadrzaj;
			BrojTacaka = 0;
		}
		public Stav()
		{

		}
	}
}
