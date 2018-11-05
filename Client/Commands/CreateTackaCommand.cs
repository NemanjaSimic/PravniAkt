using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Client.ViewModel;

namespace Client.Commands
{
	public class CreateTackaCommand : ICommand
	{
		private TackaViewModel TackaViewModel;
		public CreateTackaCommand(TackaViewModel tackaViewModel)
		{
			TackaViewModel = tackaViewModel;
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
			return TackaViewModel.CanCreateTacka;
		}

		public void Execute(object parameter)
		{
			TackaViewModel.CreateTacka();
		}
	}
}
