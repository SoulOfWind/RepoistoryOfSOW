using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestAspDotNetCoreMVC.DBContextAndEntities
{
    [Table("ecall_contacts")]
    public partial class EcallContact
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("enrollment_request_id")]
        public int EnrollmentRequestId { get; set; }
        [Required]
        [Column("family_name")]
        [StringLength(30)]
        public string FamilyName { get; set; }
        [Required]
        [Column("given_name")]
        [StringLength(30)]
        public string GivenName { get; set; }
        [Required]
        [Column("mobile")]
        [StringLength(50)]
        public string Mobile { get; set; }
        [Required]
        [Column("relationship")]
        [StringLength(30)]
        public string Relationship { get; set; }
        [Column("ecall_order")]
        public int EcallOrder { get; set; }
        [Column("create_at", TypeName = "datetime")]
        public DateTime CreateAt { get; set; }
        [Column("update_at", TypeName = "datetime")]
        public DateTime UpdateAt { get; set; }
    }
}
