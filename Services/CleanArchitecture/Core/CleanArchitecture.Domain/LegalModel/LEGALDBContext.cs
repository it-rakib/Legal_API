using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CleanArchitecture.Domain.LegalModel
{
    public partial class LEGALDBContext : DbContext
    {
        public LEGALDBContext()
        {
        }

        public LEGALDBContext(DbContextOptions<LEGALDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CaseFileMaster> CaseFileMasters { get; set; }
        public virtual DbSet<CaseType> CaseTypes { get; set; }
        public virtual DbSet<CmnDocument> CmnDocuments { get; set; }
        public virtual DbSet<CourtInfo> CourtInfos { get; set; }
        public virtual DbSet<DistrictWiseJurisdiction> DistrictWiseJurisdictions { get; set; }
        public virtual DbSet<ExpensesInfo> ExpensesInfos { get; set; }
        public virtual DbSet<FileType> FileTypes { get; set; }
        public virtual DbSet<JurisdictionInfo> JurisdictionInfos { get; set; }
        public virtual DbSet<LawyerInfo> LawyerInfos { get; set; }
        public virtual DbSet<MatterInfo> MatterInfos { get; set; }
        public virtual DbSet<OnBehalfOf> OnBehalfOfs { get; set; }
        public virtual DbSet<StatusInfo> StatusInfos { get; set; }
        public virtual DbSet<UpdateDiary> UpdateDiaries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CaseFileMaster>(entity =>
            {
                entity.HasKey(e => e.FileMasterId)
                    .HasName("PK__CaseFile__8871F1495F3BEC94");

                entity.ToTable("CaseFile_Master");

                entity.Property(e => e.CaseNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.FillingLawyer).HasMaxLength(150);

                entity.Property(e => e.FillingLawyerContact).HasMaxLength(150);

                entity.Property(e => e.IsPublish).HasColumnName("Is_Publish");

                entity.Property(e => e.OppositeLawyer).HasMaxLength(150);

                entity.Property(e => e.OppositeLawyerContact).HasMaxLength(150);

                entity.Property(e => e.OppositeParty).HasMaxLength(150);

                entity.Property(e => e.OppositePartyContact).HasMaxLength(150);

                entity.Property(e => e.Petitioner).HasMaxLength(150);

                entity.Property(e => e.PetitionerContact).HasMaxLength(150);

                entity.Property(e => e.RegNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.AssignLawyerNavigation)
                    .WithMany(p => p.CaseFileMasters)
                    .HasForeignKey(d => d.AssignLawyer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CaseFile_Master_Lawyer_Info");

                entity.HasOne(d => d.Court)
                    .WithMany(p => p.CaseFileMasters)
                    .HasForeignKey(d => d.CourtId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CaseFile___Court__47DBAE45");

                entity.HasOne(d => d.FileType)
                    .WithMany(p => p.CaseFileMasters)
                    .HasForeignKey(d => d.FileTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CaseFile___FileT__4E88ABD4");

                entity.HasOne(d => d.Matter)
                    .WithMany(p => p.CaseFileMasters)
                    .HasForeignKey(d => d.MatterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CaseFile___Matte__48CFD27E");

                entity.HasOne(d => d.OnBehalfOf)
                    .WithMany(p => p.CaseFileMasters)
                    .HasForeignKey(d => d.OnBehalfOfId)
                    .HasConstraintName("FK__CaseFile___OnBeh__160F4887");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.CaseFileMasters)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_CaseFile_Master_Status_Info");
            });

            modelBuilder.Entity<CaseType>(entity =>
            {
                entity.ToTable("CaseType");

                entity.Property(e => e.CaseTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CmnDocument>(entity =>
            {
                entity.HasKey(e => e.DocumentId)
                    .HasName("PK__CmnDocum__1ABEEF0F9EA9E728");

                entity.Property(e => e.FileExtension)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileUniqueName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CourtInfo>(entity =>
            {
                entity.HasKey(e => e.CourtId)
                    .HasName("PK__Court_In__C3A67C9A672F2976");

                entity.ToTable("Court_Info");

                entity.Property(e => e.CourtAddress).HasMaxLength(200);

                entity.Property(e => e.CourtName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CourtNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DistrictWiseJurisdiction>(entity =>
            {
                entity.ToTable("DistrictWiseJurisdiction");

                entity.HasOne(d => d.Court)
                    .WithMany(p => p.DistrictWiseJurisdictions)
                    .HasForeignKey(d => d.CourtId)
                    .HasConstraintName("FK_DistrictWiseJurisdiction_Court_Info1");

                entity.HasOne(d => d.Jurisdiction)
                    .WithMany(p => p.DistrictWiseJurisdictions)
                    .HasForeignKey(d => d.JurisdictionId)
                    .HasConstraintName("FK_DistrictWiseJurisdiction_Jurisdiction_Info");
            });

            modelBuilder.Entity<ExpensesInfo>(entity =>
            {
                entity.HasKey(e => e.ExpenseId)
                    .HasName("PK__Expenses__1445CFD3AB638AEC");

                entity.ToTable("Expenses_Info");

                entity.Property(e => e.Amount).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Discription).HasMaxLength(400);

                entity.Property(e => e.ExpenseDate).HasColumnType("datetime");

                entity.Property(e => e.ExpenseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.FileMaster)
                    .WithMany(p => p.ExpensesInfos)
                    .HasForeignKey(d => d.FileMasterId)
                    .HasConstraintName("FK__Expenses___FileM__571DF1D5");
            });

            modelBuilder.Entity<FileType>(entity =>
            {
                entity.ToTable("File_Type");

                entity.Property(e => e.FileTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileTypeNo)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JurisdictionInfo>(entity =>
            {
                entity.HasKey(e => e.JurisdictionId)
                    .HasName("PK__Jurisdic__160C652C8A352F4A");

                entity.ToTable("Jurisdiction_Info");

                entity.Property(e => e.JurisdictionName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LawyerInfo>(entity =>
            {
                entity.HasKey(e => e.LawyerId)
                    .HasName("PK__Lawyer_I__58AB68742693C537");

                entity.ToTable("Lawyer_Info");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LawyerAddress).HasMaxLength(200);

                entity.Property(e => e.LawyerName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MatterInfo>(entity =>
            {
                entity.HasKey(e => e.MatterId)
                    .HasName("PK__Matter_I__4D8E0B3AEECDF522");

                entity.ToTable("Matter_Info");

                entity.Property(e => e.Discription).HasMaxLength(400);

                entity.Property(e => e.MatterName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OnBehalfOf>(entity =>
            {
                entity.ToTable("OnBehalfOf");

                entity.Property(e => e.OnBehalfOfName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<StatusInfo>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__Status_I__C8EE2063B1E2E600");

                entity.ToTable("Status_Info");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UpdateDiary>(entity =>
            {
                entity.HasKey(e => e.DiaryId)
                    .HasName("PK__Update_D__267B56F41442F5AB");

                entity.ToTable("Update_Diary");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.NextDate).HasColumnType("datetime");

                entity.Property(e => e.NextDateFor).HasMaxLength(400);

                entity.Property(e => e.PreviousDate).HasColumnType("datetime");

                entity.Property(e => e.PreviousDateFor).HasMaxLength(400);

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.FileMaster)
                    .WithMany(p => p.UpdateDiaries)
                    .HasForeignKey(d => d.FileMasterId)
                    .HasConstraintName("FK__Update_Di__FileM__5441852A");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.UpdateDiaries)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Update_Diary_Status_Info");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
