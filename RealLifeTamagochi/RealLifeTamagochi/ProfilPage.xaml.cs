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
    public partial class ProfilPage : ContentPage
    {
        public ProfilPage()
        {
            InitializeComponent();


            Device.StartTimer(TimeSpan.FromSeconds(1), () => 
            {
                if (ggwp.Progress<=1)
                {
                    ggwp.ProgressTo(ggwp.Progress + 0.1, 250, Easing.Linear);
                    return true;
                }
                return false;
            });
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.CreateCharacterPage());
        }
    }
}