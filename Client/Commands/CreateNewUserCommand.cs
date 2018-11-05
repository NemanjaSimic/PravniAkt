using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.Commands
{
	public class CreateNewUserCommand : ICommand
	{
		private HomeViewModel homeViewModel;

		public CreateNewUserCommand(HomeViewModel hwm)
		{
			this.homeViewModel = hwm;
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
			return homeViewModel.CanCreate;
		}

		public void Execute(object parameter)
		{
			this.homeViewModel.CreateNewUser();
		}
	}
}
