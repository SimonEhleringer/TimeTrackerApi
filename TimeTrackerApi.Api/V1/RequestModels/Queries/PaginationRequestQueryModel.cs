using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTrackerApi.Api.V1.RequestModels.Queries
{
    public class PaginationRequestQueryModel
    {
        public int PageNumber { get; set; }

        public int PageLength { get; set; }
    }
}
