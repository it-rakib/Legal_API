using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCaseFileMasterGrid;
using CleanArchitecture.Application.Features.Legal.Expanses_Info.Command.CreateUpdateExpense;
using CleanArchitecture.Application.Features.Legal.Expanses_Info.Queries.GetAllExpenseGrid;
using CleanArchitecture.Application.Features.Legal.Expanses_Info.Queries.GetAllExpenseInfo;
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
    public class ExpenseController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ExpenseController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        [Route("CreateUpdateExpenseInfo")]
        public async Task<ActionResult<string>> CreateUpdateExpenseInfo([FromBody] CreateUpdateExpenseCommand createUpdateExpenseCommand)
        {

            var response = await _mediator.Send(createUpdateExpenseCommand);
            return Ok(response);
        }

        [HttpGet("all", Name = "GetAllExpenseInfo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<GetAllExpenseInfoVm>>> GetAllExpenseInfo()
        {
            var all = await _mediator.Send(new GetAllExpenseInfoQuery());
            return Ok(all);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        [Route("GetAllGridData")]
        public async Task<ActionResult<List<GetAllExpenseGridVm>>> GetAllGridData([FromBody] GridOptions options)
        {
            var allData = await _mediator.Send(new GetAllExpenseGridQuery() { options = options });
            return Ok(allData);
        }
    }
}
