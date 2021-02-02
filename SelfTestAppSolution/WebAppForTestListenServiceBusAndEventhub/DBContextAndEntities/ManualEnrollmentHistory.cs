using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestListenServiceBusAndEventhub.DBContextAndEntities
{
    [Table("manual_enrollment_history")]
    public partial class ManualEnrollmentHistory
    {
        [Key]
        public int Id { get; set; }
        public int ManualEnrollmentId { get; set; }
        public int OperationType { get; set; }
        public int ReviewStatus { get; set; }
        [Required]
        [StringLength(4000)]
        public string Content { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Required]
        [StringLength(50)]
        public string Reviewer { get; set; }
    }
}
