using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestAspDotNetCoreMVC.DBContextAndEntities
{
    [Table("transition_histories")]
    [Index(nameof(EnrollmentId), Name = "IX_TRANSITIONHISTORY_ENROLLMENT_ID")]
    public partial class TransitionHistory
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("enrollment_id")]
        public int EnrollmentId { get; set; }
        [Required]
        [Column("vin")]
        [StringLength(20)]
        public string Vin { get; set; }
        [Required]
        [Column("mobile")]
        [StringLength(50)]
        public string Mobile { get; set; }
        [Required]
        [Column("content")]
        [StringLength(300)]
        public string Content { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column("bizstatus")]
        public int Bizstatus { get; set; }
        [Required]
        [Column("record_status")]
        public bool? RecordStatus { get; set; }
    }
}
