using AutoMapper;
using Paymentsense.Coding.Challenge.Api.Models;
using Paymentsense.Coding.Challenge.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paymentsense.Coding.Challenge.Api.Mapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Country, CountryViewModel > ();
            CreateMap<PagedList<Country>, PagedList<CountryViewModel>>()
                .ForMember(src => src.List, opt => opt.MapFrom(des => des.List))
                .ForMember(src => src.TotalItems, opt => opt.MapFrom(des => des.TotalItems))
                .ForMember(src => src.PageSize, opt => opt.MapFrom(des => des.PageSize))
                .ForMember(src => src.PageNumber, opt => opt.MapFrom(des => des.PageNumber));
            CreateMap<Country, CountryDetailsViewModel>();
            
        }
    }
}
