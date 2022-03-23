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
    public partial class CreateCharacterPage : ContentPage
    {
        public List<People> Peoples { get; set; } = new List<People>()
        {
            new People { Image = "first"},
            new People { Image = "second"},
            new People { Image = "third"},
            new People { Image = "forth"}

        };
        public CreateCharacterPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void btn_Save_Clicked(object sender, EventArgs e)
        {

        }
    }
    public class People
    {
        public string Image { get; set; }
    }
}