using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTrackerApi.Api.V1.ResponseModels;
using TimeTrackerApi.Core.Entities;

namespace TimeTrackerApi.Api.V1.Mappings
{
    public class TimeMappings : Profile
    {
        public TimeMappings()
        {
            CreateMap<Time, TimeResponseModel>();
        }
    }
}
