using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Common.Models;
using Client.Commands;
using System.Windows.Input;
using Common.Enumerations;
using Client.Connection;

namespace Client.ViewModel
{
	public class PravniAktViewModel
	{
		#region Properties
		public DateTime DatumStupanjaNaSnagu { get; set; }
		public Window Window { get; set; }
		public Korisnik User { get; set; }
		public PravniAkt PravniAkt { get; set; }
		public EPravniAktTypes TipPravnogAkta { get; set; }
		public PravniAkt PravniAktToCreate { get; set; }
		public String NaslovPravnogAkta { get; set; }
		public String UvodPravnogAkta { get; set; }
		public bool ZabranaGlava { get; set; }
		public bool PermZabranaGlava { get; set; }
		public bool PermZabranaDela { get; set; }
		public bool ZabranaDela { get; set; }
		public bool ZabranaClana { get; set; }
		public bool ZabranaTacke { get; set; }
		public bool ZabranaStava { get; set; }
		public bool ZabranaOdeljka { get; set; }
		#endregion
		#region Commands
		public ICommand NewDeoCommand
		{
			get;
			private set;
		}

		public ICommand NewGlavaCommand
		{
			get;
			private set;
		}

		public ICommand NewOdeljakCommand
		{
			get;
			private set;
		}
		public ICommand NewClanCommand
		{
			get;
			private set;
		}

		public ICommand NewTackaCommand
		{
			get;
			private set;
		}
		public ICommand NewStavCommand
		{
			get;
			private set;
		}

		public ICommand CreatePravniAktCommand
		{
			get;
			private set;
		}
		#endregion
		public PravniAktViewModel()
		{
			PermZabranaDela = false;
			PermZabranaGlava = false;
			ZabranaDela = false;
			ZabranaGlava = false;
			ZabranaOdeljka = false;
			ZabranaClana = true;
			ZabranaStava = true;
			ZabranaTacke = true;

			PravniAkt = new Zakon();

			NewDeoCommand = new NewDeoCommand(this);
			NewGlavaCommand = new NewGlavaCommand(this);
			NewOdeljakCommand = new NewOdeljakCommand(this);
			NewClanCommand = new NewClanCommand(this);
			NewTackaCommand = new NewTackaCommand(this);
			NewStavCommand = new NewStavCommand(this);
			CreatePravniAktCommand = new CreatePravniAktCommand(this);
		}

		#region NewDeoCommand
		public bool CanMakeNewDeo => !ZabranaDela && !PermZabranaDela;

		public void NewDeo()
		{
			Deo newDeo = new Deo(++PravniAkt.BrojDelova)
			{
				IdUAktu = PravniAkt.ElementiPravnogAkta.Count + 1
			};
			PravniAkt.ElementiPravnogAkta.Add(newDeo);
			ZabranaDela = true;
			ZabranaTacke = true;
			ZabranaStava = true;
			ZabranaOdeljka = true;
			MessageBox.Show("Dodat novi deo!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
		}
		#endregion
		#region NewGlavaCommand
		public bool CanMakeNewGlava => !ZabranaGlava && !PermZabranaGlava;

		public void NewGlava()
		{
			new View.Glava(this).Show();
		}
		#endregion
		#region NewOdeljakCommand
		public bool CanMakeNewOdeljak
		{ get { return !ZabranaOdeljka; } }
		public void NewOdleljak()
		{
			new View.Odeljak(this).Show();
		}
		#endregion
		#region NewClanCommand
		public bool CanMakeNewClan => !ZabranaClana;
		public void NewClan()
		{
			new View.Clan(this).Show();
		}
		#endregion
		#region NewTackaCommand
		public bool CanMakeNewTacka => !ZabranaTacke;
		public void NewTacka()
		{
			new View.Tacka(this).Show();
		}
		#endregion
		#region NewStavCommand
		public bool CanMakeNewStav => !ZabranaStava;
		public void NewStav()
		{
			new View.Stav(this).Show();
		}
		#endregion

		#region CreatePravniAkt
		public bool CanCreatePravniAkt => !String.IsNullOrWhiteSpace(NaslovPravnogAkta) && !String.IsNullOrWhiteSpace(UvodPravnogAkta);
		public void CreatePravniAkt()
		{
			switch (TipPravnogAkta)
			{
				case EPravniAktTypes.Zakon:
					PravniAktToCreate = new Zakon();
					break;
				case EPravniAktTypes.Uredba:
					PravniAktToCreate = new Uredba();
					break;
				case EPravniAktTypes.Odluka:
					PravniAktToCreate = new Odluka();
					break;
				case EPravniAktTypes.Pravilnik:
					PravniAktToCreate = new Pravilnik();
					break;
				default:
					break;
			}

			PravniAktToCreate.Naslov = NaslovPravnogAkta;
			PravniAktToCreate.Uvod = UvodPravnogAkta;
			for (int i = 0; i <= PravniAkt.ElementiPravnogAkta.Count - 1; i++)
			{
				var element = PravniAkt.ElementiPravnogAkta[i];
				PravniAkt.ElementiPravnogAkta.Remove(element);
				element.NaslovPravnogAkta = NaslovPravnogAkta;
				PravniAkt.ElementiPravnogAkta.Add(element);
			}
			PravniAktToCreate.ElementiPravnogAkta = PravniAkt.ElementiPravnogAkta.OrderBy(x => x.IdUAktu).ToList();
			PravniAktToCreate.DatumStupanjaNaSnagu = DatumStupanjaNaSnagu;
			try
			{
				if (Channel.Instance.pravniAktProxy.CreatePravniAkt(PravniAktToCreate))
				{
					Window.Close();
					MessageBox.Show("Uspesno napravljena Pravna Akta!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
				}
				else
				{
					MessageBox.Show("Konflikt pri dodavanju!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);

				}
			}
			catch (Exception)
			{
				MessageBox.Show("Prekid konekcije sa serverom!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
			}

		}
		#endregion

	}
}
