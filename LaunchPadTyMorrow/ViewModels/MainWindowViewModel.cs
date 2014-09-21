using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchPadTyMorrow.ViewModels
{
	using Caliburn.Micro;
	using Models;

	class MainWindowViewModel : PropertyChangedBase
	{
		private MainWindowModel Model;

		public MainWindowViewModel()
		{
			Model = new MainWindowModel();
		}
	}
}
