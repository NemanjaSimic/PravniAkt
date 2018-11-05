using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Client.ViewModel;

namespace Client.Commands
{
	public class CreateStavCommand : ICommand
	{
		private StavViewModel StavViewModel;
		public CreateStavCommand(StavViewModel stavViewModel)
		{
			StavViewModel = stavViewModel;
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
			return StavViewModel.CanCreate;
		}

		public void Execute(object parameter)
		{
			StavViewModel.CreateStav();
		}
	}
}
