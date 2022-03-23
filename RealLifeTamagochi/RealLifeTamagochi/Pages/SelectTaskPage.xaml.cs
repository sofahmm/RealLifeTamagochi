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
    public partial class SelectTaskPage : ContentPage
    {
        public List<Task> Tasks { get; set; } = new List<Task>()
        {
            new Task{ Name = "Cleaning", Reward="+200xp"}
        };
        public SelectTaskPage()
        {
            InitializeComponent();
            BindingContext = this;
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
    public class Task
    {
        public string Name { get; set; }
        public string Reward { get; set; }
       // public CheckBox checkBox { get; set; }
    }
}