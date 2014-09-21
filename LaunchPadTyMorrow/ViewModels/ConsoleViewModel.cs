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
