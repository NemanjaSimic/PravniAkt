using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Common.Models;

namespace Common.Database
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext() : base("PravniAktBaza")
		{
			//Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext, Config>());

		}

		public DbSet<PravniAkt> PravniAkti { get; set; }
		public DbSet<ElementPravnogAkta> ElementiPravnogAkta { get; set; }
		public DbSet<Korisnik> Korisnici { get; set; }

	}
}
