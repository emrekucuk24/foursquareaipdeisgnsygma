﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using emredeisgn.Views;

namespace emredeisgn
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();


            MainPage = new StartPage();
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