//using Android.App;

namespace MauiApp2.Pages;

public partial class LogIn : ContentPage
{
    //public string[,] masssive = new string[1, 3];
    public LogIn()
    {
        InitializeComponent();
    }
    User user = new User();
    private void Logged(object sender, EventArgs e)
    {
        if ((Pass.Text != null && gin.Text != null) || (Pass.Text == user.Password) && (gin.Text == user.Name))
        {
            var page = new Profile();
            page.IsVisible = true;
            Navigation.PushAsync(new Profile());
        }
        else
        {
            DisplayAlert("Ошибка", "Неверные данные", "ОК");
        }
    }
}