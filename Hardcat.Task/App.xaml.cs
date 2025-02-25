namespace Hardcat.Task
{
    public partial class App : Application
    {
		public static Models.TaskViewModel TaskVM { get; } = new Models.TaskViewModel();
		public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
