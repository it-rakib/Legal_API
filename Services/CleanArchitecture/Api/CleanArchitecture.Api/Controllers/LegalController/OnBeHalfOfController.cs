using CleanArchitecture.Application.Features.Legal.OnBehalfOfInfo.Queries.GetAllOnBehalfOf;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Api.Controllers.LegalController
{
    [Route("api/[controller]")]
    [ApiController]
    public class OnBeHalfOfController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OnBeHalfOfController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet("GetAllOnBehalfOf")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<GetAllOnBehalfOfVm>>> GetAllOnBehalfOf()
        {
            var all = await _mediator.Send(new GetAllOnBehalfOfQuery());
            return Ok(all);
        }
    }
}
