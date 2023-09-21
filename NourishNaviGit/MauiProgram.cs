﻿using ChatGptNet;
using ChatGptNet.Models;
using Microsoft.Extensions.Logging;

namespace NourishNaviGit
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

            builder.Services.AddChatGpt(options =>
            {
                options.UseOpenAI(apiKey: "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", organization: "NourishNavi");
                options.DefaultModel = "my-model"; // Default: ChatGptModels.Gpt35Turbo
                options.MessageLimit = 10; // Default: 10
                options.MessageExpiration = TimeSpan.FromMinutes(5); // Default: 1 hour
            });


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}