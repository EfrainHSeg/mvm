﻿using mvm.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new operaciones();
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
