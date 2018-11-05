using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.Commands
{
	public class CreateUserCommand : ICommand
	{
		private NewUserViewModel NewUserViewModel;
		public CreateUserCommand(NewUserViewModel newUserViewModel)
		{
			NewUserViewModel = newUserViewModel;
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
			return NewUserViewModel.CanCreate;
		}

		public void Execute(object parameter)
		{
			NewUserViewModel.CreateUser();
		}
	}
}
