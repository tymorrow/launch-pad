namespace LaunchPadTyMorrow.Models
{
	class RoverModel
	{
		internal string name;
		internal int speed;
		internal double temperature;
		internal bool isConnected;

		public RoverModel()
		{
			name = string.Empty;
			speed = 0;
			temperature = 0;
			isConnected = false;
		}
	}
}
