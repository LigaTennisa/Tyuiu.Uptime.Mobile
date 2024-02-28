namespace MauiApp2;

public partial class Authorization : ContentPage
{
	public Authorization()
	{
		InitializeComponent();
	}

    private async void ToLogIn(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Login");
    }
    private async void ToReg(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Registration");
    }
}