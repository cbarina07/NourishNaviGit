using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using NourishNaviGit.Data;

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

            // Configure your database context
            //services.AddDbContext<ApplicationDbContext>(options =>
            //    options.UseSqlServer(connectionString));

            // Other services configuration...
        }

        public void Configure()
        {
            // Other configuration...
        }
    }
}