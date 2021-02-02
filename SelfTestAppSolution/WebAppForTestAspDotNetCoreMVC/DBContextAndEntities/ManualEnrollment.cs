using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestAspDotNetCoreMVC.DBContextAndEntities
{
    [Table("manual_enrollment")]
    public partial class ManualEnrollment
    {
        [Key]
        public int Id { get; set; }
        public Guid Usid { get; set; }
        [Required]
        [StringLength(50)]
        public string Mobile { get; set; }
        [Required]
        [StringLength(17)]
        public string FullVin { get; set; }
        [Required]
        [StringLength(20)]
        public string UserName { get; set; }
        public short PicType { get; set; }
        [Required]
        [StringLength(4000)]
        public string PicUrl { get; set; }
        public short IsConsistent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EnrollmentCreatedAt { get; set; }
        [Required]
        [StringLength(17)]
        public string OriginalVin { get; set; }
        [Required]
        [StringLength(20)]
        public string OriginalUserName { get; set; }
        public int ReviewStatus { get; set; }
        public int FailReason { get; set; }
        [Required]
        [StringLength(30)]
        public string OtherFailReason { get; set; }
        [Required]
        [StringLength(30)]
        public string EngineNo { get; set; }
        [Required]
        [StringLength(30)]
        public string LicenseNo { get; set; }
        [Required]
        [StringLength(10)]
        public string RegistartionDate { get; set; }
        [Required]
        [StringLength(10)]
        public string IssueCertificationDate { get; set; }
        [Required]
        [StringLength(10)]
        public string IssueInvoiceDate { get; set; }
        [StringLength(50)]
        public string CardNo { get; set; }
        [StringLength(50)]
        public string OriginalCardNo { get; set; }
    }
}
