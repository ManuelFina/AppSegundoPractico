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
            string contraseña = PasswordEntry.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                await DisplayAlert("Campos vacíos", "Por favor, complete ambos campos.", "OK");
                return;
            }

            if (usuario == "admin" && contraseña == "1234")
            {
                await DisplayAlert("Acceso concedido", "Bienvenido, " + usuario, "OK");

                // Ir al menú principal (reemplazá por tu página real)
                //await Navigation.PushAsync(new MenuPage());
            }
            else
            {
                await DisplayAlert("Error", "Usuario o contraseña incorrectos", "Intentar de nuevo");
            }
        }
        
    }
        
}
