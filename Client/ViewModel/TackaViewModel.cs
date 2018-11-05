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
	public class TackaViewModel
	{
		public Window Window { get; set; }
		public String Sadrzaj { get; set; }
		public PravniAktViewModel PravniAktViewModel { get; set; }
		public ICommand CreateTackaCommand
		{
			get;
			private set;
		}
		public TackaViewModel()
		{
			CreateTackaCommand = new CreateTackaCommand(this);
		}

		public bool CanCreateTacka => !String.IsNullOrEmpty(Sadrzaj);

		public void CreateTacka()
		{
			List<ElementPravnogAkta> lista = PravniAktViewModel.PravniAkt.ElementiPravnogAkta.OrderBy(x => x.IdUAktu).ToList();

			for (int i = lista.Count - 1; i <= 0; i--)
			{
				if (lista[i].GetType().Name.Equals("Clan") || lista[i].GetType().Name.Equals("Stav"))
				{
					if (lista[i].GetType().Name.Equals("Clan"))
					{
						var element = (Clan)lista[i];
						Tacka newTacka = new Tacka(++element.BrojTacaka, Sadrzaj)
						{
							IdUAktu = PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Count + 1,
							NaslovPravnogAkta = PravniAktViewModel.PravniAkt.Naslov,
							TipNadElementa = Common.Enumerations.EElementiPravnogAktaTypes.Clan
						};
						element.Elementi.Add(newTacka);
						PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Remove(element);
						newTacka.IdNadElementa = element.IdUAktu;
						PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Add(element);
						PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Add(newTacka);
						break;
					}
					else
					{
						var element = (Stav)lista[i];
						Tacka newTacka = new Tacka(++element.BrojTacaka, Sadrzaj)
						{
							IdUAktu = PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Count + 1,
							NaslovPravnogAkta = PravniAktViewModel.PravniAkt.Naslov,
							TipNadElementa = Common.Enumerations.EElementiPravnogAktaTypes.Stav
						};
						element.Elementi.Add(newTacka);
						PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Remove(element);
						newTacka.IdNadElementa = element.IdUAktu;
						PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Add(element);
						PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Add(newTacka);
						break;
					}
				}
			}

			PravniAktViewModel.ZabranaStava = false;
			PravniAktViewModel.ZabranaTacke = false;
			PravniAktViewModel.ZabranaDela = false;
			PravniAktViewModel.ZabranaGlava = false;
			PravniAktViewModel.ZabranaClana = false;
			PravniAktViewModel.ZabranaOdeljka = false;	
			Window.Close();
			MessageBox.Show("Dodata nova tacka!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
		}
	}
}
