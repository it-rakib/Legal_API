using CleanArchitecture.Application.Features.Legal.Company_Info.Queries.GetAllCompany;
using CleanArchitecture.Application.Features.Legal.Company_Info.Queries.GetUnitByCompanyId;
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
    public class CompanyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CompanyController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet("all", Name = "GetAllCompany")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<GetAllCompanyVm>>> GetAllCompany()
        {
            var all = await _mediator.Send(new GetAllCompanyQuery());
            return Ok(all);
        }

        [HttpGet("GetAllUnitByCompanyId/{companyId}", Name = "GetAllUnitByCompanyId")]
        public async Task<ActionResult<GetUnitByCompanyIdVm>> GetAllUnitByCompanyId(int companyId)
        {
            var result1 = new GetUnitByCompanyIdQuery() { CompanyId = companyId };
            return Ok(await _mediator.Send(result1));
        }
    }
}
