namespace LaunchPadTyMorrow.Views
{
	using ViewModels;

	public partial class ConsoleView
	{
		public ConsoleView()
		{
			InitializeComponent();
			DataContext = new ConsoleViewModel();
		}
	}
}
