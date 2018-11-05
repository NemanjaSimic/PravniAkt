using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Enumerations;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Models
{
	[DataContract]
	public class Korisnik
	{
		[DataMember]
		public String Ime { get; set; }
		[DataMember]
		public String Prezime { get; set; }
		[DataMember]
		[Key]
		public String Username { get; set; }
		[DataMember]
		public String Sifra { get; set; }
		[DataMember]
		public EUserTypes Tip { get; set; }
		public Korisnik(String ime,String prezime,String username,String sifra,EUserTypes tip)
		{
			Ime = ime;
			Prezime = prezime;
			Username = username;
			Sifra = sifra;
			Tip = tip;
		}
		public Korisnik()
		{

		}
	}
}
