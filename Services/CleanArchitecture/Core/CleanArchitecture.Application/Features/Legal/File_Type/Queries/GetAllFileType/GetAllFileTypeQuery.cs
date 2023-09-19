using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Legal.File_Type.Queries.GetAllFileType
{
    public class GetAllFileTypeQuery : IRequest<List<GetAllFileTypeVm>>
    {
    }
}
