﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopSolution.UIForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navigation = new NavigationPage(new MainPage());

            MainPage = navigation;
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
