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

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            try
            {
                string username = UsuarioEntry.Text;
                string password = PasswordEntry.Text;

                if (username == USERNAME && password == PASSWORD)
                    await Navigation.PushAsync(new MenuAccesoPage());
                
                else
                    await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
                
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Ocurrió un error: {ex.Message}", "OK");
            }
        }

        private void OnTogglePasswordVisibility(object sender, EventArgs e)
        {
            PasswordEntry.IsPassword = !PasswordEntry.IsPassword;

            TogglePasswordButton.Source = PasswordEntry.IsPassword ? "visibilitygrey.png" : "visibilityoffgrey.png";
        }

    }
}
