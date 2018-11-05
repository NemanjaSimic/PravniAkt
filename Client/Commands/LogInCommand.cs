using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Client.ViewModel;

namespace Client.Commands
{
	public class LogInCommand : ICommand
	{
		private MainWindowViewModel mainWindowViewModel;

		public LogInCommand(MainWindowViewModel main)
		{
			this.mainWindowViewModel = main;
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
			return mainWindowViewModel.CanLogin;
		}

		public void Execute(object parameter)
		{
			mainWindowViewModel.LogIn();
		}
	}
}
