using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.UI.ViewModels
{
    class TodoAppViewModel
    {
        public ObservableCollection<string> Tasks { get; set; }

        public TodoAppViewModel()
        {
            this.Tasks = new ObservableCollection<string>()
            {
                "Learn WPF",
                "Do the excersies",
            };
        }
    }
}
