namespace NCAppNotas;

public partial class NCAboutPage : ContentPage
{
	public NCAboutPage()
	{
		InitializeComponent();
	}
    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }
}