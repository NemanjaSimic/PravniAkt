using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;
using Common.Models;

namespace Common.Contracts
{
	[ServiceContract]
	public interface IUser
	{
		[OperationContract]
		Korisnik LogIn(String username, String password);
		[OperationContract]
		bool CreateNewUser(Korisnik newUser);
		[OperationContract]
		bool ChangeUserInformations(Korisnik user);
	}
}
