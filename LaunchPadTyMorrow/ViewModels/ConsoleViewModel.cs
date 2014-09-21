using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchPadTyMorrow.ViewModels
{
	using Caliburn.Micro;
	using Models;

	class ConsoleViewModel : PropertyChangedBase
	{
		private ConsoleModel Model;

		public ConsoleViewModel()
		{
			Model = new ConsoleModel();
		}

	}
}
