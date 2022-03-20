using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using RealLifeTamagochi.Model;

namespace RealLifeTamagochi.ViewModel
{
    class TaskViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        SelectTaskViewModel selectTaskVM;

        public Task Task { get; private set; }

        public TaskViewModel() => Task = new Task();
        public SelectTaskViewModel selectTaskViewModel
        {
            get { return selectTaskVM; }
            set
            {
                if(selectTaskVM != value)
                {
                    selectTaskVM = value;
                    OnPropertyChanged("selectTaskViewModel");
                }
            }
        }
        public string Description
        {
            get {return Task.Description; }
            set
            {
                if (Task.Description != value)
                {
                    Task.Description = value;
                    OnPropertyChanged("Description");
                }
            }
        }
        public string Reward
        {
            get { return Task.Reward; }
            set
            {
                if(Task.Reward != value)
                {
                    Task.Reward = value;
                    OnPropertyChanged("Reward");
                }
            }
        }
        /*public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(Name.Trim())) ||
                    (!string.IsNullOrEmpty(Group.Trim())));
            }
        }*/
        public bool IsVaild
        {
            get
            {
                return ((!string.IsNullOrEmpty(Description.Trim()))) ||
                    (!string.IsNullOrEmpty(Reward.Trim()));
            }
        }
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
