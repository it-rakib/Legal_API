using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Command.CreateUpdateCaseFileMaster;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCaseFileGridByIds;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCaseFileMasterGrid;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCourtByFileMasterId;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllFileMaster;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllFileMasterByRegNo;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetCaseFilesByFileMasterId;
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
    public class CaseFileMasterController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CaseFileMasterController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        [Route("CreateUpdateCaseFileMaster")]
        public async Task<ActionResult<string>> CreateUpdateCaseFileMaster([FromBody] CreateUpdateCaseFileMasterCommand createUpdateCaseFileMasterCommand)
        {
            
            var response = await _mediator.Send(createUpdateCaseFileMasterCommand);
            return Ok(response);
        }

        [HttpGet("all", Name = "GetAllCaseFileMaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<GetAllFileMasterVm>>> GetAllCaseFileMaster()
        {
            var all = await _mediator.Send(new GetAllFileMasterQuery());
            return Ok(all);
        }

        [HttpGet("{searchKey}", Name = "GetCaseFileByRegNo")]
        public async Task<ActionResult<GetAllFileMasterByRegNoVm>> GetById(string searchKey)
        {
            var result = new GetAllFileMasterByRegNoQuery() { Search = searchKey };
            return Ok(await _mediator.Send(result));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        [Route("GetAllGridData")]
        public async Task<ActionResult<List<GetAllCaseFileMasterGridVm>>> GetAllGridData([FromBody] GridOptions options)
        {
            var allData = await _mediator.Send(new GetAllCaseFileMasterGridQuery() { options = options });
            return Ok(allData);
        }


        [HttpGet("fileMasterByFileMasterId/{fileMasterId}", Name = "GetCaseFilesByFileMasterId")]
        public async Task<ActionResult<GetCaseFilesByFileMasterIdVm>> GetCaseFilesByFileMasterId(int fileMasterId)
        {
            var data = new GetCaseFilesByFileMasterIdQuery() { FileMasterId = fileMasterId };
            var list = await _mediator.Send(data);
            return Ok(list);
        }

        [HttpGet("GetAllCourtByFileId/{fileMasterId}", Name = "GetAllCourtByFileId")]
        public async Task<ActionResult<GetAllCourtByFileMasterIdVm>> GetAllCourtByFileMasterId(int fileMasterId)
        {
            var result1 = new GetAllCourtByFileMasterIdQuery() { FileMasterId = fileMasterId };
            return Ok(await _mediator.Send(result1));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        [Route("GetAllCaseFileGridById/{fileTypeId}/{courtId}/{statusId}/{unitId}")]
        public async Task<ActionResult<List<GetAllCaseFileGridByIdsVm>>> GetAllCaseFileGridById([FromBody] GridOptions options, string? fileTypeId = "0", string? courtId="0", string? statusId="0", string? unitId = "0")
        {
            var allData = await _mediator.Send(new GetAllCaseFileGridByIdsQuery()
            {
                options = options,
                FileTypeId =Convert.ToInt32(fileTypeId),
                CourtId = Convert.ToInt32(courtId),
                StatusId = Convert.ToInt32(statusId),
                UnitId = Convert.ToInt32(unitId)
            });
            return Ok(allData);
        }
    }
}
