using System;
using System.Collections;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("MaterialIcons-Regular.ttf", Alias = "TamaFont")]

namespace RealLifeTamagochi
{
    public partial class App : Application
    {
        public static IEnumerable TaskDB { get; internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Pages.AuthorizationPage()) {BarBackgroundColor = Color.FromRgb(248, 220, 165), BarTextColor = Color.Black };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
