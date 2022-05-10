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
            services.AddScoped<IPlayerService, PlayerService>();
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<IEventService, EventService>();
        }
    }
}
