using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Common.Contracts;
using Server.Services;
using Common.Database;

namespace Server
{
	public class ServerHost
	{
		private static ServiceHost userServiceHost;
		private static ServiceHost pravniAktServiceHost;

		public ServerHost()
		{
			DBManager.Instance.InitialAdmin();

			userServiceHost = new ServiceHost(typeof(UserService));
			userServiceHost.AddServiceEndpoint(typeof(IUser), new NetTcpBinding(), new Uri("net.tcp://localhost:6000/IUser"));

			pravniAktServiceHost = new ServiceHost(typeof(PravniAktService));
			pravniAktServiceHost.AddServiceEndpoint(typeof(IPravniAkt), new NetTcpBinding(), new Uri("net.tcp://localhost:6000/IPravniAkt"));
		}

		public void Start()
		{
			userServiceHost.Open();
			pravniAktServiceHost.Open();
			Console.WriteLine("Server host started at " + DateTime.Now);
		}

		public void Stop()
		{
			userServiceHost.Close();
			pravniAktServiceHost.Close();
			Console.WriteLine("Server host closed at " + DateTime.Now);
		}

	}
}
