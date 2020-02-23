using Paymentsense.Coding.Challenge.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paymentsense.Coding.Challenge.Api.ViewModels
{
    public class CountryDetailsViewModel
    {
        public string Flag { get; set; }
        public int Population { get; set; }
        public List<string> Timezones { get; set; }
        public List<Currency> Currencies { get; set; }
        public List<Language> Languages { get; set; }
        public string Capital { get; set; }
    }
}
