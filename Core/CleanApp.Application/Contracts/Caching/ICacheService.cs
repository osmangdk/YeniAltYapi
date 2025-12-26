namespace CleanApp.Application.Contracts.Caching;

public interface ICacheService
{
    Task<T?> GetAsync<T>(string cacheKey);
    Task AddAsync<T>(string cacheKey, T value, TimeSpan? absoluteExpireTime = null, TimeSpan? unusedExpireTime = null);
    Task RemoveAsync(string cacheKey);
}
