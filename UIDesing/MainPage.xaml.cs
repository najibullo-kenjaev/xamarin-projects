﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UIDesing
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private  void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetailPage());
        }
    }
}
