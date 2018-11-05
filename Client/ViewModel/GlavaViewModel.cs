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
	public class GlavaViewModel
	{
		public Window Window { get; set; }
		public String Naslov {get; set;}
		public PravniAktViewModel PravniAktViewModel { get; set; }
		public ICommand CreateGlavaCommand
		{
			get;
			private set;
		}

		public GlavaViewModel()
		{
			CreateGlavaCommand = new CreateGlavaCommand(this);
		}

		public bool CanCreateGlava
		{
			get { return true; }
		}
		public void CreateNewGlava()
		{
			Glava newGlava = new Glava(++PravniAktViewModel.PravniAkt.BrojGlava, Naslov)
			{
				IdUAktu = PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Count + 1,
				NaslovPravnogAkta = PravniAktViewModel.PravniAkt.Naslov
			};

			if (PravniAktViewModel.PravniAkt.BrojDelova != 0)
			{
				int i = 0;
				Deo deo = new Deo(0);
				foreach (var item in PravniAktViewModel.PravniAkt.ElementiPravnogAkta)
				{
					if (item.GetType().Name.Equals("Deo"))
					{
						i++;
					}

					if (i == PravniAktViewModel.PravniAkt.BrojDelova)
					{
						newGlava.IdNadElementa = item.IdUAktu;
						newGlava.TipNadElementa = Common.Enumerations.EElementiPravnogAktaTypes.Deo;
						deo = (Deo)item;
						break;
					}
				}
				PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Remove(deo);
				deo.Elementi.Add(newGlava);
				PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Add(deo);
			}
			else
			{
				PravniAktViewModel.PermZabranaDela = true;
			}
			PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Add(newGlava);
			PravniAktViewModel.ZabranaClana = false;
			PravniAktViewModel.ZabranaOdeljka = false;
			PravniAktViewModel.ZabranaTacke = true;
			PravniAktViewModel.ZabranaStava = true;
			Window.Close();
			MessageBox.Show("Dodata nova glava!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
		}
	}
}
