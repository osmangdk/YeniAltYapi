using System;
using CleanApp.Application.DTOs;

namespace CleanApp.Application.Interfaces.MarketPlaces;

public interface IMarketplaceService
{
    Task<IEnumerable<ProductDto>> GetProductsAsync();
    Task UpdateStockAsync(UpdateStockDto dto);
}