namespace navigation_eliezer_practica_15;

public partial class Suerficie : ContentPage
{
	public Suerficie()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        double b = Convert.ToDouble(baseTri.Text);
        double a = Convert.ToDouble(altTri.Text);

        double s = b * a;

        supTri.Text = "La superficie es : " + s;
    }
}