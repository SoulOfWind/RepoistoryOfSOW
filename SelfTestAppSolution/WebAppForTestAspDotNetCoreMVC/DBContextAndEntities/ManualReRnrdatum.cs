using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestAspDotNetCoreMVC.DBContextAndEntities
{
    [Table("ManualReRNRData")]
    [Index(nameof(CreateAt), Name = "IX_MANUALRERNRDATA_CREATEAT")]
    [Index(nameof(EnrollmentRequestId), Name = "IX_MANUALRERNRDATA_ENROLLMENTREQUESTID")]
    [Index(nameof(Mobile), Name = "IX_MANUALRERNRDATA_MOBILE")]
    [Index(nameof(UpdateAt), Name = "IX_MANUALRERNRDATA_UPDATEAT")]
    [Index(nameof(Vin), Name = "IX_MANUALRERNRDATA_VIN")]
    public partial class ManualReRnrdatum
    {
        [Key]
        public int Id { get; set; }
        public int EnrollmentRequestId { get; set; }
        [Required]
        [StringLength(20)]
        public string Vin { get; set; }
        [Required]
        [StringLength(50)]
        public string Mobile { get; set; }
        [Required]
        [Column("RNRReturnCode")]
        [StringLength(50)]
        public string RnrreturnCode { get; set; }
        [Required]
        [Column("RNRFailedReason")]
        [StringLength(200)]
        public string RnrfailedReason { get; set; }
        [Column("RNRFailedTime", TypeName = "datetime")]
        public DateTime RnrfailedTime { get; set; }
        public int ProcessingStatus { get; set; }
        public bool RecordStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateAt { get; set; }
        [Required]
        [StringLength(50)]
        public string CreateBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdateAt { get; set; }
        [Required]
        [StringLength(50)]
        public string UpdateBy { get; set; }
    }
}
