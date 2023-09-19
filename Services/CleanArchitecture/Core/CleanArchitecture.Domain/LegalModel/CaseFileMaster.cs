using System;
using System.Collections.Generic;

namespace CleanArchitecture.Domain.LegalModel
{
    public partial class CaseFileMaster
    {
        public CaseFileMaster()
        {
            ExpensesInfos = new HashSet<ExpensesInfo>();
            UpdateDiaries = new HashSet<UpdateDiary>();
        }

        public int FileMasterId { get; set; }
        public string RegNo { get; set; }
        public string CaseNo { get; set; }
        public int CourtId { get; set; }
        public int MatterId { get; set; }
        public int AssignLawyer { get; set; }
        public string FillingLawyer { get; set; }
        public string OppositeLawyer { get; set; }
        public int FileTypeId { get; set; }
        public int? UnitId { get; set; }
        public string Discription { get; set; }
        public bool? IsPublish { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public string Petitioner { get; set; }
        public string OppositeParty { get; set; }
        public string PetitionerContact { get; set; }
        public string OppositePartyContact { get; set; }
        public int? StatusId { get; set; }
        public string FillingLawyerContact { get; set; }
        public string OppositeLawyerContact { get; set; }
        public DateTime? StatusDate { get; set; }
        public int? CompanyId { get; set; }
        public int? OnBehalfOfId { get; set; }
        public int? DeletedBy { get; set; }

        public virtual LawyerInfo AssignLawyerNavigation { get; set; }
        public virtual CourtInfo Court { get; set; }
        public virtual FileType FileType { get; set; }
        public virtual MatterInfo Matter { get; set; }
        public virtual OnBehalfOf OnBehalfOf { get; set; }
        public virtual StatusInfo Status { get; set; }
        public virtual ICollection<ExpensesInfo> ExpensesInfos { get; set; }
        public virtual ICollection<UpdateDiary> UpdateDiaries { get; set; }
    }
}
