using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardcat.Task.Models
{
    public class TaskViewModel
    {
		// Observablecollection can update view when the collection is changed
		public ObservableCollection<Task> Tasks { get; } = new ObservableCollection<Task>();

		// Constructor with sample tasks
		public TaskViewModel()
		{
			Tasks.Add(new Task { Id = 1, Description = "Task 1", IsCompleted = false });
			Tasks.Add(new Task { Id = 2, Description = "Task 2", IsCompleted = false });
			Tasks.Add(new Task { Id = 3, Description = "Task 3", IsCompleted = false });
		}

		// Method to add a new task
		public void AddTask(string description)
		{
			int newId = Tasks.Any() ? Tasks.Max(t => t.Id) + 1 : 1;
			Tasks.Add(new Task { Id = newId, Description = description });
		}
	}
}
