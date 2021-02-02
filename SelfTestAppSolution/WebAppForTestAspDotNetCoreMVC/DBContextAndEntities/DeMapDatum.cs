using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestAspDotNetCoreMVC.DBContextAndEntities
{
    [Index(nameof(Gcid), Name = "IX_DEMAPDATA_GCID")]
    [Index(nameof(Vin), Name = "IX_DEMAPDATA_VIN")]
    public partial class DeMapDatum
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string RelationId { get; set; }
        [Required]
        [StringLength(50)]
        public string Gcid { get; set; }
        [Required]
        [StringLength(20)]
        public string Vin { get; set; }
        public int DeMapFrom { get; set; }
        public bool RecordStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; }
    }
}
