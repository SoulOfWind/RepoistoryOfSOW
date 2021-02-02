using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestAspDotNetCoreMVC.DBContextAndEntities
{
    [Table("invoice_request")]
    [Index(nameof(Usid), Name = "IX_INVOICEREQUEST_USID")]
    [Index(nameof(Vin), Name = "IX_INVOICEREQUEST_VIN")]
    public partial class InvoiceRequest
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Vin { get; set; }
        [Required]
        [StringLength(50)]
        public string Usid { get; set; }
        [Required]
        [StringLength(500)]
        public string ImageUrl { get; set; }
        [Required]
        [StringLength(500)]
        public string NewImageUrl { get; set; }
        [Required]
        [StringLength(50)]
        public string InvoiceCode { get; set; }
        [Required]
        [StringLength(50)]
        public string InvoiceNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime InvoiceDate { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomName { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomId { get; set; }
        [Required]
        [StringLength(30)]
        public string EngineNo { get; set; }
        [Required]
        [StringLength(50)]
        public string ShopName { get; set; }
        [Required]
        [StringLength(30)]
        public string ShopTel { get; set; }
        [Required]
        [StringLength(100)]
        public string ShopAddress { get; set; }
        [Required]
        [StringLength(500)]
        public string HidenPosition { get; set; }
        [Required]
        [Column("CustomVATNo")]
        [StringLength(50)]
        public string CustomVatno { get; set; }
        [Required]
        [StringLength(50)]
        public string VehicleCategory { get; set; }
        [Required]
        [StringLength(50)]
        public string Nameplate { get; set; }
        [Required]
        [StringLength(50)]
        public string Place { get; set; }
        [Required]
        [StringLength(100)]
        public string CertificateNo { get; set; }
        [Required]
        [StringLength(100)]
        public string ImportCertificateNo { get; set; }
        [Required]
        [StringLength(100)]
        public string CommodityInspectionReportNo { get; set; }
        [Required]
        [StringLength(100)]
        public string ShopTaxpayerNo { get; set; }
        [Required]
        [StringLength(50)]
        public string ShopAccount { get; set; }
        [Required]
        [StringLength(100)]
        public string ShopBankAccount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Tonnage { get; set; }
        public int LimitedNo { get; set; }
        public bool Validation { get; set; }
        [Column("VATRate", TypeName = "decimal(18, 2)")]
        public decimal Vatrate { get; set; }
        [Column("VATAmount", TypeName = "decimal(18, 2)")]
        public decimal Vatamount { get; set; }
        [Required]
        [Column("VATMgtCode")]
        [StringLength(100)]
        public string VatmgtCode { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal VehicleAmount { get; set; }
        [Required]
        [Column("VATProofNo")]
        [StringLength(100)]
        public string VatproofNo { get; set; }
        [Required]
        [StringLength(100)]
        public string TotalAmountUperCase { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalAmountLowerCase { get; set; }
        public bool RecordStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; }
    }
}
