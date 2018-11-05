using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Client.ViewModel;

namespace Client.Commands
{
	public class CreatePravniAktCommand : ICommand
	{
		private PravniAktViewModel PravniAktViewModel;

		public CreatePravniAktCommand(PravniAktViewModel pravniAktViewModel)
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
			return PravniAktViewModel.CanCreatePravniAkt;
		}

		public void Execute(object parameter)
		{
			PravniAktViewModel.CreatePravniAkt();
		}
	}
}
