//using Android.App;

using MauiApp2.Data;

namespace MauiApp2.Pages;

public partial class LogIn : ContentPage
{
    //private readonly IData data;
    public LogIn()
    {
        InitializeComponent();
        //this.data = new FakeData();
        //BindingContext = this.data;
    }
    
    private async void Logged(object sender, EventArgs e)
    {
        //User user = new User { 
        //    Name = gin.Text, 
        //    oneName = "New", 
        //    twoName = "User", 
        //    Email = "NewUser@yourdomain.com", 
        //    Password = Pass.Text };
        if ((Pass.Text != null && gin.Text != null))
        {
            //this.data.Users.Add(user);
            //bool a = this.data.Users.Contains(user);
            await Shell.Current.GoToAsync("//Profile");
        }
        else
        {
            DisplayAlert("Ошибка", "Неверные данные", "ОК");
        }
    }
}