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
	public class UserService : IUser
	{
		public Korisnik LogIn(String username, String password)
		{
			return DBManager.Instance.CheckUser(username, password);
		}

		public bool CreateNewUser(Korisnik newUser)
		{
			return DBManager.Instance.AddUser(newUser);
		}

		public bool ChangeUserInformations(Korisnik user)
		{
			return DBManager.Instance.ChangeUserInformations(user);
		}
	}
}
