using System;
using CleanApp.Application.Contracts.Caching;
using Microsoft.Extensions.Caching.Memory;

namespace CleanApp.Caching;

public class CacheService(IMemoryCache memoryCache) : ICacheService
{
 public Task<T?> GetAsync<T>(string cacheKey)
 {
     return Task.FromResult(memoryCache.TryGetValue(cacheKey, out T? cacheItem) ? cacheItem : default(T));
 }

 public Task AddAsync<T>(string cacheKey, T value, TimeSpan exprTimeSpan)
 {
     var cacheOptions = new MemoryCacheEntryOptions
     {
         AbsoluteExpirationRelativeToNow = exprTimeSpan
     };

     memoryCache.Set(cacheKey, value, cacheOptions);

     return Task.CompletedTask;
 }

 public Task AddAsync<T>(string cacheKey, T value, TimeSpan? absoluteExpiration, TimeSpan? slidingExpiration)
 {
     var cacheOptions = new MemoryCacheEntryOptions();

     if (absoluteExpiration.HasValue)
         cacheOptions.AbsoluteExpirationRelativeToNow = absoluteExpiration.Value;

     if (slidingExpiration.HasValue)
         cacheOptions.SlidingExpiration = slidingExpiration.Value;

     memoryCache.Set(cacheKey, value, cacheOptions);

     return Task.CompletedTask;
 }

 public Task RemoveAsync(string cacheKey)
 {
     memoryCache.Remove(cacheKey);

     return Task.CompletedTask;
 }
}

