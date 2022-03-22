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
    public partial class EditPage : ContentPage
    {
        public EditPage()
        {
            InitializeComponent();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }

        private async void btn_save_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SelectTaskPage());
        }
    }
}