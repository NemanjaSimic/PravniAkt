using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Client.ViewModel;

namespace Client.Commands
{
	public class NewTackaCommand : ICommand
	{
		private PravniAktViewModel PravniAktViewModel;
		public NewTackaCommand(PravniAktViewModel pravniAktViewModel)
		{
			PravniAktViewModel = pravniAktViewModel;
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
			return PravniAktViewModel.CanMakeNewTacka;
		}

		public void Execute(object parameter)
		{
			PravniAktViewModel.NewTacka();
		}
	}
}
