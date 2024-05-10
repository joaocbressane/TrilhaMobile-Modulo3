using CommunityToolkit.Maui;
using GerenciadorProdutoresApp.Services.Produtor;
using Microsoft.Extensions.Logging;

namespace GerenciadorProdutoresApp
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<ICadastroProdutorService, ProdutorService>();
            return builder.Build();
        }
    }
}
