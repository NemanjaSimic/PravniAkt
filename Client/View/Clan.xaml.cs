﻿using System;
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
	/// Interaction logic for Clan.xaml
	/// </summary>
	public partial class Clan : Window
	{
		public Clan(PravniAktViewModel pravniAktViewModel)
		{
			InitializeComponent();
			DataContext = new ClanViewModel() { Window = this, PravniAktViewModel = pravniAktViewModel };
		}
	}
}
