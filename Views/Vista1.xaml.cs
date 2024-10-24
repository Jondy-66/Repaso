namespace Repaso.Views;

public partial class Vista1 : ContentPage
{
	string datoU;
	public Vista1(string dato, int dato1, int dato2, string dato3)
	{
		InitializeComponent();
		this.datoU = dato;
		lblDato.Text = "usuario conectado:" + dato;
	}

    private void btnAbrir2_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Vista2(datoU));
    }

    //
}