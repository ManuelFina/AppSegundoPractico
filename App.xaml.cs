﻿using AppSegundoPractico.Views;

namespace AppSegundoPractico
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
