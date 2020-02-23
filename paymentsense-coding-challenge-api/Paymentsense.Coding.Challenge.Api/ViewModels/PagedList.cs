using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paymentsense.Coding.Challenge.Api.ViewModels
{
    public class PagedList<T>
    {
        public PagedList()
        {

        }

        public PagedList(List<T> source, int pageNumber, int pageSize)
        {
            this.TotalItems = source.Count();
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.List = source
                            .Skip(pageSize * (pageNumber - 1))
                            .Take(pageSize)
                            .ToList();
        }
        public int TotalItems { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public List<T> List { get; set; }
    }
}
