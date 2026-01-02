using System;
using CleanApp.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CleanApp.Persistence.Factories;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDBContext>
{
 
   public AppDBContext CreateDbContext(string[] args)
    {
        var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Development";

        var configuration = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../API/CleanApi.Api"))
            .AddJsonFile("appsettings.json", optional: false) 
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<AppDBContext>();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

        return new AppDBContext(optionsBuilder.Options);
    }  
}