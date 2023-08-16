namespace navigation_eliezer_practica_15;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }


    private void Cambiobtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Cambio());
    }

 
    private void Dinobtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Dinosaurio());
    }

    private void Gasbtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Gas());
    }

    private void Superficiebtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Suerficie());
    }

   
    private void Acercabtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new acerca());
    }
}


