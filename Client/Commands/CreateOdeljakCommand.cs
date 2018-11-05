using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Client.ViewModel;

namespace Client.Commands
{
	public class CreateOdeljakCommand : ICommand		
	{
		private OdeljakVIewModel OdeljakVIewModel;

		public CreateOdeljakCommand(OdeljakVIewModel odeljakVIewModel)
		{
			OdeljakVIewModel = odeljakVIewModel;
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
			return OdeljakVIewModel.CanCreateOdeljak;
		}

		public void Execute(object parameter)
		{
			OdeljakVIewModel.CreateOdeljak();
		}
	}
}
