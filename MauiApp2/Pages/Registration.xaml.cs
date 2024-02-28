namespace MauiApp2.Pages;

public partial class Registration : ContentPage
{
    public Registration()
    {
        InitializeComponent();
    }
    public string[,] masssive = new string[1,3];
    private void Registred(object sender, EventArgs e)
    {
        Entry entryMail = new Entry { Placeholder = "Введите Email" };
        Entry entryLogin = new Entry { Placeholder = "Введите Email" };
        Entry entryPasssword = new Entry { Placeholder = "Введите Email" };

        Entry entryProve = new Entry { Placeholder = "Проверка" };

        string Mail = entryMail.Text;
        string Login = entryLogin.Text;
        string Password = entryPasssword.Text;

        masssive[0,0] = Mail;
        masssive[0,1] = Login;
        masssive[0, 2] = Password;
        entryProve.Text = Mail+Login+Password;
    }
}