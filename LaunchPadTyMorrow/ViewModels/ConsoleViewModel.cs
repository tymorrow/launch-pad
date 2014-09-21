namespace LaunchPadTyMorrow.ViewModels
{
	using Caliburn.Micro;
	using Models;

	class ConsoleViewModel : PropertyChangedBase
	{
		private ConsoleModel Model;

		public string Text
		{
			get { return Model.text; }
			set
			{
				Model.text = value;
				NotifyOfPropertyChange(() => Text);
			}
		}

		public ConsoleViewModel()
		{
			Model = new ConsoleModel();
		}

	}
}
