using System.Windows;
using TodoApp.UI.ViewModels;

namespace TodoApp.UI.Views
{
    /// <summary>
    /// Interaction logic for TodoApp.xaml
    /// </summary>
    public partial class TodoApp : Window
    {
        public TodoApp()
        {
            InitializeComponent();
            this.DataContext = new TodoAppViewModel();
        }
    }
}
