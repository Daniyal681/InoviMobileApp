namespace INOVI.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();

        NavigationPage.SetHasBackButton(this, false); // Hide the back button
    }
}