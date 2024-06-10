using CommunityToolkit.Maui;
using ExamDesmechtDenysPOO.Utilities;
using ExamDesmechtDenysPOO.ViewModel;
using Microsoft.Extensions.Logging;

namespace ExamDesmechtDenysPOO
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
;


            //Injection Singletons
            builder.Services.AddSingleton<DataAccess>();

            //Injection Transient
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<MainPageViewModel>();


#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
