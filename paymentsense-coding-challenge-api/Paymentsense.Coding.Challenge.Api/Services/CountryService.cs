﻿using Newtonsoft.Json;
using Paymentsense.Coding.Challenge.Api.Extensions;
using Paymentsense.Coding.Challenge.Api.Models;
using Paymentsense.Coding.Challenge.Api.Models.Interfaces;
using Paymentsense.Coding.Challenge.Api.Services.Interfaces;
using Paymentsense.Coding.Challenge.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Paymentsense.Coding.Challenge.Api.Services
{
    public class CountryService : ICountryService
    {
        private readonly IHttpService _httpService;
        private ICacheService _cacheSrv;

        public CountryService(IHttpService httpService, ICacheService cacheSrv)
        {
            _httpService = httpService;
            _cacheSrv = cacheSrv;
        }

        public async Task<List<Country>> Get()
        {
            var countries = await _cacheSrv.GetCache(() => GetLiveData());
            return countries;
        }
        public async Task<PagedList<Country>> Get(int page=1,int take=10)
        {
            var countries = await Get();
            var pagedModel = countries.ToPagedList(page, take);
            return pagedModel;
        }
        public async Task<Country> GetByName(string name)
        {
            var url = $"/name/{name}";
            var country = await _httpService.Get<List<Country>>(url);
            return country?.FirstOrDefault();
        }
        public async Task<List<Country>> GetLiveData()
        {
            var url = "/all";
            var countries = await _httpService.Get<List<Country>>(url);
            return countries;
        }
    }
  
}
