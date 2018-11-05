using Client.ViewModel;
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
using Common.Enumerations;

namespace Client.View
{
    /// <summary>
    /// Interaction logic for NewUser.xaml
    /// </summary>
    public partial class NewUser : Window
    {
        public NewUser(Korisnik user)
        {
            InitializeComponent();
			DataContext = new NewUserViewModel() { Window = this, User = user };

			ComboBoxTipKorisinika.ItemsSource = Enum.GetValues(typeof(EUserTypes)).Cast<EUserTypes>().ToList();
		}

		
		
	}
}
