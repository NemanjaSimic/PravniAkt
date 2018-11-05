using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.Commands
{
	public class CreateGlavaCommand : ICommand
	{
		private GlavaViewModel GlavaViewModel;

		public CreateGlavaCommand(GlavaViewModel glavaViewModel)
		{
			GlavaViewModel = glavaViewModel;
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
			return GlavaViewModel.CanCreateGlava;
		}

		public void Execute(object parameter)
		{
			GlavaViewModel.CreateNewGlava();
		}
	}
}
