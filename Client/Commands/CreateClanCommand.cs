using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Client.ViewModel;

namespace Client.Commands
{
	public class CreateClanCommand : ICommand
	{
		private ClanViewModel ClanViewModel;
		public CreateClanCommand(ClanViewModel clanViewModel)
		{
			ClanViewModel = clanViewModel;
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
			return ClanViewModel.CanCreateClan;
		}

		public void Execute(object parameter)
		{
			ClanViewModel.CreateClan();
		}
	}
}
