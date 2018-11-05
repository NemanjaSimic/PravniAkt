using Client.Commands;
using Client.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Common.Models;

namespace Client.ViewModel
{
	public class OdeljakVIewModel
	{
		public Window Window { get; set; }
		public String Naslov { get; set; }
		public PravniAktViewModel PravniAktViewModel { get; set; }
		public ICommand CreateOdeljakCommand
		{
			get;
			private set;
		}

		public OdeljakVIewModel()
		{
			CreateOdeljakCommand = new CreateOdeljakCommand(this);
		}

		public bool CanCreateOdeljak
		{
			get { return true; }
		}

		public void CreateOdeljak()
		{
			Common.Models.Odeljak newOdeljak = new Common.Models.Odeljak(++PravniAktViewModel.PravniAkt.BrojOdeljaka, Naslov)
			{
				IdUAktu = PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Count + 1,
				NaslovPravnogAkta = PravniAktViewModel.PravniAkt.Naslov
			};

			if (PravniAktViewModel.PravniAkt.BrojGlava != 0)
			{
				int i = 0;
				Common.Models.Glava glava = new Common.Models.Glava(1,"");
				foreach (var item in PravniAktViewModel.PravniAkt.ElementiPravnogAkta)
				{
					if (item.GetType().Name.Equals("Glava"))
					{
						i++;
					}

					if (i == PravniAktViewModel.PravniAkt.BrojGlava)
					{
						newOdeljak.IdNadElementa = item.IdUAktu;
						newOdeljak.TipNadElementa = Common.Enumerations.EElementiPravnogAktaTypes.Glava;
						glava = (Common.Models.Glava)item;
						break;
					}
				}
				PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Remove(glava);
				glava.Elementi.Add(newOdeljak);
				PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Add(glava);
			}
			else
			{
				PravniAktViewModel.PermZabranaGlava = true;
				PravniAktViewModel.PermZabranaDela = true;
			}
			PravniAktViewModel.ZabranaClana = false;
			PravniAktViewModel.ZabranaDela = true;
			PravniAktViewModel.ZabranaGlava = true;
			PravniAktViewModel.ZabranaTacke = true;
			PravniAktViewModel.ZabranaStava = true;
			PravniAktViewModel.PravniAkt.ElementiPravnogAkta.Add(newOdeljak);
			Window.Close();
			MessageBox.Show("Dodat nova odeljak!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
		}
		
	}
}
