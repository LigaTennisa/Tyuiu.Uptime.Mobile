namespace MauiApp2.Pages;

public partial class Registration : ContentPage
{
    public Registration()
    {
        InitializeComponent();
    }
    //public string[,] masssive = new string[2,3];
    private void Registred(object sender, EventArgs e)
    {
        if ((Pass.Text == PassMore.Text) && Pass.Text != null && Mail.Text != null && Login.Text != null)
        {
            User user = new User();
            user.Password = Pass.Text;
            user.Email = Mail.Text;
            user.Name = Login.Text;
            Shell.Current.GoToAsync("//Profile");
            //Navigation.PushAsync(new Profile(), true);
            var page = new Registration();
            page.IsVisible = false;
            page.IsEnabled = false;

        }
        else
        {
            DisplayAlert("Ошибка", "Неверные данные", "ОК");
        }
    }

    //private void Registred(object sender, EventArgs e)
    //{

    //}

    //private void Registred(object sender, EventArgs e)
    //{

    //}
}