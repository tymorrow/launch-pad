namespace LaunchPadTyMorrow.Models
{
	class RoverModel
	{
		internal string roverName;
		internal int speed;
		internal double temperature;
		internal bool isConnected;

		public RoverModel()
		{
			roverName = string.Empty;
			speed = 0;
			temperature = 0;
			isConnected = false;
		}
	}
}
