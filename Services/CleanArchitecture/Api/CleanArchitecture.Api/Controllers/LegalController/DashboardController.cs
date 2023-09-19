using CleanArchitecture.Application.Features.Legal.Dashboard;
using CleanArchitecture.Application.Features.Legal.Dashboard.LADDisposed.Queries;
using CleanArchitecture.Application.Features.Legal.Dashboard.LADPending.Queries;
using CleanArchitecture.Application.Features.Legal.Dashboard.LDCDisposed.Queries;
using CleanArchitecture.Application.Features.Legal.Dashboard.LDCPending.Queries;
using CleanArchitecture.Application.Features.Legal.Dashboard.LHDDisposed.Queries;
using CleanArchitecture.Application.Features.Legal.Dashboard.LHDPending.Queries;
using CleanArchitecture.Application.Features.Legal.Dashboard.LLCDisposed.Queries;
using CleanArchitecture.Application.Features.Legal.Dashboard.LLCPending.Queries;
using CleanArchitecture.Application.Features.Legal.Dashboard.OverDatedCases.Queries;
using CleanArchitecture.Application.Features.Legal.Dashboard.UpcomingCases.Queries;
using Common.Service.CommonEntities.KendoGrid;
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
    public class DashboardController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DashboardController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        [Route("GetAllUpcomingDatedGridData")]
        public async Task<ActionResult<List<DashboardCasesVm>>> GetAllUpcomingDatedGridData([FromBody] GridOptions options)
        {
            var allData = await _mediator.Send(new GetAllUpcomingCasesQuery() { options = options });
            return Ok(allData);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        [Route("GetAllOverDatedGridData")]
        public async Task<ActionResult<List<DashboardCasesVm>>> GetAllOverDatedGridData([FromBody] GridOptions options)
        {
            var allData = await _mediator.Send(new GetAllOverRatedCasesQuery() { options = options });
            return Ok(allData);
        }

        [HttpGet("GetTotalPendingLLC", Name = "GetTotalPendingLLC")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<int>> GetTotalPendingLLC()
        {
            var total = await _mediator.Send(new LLCPendingQuery());
            return Ok(total);
        }

        [HttpGet("GetTotalDisposedLLC", Name = "GetTotalDisposedLLC")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<int>> GetTotalDisposedLLC()
        {
            var total = await _mediator.Send(new LLCDisposedQuery());
            return Ok(total);
        }

        [HttpGet("GetTotalPendingLDC", Name = "GetTotalPendingLDC")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<int>> GetTotalPendingLDC()
        {
            var total = await _mediator.Send(new LDCPendingQuery());
            return Ok(total);
        }

        [HttpGet("GetTotalDisposedLDC", Name = "GetTotalDisposedLDC")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<int>> GetTotalDisposedLDC()
        {
            var total = await _mediator.Send(new LDCDisposedQuery());
            return Ok(total);
        }

        [HttpGet("GetTotalPendingLHD", Name = "GetTotalPendingLHD")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<int>> GetTotalPendingLHD()
        {
            var total = await _mediator.Send(new LHDPendingQuery());
            return Ok(total);
        }

        [HttpGet("GetTotalDisposedLHD", Name = "GetTotalDisposedLHD")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<int>> GetTotalDisposedLHD()
        {
            var total = await _mediator.Send(new LHDDisposedQuery());
            return Ok(total);
        }

        [HttpGet("GetTotalPendingLAD", Name = "GetTotalPendingLAD")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<int>> GetTotalPendingLAD()
        {
            var total = await _mediator.Send(new LADPendingQuery());
            return Ok(total);
        }

        [HttpGet("GetTotalDisposedLAD", Name = "GetTotalDisposedLAD")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<int>> GetTotalDisposedLAD()
        {
            var total = await _mediator.Send(new LADDisposedQuery());
            return Ok(total);
        }
    }
}
