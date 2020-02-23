using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Paymentsense.Coding.Challenge.Api.Models;
using Paymentsense.Coding.Challenge.Api.Models.Interfaces;
using Paymentsense.Coding.Challenge.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Paymentsense.Coding.Challenge.Api.Extensions;

namespace Paymentsense.Coding.Challenge.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentsenseCodingChallengeController : ControllerBase
    {
        private ICountryService _countrySrv;
        private IMapper _mapper;
        public PaymentsenseCodingChallengeController(ICountryService countrySrv,IMapper mapper)
        {
            _countrySrv = countrySrv;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Country>), 200)]
        public async Task<IActionResult> Get(int page=0,int take=10)
        {
            var model = await _countrySrv.Get(page,take);
            var mappedModel = _mapper.Map<PagedList<CountryViewModel>>(model);
            return Ok(mappedModel);
        }
        [HttpGet("{name}")]
        [ProducesResponseType(typeof(Country), 200)]
        public async Task<IActionResult> Get(string name)
        {
            var model = await _countrySrv.GetByName(name);
            if (model == null)
                return NotFound(" No matching results!");
            var mappedModel = _mapper.Map<CountryDetailsViewModel>(model);
            return Ok(mappedModel);
        }
    }
}
