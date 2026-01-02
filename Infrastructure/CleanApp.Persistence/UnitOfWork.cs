using System;
using CleanApp.Application.Contracts.Persistence;
using CleanApp.Persistence.Contexts;

namespace CleanApp.Persistence;

public class UnitOfWork(AppDBContext context) : IUnitOfWork
{ 
    public Task<int> SaveChangesAsync() => context.SaveChangesAsync();
}