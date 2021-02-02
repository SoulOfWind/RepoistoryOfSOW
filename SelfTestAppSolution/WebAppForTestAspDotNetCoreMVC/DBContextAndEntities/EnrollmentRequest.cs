using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestAspDotNetCoreMVC.DBContextAndEntities
{
    [Table("enrollment_requests")]
    [Index(nameof(CardNo), Name = "IX_ENROLLMENTREQUEST_IDCARD")]
    [Index(nameof(Mobile), Name = "IX_ENROLLMENTREQUEST_MOBILE")]
    [Index(nameof(Usid), Name = "IX_ENROLLMENTREQUEST_USID")]
    [Index(nameof(Vin), Name = "IX_ENROLLMENTREQUEST_VIN")]
    public partial class EnrollmentRequest
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("register_type")]
        public int RegisterType { get; set; }
        [Required]
        [Column("vin")]
        [StringLength(20)]
        public string Vin { get; set; }
        [Required]
        [Column("company_name")]
        [StringLength(30)]
        public string CompanyName { get; set; }
        [Required]
        [Column("family_name")]
        [StringLength(30)]
        public string FamilyName { get; set; }
        [Required]
        [Column("given_name")]
        [StringLength(30)]
        public string GivenName { get; set; }
        [Column("gender")]
        public bool? Gender { get; set; }
        [Required]
        [Column("mobile")]
        [StringLength(50)]
        public string Mobile { get; set; }
        [Column("isagree")]
        public bool Isagree { get; set; }
        [Required]
        [Column("card_no")]
        [StringLength(50)]
        public string CardNo { get; set; }
        [Required]
        [Column("address")]
        [StringLength(50)]
        public string Address { get; set; }
        [Required]
        [Column("cd_pin")]
        [StringLength(50)]
        public string CdPin { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("create_at", TypeName = "datetime")]
        public DateTime CreateAt { get; set; }
        [Column("update_at", TypeName = "datetime")]
        public DateTime UpdateAt { get; set; }
        [Required]
        [Column("usid")]
        [StringLength(50)]
        public string Usid { get; set; }
        [Column("realnamerawdata")]
        public string Realnamerawdata { get; set; }
        [Column("verify_at", TypeName = "datetime")]
        public DateTime VerifyAt { get; set; }
        [Column("company_type")]
        [StringLength(2)]
        public string CompanyType { get; set; }
        [Column("company_address")]
        [StringLength(50)]
        public string CompanyAddress { get; set; }
        [Column("industry_type")]
        [StringLength(10)]
        public string IndustryType { get; set; }
        [Column("license_no")]
        [StringLength(30)]
        public string LicenseNo { get; set; }
        [Required]
        [Column("card_type")]
        [StringLength(50)]
        public string CardType { get; set; }
        [Column("source_name")]
        public int SourceName { get; set; }
        [Required]
        [Column("record_status")]
        public bool? RecordStatus { get; set; }
        [Required]
        [Column("gcid")]
        [StringLength(50)]
        public string Gcid { get; set; }
        [Column("is_used_car")]
        public bool IsUsedCar { get; set; }
    }
}
