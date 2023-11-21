using DatingApp.API.Data;
using DatingApp.API.Interfaces;
using DatingApp.API.Services;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options => 
            {
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddCors();
            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}