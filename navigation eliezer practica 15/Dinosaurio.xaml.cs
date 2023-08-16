namespace navigation_eliezer_practica_15;

public partial class Dinosaurio : ContentPage
{
	public Dinosaurio()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        string nombre = Convert.ToString(NDino.Text);
        double peso = Convert.ToDouble(pesKg.Text);
        double altura = Convert.ToDouble(altMts.Text);

        dinoNom.Text = "Nombre del dinosaurio: " + nombre;
        pesoLb.Text = "Peso en LB: " + (peso * 2.2);
        altCm.Text = "Altura en CM: " + (altura * 100);
    }
}