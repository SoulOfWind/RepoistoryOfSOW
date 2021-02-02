using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestAspDotNetCoreMVC.DBContextAndEntities
{
    [Table("dms_data")]
    [Index(nameof(Phone), Name = "IX_DMSDATA_PHONE")]
    [Index(nameof(SeriesNo), Name = "IX_DMSDATA_SERIESNO", IsUnique = true)]
    [Index(nameof(Vin), Name = "IX_DMSDATA_VIN")]
    public partial class DmsDatum
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string SeriesNo { get; set; }
        [Required]
        [StringLength(20)]
        public string Vin { get; set; }
        [Required]
        [StringLength(50)]
        public string Phone { get; set; }
        [Required]
        [Column("CustomerID")]
        [StringLength(50)]
        public string CustomerId { get; set; }
        public int DealerId { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string CompanyName { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        public bool HandOverType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HandoverDate { get; set; }
        [Required]
        [StringLength(50)]
        public string InvoiceNo { get; set; }
        [Required]
        [StringLength(2)]
        public string NewUsed { get; set; }
        public bool TradeIn { get; set; }
        public int TradeVeh { get; set; }
        [Required]
        [StringLength(20)]
        public string Extn1 { get; set; }
        [Required]
        [StringLength(20)]
        public string Series { get; set; }
        public bool ConnectedDrive { get; set; }
        [Required]
        [StringLength(20)]
        public string ItemCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TermServiceBegins { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TermServiceExpires { get; set; }
        [Required]
        [Column("UCReplaceBrand")]
        [StringLength(50)]
        public string UcreplaceBrand { get; set; }
        [Required]
        [Column("UCReplaceModel")]
        [StringLength(50)]
        public string UcreplaceModel { get; set; }
        [Required]
        [Column("UCVin")]
        [StringLength(20)]
        public string Ucvin { get; set; }
        public int VehicleSoruce { get; set; }
        [Required]
        [StringLength(50)]
        public string IdNumber { get; set; }
        [Column("CDCommunicationChannel")]
        public int CdcommunicationChannel { get; set; }
        [Column("CDHomeRegion")]
        public int CdhomeRegion { get; set; }
        [Required]
        [StringLength(50)]
        public string VerifyPin { get; set; }
        public int BizStatus { get; set; }
        public bool RecordStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; }
    }
}
