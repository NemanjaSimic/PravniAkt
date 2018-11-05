using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Client.Commands;
using Client.Connection;
using Client.View;
using Common.Models;

namespace Client.ViewModel
{
	public class MainWindowViewModel
	{


		public Window Window { get; set; }
		public String Username { get; set; }
		public String Password { get; set; }

		public ICommand LogInCommand
		{
			get;
			private set;
		}

		public MainWindowViewModel()
		{
			LogInCommand = new LogInCommand(this);
		}

		public bool CanLogin
		{
			get
			{
				return !String.IsNullOrEmpty(Username) && !String.IsNullOrEmpty(Password);
			}
		}

		public void LogIn()
		{
			try
			{
				Korisnik user = Channel.Instance.userProxy.LogIn(Username, Password);
				if (user != null)
				{
					new Home(user).Show();
					Window.Close();
					
				}
				else
				{
					MessageBox.Show("Losa kombinacija username/password !", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);

				}

			}
			catch (Exception)
			{

				MessageBox.Show("Prekid konekcije sa serverom!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

	}
}
