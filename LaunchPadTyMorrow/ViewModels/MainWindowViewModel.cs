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
		public RoverViewModel Rover
		{
			get { return Model.rover; }
			set
			{
				Model.rover = value;
				NotifyOfPropertyChange(() => Rover);
			}
		}

		public MainWindowViewModel()
		{
			Model = new MainWindowModel
			{
				console = new ConsoleViewModel(this),
				rover = new RoverViewModel(this)
			};
		}
	}
}
