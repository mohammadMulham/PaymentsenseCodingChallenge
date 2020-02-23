using Microsoft.Extensions.Caching.Memory;
using Paymentsense.Coding.Challenge.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Paymentsense.Coding.Challenge.Api.Services
{
    public class CacheService : ICacheService
    {
        private IMemoryCache _cache;
        public CacheService(IMemoryCache cache)
        {
            _cache = cache;
        }
        public async Task<T> GetCache<T>(Func<Task<T>> createAction, [CallerMemberName] string actionName = null)
        {
            var cacheKey = GetType().Name + "_" + actionName;
            return await _cache.GetOrCreateAsync(cacheKey, entry => createAction());
        }
    }
}
