using MauiApp2.Pages;

namespace MauiApp2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Routing.RegisterRoute("TennisLeague", typeof(TennisLeague));
            Routing.RegisterRoute("Coaches", typeof(Coaches));
            Routing.RegisterRoute("Authorization", typeof(Authorization));
            Routing.RegisterRoute("Login", typeof(Login));
            Routing.RegisterRoute("Registration", typeof(Registration));
            MainPage = new AppShell();
        }
    }
}
