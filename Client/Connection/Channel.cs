using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Contracts;
using System.ServiceModel;

namespace Client.Connection
{
	public class Channel
	{
		public IUser userProxy;
		public IPravniAkt pravniAktProxy;

		private static Channel instance;

		public static Channel Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new Channel();
				}
				return instance;
			}
		}

		private Channel()
		{
			ChannelFactory<IUser> factoryUser = new ChannelFactory<IUser>(new NetTcpBinding(), new EndpointAddress("net.tcp://localhost:6000/IUser"));
			userProxy = factoryUser.CreateChannel();

			ChannelFactory<IPravniAkt> factoryPravniAkt = new ChannelFactory<IPravniAkt>(new NetTcpBinding(), new EndpointAddress("net.tcp://localhost:6000/IPravniAkt"));
			pravniAktProxy = factoryPravniAkt.CreateChannel();
		}

	}
}
