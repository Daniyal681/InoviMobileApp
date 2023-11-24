namespace INOVI;

public partial class Signup : ContentPage
{
	public Signup()
	{
		InitializeComponent();
	}

    private async void OnLoginTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}