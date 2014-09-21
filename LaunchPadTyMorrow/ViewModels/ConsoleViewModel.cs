namespace LaunchPadTyMorrow.ViewModels
{
	using Caliburn.Micro;
	using Models;

	class ConsoleViewModel : PropertyChangedBase
	{
		private ConsoleModel Model;
		private MainWindowViewModel mainWindow;

		public string Text
		{
			get { return Model.text; }
			set
			{
				Model.text = value;
				NotifyOfPropertyChange(() => Text);
			}
		}

		public ConsoleViewModel(MainWindowViewModel mw)
		{
			Model = new ConsoleModel();
			mainWindow = mw;
			Print("Welcome to Launch Pad!");
		}

		public void Clear()
		{
			Text = string.Empty;
		}
		public void Connect()
		{
			Print("Connected!");
		}
		public void Disconnect()
		{
			Print("Disconnected!");
		}
		public void Print(string message)
		{
			Text += message + System.Environment.NewLine;
		}
	}
}
