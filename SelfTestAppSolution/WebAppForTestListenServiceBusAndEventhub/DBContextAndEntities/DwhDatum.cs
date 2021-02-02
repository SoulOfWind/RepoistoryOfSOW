using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestListenServiceBusAndEventhub.DBContextAndEntities
{
    [Table("dwh_data")]
    [Index(nameof(EnrollmentRequestId), Name = "IX_DWHDATA_ENROLLMENTREQUESTID")]
    [Index(nameof(Mobile), Name = "IX_DWHDATA_MOBILE")]
    [Index(nameof(Vin), Name = "IX_DWHDATA_VIN")]
    public partial class DwhDatum
    {
        [Key]
        public int Id { get; set; }
        public int EnrollmentRequestId { get; set; }
        [Required]
        [StringLength(20)]
        public string Vin { get; set; }
        [Required]
        [StringLength(50)]
        public string Mobile { get; set; }
        [StringLength(50)]
        public string ContractStatus { get; set; }
        [Column("DWHStatus")]
        public int? Dwhstatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }
        [StringLength(50)]
        public string OfferId { get; set; }
        [StringLength(1000)]
        public string ServiceId { get; set; }
        [StringLength(50)]
        public string RelationId { get; set; }
    }
}
