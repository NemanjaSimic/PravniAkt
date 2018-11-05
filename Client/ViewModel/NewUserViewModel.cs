using Client.View;
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
    public class NewUserViewModel
    {
		public Korisnik User { get; set; }
		public Korisnik NewUser { get; set; }
		public Window Window { get; set; }


		public ICommand CreateUserCommand
		{
			get;
			private set;
		}

		public NewUserViewModel()
		{
			NewUser = new Korisnik();
			
			CreateUserCommand = new CreateUserCommand(this);
		}

		public bool CanCreate
		{
			get { return !String.IsNullOrEmpty(NewUser.Ime) && !String.IsNullOrEmpty(NewUser.Prezime) && !String.IsNullOrEmpty(NewUser.Username) && !String.IsNullOrEmpty(NewUser.Sifra); }
		}

		public void CreateUser()
		{
			Korisnik newUser = new Korisnik(NewUser.Ime, NewUser.Prezime, NewUser.Username, NewUser.Sifra, NewUser.Tip);

			try
			{
				if (Channel.Instance.userProxy.CreateNewUser(newUser))
				{
					MessageBox.Show("Uspesno dodat novi korisnik!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
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
