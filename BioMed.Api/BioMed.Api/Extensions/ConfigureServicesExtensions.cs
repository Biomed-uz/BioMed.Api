using BioMed.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BioMed.Api.Extensions
{
    public static class ConfigureServicesExtensions
    {
        public static IServiceCollection ConfigureDatabaseContext(this IServiceCollection services)
        {
            var builder = WebApplication.CreateBuilder();

            services.AddDbContext<BioMedDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("BioMedConnection")));

            return services;
        }
    }
}
