using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Client.Commands;
using Client.Connection;

namespace Client.ViewModel
{
	public class UserInformationsViewModel
	{
		public Window Window { get; set; }
		public Korisnik User { get; set; }

		public ICommand ChangeInformationsCommand
		{
			get;
			private set;
		}

		public UserInformationsViewModel()
		{
			ChangeInformationsCommand = new ChangeInformationsCommand(this);
			User = new Korisnik();
		}

		public bool CanChange
		{
			get { return !String.IsNullOrEmpty(User.Ime.Trim()) && !String.IsNullOrEmpty(User.Prezime.Trim()) && !String.IsNullOrEmpty(User.Sifra.Trim()); }
		}

		public void ChangeInformation()
		{
			try
			{
				if (Channel.Instance.userProxy.ChangeUserInformations(User))
				{
					MessageBox.Show("Uspesno sacuvane izmene!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
					Window.Close();
				}
				else
				{
					MessageBox.Show("Neispravno uneseni podaci!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Prekid konekcije sa serverom!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}
 	}
}
