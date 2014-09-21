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
