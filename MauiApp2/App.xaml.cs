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
            Routing.RegisterRoute("LogIn", typeof(LogIn));
            Routing.RegisterRoute("Registration", typeof(Registration));
            MainPage = new AppShell();

            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderlessEntry), (handler, view) =>
            {
#if ANDROID
            handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#elif IOS
                handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
#endif
            });
        }
    }
}
