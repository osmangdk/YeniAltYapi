using System;
using CleanApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanApp.Persistence.Configurations;

public class TestTableConfiguration : IEntityTypeConfiguration<TestTable>
{
    public void Configure(EntityTypeBuilder<TestTable> builder)
    {
        builder.ToTable("TestTables").HasKey(p => p.Id);
    }
}