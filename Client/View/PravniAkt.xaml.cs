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
using Client.ViewModel;
using Common.Models;

namespace Client.View
{
	/// <summary>
	/// Interaction logic for PravniAkt.xaml
	/// </summary>
	public partial class PravniAkt : Window
	{
		public PravniAkt(Korisnik user)
		{
			InitializeComponent();
			DataContext = new PravniAktViewModel() { Window = this, User = user};
			Datepicker.SelectedDate = DateTime.Today;
			Datepicker.DisplayDate = DateTime.Today;
			TipoviAktaComboBox.ItemsSource = Enum.GetValues(typeof(EPravniAktTypes)).Cast<EPravniAktTypes>().ToList();
		}

	}
}
