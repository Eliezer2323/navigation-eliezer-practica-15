namespace navigation_eliezer_practica_15;

public partial class Cambio : ContentPage
{
	public Cambio()
	{
		InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        double costo = Convert.ToDouble(costoArt.Text);
    double dinero = Convert.ToDouble(dinerocli.Text);

    double cambio = dinero - costo;

    cambioCli.Text = "EL cambio es: $" + cambio;
    }
}