using Microsoft.Maui.Controls;
using System;
using AppSegundoPractico;

namespace AppSegundoPractico.Views
{
    public partial class LoginPage : ContentPage
    {
        private const string USERNAME = "admin";
        private const string PASSWORD = "1234";

        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            try
            {
                string username = UsuarioEntry.Text;
                string password = PasswordEntry.Text;

                if (username == USERNAME && password == PASSWORD)
                    Application.Current.MainPage = new MenuAccesoPage();
                
                else
                    await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
                
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Ocurrió un error: {ex.Message}", "OK");
            }
        }
    }
}
