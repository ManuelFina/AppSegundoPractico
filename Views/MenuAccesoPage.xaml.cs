namespace AppSegundoPractico.Views;

public partial class MenuAccesoPage : ContentPage
{
	public MenuAccesoPage()
	{
        InitializeComponent();
	}

    private async void OnServicioOfrecidoClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ServicioOfrecidoPage());
    }

    private async void OnDatosDesarrolladorClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AcercaDesarrolladorPage());
    }

    private async void OnCerrarSesionClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync(); // Vuelve al login
    }

}