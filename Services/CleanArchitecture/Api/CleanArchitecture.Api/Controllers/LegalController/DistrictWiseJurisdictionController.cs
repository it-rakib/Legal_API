using CleanArchitecture.Application.Features.Legal.DistrictWiseJurisdictionInfo.GetCourtByDistrictAndJurisdictionId;
using CleanArchitecture.Application.Features.Legal.DistrictWiseJurisdictionInfo.Queries;
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
    public class DistrictWiseJurisdictionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DistrictWiseJurisdictionController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet("GetAllDistrictWiseJurisdiction/{courtId}", Name = "GetAllDistrictWiseJurisdictionByCourtId")]
        public async Task<ActionResult<GetAllDistrictJurisdictionByCourtVm>> GetAllDistrictWiseJurisdictionByCourtId(int courtId)
        {
            var data = new GetAllDistrictJurisdictionByCourtQuery() { CourtId = courtId };
            var list = await _mediator.Send(data);
            return Ok(list);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        [Route("GetCourtByDistrictAndJurisdictionId/{districtId}/{jurisdictionId}")]
        public async Task<ActionResult<List<GetCourtByDistrictAndJurisdictionIdVm>>> GetAllGridData(int districtId, int jurisdictionId)
        {
            var allData = await _mediator.Send(new GetCourtByDistrictAndJurisdictionIdQuery()
            {
                DistrictId = districtId,
                JurisdictionId = jurisdictionId
            });
            return Ok(allData);
        }
    }
}
