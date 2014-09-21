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
			Text = "Welcome to Launch Pad!" + System.Environment.NewLine;
		}

		public void Clear()
		{
			Text = string.Empty;
		}
		public void Connect()
		{
			Text += "Connected!" + System.Environment.NewLine;
		}
		public void Disconnect()
		{
			Text += "Disconnected!" + System.Environment.NewLine;
		}
	}
}
