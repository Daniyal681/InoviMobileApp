namespace INOVI;

public partial class ForgotPassword : ContentPage
{
	public ForgotPassword()
	{
		InitializeComponent();
	}

    private async void SendEmailClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EmailVerification());
    }
}