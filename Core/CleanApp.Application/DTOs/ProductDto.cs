using System;
using CleanApp.Domain.Enums;

namespace CleanApp.Application.DTOs;

public class ProductDto
{
    /// <summary>
    /// Satıcıya ait stok kodu (Merchant SKU)
    /// </summary>
    public string Sku { get; set; } = default!;

    /// <summary>
    /// Ürün adı
    /// </summary>
    public string Name { get; set; } = default!;

    /// <summary>
    /// Satış fiyatı
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Mevcut stok miktarı
    /// </summary>
    public int StockQuantity { get; set; }

    /// <summary>
    /// Ürün yayında mı?
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Pazar yeri adı (bilgi amaçlı)
    /// </summary>
    public MarketplaceType Marketplace { get; set; }
}
