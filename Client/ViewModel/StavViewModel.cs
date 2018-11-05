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
	public class StavViewModel
	{
		public Window Window { get; set; }
		public String Sadrzaj { get; set; }
		public PravniAktViewModel PravniAktViewModel { get; set; }
		public ICommand CreateStavCommand
		{
			get;
			private set;
		}
		public StavViewModel()
		{
			CreateStavCommand = new CreateStavCommand(this);
		}

		public bool CanCreate => true;

		public void CreateStav()
		{
			List<ElementPravnogAkta> lista = PravniAktViewModel.PravniAkt.ElementiPravnogAkta.OrderBy(x => x.IdUAktu).ToList();

			for (int i = lista.Count - 1; i <= 0; i--)
			{
				if (lista[i].GetType().Name.Equals("Clan"))
				{
					
						var element = (Clan)lista[i];
						Stav newStav = new Stav(Sadrzaj)
						{
							IdUAktu = PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Count + 1,
							NaslovPravnogAkta = PravniAktViewModel.PravniAkt.Naslov,
							TipNadElementa = Common.Enumerations.EElementiPravnogAktaTypes.Clan
						};
						element.Elementi.Add(newStav);
						PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Remove(element);
						newStav.IdNadElementa = element.IdUAktu;
						PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Add(element);
						PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Add(newStav);
						break;					
				}
			}
			PravniAktViewModel.ZabranaStava = false;
			PravniAktViewModel.ZabranaTacke = false;
			PravniAktViewModel.ZabranaDela = false;
			PravniAktViewModel.ZabranaGlava = false;
			PravniAktViewModel.ZabranaClana = false;
			PravniAktViewModel.ZabranaOdeljka = false;
			Window.Close();
			MessageBox.Show("Dodat nov stav!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);

		}
	}
}
