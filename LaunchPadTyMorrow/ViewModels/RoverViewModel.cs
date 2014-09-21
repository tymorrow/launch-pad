namespace LaunchPadTyMorrow.ViewModels
{
	using Caliburn.Micro;
	using Models;

	class RoverViewModel : PropertyChangedBase
	{
		private RoverModel Model;

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

		public RoverViewModel()
		{
			Model = new RoverModel();
		}

		public void Rove()
		{
			
		}
	}
}
