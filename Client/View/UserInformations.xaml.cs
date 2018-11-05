using Common.Models;
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

namespace Client.View
{
	/// <summary>
	/// Interaction logic for UserInformations.xaml
	/// </summary>
	public partial class UserInformations : Window
	{
		public UserInformations(Korisnik user)
		{
			InitializeComponent();
			DataContext = new UserInformationsViewModel() { Window = this, User = user };
		}
	}
}
