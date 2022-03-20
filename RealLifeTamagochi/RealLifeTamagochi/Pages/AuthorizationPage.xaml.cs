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
    public partial class AuthorizationPage : ContentPage
    {
        public AuthorizationPage()
        {
            
            InitializeComponent();
        }

        private async void btn_login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TasksPage());
        }

        private async void btn_registr_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPasswordPAge());
        }
    }
}