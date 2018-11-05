using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Contracts;
using Common.Database;
using Common.Models;

namespace Server.Services
{
	public class PravniAktService : IPravniAkt
	{
		public bool CreatePravniAkt(PravniAkt pravniAkt)
		{
			return DBManager.Instance.AddPravniAkt(pravniAkt);
		}

		public void DeleteAkt(string naslov)
		{
			DBManager.Instance.DeleteAkt(naslov);
		}

		public List<PravniAkt> PravneAkte()
		{
			return DBManager.Instance.GetAllPravniAkt();
		}
	}
}
