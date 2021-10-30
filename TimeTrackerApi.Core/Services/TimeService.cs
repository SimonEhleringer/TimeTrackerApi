using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TimeTrackerApi.Core.Entities;
using TimeTrackerApi.Core.EntityFramework;
using TimeTrackerApi.Core.Services.Interfaces;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TimeTrackerApi.Core.Exceptions;

namespace TimeTrackerApi.Core.Services
{
    public class TimeService : ITimeService
    {
        private readonly TimeTrackerDbContext _dbContext;

        public TimeService(TimeTrackerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Time> CreateAsync(DateTime startTime, DateTime endTime, string description)
        {
            var newTime = new Time()
            {
                StartTime = startTime,
                EndTime = endTime,
                Description = description
            };

            var entityEntry = await _dbContext.Times.AddAsync(newTime);
            await _dbContext.SaveChangesAsync();

            return entityEntry.Entity;
        }

        public async Task<Time> GetById(int id)
        {
            return await _dbContext.Times.AsNoTracking()
                .Where(t => t.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IList<Time>> Get(string filter, int pageNumber, int pageLength)
        {
            if (pageNumber == 0)
            {
                throw new PageIsZeroException();
            }

            var numberOfRecordsToSkip = (pageNumber - 1) * pageLength;

            return await _dbContext.Times.AsNoTracking()
                .Where(t => t.Description.Contains(filter != null ? filter : string.Empty))
                .Skip(numberOfRecordsToSkip)
                .Take(pageLength)
                .ToListAsync();
        }
    }
}
