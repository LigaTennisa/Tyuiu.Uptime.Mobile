using MauiApp2.Data;

namespace MauiApp2;

public partial class Profile : ContentPage
{
    private readonly IData data;
    public Profile()//(IData data)
    {
		InitializeComponent();
        this.data = new FakeData();
        BindingContext = this.data;
        //Users.ItemsSource = data.Users;
	}
}