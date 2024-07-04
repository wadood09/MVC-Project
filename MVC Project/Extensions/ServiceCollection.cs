using Microsoft.EntityFrameworkCore;
using MVC_Project.Core.Application.Interface.Repositories;
using MVC_Project.Core.Application.Interface.Services;
using MVC_Project.Core.Application.Services;
using MVC_Project.Infrastructure.Context;
using MVC_Project.Infrastructure.Repositories;

namespace MVC_Project.Extensions
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddContext(this IServiceCollection services, string connectionString)
        {
            return services
                .AddDbContext<RestaurantContext>(a => a.UseMySQL(connectionString));
        }
    }
}
