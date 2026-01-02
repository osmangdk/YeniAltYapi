using System;
using CleanApp.Application.Contracts.Persistence;
using CleanApp.Domain.Options;
using CleanApp.Persistence.Contexts;
using CleanApp.Persistence.Interceptors;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanApp.Persistence.Extensions;


 public static class RepositoryExtensions
 {
     public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
     {
         services.AddDbContext<AppDBContext>(options =>
         {
             var connectionStrings =
                 configuration.GetSection(ConnectionStringOption.Key).Get<ConnectionStringOption>();

             options.UseNpgsql(connectionStrings!.PostgreServer,
                 postgreServerOptionsAction =>
                 {
                     postgreServerOptionsAction.MigrationsAssembly(typeof(PersistenceAssembly).Assembly.FullName);
                 });

             options.AddInterceptors(new AuditDbContextInterceptor());
         });
         
        services.AddDbContext<AppDBContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        //  services.AddScoped<IProductRepository, ProductRepository>();
        //  services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));

         services.AddScoped<IUnitOfWork, UnitOfWork>();
         return services;
     }
 }