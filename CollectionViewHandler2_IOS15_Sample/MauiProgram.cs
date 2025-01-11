using Microsoft.Extensions.Logging;
using CollectionViewHandler2_IOS15_Sample.Handlers;

namespace CollectionViewHandler2_IOS15_Sample;

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

		builder.ConfigureMauiHandlers(handlers => {
#if IOS
		handlers.AddHandler<Microsoft.Maui.Controls.CollectionView, CustomCollectionViewHandler>();
		handlers.AddHandler<Microsoft.Maui.Controls.CarouselView, CustomCarouselViewHandler>();
#endif
		});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
