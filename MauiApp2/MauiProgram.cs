using MauiApp2.Data;
using Microsoft.Extensions.Logging;

namespace MauiApp2
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {

            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("ru-Bowler.ttf", "bowler");
                });
#if DEBUG
            builder.Services.AddSingleton<IData, FakeData>();
            builder.Logging.AddDebug();
#else
            builder.Services.AddSingleton<IData, RealData>();            
#endif

            return builder.Build();
        }
    }
}
