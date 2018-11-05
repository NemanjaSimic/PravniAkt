using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Enumerations;
using Common.Models;

namespace Common.Database
{
	public class DBManager
	{
		private DBManager() { }
		private static DBManager instance;
		public static DBManager Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new DBManager();
				}

				return instance;
			}
		}

		public Korisnik CheckUser(String username, String password)
		{
			using (var dbContext = new DatabaseContext())
			{
				foreach (var user in dbContext.Korisnici)
				{
					if (user.Username.Equals(username) && user.Sifra.Equals(password))
					{
						return user;
					}
				}				
			}
			return null;
		}

		public bool AddUser(Korisnik user)
		{
			if (CheckUser(user.Username, user.Sifra) != null)
			{
				return false;
			}
			using (var dbContext = new DatabaseContext())
			{
				dbContext.Korisnici.Add(user);
				dbContext.SaveChanges();
				return true;
			}
		}

		public bool ChangeUserInformations(Korisnik user)
		{
			Korisnik userForChange = new Korisnik();

			using (var dbContext = new DatabaseContext())
			{
				foreach (var User in dbContext.Korisnici.ToList())
				{
					if (User.Username.Equals(user.Username))
					{
						userForChange = User;
					}
				}
				if (userForChange.Username != null)
				{
					dbContext.Korisnici.Remove(userForChange);
					dbContext.Korisnici.Add(user);
					dbContext.SaveChanges();
					return true;
				}
				else
				{
					return false;
				}
				
			}
		}

		public void InitialAdmin()
		{
			using (var dbContext = new DatabaseContext())
			{
				bool postoji = false;
				foreach (var user in dbContext.Korisnici)
				{
					if (user.Username.Equals("admin") && user.Username.Equals("admin"))
					{
						postoji = true;
					}
				}

				if (!postoji)
				{
					dbContext.Korisnici.Add(new Korisnik("admin", "admin", "admin", "admin", EUserTypes.Admin));
					dbContext.SaveChanges();
				}
			}
		}

		public bool AddPravniAkt(PravniAkt pravniAkt)
		{
			using (var dbContext = new DatabaseContext())
			{
				bool postoji = false;
				foreach (var akt in dbContext.PravniAkti)
				{
					if (akt.Naslov.Equals(pravniAkt.Naslov))
					{
						postoji = true;
					}
				}

				if (!postoji)
				{
					dbContext.PravniAkti.Add(pravniAkt);
					foreach (var item in pravniAkt.ElementiPravnogAkta)
					{
						dbContext.ElementiPravnogAkta.Add(item);
					}
					dbContext.SaveChanges();
					return true;
				}
				else
				{
					return false;
				}
			}
		}

		public List<PravniAkt> GetAllPravniAkt()
		{
			List<PravniAkt> result = new List<PravniAkt>();
			using (var dbContext = new DatabaseContext())
			{
				
				foreach (var akt in dbContext.PravniAkti)
				{
					result.Add(akt);
				}				
			}

			return result;
		}

		public void DeleteAkt(string naslov)
		{
			List<PravniAkt> listaAkta = new List<PravniAkt>();
			List<ElementPravnogAkta> listaElemenata = new List<ElementPravnogAkta>();
			using (var dbContext = new DatabaseContext())
			{
				foreach (var item in dbContext.PravniAkti)
				{
					if (item.Naslov.Equals(naslov))
					{
						listaAkta.Add(item);
					}
				}

				foreach (var item in dbContext.ElementiPravnogAkta)
				{
					if (item.NaslovPravnogAkta.Equals(naslov))
					{
						listaElemenata.Add(item);
					}
				}

				for (int i = 0; i < listaElemenata.Count -1; i++)
				{
					dbContext.ElementiPravnogAkta.Remove(listaElemenata[i]);
				}

				dbContext.PravniAkti.Remove(listaAkta.First());
				dbContext.SaveChanges();
 			}
		}
	}
}
