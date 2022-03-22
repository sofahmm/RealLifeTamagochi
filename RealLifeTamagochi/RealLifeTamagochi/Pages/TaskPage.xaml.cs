using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace RealLifeTamagochi.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskPage : ContentPage
    {
        /*public StudentViewModel ViewModel { get;  private set; }
        public StudentPage(StudentViewModel studentViewModel)
        {
            InitializeComponent();
            ViewModel = studentViewModel;
            this.BindingContext = ViewModel;
        }*/


        //public TaskViewModel TaskViewModel { get; private set; }

        public TaskPage(/*TaskViewModel taskViewModel*/)
        {
            InitializeComponent();
            /*ViewModel = taskViewModel;
            this.BindingContext = ViewModel;*/
        }

        private void pick_reward_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }
    }
}