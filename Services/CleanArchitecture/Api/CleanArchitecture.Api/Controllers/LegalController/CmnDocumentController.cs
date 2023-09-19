using CleanArchitecture.Application.Features.Legal.CmnDocuments.Commands.CreateUpdateDocumentCommand;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CleanArchitecture.Api.Controllers.LegalController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CmnDocumentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CmnDocumentController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        [Route("CreateUpdateCmnDocument")]
        public async Task<ActionResult<string>> CreateUpdateCmnDocument([FromBody] CreateOrUpdateCmnDocumentCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }
    }
}
