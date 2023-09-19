using System;

namespace CleanArchitecture.Application.Features.Legal.CaseFile_Master.Command.CreateUpdateCaseFileMaster
{
    public class CreateUpdateCaseFileMasterDto
    {
        public int FileMasterId { get; set; }
        public string RegNo { get; set; }
        public string CaseNo { get; set; }
    }
}
