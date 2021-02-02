using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestAspDotNetCoreMVC.DBContextAndEntities
{
    [Table("SendToGCDMData")]
    [Index(nameof(Gcid), Name = "IX_SENDTOGCDMDATA_GCID")]
    public partial class SendToGcdmdatum
    {
        [Key]
        public int Id { get; set; }
        public int BizStatus { get; set; }
        [Required]
        [Column("GCID")]
        [StringLength(50)]
        public string Gcid { get; set; }
        [Required]
        [StringLength(50)]
        public string Pin { get; set; }
        [Required]
        [StringLength(30)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(30)]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(30)]
        public string Lastname { get; set; }
        [Required]
        [StringLength(30)]
        public string Company { get; set; }
        public bool Gender { get; set; }
        [Required]
        [StringLength(50)]
        public string PartnerCategory { get; set; }
        [Required]
        [StringLength(50)]
        public string Phone { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string CommunicationChannel { get; set; }
        public bool RecordStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; }
    }
}
