namespace LaunchPadTyMorrow.ViewModels
{
	using Caliburn.Micro;
	using Models;

	class RoverViewModel : PropertyChangedBase
	{
		private RoverModel Model;

		public RoverViewModel()
		{
			Model = new RoverModel();
		}

		public void Rove()
		{
			
		}
	}
}
