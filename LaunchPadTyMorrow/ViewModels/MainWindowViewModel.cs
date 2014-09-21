namespace LaunchPadTyMorrow.ViewModels
{
	using Caliburn.Micro;
	using Models;

	class MainWindowViewModel : PropertyChangedBase
	{
		private MainWindowModel Model;

		public ConsoleViewModel Console
		{
			get { return Model.console; }
			set
			{
				Model.console = value;
				NotifyOfPropertyChange(() => Console);
			}
		}

		public MainWindowViewModel()
		{
			Model = new MainWindowModel
			{
				console = new ConsoleViewModel()
			};
		}
	}
}
