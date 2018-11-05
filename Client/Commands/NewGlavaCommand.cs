using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.Commands
{
	public class NewGlavaCommand : ICommand
	{
		private PravniAktViewModel PravniAktViewModel;

		public NewGlavaCommand(PravniAktViewModel pravniAktViewModel)
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
			return PravniAktViewModel.CanMakeNewGlava;
		}

		public void Execute(object parameter)
		{
			PravniAktViewModel.NewGlava();
		}
	}
}
