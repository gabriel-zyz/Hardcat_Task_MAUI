namespace Hardcat.Task.Views;
using Hardcat.Task.Models;
using System.Collections.ObjectModel;

public partial class TaskPage : ContentPage
{
	public ObservableCollection<Task> Tasks { get; set; }
	public TaskPage()
	{
		InitializeComponent();

		Tasks = new ObservableCollection<Task>
		{
			new Task { Id = 1, Description = "Task 1" },
			new Task { Id = 2, Description = "Task 2" },
			new Task { Id = 3, Description = "Task 3" }
		};

		BindingContext = this;
	}

	private void OnAddTaskClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(AddTaskPage));
	}

	private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		if (sender is CheckBox checkBox && checkBox.BindingContext is Task task)
		{
			task.IsCompleted = e.Value;
		}
	}
}
