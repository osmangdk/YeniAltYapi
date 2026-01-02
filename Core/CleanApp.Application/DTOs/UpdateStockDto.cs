using System;
using CleanApp.Domain.Enums;

namespace CleanApp.Application.DTOs;

public class UpdateStockDto
{
    /// <summary>
    /// Satıcı stok kodu
    /// </summary>
    public string Sku { get; set; } = default!;

    /// <summary>
    /// Güncellenecek stok miktarı
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Marketplace bilgisi (Factory için)
    /// </summary>
    public MarketplaceType Marketplace { get; set; }

    /// <summary>
    /// Stok sıfırlandığında ürünü pasife al
    /// (Bazı pazar yerleri destekler)
    /// </summary>
    public bool DeactivateIfZero { get; set; } = true;
}
