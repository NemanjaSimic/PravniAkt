using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Client.ViewModel;
using Common.Models;
using Common.Enumerations;

namespace Client.View
{
	/// <summary>
	/// Interaction logic for Home.xaml
	/// </summary>
	public partial class Home : Window
	{
		public Home(Korisnik user)
		{
			InitializeComponent();
			DataContext = new HomeViewModel() { Window = this , User = user};

			if (user.Tip == EUserTypes.Korisnik)
			{
				DodajKorisnikaButton.Visibility = Visibility.Collapsed;
			}
		}
	}
}
