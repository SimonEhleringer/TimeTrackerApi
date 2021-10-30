using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTrackerApi.Api.V1.RequestModels.Body;
using TimeTrackerApi.Api.V1.RequestModels.Queries;
using TimeTrackerApi.Api.V1.ResponseModels;
using TimeTrackerApi.Core.Services.Interfaces;

namespace TimeTrackerApi.Api.V1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TimesController : ControllerBase
    {
        private readonly ITimeService _timeService;
        private readonly IMapper _mapper;

        public TimesController(ITimeService timeService, IMapper mapper)
        {
            _timeService = timeService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTimeRequestBodyModel body)
        {
            var createdTime = await _timeService.CreateAsync(body.StartTime, body.EndTime, body.Description);

            var responseModel = _mapper.Map<TimeResponseModel>(createdTime);

            return CreatedAtAction(nameof(GetById), new { timeId = createdTime.Id }, responseModel);
        }

        [HttpGet("{timeId}")]
        public async Task<IActionResult> GetById([FromRoute] int timeId)
        {
            var time = await _timeService.GetById(timeId);

            var responseModel = _mapper.Map<TimeResponseModel>(time);

            return Ok(responseModel);
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string filter, [FromQuery] PaginationRequestQueryModel paginationQuery)
        {
            var times = await _timeService.Get(filter, paginationQuery.PageNumber, paginationQuery.PageLength);

            var responseModelData = _mapper.Map<List<TimeResponseModel>>(times);
            var responseModel = new PagedResponseModel<TimeResponseModel>(responseModelData, paginationQuery.PageNumber, paginationQuery.PageLength);

            return Ok(responseModel);
        }
    }
}
