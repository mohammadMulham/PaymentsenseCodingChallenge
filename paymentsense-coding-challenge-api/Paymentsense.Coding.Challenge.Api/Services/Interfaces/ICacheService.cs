using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Paymentsense.Coding.Challenge.Api.Services.Interfaces
{
    public interface ICacheService
    {
        Task<T> GetCache<T>(Func<Task<T>> createAction, [CallerMemberName] string actionName = null);
    }
}
