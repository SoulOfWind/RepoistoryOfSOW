using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebAppForTestListenServiceBusAndEventhub.DBContextAndEntities
{
    public partial class CDPreActivationDbContext : DbContext
    {
        public CDPreActivationDbContext()
        {
        }

        public CDPreActivationDbContext(DbContextOptions<CDPreActivationDbContext> options)
            : base(options)
        {
        }


        public virtual DbSet<ConfigInfo> ConfigInfos { get; set; }
        public virtual DbSet<DeMapDatum> DeMapData { get; set; }
        public virtual DbSet<DmsDatum> DmsData { get; set; }
        public virtual DbSet<DmsRawdatum> DmsRawdata { get; set; }
        public virtual DbSet<DwhDatum> DwhData { get; set; }
        public virtual DbSet<EcallContact> EcallContacts { get; set; }
        public virtual DbSet<EnrollmentEntry> EnrollmentEntries { get; set; }
        public virtual DbSet<EnrollmentImage> EnrollmentImages { get; set; }
        public virtual DbSet<EnrollmentRequest> EnrollmentRequests { get; set; }
        public virtual DbSet<EnrollmentRequestHistory> EnrollmentRequestHistories { get; set; }
        public virtual DbSet<InternalVehicleRequest> InternalVehicleRequests { get; set; }
        public virtual DbSet<InvoiceRequest> InvoiceRequests { get; set; }
        public virtual DbSet<ManualEnrollment> ManualEnrollments { get; set; }
        public virtual DbSet<ManualEnrollmentHistory> ManualEnrollmentHistories { get; set; }
        public virtual DbSet<ManualEnrollmentNotificationHistory> ManualEnrollmentNotificationHistories { get; set; }
        public virtual DbSet<ManualReRnrdatum> ManualReRnrdata { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<PixreceiveRawdatum> PixreceiveRawdata { get; set; }
        public virtual DbSet<PixsendRawdatum> PixsendRawdata { get; set; }
        public virtual DbSet<SendEcallDatum> SendEcallData { get; set; }
        public virtual DbSet<SendToGcdmdatum> SendToGcdmdata { get; set; }
        public virtual DbSet<SendtocasaDatum> SendtocasaData { get; set; }
        public virtual DbSet<TransitionHistoriesbak> TransitionHistoriesbaks { get; set; }
        public virtual DbSet<TransitionHistory> TransitionHistories { get; set; }
        public virtual DbSet<UnicomRequestRawDatum> UnicomRequestRawData { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WeatherForecast> WeatherForecasts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DmsDatum>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Extn1).IsUnicode(false);

                entity.Property(e => e.IdNumber).IsUnicode(false);

                entity.Property(e => e.ItemCode).IsUnicode(false);

                entity.Property(e => e.NewUsed)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Phone).IsUnicode(false);

                entity.Property(e => e.Series).IsUnicode(false);

                entity.Property(e => e.SeriesNo).IsUnicode(false);

                entity.Property(e => e.UcreplaceBrand).IsUnicode(false);

                entity.Property(e => e.UcreplaceModel).IsUnicode(false);

                entity.Property(e => e.Ucvin).IsUnicode(false);

                entity.Property(e => e.VerifyPin).IsUnicode(false);

                entity.Property(e => e.Vin).IsUnicode(false);
            });

            modelBuilder.Entity<DmsRawdatum>(entity =>
            {
                entity.Property(e => e.DealerId).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Extn1).IsUnicode(false);

                entity.Property(e => e.IdNumber).IsUnicode(false);

                entity.Property(e => e.ItemCode).IsUnicode(false);

                entity.Property(e => e.NewUsed)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Phone).IsUnicode(false);

                entity.Property(e => e.Series).IsUnicode(false);

                entity.Property(e => e.SeriesNo).IsUnicode(false);

                entity.Property(e => e.UcreplaceBrand).IsUnicode(false);

                entity.Property(e => e.UcreplaceModel).IsUnicode(false);

                entity.Property(e => e.Ucvin).IsUnicode(false);

                entity.Property(e => e.VerifyPin).IsUnicode(false);

                entity.Property(e => e.Vin).IsUnicode(false);
            });

            modelBuilder.Entity<EnrollmentImage>(entity =>
            {
                entity.Property(e => e.PicUrl).IsUnicode(false);
            });

            modelBuilder.Entity<EnrollmentRequest>(entity =>
            {
                entity.Property(e => e.CardType).HasDefaultValueSql("('IDCARD')");

                entity.Property(e => e.Gcid).HasDefaultValueSql("('')");

                entity.Property(e => e.RecordStatus).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<InternalVehicleRequest>(entity =>
            {
                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.CustomerId).IsUnicode(false);

                entity.Property(e => e.Mobile).IsUnicode(false);

                entity.Property(e => e.Pin).IsUnicode(false);

                entity.Property(e => e.RoleName).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);

                entity.Property(e => e.Vin).IsUnicode(false);
            });

            modelBuilder.Entity<InvoiceRequest>(entity =>
            {
                entity.Property(e => e.CustomId).IsUnicode(false);

                entity.Property(e => e.CustomVatno).IsUnicode(false);

                entity.Property(e => e.EngineNo).IsUnicode(false);

                entity.Property(e => e.HidenPosition).IsUnicode(false);

                entity.Property(e => e.ImageUrl).IsUnicode(false);

                entity.Property(e => e.NewImageUrl).IsUnicode(false);

                entity.Property(e => e.ShopAccount).IsUnicode(false);

                entity.Property(e => e.ShopTel).IsUnicode(false);

                entity.Property(e => e.Vin).IsUnicode(false);
            });

            modelBuilder.Entity<ManualEnrollment>(entity =>
            {
                entity.Property(e => e.EngineNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FullVin).IsUnicode(false);

                entity.Property(e => e.IssueCertificationDate)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IssueInvoiceDate)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LicenseNo).HasDefaultValueSql("('')");

                entity.Property(e => e.Mobile).IsUnicode(false);

                entity.Property(e => e.OriginalUserName).HasDefaultValueSql("('')");

                entity.Property(e => e.OriginalVin)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OtherFailReason).HasDefaultValueSql("('')");

                entity.Property(e => e.RegistartionDate)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ManualEnrollmentHistory>(entity =>
            {
                entity.Property(e => e.Reviewer).IsUnicode(false);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");
            });

            modelBuilder.Entity<SendtocasaDatum>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Gcid).IsUnicode(false);

                entity.Property(e => e.IdcardNo).IsUnicode(false);

                entity.Property(e => e.IdcardType).IsUnicode(false);

                entity.Property(e => e.Mobile).IsUnicode(false);

                entity.Property(e => e.Pin).IsUnicode(false);

                entity.Property(e => e.VehicleLicence).IsUnicode(false);

                entity.Property(e => e.Vin).IsUnicode(false);
            });

            modelBuilder.Entity<TransitionHistoriesbak>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TransitionHistory>(entity =>
            {
                entity.Property(e => e.Bizstatus).HasDefaultValueSql("((-1))");

                entity.Property(e => e.RecordStatus).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<UnicomRequestRawDatum>(entity =>
            {
                entity.Property(e => e.RequestType).HasDefaultValueSql("((200))");
            });

            modelBuilder.HasSequence("TestSequence")
                .StartsAt(0)
                .HasMin(0)
                .HasMax(3)
                .IsCyclic();

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
