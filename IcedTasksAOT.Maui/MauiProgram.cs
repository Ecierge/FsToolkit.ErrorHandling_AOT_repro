using IcedTasksAOT.IcedTasks;

using Microsoft.Extensions.Logging;

namespace IcedTasksAOT
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            Say.method1();
            Say.method2();
            Say.method3();
            Say.method4();
            Say.method5();

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

            return builder.Build();
        }
    }
}
