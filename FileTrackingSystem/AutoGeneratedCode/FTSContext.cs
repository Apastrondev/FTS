using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FileTrackingSystem.AutoGeneratedCode
{
    public partial class FTSContext : DbContext
    {
        public FTSContext()
        {
        }

        public FTSContext(DbContextOptions<FTSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acceptance> Acceptances { get; set; } = null!;
        public virtual DbSet<Cc> Ccs { get; set; } = null!;
        public virtual DbSet<Classification> Classifications { get; set; } = null!;
        public virtual DbSet<DepartmentMaster> DepartmentMasters { get; set; } = null!;
        public virtual DbSet<Designation> Designations { get; set; } = null!;
        public virtual DbSet<District> Districts { get; set; } = null!;
        public virtual DbSet<EmployeeMaster> EmployeeMasters { get; set; } = null!;
        public virtual DbSet<FromTo> FromTos { get; set; } = null!;
        public virtual DbSet<Inward> Inwards { get; set; } = null!;
        public virtual DbSet<InwardOutward> InwardOutwards { get; set; } = null!;
        public virtual DbSet<Letter> Letters { get; set; } = null!;
        public virtual DbSet<ModeOfDispatch> ModeOfDispatches { get; set; } = null!;
        public virtual DbSet<OfficeMaster> OfficeMasters { get; set; } = null!;
        public virtual DbSet<OfficeType> OfficeTypes { get; set; } = null!;
        public virtual DbSet<Outward> Outwards { get; set; } = null!;
        public virtual DbSet<Reason> Reasons { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Section> Sections { get; set; } = null!;
        public virtual DbSet<SendToOutward> SendToOutwards { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;
        public virtual DbSet<Taluka> Talukas { get; set; } = null!;
        public virtual DbSet<TblConnectionString> TblConnectionStrings { get; set; } = null!;
        public virtual DbSet<TblExceptionLoggingToDataBase> TblExceptionLoggingToDatabases { get; set; } = null!;
        public virtual DbSet<UserMaster> UserMasters { get; set; } = null!;
        public virtual DbSet<Year> Years { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source = LAPTOP-63SAMREV\\SQLEXPRESS; initial catalog = FTS; integrated security = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acceptance>(entity =>
            {
                entity.ToTable("Acceptance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Status).HasMaxLength(500);
            });

            modelBuilder.Entity<Cc>(entity =>
            {
                entity.ToTable("CC");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Designation).HasMaxLength(500);
            });

            modelBuilder.Entity<Classification>(entity =>
            {
                entity.ToTable("Classification");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(500);
            });

            modelBuilder.Entity<DepartmentMaster>(entity =>
            {
                entity.ToTable("DepartmentMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.ToTable("Designation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Type).HasMaxLength(500);
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("District");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeMaster>(entity =>
            {
                entity.ToTable("EmployeeMaster");

                entity.Property(e => e.Designation).HasMaxLength(500);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(500);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Password).HasMaxLength(500);

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.EmployeeMasters)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EmployeeMaster_DepartmentMaster");
            });

            modelBuilder.Entity<FromTo>(entity =>
            {
                entity.ToTable("From_To");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<Inward>(entity =>
            {
                entity.ToTable("Inward");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcceptanceId).HasColumnName("AcceptanceID");

                entity.Property(e => e.AcceptedDate).HasColumnType("datetime");

                entity.Property(e => e.Cc3)
                    .HasMaxLength(1)
                    .HasColumnName("CC3");

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.ClassificationId).HasColumnName("ClassificationID");

                entity.Property(e => e.CompleteDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.InwardFrom).HasMaxLength(500);

                entity.Property(e => e.ReasonId).HasColumnName("ReasonID");

                entity.Property(e => e.ReassignDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceDate).HasColumnType("date");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.StatusChangeDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Acceptance)
                    .WithMany(p => p.Inwards)
                    .HasForeignKey(d => d.AcceptanceId)
                    .HasConstraintName("FK_AcceptanceId");

                entity.HasOne(d => d.Cc)
                    .WithMany(p => p.Inwards)
                    .HasForeignKey(d => d.Ccid)
                    .HasConstraintName("FK_CC");

                entity.HasOne(d => d.Classification)
                    .WithMany(p => p.Inwards)
                    .HasForeignKey(d => d.ClassificationId)
                    .HasConstraintName("FK_Classification");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.Inwards)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("FK_Designation");

                entity.HasOne(d => d.Reason)
                    .WithMany(p => p.Inwards)
                    .HasForeignKey(d => d.ReasonId)
                    .HasConstraintName("FK_Reason");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Inwards)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Status");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Inwards)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_Subject");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Inwards)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserMaster");
            });

            modelBuilder.Entity<InwardOutward>(entity =>
            {
                entity.ToTable("Inward_Outward");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InwardId).HasColumnName("InwardID");

                entity.Property(e => e.OutwardId).HasColumnName("OutwardID");

                entity.HasOne(d => d.Inward)
                    .WithMany(p => p.InwardOutwards)
                    .HasForeignKey(d => d.InwardId)
                    .HasConstraintName("FK_Inward");

                entity.HasOne(d => d.Outward)
                    .WithMany(p => p.InwardOutwards)
                    .HasForeignKey(d => d.OutwardId)
                    .HasConstraintName("FK_Outward");
            });

            modelBuilder.Entity<Letter>(entity =>
            {
                entity.ToTable("Letter");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Type).HasMaxLength(500);
            });

            modelBuilder.Entity<ModeOfDispatch>(entity =>
            {
                entity.ToTable("ModeOfDispatch");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<OfficeMaster>(entity =>
            {
                entity.ToTable("OfficeMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Contact1).HasMaxLength(50);

                entity.Property(e => e.Contact2).HasMaxLength(50);

                entity.Property(e => e.Ddocode).HasColumnName("DDOCode");

                entity.Property(e => e.District).HasMaxLength(500);

                entity.Property(e => e.Email).HasMaxLength(500);

                entity.Property(e => e.Fax).HasMaxLength(500);

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.OfficeName).HasMaxLength(500);

                entity.Property(e => e.OfficeTypeId).HasColumnName("OfficeTypeID");

                entity.Property(e => e.RegionalOfficeId).HasColumnName("RegionalOfficeID");

                entity.Property(e => e.Taluka).HasMaxLength(500);

                entity.Property(e => e.WebSite).HasMaxLength(500);

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.InverseOffice)
                    .HasForeignKey(d => d.OfficeId)
                    .HasConstraintName("FK_OfficeMaster");

                entity.HasOne(d => d.OfficeType)
                    .WithMany(p => p.OfficeMasters)
                    .HasForeignKey(d => d.OfficeTypeId)
                    .HasConstraintName("FK_OfficeType");
            });

            modelBuilder.Entity<OfficeType>(entity =>
            {
                entity.ToTable("OfficeType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Type).HasMaxLength(500);
            });

            modelBuilder.Entity<Outward>(entity =>
            {
                entity.ToTable("Outward");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcceptanceId).HasColumnName("AcceptanceID");

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.CompleteDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DispatchDate).HasColumnType("datetime");

                entity.Property(e => e.DispatchId).HasColumnName("DispatchID");

                entity.Property(e => e.OutwardTo).HasMaxLength(500);

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Cc)
                    .WithMany(p => p.Outwards)
                    .HasForeignKey(d => d.Ccid)
                    .HasConstraintName("FK_CC1");

                entity.HasOne(d => d.Dispatch)
                    .WithMany(p => p.Outwards)
                    .HasForeignKey(d => d.DispatchId)
                    .HasConstraintName("FK_ModeOfDispatch");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Outwards)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_Subject1");
            });

            modelBuilder.Entity<Reason>(entity =>
            {
                entity.ToTable("Reason");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Designation).HasMaxLength(500);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Role1)
                    .HasMaxLength(500)
                    .HasColumnName("Role");
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.ToTable("Section");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<SendToOutward>(entity =>
            {
                entity.ToTable("SendToOutward");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(500);
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.ToTable("Subject");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.SubName).HasMaxLength(500);
            });

            modelBuilder.Entity<Taluka>(entity =>
            {
                entity.ToTable("Taluka");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Talukas)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_Taluka_District");
            });

            modelBuilder.Entity<TblConnectionString>(entity =>
            {
                entity.ToTable("tblConnectionStrings");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<TblExceptionLoggingToDataBase>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK__TblExcep__5E548648C1FCF2E7");

                entity.ToTable("TblExceptionLoggingToDataBase");

                entity.Property(e => e.ExceptionUrl).HasColumnName("ExceptionURL");

                entity.Property(e => e.Logdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserMaster>(entity =>
            {
                entity.ToTable("UserMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdharCardNo).HasMaxLength(50);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.Designation).HasMaxLength(500);

                entity.Property(e => e.Email).HasMaxLength(500);

                entity.Property(e => e.FaxNo).HasMaxLength(500);

                entity.Property(e => e.Gender).HasMaxLength(20);

                entity.Property(e => e.MobileNumber).HasMaxLength(30);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Password).HasMaxLength(500);

                entity.Property(e => e.RegisterDateTime).HasColumnType("datetime");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Section).HasMaxLength(500);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserMasters)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Role");
            });

            modelBuilder.Entity<Year>(entity =>
            {
                entity.ToTable("Year");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Year1)
                    .HasMaxLength(500)
                    .HasColumnName("Year");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
