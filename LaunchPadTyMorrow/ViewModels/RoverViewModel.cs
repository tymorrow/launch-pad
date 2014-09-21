namespace LaunchPadTyMorrow.ViewModels
{
	using System.Threading.Tasks;
	using Caliburn.Micro;
	using Models;

	class RoverViewModel : PropertyChangedBase
	{
		private RoverModel Model;
		private MainWindowViewModel mainWindow;

		public string RoverName
		{
			get { return Model.roverName; }
			set
			{
				Model.roverName = value;
				NotifyOfPropertyChange(() => RoverName);
			}
		}
		public int Speed
		{
			get { return Model.speed; }
			set
			{
				Model.speed = value;
				NotifyOfPropertyChange(() => Speed);
			}
		}
		public double Temperature
		{
			get { return Model.temperature; }
			set
			{
				Model.temperature = value;
				NotifyOfPropertyChange(() => Temperature);
			}
		}
		public bool IsConnected
		{
			get { return Model.isConnected; }
			set
			{
				Model.isConnected = value;
				NotifyOfPropertyChange(() => IsConnected);
			}
		}

		public RoverViewModel(MainWindowViewModel mw)
		{
			Model = new RoverModel
			{
				roverName = "Phoenix I"
			};
			mainWindow = mw;
		}

		public void Rove()
		{
			if (IsConnected)
			{
				Task.Run(async () =>
				{
					Temperature = 50;
					for (var i = 0; i < 15; i++)
					{
						Speed = i;
						Temperature += i / 4.0;
						await Task.Delay(200);
					}
					for (var i = 14; i >= 0; i--)
					{
						Speed = i;
						Temperature -= i / 4.0;
						await Task.Delay(200);
					}
				});
			}
			else
			{
				// Something later
			}
		}
	}
}
