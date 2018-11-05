using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Client.Commands;
using Common.Models;

namespace Client.ViewModel
{
	public class ClanViewModel
	{
		public Window Window { get; set; }
		public String Naslov { get; set; }
		public PravniAktViewModel PravniAktViewModel { get; set; }
		public ICommand CreateClanCommand
		{
			get;
			private set;
		}

		public ClanViewModel()
		{
			CreateClanCommand = new CreateClanCommand(this);
		}

		public bool CanCreateClan
		{
			get { return !String.IsNullOrEmpty(this.Naslov); }
		}
		public void CreateClan()
		{
			Clan newClan = new Clan(++PravniAktViewModel.PravniAkt.BrojClana, Naslov)
			{
				IdUAktu = PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Count + 1,
				NaslovPravnogAkta = PravniAktViewModel.PravniAkt.Naslov
			};

			List<ElementPravnogAkta> lista = PravniAktViewModel.PravniAkt.ElementiPravnogAkta.OrderBy(x => x.IdUAktu).ToList();

			for (int i = lista.Count - 1; i <= 0; i--)
			{
				if (!lista[i].GetType().Name.Equals("Tacka") && !lista[i].GetType().Name.Equals("Stav") && !lista[i].GetType().Name.Equals("Clan"))
				{
					var element = lista[i];
					element.Elementi.Add(newClan);
					PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Remove(element);
					newClan.IdNadElementa = element.IdUAktu;
					PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Add(element);
					break;
				}
			}

			PravniAktViewModel.ZabranaStava = false;
			PravniAktViewModel.ZabranaTacke = false;
			PravniAktViewModel.ZabranaDela = true;
			PravniAktViewModel.ZabranaGlava = true;
			PravniAktViewModel.ZabranaClana = true;
			PravniAktViewModel.ZabranaOdeljka = true;
			PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Add(newClan);
			Window.Close();
			MessageBox.Show("Dodat novi clan!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
		}
	}
}
