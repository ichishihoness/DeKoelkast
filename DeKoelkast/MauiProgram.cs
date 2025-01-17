﻿using DeKoelkast.Repositories;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using DeKoelkast.MVVM.Models;
using Camera.MAUI;
using ZXing.Net.Maui.Controls;

namespace DeKoelkast
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseBarcodeReader()
                .UseMauiCameraView()
                .UseMauiCommunityToolkit()
                .UseMauiCommunityToolkitCamera()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Roboto-Black.ttf", "Roboto");
                    fonts.AddFont("Roboto-Light.ttf", "RobotoLight");
                });

            builder.Services.AddSingleton<BaseRepository<Users>>();
            builder.Services.AddSingleton<BaseRepository<Products>>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
