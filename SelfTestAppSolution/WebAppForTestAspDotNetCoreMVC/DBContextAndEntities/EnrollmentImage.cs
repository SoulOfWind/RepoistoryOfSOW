using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestAspDotNetCoreMVC.DBContextAndEntities
{
    [Table("enrollment_images")]
    public partial class EnrollmentImage
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("enrollment_request_id")]
        public int EnrollmentRequestId { get; set; }
        public int PicType { get; set; }
        [Required]
        [StringLength(500)]
        public string PicUrl { get; set; }
        [Column("create_at", TypeName = "datetime")]
        public DateTime CreateAt { get; set; }
        [Column("update_at", TypeName = "datetime")]
        public DateTime UpdateAt { get; set; }
    }
}
