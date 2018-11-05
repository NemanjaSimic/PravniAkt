using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using Common.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Common.Models
{
	[DataContract]
	public abstract class ElementPravnogAkta : IElementPravnogAkta
	{
		[Key]
		[ScaffoldColumn(false)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[DataMember]
		public String Naslov { get; set; }
		[DataMember]
		public String Sadrzaj { get; set; }
		[DataMember]
		public int IdUAktu { get; set; }
		[DataMember]
		public int RedniBroj { get; set; }
		[DataMember]
		public bool PodElement { get; set; }
		[DataMember]
		public EElementiPravnogAktaTypes TipNadElementa { get; set; }
		[DataMember]
		public int IdNadElementa { get; set; }
		[DataMember]
		public String NaslovPravnogAkta { get; set; }
		[DataMember]
		[NotMapped]
		public List<IElementPravnogAkta> Elementi { get; set; }

		public ElementPravnogAkta()
		{
			Elementi = new List<IElementPravnogAkta>();
		}
	}
}
