
using BookStore.Infrastructure.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using BookStore.Application.Repositories;
using BookStore.Infrastructure.Repositories;

namespace BookStore.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection InjectInfrastructureDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Books") ?? "Data Source=books.db";
            services.AddDbContext<DataContext>(opt => opt.UseSqlite(connectionString));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IBookRepository, BookRepository>();
            return services;
        }
    }
}
