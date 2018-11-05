
using Common.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
	public interface IPravniAkt
	{
		List<IElementPravnogAkta> ElementiPravnogAkta { get; set; }
		EPravniAktTypes TipPravnogAkta { get; }
	}
}
