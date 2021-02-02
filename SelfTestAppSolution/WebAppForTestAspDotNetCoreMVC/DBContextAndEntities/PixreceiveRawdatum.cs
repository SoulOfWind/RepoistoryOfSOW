using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestAspDotNetCoreMVC.DBContextAndEntities
{
    [Table("pixreceive_rawdata")]
    public partial class PixreceiveRawdatum
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at", TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Required]
        [Column("chassisno")]
        [StringLength(20)]
        public string Chassisno { get; set; }
        [Required]
        [Column("contract_status")]
        [StringLength(20)]
        public string ContractStatus { get; set; }
        [Required]
        [Column("mobilephone")]
        [StringLength(50)]
        public string Mobilephone { get; set; }
        [Required]
        [Column("term_service_begins")]
        [StringLength(50)]
        public string TermServiceBegins { get; set; }
        [Required]
        [Column("term_service_expires")]
        [StringLength(50)]
        public string TermServiceExpires { get; set; }
    }
}
