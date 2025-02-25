namespace Hardcat.Task.Views;
using Hardcat.Task.Models;
using System.Collections.ObjectModel;

public partial class TaskPage : ContentPage
{

	public TaskPage()
	{
		InitializeComponent();

		BindingContext = App.TaskVM;
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
