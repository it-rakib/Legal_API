using CleanArchitecture.Application.Features.Legal.Case_Type.Command.CreateUpdateCaseType;
using CleanArchitecture.Application.Features.Legal.Case_Type.Queries.GetAllCaseType;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCaseFileGridByIds;
using CleanArchitecture.Application.Features.Legal.CaseFile_Master.Queries.GetAllCaseFileMasterGrid;
using CleanArchitecture.Application.Features.Legal.Update_Diary.Command.CreateUpdateDiary;
using CleanArchitecture.Application.Features.Legal.Update_Diary.Queries.GetAllUpdateDiary;
using CleanArchitecture.Application.Features.Legal.Update_Diary.Queries.GetAllUpdateDiaryGrid;
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
    public class UpdateDiaryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UpdateDiaryController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        [Route("CreateUpdateDiary")]
        public async Task<ActionResult<string>> CreateUpdateDiary([FromBody] CreateUpdateDiaryCommand createUpdateDiaryCommand)
        {
            var response = await _mediator.Send(createUpdateDiaryCommand);
            return Ok(response);
        }

        [HttpGet("all", Name = "GetAllUpdateDiary")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<List<GetAllUpdateDiaryVm>>> GetAllCaseType()
        {
            var all = await _mediator.Send(new GetAllUpdateDiaryQuery());
            return Ok(all);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        [Route("GetAllGridData/{fileMasterId}")]
        public async Task<ActionResult<List<GetAllUpdateDiaryGridVm>>> GetAllGridData([FromBody] GridOptions options, int fileMasterId)
        {
            var allData = await _mediator.Send(new GetAllUpdateDiaryGridQuery() { options = options,FileMasterId = fileMasterId });
            return Ok(allData);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        [Route("GetAllCaseFileGridById/{fileTypeId}/{courtId}/{statusId}/{unitId}")]
        public async Task<ActionResult<List<GetAllCaseFileGridByIdsVm>>> GetAllCaseFileGridById([FromBody] GridOptions options, string? fileTypeId = "0", string? courtId = "0", string? statusId = "0", string? unitId = "0")
        {
            var allData = await _mediator.Send(new GetAllCaseFileGridByIdsQuery()
            {
                options = options,
                FileTypeId = Convert.ToInt32(fileTypeId),
                CourtId = Convert.ToInt32(courtId),
                StatusId = Convert.ToInt32(statusId),
                UnitId = Convert.ToInt32(unitId)
            });
            return Ok(allData);
        }
    }
}
