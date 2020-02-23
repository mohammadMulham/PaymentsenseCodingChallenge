using Newtonsoft.Json;
using Paymentsense.Coding.Challenge.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Paymentsense.Coding.Challenge.Api.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;
        public Uri BaseAddress { get => _httpClient.BaseAddress;}

        public HttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<T> Get<T>(string url)
        {
            T data = default(T);

            if (!string.IsNullOrEmpty(url))
            {
                var httpResponse = await _httpClient.GetAsync(BaseAddress+url);
                if (httpResponse != null && httpResponse.IsSuccessStatusCode)
                {
                    var content = await httpResponse.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<T>(content);   
                }
            }
            return data;
        }
    }
}
