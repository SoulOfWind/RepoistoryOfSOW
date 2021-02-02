using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestListenServiceBusAndEventhub.DBContextAndEntities
{
    [Table("enrollment_entries")]
    public partial class EnrollmentEntry
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("usid")]
        [StringLength(50)]
        public string Usid { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at", TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; }
        [Column("status")]
        public int Status { get; set; }
    }
}
