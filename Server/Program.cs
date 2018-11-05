using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
	class Program
	{
		static void Main(string[] args)
		{
			ServerHost sh = new ServerHost();
			sh.Start();
			Console.WriteLine("Press any key to stop server....");			
			Console.ReadLine();
			sh.Stop();
		}
	}
}
