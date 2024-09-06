﻿using AppFakeStore.Services;
using AppFakeStore.ViewModels;
using AppFakeStore.Views;
using Microsoft.Extensions.Logging;

namespace AppFakeStore
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
                    fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialDesignIcons");
                    fonts.AddFont("FontAwesome.ttf", "FASolid");
                });

            builder.Services.AddSingleton<IProductoService, ProductoService>();
            builder.Services.AddSingleton<IUsuariosService, UsuariosService>();

            builder.Services.AddTransient<ProductoListaViewModel>();
            builder.Services.AddTransient<ProductoListaPage>();
                        
            builder.Services.AddSingleton<UsuarioListaViewModel>();
            builder.Services.AddSingleton<UsuarioListaPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
