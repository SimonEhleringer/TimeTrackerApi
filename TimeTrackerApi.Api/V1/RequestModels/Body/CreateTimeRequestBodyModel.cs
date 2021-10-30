using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TimeTrackerApi.Core.Constants;

namespace TimeTrackerApi.Api.V1.RequestModels.Body
{
    public class CreateTimeRequestBodyModel
    {
        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [MaxLength(TimeConstants.MaxLengthDescription)]
        public string Description { get; set; }
    }
}
