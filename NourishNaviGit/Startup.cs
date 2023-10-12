using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using NourishNaviGit.Data;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;

namespace NourishNaviGit
{
    public partial class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Load the connection string from appsettings.json
            string connectionString = Configuration.GetConnectionString("DefaultConnection");

            try
            {
                // Configure your database context
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(connectionString));
            }
            catch (Exception ex)
            {
                // Handle database connection error
                // Log the exception for debugging purposes
                var loggerFactory = LoggerFactory.Create(builder =>
                {
                    builder.AddConsole();
                });
                var logger = loggerFactory.CreateLogger("DatabaseConnection");
                logger.LogError(ex, "Database connection error.");
            }

            // Other services configuration...
        }
    }
}