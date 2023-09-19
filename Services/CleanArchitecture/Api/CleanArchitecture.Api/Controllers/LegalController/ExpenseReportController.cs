using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCaseFileMasterGrid;
using CleanArchitecture.Application.Features.Legal.Expanses_Info.Queries.GetExpenseGridByDate;
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
    public class ExpenseReportController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ExpenseReportController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        [Route("GetAllExpenseGridDataByDate/{fromDate}/{toDate}")]
        public async Task<ActionResult<List<GetExpenseGridByDateVm>>> GetAllGridData([FromBody] GridOptions options,string fromDate,string toDate)
        {
            var allData = await _mediator.Send(new GetExpenseGridByDateQuery() { options = options,fromDate = fromDate,toDate = toDate
            });
            return Ok(allData);
        }
    }
}
