using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paymentsense.Coding.Challenge.Api.Models
{
    public class RegionalBloc
    {
        public string Acronym { get; set; }
        public string Name { get; set; }
        public List<object> OtherAcronyms { get; set; }
        public List<string> OtherNames { get; set; }
    }
}
