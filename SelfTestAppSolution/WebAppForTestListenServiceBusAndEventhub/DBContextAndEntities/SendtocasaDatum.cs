using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestListenServiceBusAndEventhub.DBContextAndEntities
{
    [Table("sendtocasa_data")]
    [Index(nameof(Mobile), Name = "IX_SENDTOCASADATA_MOBILE")]
    [Index(nameof(Vin), Name = "IX_SENDTOCASADATA_VIN")]
    public partial class SendtocasaDatum
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Vin { get; set; }
        [Required]
        [StringLength(50)]
        public string Mobile { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string Pin { get; set; }
        public short CustomerCategory { get; set; }
        [Required]
        [StringLength(50)]
        public string Gcid { get; set; }
        [Required]
        [Column("IDCardType")]
        [StringLength(50)]
        public string IdcardType { get; set; }
        [Required]
        [Column("IDCardNo")]
        [StringLength(50)]
        public string IdcardNo { get; set; }
        [Required]
        [Column("IDCardExpires")]
        [StringLength(50)]
        public string IdcardExpires { get; set; }
        public int CommunicationChannel { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        public bool ConnectivityStatus { get; set; }
        [Required]
        [StringLength(50)]
        public string SalesType { get; set; }
        [Required]
        [StringLength(30)]
        public string VehicleLicence { get; set; }
        public int MapUpdateArea { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TermServiceBegins { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TermServiceExpires { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HandoverDate { get; set; }
        [Required]
        [StringLength(50)]
        public string InvoiceNo { get; set; }
        [Required]
        [Column("EMergencyContact1")]
        [StringLength(500)]
        public string EmergencyContact1 { get; set; }
        [Required]
        [Column("EMergencyContact2")]
        [StringLength(500)]
        public string EmergencyContact2 { get; set; }
        [Required]
        [Column("EMergencyContact3")]
        [StringLength(500)]
        public string EmergencyContact3 { get; set; }
        public int BizStatus { get; set; }
        public bool RecordStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; }
        [Required]
        [StringLength(30)]
        public string CompanyName { get; set; }
    }
}
