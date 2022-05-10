using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Quiz.Service.Abstraction;
using Quiz.Service.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Service
{
    public static class ServiceRegistration
    {
        public static void AddServiceServices(this IServiceCollection services)
        {
            //services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            //services.AddScoped<IEventRepository, EventRepository>();
            //services.AddScoped<IQuestionRepository, QuestionRepository>();
            //services.AddScoped<IPlayerRepository, PlayerRepository>();

            services.AddScoped<IEventService, EventService>();
        }
    }
}
