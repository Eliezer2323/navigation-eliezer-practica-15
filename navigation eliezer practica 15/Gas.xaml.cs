namespace navigation_eliezer_practica_15;

public partial class Gas : ContentPage
{
	public Gas()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        double galones = Convert.ToDouble(canGas.Text);

        double litros;

        litros = galones * 3.78541;

        cosTotal.Text = "El costo total es: $" + (litros * 1.168);
    }
}