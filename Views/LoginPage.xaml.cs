namespace AppSegundoPractico.Views
{
    public partial class LoginPage : ContentPage
    {
        
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string ? usuario = UsuarioEntry.Text?.Trim();
            string contrase�a = PasswordEntry.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrase�a))
            {
                await DisplayAlert("Campos vac�os", "Por favor, complete ambos campos.", "OK");
                return;
            }

            if (usuario == "admin" && contrase�a == "1234")
            {
                await DisplayAlert("Acceso concedido", "Bienvenido, " + usuario, "OK");

                // Ir al men� principal (reemplaz� por tu p�gina real)
                //await Navigation.PushAsync(new MenuPage());
            }
            else
            {
                await DisplayAlert("Error", "Usuario o contrase�a incorrectos", "Intentar de nuevo");
            }
        }
        
    }
        
}
