namespace LaunchPadTyMorrow
{
	using ViewModels;

	public partial class MainWindow
	{
		public MainWindow()
		{
			InitializeComponent();
			DataContext = new MainWindowViewModel();
		}
	}
}
