using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paymentsense.Coding.Challenge.Api.Services.Interfaces
{
    public interface IHttpService 
    {
        Uri BaseAddress { get; }
        Task<T> Get<T>(string url);
    }
}
