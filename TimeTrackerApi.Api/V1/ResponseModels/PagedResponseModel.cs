using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTrackerApi.Api.V1.ResponseModels
{
    public class PagedResponseModel<TData>
    {
        public IList<TData> Data { get; set; }

        public int PageNumber { get; set; }

        public int PageLength { get; set; }

        public PagedResponseModel(IList<TData> data, int pageNumber, int pageLength)
        {
            Data = data;
            PageNumber = pageNumber;
            PageLength = pageLength;
        }
    }
}
