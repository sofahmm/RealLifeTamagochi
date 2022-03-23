using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RealLifeTamagochi.Model;
using RealLifeTamagochi.View;

namespace RealLifeTamagochi.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectTaskPage : ContentPage
    {
        public string[] tasks { get; set; }
        public SelectTaskPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            lv_task.ItemsSource = App.TaskDB.GetTask();
            base.OnAppearing();
        }

        private async void lv_task_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new EditPage());
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TaskPage());
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilPage());
        }
    }
    //public class Task
    //{
    //    public string Name { get; set; }
    //    public string Reward { get; set; }
    //   // public CheckBox checkBox { get; set; }
    //}
}