﻿using System;
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
            new People { Image = "fr"},
            new People { Image = "gh"}

        };
        public CreateCharacterPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

    }
    public class People
    {
        public string Image { get; set; }
    }
}