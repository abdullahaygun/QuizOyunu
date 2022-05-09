using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Data
{
    public static class ServiceRegistration
    {
        public static void AddDbServices(this IServiceCollection services)
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory()));
            configurationManager.AddJsonFile("appsettings.json");
            // App deki interface, Persistence deki class
            //services.AddSingleton<>();
            services.AddDbContext<QuizDbContext>(options => options.UseNpgsql(configurationManager.GetConnectionString("PostgreSQL")));
        }
    }
}
