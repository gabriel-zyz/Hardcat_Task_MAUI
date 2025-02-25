## To Do List App (.NET MAUI)

A simple To-Do List app built with .NET MAUI. Users can use this app to add tasks, mark as completed, and view tasks in a list.


### Project Structure
- #### Views
  - **TaskPage.xaml**: Main screen which displays task list
  - **TaskPage.xaml.cs**: Handle the logic for TaskPage
  - **AddTaskPage.xaml**: Screen for task adding
  - **AddTaskPage.xaml.cs**: Handle the logic for AddTaskPage
- #### Models
  - **Task.cs**: Defines the fields of task
  - **TaskViewModel.cs**: Handle task data


### How to Run the Project
1. Clone the Github repo: https://github.com/gabriel-zyz/Hardcat_Task_MAUI.git
2. Open the project in Visual Studio
3. Run the app in emulator(I used Pixel 4 - API 34 for testing)


### How to Use the App
- View added tasks in the list on the main screen
- Mark added tasks completed in the check boxes on the list
- To visit the task-adding screen, click "+" button on topbar of main screen
- Add new tasks on task-adding screen(the description can not be empty)
