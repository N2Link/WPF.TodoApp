using System.Collections.ObjectModel;
using System.Windows.Input;
using TodoApp.UI.Commands;

namespace TodoApp.UI.ViewModels
{
    class TodoAppViewModel
    {
        public ObservableCollection<string> Tasks { get; set; }


        public string NewTask { get; set; } = string.Empty;
        public ICommand AddTaskCommand { get; }
        public ICommand RemoveTaskCommand { get; set; }

        public TodoAppViewModel()
        {
            this.Tasks = new ObservableCollection<string>()
            {
                "Learn WPF",
                "Do the excersies",
            };

            this.AddTaskCommand = new RelayCommand(_ => this.AddTask(), _ => !string.IsNullOrEmpty(this.NewTask));
            this.RemoveTaskCommand = new RelayCommand(task => this.RemoveTask(task as string), task => task is string);
        }

        private void RemoveTask(string? task)
        {
            if (!string.IsNullOrEmpty(task) && this.Tasks.Contains(task)) 
            {
                this.Tasks.Remove(task);
            };
        }

        private void AddTask()
        {
            if (!string.IsNullOrEmpty(this.NewTask))
            {
                this.Tasks.Add(this.NewTask);
            }
        }
    }
}
