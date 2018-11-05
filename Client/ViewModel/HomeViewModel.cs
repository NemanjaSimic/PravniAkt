using Client.Commands;
using Client.View;
using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Common.Enumerations;
using Client.Connection;
using System.Threading;
using System.ComponentModel;

namespace Client.ViewModel
{
	public class HomeViewModel
	{
		private BindingList<Common.Models.PravniAkt> pravneAkte;
		#region Properties
		public Window Window { get; set; }
		public Korisnik User { get; set; }
		public String Naslov { get { return "Dobrodosli, " + User.Username; } }
		public BindingList<Common.Models.PravniAkt> PravneAkte
		{
			get { return pravneAkte; }
			set { pravneAkte = value; OnPropertyChanged("Gradovi"); }
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler handler = PropertyChanged;

			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public Common.Models.PravniAkt PravniAktToDelete { get; set; }
		#endregion

		#region Commands
		public ICommand CreateNewUserCommand
		{
			get;
			private set;
		}

		public ICommand ChangeUserInformationsCommand
		{
			get;
			private set;
		}

		public ICommand NewPravniAktCommand
		{
			get;
			private set;
		}
		public ICommand DeleteAktCommand
		{
			get;
			private set;
		}

		#endregion

		public HomeViewModel()
		{
			CreateNewUserCommand = new CreateNewUserCommand(this);
			ChangeUserInformationsCommand = new ChangeUserInforamtionsCommand(this);
			NewPravniAktCommand = new NewPravniAktCommand(this);
			DeleteAktCommand = new DeleteAktCommand(this);

			PravneAkte = new BindingList<Common.Models.PravniAkt>();
			

			PravniAktToDelete = new Zakon();

			Task t1 = new Task(() =>
			{
				while (true)
				{
					Thread.Sleep(1000);
					//Letovi = new BindingList<LetPrikaz>(Channel.Instance.flyghtsProxy.GetFlyghts().ToList());
					//Gradovi = new BindingList<Grad>(Channel.Instance.citiesProxy.GetCities().ToList());
					//Avioni = new BindingList<Avion>(Channel.Instance.airplaneProxy.GetAirplanes().ToList());

					PravneAkte = new BindingList<Common.Models.PravniAkt>(Channel.Instance.pravniAktProxy.PravneAkte().ToList());
				}
			});

			t1.Start();
		}

		#region CreateNewUser
		public bool CanCreate
		{
			get {return (User.Tip == EUserTypes.Admin) ? true : false;  }
		}

		public void CreateNewUser()
		{
			try
			{
				new NewUser(User).Show();
				
			}
			catch (Exception)
			{
				MessageBox.Show("Greska u konekciji sa serverom!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}
		#endregion

		#region ChangeUserInformations

		public bool CanChange
		{
			get { return true; }
		}

		public void ChangeUserInformations()
		{
			new UserInformations(User).Show();
		}

		#endregion

		#region NewPravniAkt
		public bool CanCreateNewPravniAkt
		{
			get { return true; }
		}
		public void NewPravniAkt()
		{
			new View.PravniAkt(User).Show();
		}
		#endregion

		#region DeleteAkt
		public bool CanDelete => !String.IsNullOrEmpty(PravniAktToDelete.Naslov);
		public void DeleteAkt()
		{

			try
			{
				Channel.Instance.pravniAktProxy.DeleteAkt(PravniAktToDelete.Naslov);
				MessageBox.Show("Uspesno izbrisana Pravna Akta!", "Obavestenje", MessageBoxButton.OK, MessageBoxImage.Information);
				
			}
			catch (Exception)
			{
				MessageBox.Show("Prekid konekcije sa serverom!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}


		#endregion
	}
}
