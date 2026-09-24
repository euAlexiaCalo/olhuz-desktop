using Microsoft.Extensions.Logging;
using olhuz_desktop.Features.Home.Views;
using olhuz_desktop.Features.Reading.Views;
using olhuz_desktop.Features.Preferences.Views;
using olhuz_desktop.Features.Profile.Views;
// using olhuz_desktop.Features.Home.ViewModels;
// using olhuz_desktop.Features.Reading.ViewModels;
// using olhuz_desktop.Features.Preferences.ViewModels;
// using olhuz_desktop.Features.Profile.ViewModels;

namespace olhuz_desktop
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            // ==========================================
            // REGISTRO DE INJEÇÃO DE DEPENDÊNCIA
            // ==========================================

            // Views
            builder.Services.AddTransient<HomePage>();
            builder.Services.AddTransient<ReadingHistoryPage>();
            builder.Services.AddTransient<PreferencesPage>();
            builder.Services.AddTransient<ProfilePage>();

            return builder.Build();
        }
    }
}
