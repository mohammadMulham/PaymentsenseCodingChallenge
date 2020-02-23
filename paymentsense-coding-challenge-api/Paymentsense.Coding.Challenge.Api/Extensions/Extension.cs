using Paymentsense.Coding.Challenge.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paymentsense.Coding.Challenge.Api.Extensions
{
    public static class Extension
    {
        public static PagedList<T> ToPagedList<T>(this List<T> source, int pageNumber, int pageSize)
        {
            return  new PagedList<T>(source, pageNumber, pageSize);
        } 
    }
}
