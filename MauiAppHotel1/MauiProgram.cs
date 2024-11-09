using Microsoft.Extensions.Logging;

namespace MauiAppHotel1
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
                    fonts.AddFont("Eater-Regular.ttf", "Eater");
                    fonts.AddFont("MysteryQuest-Regular.ttf", "MysteryQuest");
                    fonts.AddFont("RoadRage-Regular.ttf", "RoadRage");
                    fonts.AddFont("RubikBeastly-Regular.ttf", "RubikBeastly");
                    fonts.AddFont("RubikWetPaint-Regular.ttf", "RubikWetPaint");
                    fonts.AddFont("Creepster-Regular.ttf", "Creepster");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
