using CRMSERVER1.Domain.Repositories;
using CRMSERVER1.Infrastructure.Context;
using CRMSERVER1.Infrastructure.Repositories;
using GenericRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CRMSERVER1.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("SqlServer"));
        });

        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<IUnitOfWork>(configuration => configuration.GetRequiredService<ApplicationDbContext>());
        return services;
    }
}
