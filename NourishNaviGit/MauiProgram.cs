using ChatGptNet;
using ChatGptNet.Models;
using Microsoft.AspNetCore.Builder;
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

            // chatgptnet
            builder.Services.AddChatGpt(options =>
            {
                options.UseOpenAI(apiKey: "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", organization: "");
                options.DefaultModel = ""; // Default: ChatGptModels.Gpt35Turbo
                options.MessageLimit = 10; // Default: 10
                options.MessageExpiration = TimeSpan.FromMinutes(5); // Default: 1 hour

                // end chatgptnet

                //cors
                var builder = MauiApp.CreateBuilder();
                var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
                builder.Services.AddCors(options =>
                {
                    options.AddPolicy(name: MyAllowSpecificOrigins,
                                      policy =>
                                      {
                                          policy.WithOrigins("https://chat.openai.com/");
                                      });
                });

            }
            
            );


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}