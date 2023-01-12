using Microsoft.Extensions.Logging;


namespace TriggerProblemiOSRelease;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
//#if DEBUG
//                                .UseMauiCommunityToolkit()
//#else
//								.UseMauiCommunityToolkit(options =>
//								{
//									options.SetShouldSuppressExceptionsInConverters(false);
//									options.SetShouldSuppressExceptionsInBehaviors(false);
//									options.SetShouldSuppressExceptionsInAnimations(false);
//								})
//#endif
                                .RegisterViewModels()
                                .RegisterViews()
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

    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<MainPageViewModel>();

        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<MainPage>();

        return mauiAppBuilder;
    }
}
