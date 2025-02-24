using Hardcat.Task.Views;

namespace Hardcat.Task
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(TaskPage), typeof(TaskPage));
            Routing.RegisterRoute(nameof(AddTaskPage), typeof(AddTaskPage));
		}
    }
}
