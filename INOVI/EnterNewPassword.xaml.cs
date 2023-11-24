using INOVI.Pages;

namespace INOVI;

public partial class EnterNewPassword : ContentPage
{
	public EnterNewPassword()
	{
		InitializeComponent();
	}

    private async void NewPasswordClicked(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new HomePage());
        await Shell.Current.GoToAsync("//HomePage");

    }
}