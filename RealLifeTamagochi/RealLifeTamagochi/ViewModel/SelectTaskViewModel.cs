using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RealLifeTamagochi.ViewModel
{
    class SelectTaskViewModel: INotifyPropertyChanged
    {
        public ObservableCollection<TaskViewModel> Task { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand AddTaskCommand { get; set; }
        public ICommand BackCommand { get; set; }

        TaskViewModel taskVm;
        public INavigation Navigation { get; set; }

        public SelectTaskViewModel()
        {
            Task = new ObservableCollection<TaskViewModel>();
            AddTaskCommand = new Command(AddTask);
            BackCommand = new Command(Back);
        }
       
        public TaskViewModel TaskViewModel
        {
            get { return taskVm; }
            set
            {
                if(taskVm != value)
                {
                    TaskViewModel taskViewModel = value;
                    taskVm = null;
                    OnPropertyChanged("taskViewModel");
                    Navigation.PushAsync(new TasksPage());
                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        private void AddTask()
        {

        }
        private void Back()
        {

        }
    }
}
