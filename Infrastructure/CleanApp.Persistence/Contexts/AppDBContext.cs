using System;
using System.Reflection;
using CleanApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanApp.Persistence.Contexts;

public class AppDBContext  : DbContext 
{ 
    public AppDBContext() { }

    public AppDBContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
    
    public DbSet<TestTable> TestTables { get; set; }
}