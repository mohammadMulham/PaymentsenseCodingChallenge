using Paymentsense.Coding.Challenge.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paymentsense.Coding.Challenge.Api.Models.Interfaces
{
    public interface ICountryService
    {
        Task<List<Country>> Get();
        Task<PagedList<Country>> Get(int page = 0, int take = 10);
        Task<Country> GetByName(string name);
        Task<List<Country>> GetLiveData();

    }
}
