using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestListenServiceBusAndEventhub.DBContextAndEntities
{
    public partial class UnicomRequestRawDatum
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at", TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; }
        [Required]
        [Column("request_url")]
        [StringLength(500)]
        public string RequestUrl { get; set; }
        [Required]
        [Column("request_data")]
        [StringLength(2000)]
        public string RequestData { get; set; }
        [Column("request_type")]
        public int RequestType { get; set; }
        [Column("vin")]
        [StringLength(50)]
        public string Vin { get; set; }
    }
}
