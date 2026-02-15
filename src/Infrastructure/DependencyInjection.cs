using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using src.Infrastructure.Persistance;

namespace src.Infrastructure;
public static class InfrastructureDependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // Database setup
        var connectionStrings = configuration.GetConnectionString("DevelopmentDatabase");
        services.AddDbContext<ApplicationDbContext>(options => 
            options.UseSqlServer(connectionStrings));

        // Identity setup

        // Caching setup

        // Workers setup

        // WhatsApp setup

        return services;
    }
}

