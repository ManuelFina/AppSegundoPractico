namespace AppSegundoPractico.Views;

public partial class MenuAccesoPage : ContentPage
{
	public MenuAccesoPage()
	{
        InitializeComponent();

        NavigationPage.SetHasNavigationBar(this, false);
    }

    private void OnServicioOfrecidoClicked(object sender, EventArgs e)
    {
              Navigation.PushAsync(new ServicioOfrecidoPage());
    }

    private void OnDatosDesarrolladorClicked(object sender, EventArgs e)
    {
              Navigation.PushAsync(new AcercaDesarrolladorPage());
    }

    private void OnCerrarSesionClicked(object sender, EventArgs e)
    {
              Navigation.PopToRootAsync(); 
    }

}