using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TimeTrackerApi.Core.Entities;

namespace TimeTrackerApi.Core.EntityFramework
{
    public class TimeTrackerDbContext : DbContext
    {
        public TimeTrackerDbContext(DbContextOptions<TimeTrackerDbContext> options) : base(options)
        {
        }

        public DbSet<Time> Times { get; set; }
    }
}
