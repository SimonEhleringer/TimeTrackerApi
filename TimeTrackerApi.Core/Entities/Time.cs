using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TimeTrackerApi.Core.Constants;

namespace TimeTrackerApi.Core.Entities
{
    public class Time
    {
        public int Id { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [MaxLength(TimeConstants.MaxLengthDescription)]
        public string Description { get; set; }
    }
}
