using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.Commands
{
	public class ChangeInformationsCommand : ICommand
	{
		private UserInformationsViewModel UserInformationsViewModel;

		public ChangeInformationsCommand(UserInformationsViewModel userInformationsViewModel)
		{
			UserInformationsViewModel = userInformationsViewModel;
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
			var tip = UserInformationsViewModel.GetType();
			return UserInformationsViewModel.CanChange;
		}

		public void Execute(object parameter)
		{
			UserInformationsViewModel.ChangeInformation();
		}
	}
}
