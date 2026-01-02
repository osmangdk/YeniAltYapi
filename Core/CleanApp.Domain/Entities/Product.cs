using System;

namespace CleanApp.Domain.Entities;

public class Product
{
    public string Sku { get; set; } =null!;
    public string Name { get; set; }=null!;
    public decimal Price { get; set; }
}
