using Maui_NoteApp.ViewModels;
using Maui_NoteApp.ViewModels.Startup;
using Maui_NoteApp.Views;
using Maui_NoteApp.Views.Startup;
using Microsoft.Extensions.Logging;

namespace Maui_NoteApp;

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
                // 2022-12-31 Latest Maui API at this time
                // even though there are no references, anywhere, Andriod will throw an exception if this is not added !!
                fonts.AddFont("OpenSans-Regular.ttf", "sans-serif-medium"); 
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		//Views
		builder.Services.AddSingleton<AppShell>();
        builder.Services.AddSingleton<LoginPage>();

        //View Models
        builder.Services.AddSingleton<LoginPageViewModel>();
		builder.Services.AddSingleton<AppShellViewModel>();

        return builder.Build();
	}
}
