using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RealLifeTamagochi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TasksPage : ContentPage
    {
        public TasksPage()
        {
            InitializeComponent();
        }

        private void lv_Tasks_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}