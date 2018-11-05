using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using Common.Enumerations;
using System.Runtime.Serialization;

namespace Common.Models
{
	[DataContract]
	public class Zakon : PravniAkt
	{
		public Zakon()
		{

		}
	}
}

