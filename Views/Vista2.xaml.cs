namespace Repaso.Views;

public partial class Vista2 : ContentPage
{

    public Vista2(string dato)
	{
		InitializeComponent();
        lblDato.Text = "USUARIO CONECTADO"+ dato;
    }
}