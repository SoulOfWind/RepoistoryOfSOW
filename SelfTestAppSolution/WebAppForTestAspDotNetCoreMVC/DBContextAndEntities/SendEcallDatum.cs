using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestAspDotNetCoreMVC.DBContextAndEntities
{
    public partial class SendEcallDatum
    {
        [Key]
        public int Id { get; set; }
        public int EnrollmentId { get; set; }
        [Column("SendCASADataId")]
        public int SendCasadataId { get; set; }
        [Required]
        public string Gcid { get; set; }
        public int BizStatus { get; set; }
        public bool RecordStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; }
    }
}
