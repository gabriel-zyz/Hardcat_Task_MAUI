using System.Formats.Tar;

namespace Hardcat.Task.Views;

public partial class AddTaskPage : ContentPage
{
	public AddTaskPage()
	{
		InitializeComponent();
	}

	// Handle the navigation and data update when add button clicked
	private async void btnAdd_Clicked(object sender, EventArgs e)
	{
		var description = taskEntry.Text;
		if (!string.IsNullOrWhiteSpace(description))
		{
			// Add the task to the viewmodel
			App.TaskVM.AddTask(description);
			await Shell.Current.GoToAsync("..");
		}
		else
		{
			await DisplayAlert("Error", "Task description cannot be empty!", "OK");
		}
	}

	// Handle the navigation when cancel button clicked
	private async void btnCancel_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("..");
	}
}