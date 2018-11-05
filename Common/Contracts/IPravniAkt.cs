using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Common.Models;

namespace Common.Contracts
{
	[ServiceContract]
	public interface IPravniAkt
	{
		[OperationContract]
		bool CreatePravniAkt(PravniAkt pravniAkt);
		[OperationContract]
		List<PravniAkt> PravneAkte();
		[OperationContract]
		void DeleteAkt(string naslov);
	}
}
