﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Client.ViewModel;

namespace Client.Commands
{
	public class ChangeUserInforamtionsCommand : ICommand
	{
		private HomeViewModel HomeViewModel;

		public ChangeUserInforamtionsCommand(HomeViewModel homeViewModel)
		{
			HomeViewModel = homeViewModel;
		}

		public event EventHandler CanExecuteChanged
		{
			add
			{
				CommandManager.RequerySuggested += value;
			}
			remove
			{
				CommandManager.RequerySuggested -= value;
			}
		}

		public bool CanExecute(object parameter)
		{
			return HomeViewModel.CanChange;
		}

		public void Execute(object parameter)
		{
			HomeViewModel.ChangeUserInformations();
		}
	}
}
