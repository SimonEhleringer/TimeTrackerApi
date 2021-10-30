using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TimeTrackerApi.Core.Entities;

namespace TimeTrackerApi.Core.Services.Interfaces
{
    public interface ITimeService
    {
        public Task<Time> CreateAsync(DateTime startTime, DateTime endTime, string description);

        public Task<Time> GetById(int id);

        public Task<IList<Time>> Get(string filter, int pageNumber, int pageLength);
    }
}
