using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Common.Enumerations;
using System.Runtime.Serialization;

namespace Common.Models
{
	[DataContract]
	[KnownType(typeof(Zakon))]
	[KnownType(typeof(Uredba))]
	[KnownType(typeof(Odluka))]
	[KnownType(typeof(Pravilnik))]
	[KnownType(typeof(Deo))]
	[KnownType(typeof(Glava))]
	[KnownType(typeof(Odeljak))]
	[KnownType(typeof(Tacka))]
	[KnownType(typeof(Stav))]
	[KnownType(typeof(Clan))]
	public abstract class PravniAkt  
	{
		
		protected  String naslov;
		protected  String uvod;
		protected  DateTime? datumStupanjaNaSnagu;
		[DataMember]
		[Key]
		public String Naslov { get { return naslov; } set { naslov = value; } }
		[DataMember]
		public String Uvod { get { return uvod; } set { uvod = value; } }
		[DataMember]
		public DateTime? DatumStupanjaNaSnagu { get { return datumStupanjaNaSnagu; } set { datumStupanjaNaSnagu = value; } }
		[DataMember]
		public EPravniAktTypes TipPravnogAkta
		{
			get;
			set;
		}
		[DataMember]
		[NotMapped]
		public List<ElementPravnogAkta> ElementiPravnogAkta { get; set; }
		[DataMember]
		public int BrojDelova { get; set; }
		[DataMember]
		public int BrojOdeljaka { get; set; }
		[DataMember]
		public int BrojGlava { get; set; }
		[DataMember]
		public int BrojClana { get; set; }
		public PravniAkt()
		{
			ElementiPravnogAkta = new List<ElementPravnogAkta>();
			BrojDelova = 0;
			BrojGlava = 0;
			BrojOdeljaka = 0;
		}
	}
}
