namespace Hardcat.Task.Views;
using Hardcat.Task.Models;
using System.Collections.ObjectModel;

public partial class TaskPage : ContentPage
{

	public TaskPage()
	{
		InitializeComponent();

		// bind the viewmodel with view
		BindingContext = App.TaskVM;
	}

	// Handle the navigation when the add button clicked
	private void OnAddTaskClicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(nameof(AddTaskPage));
	}

	// Handle the isCompleted update when the checkbox checked
	private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		if (sender is CheckBox checkBox && checkBox.BindingContext is Task task)
		{
			task.IsCompleted = e.Value;
		}
	}
}
