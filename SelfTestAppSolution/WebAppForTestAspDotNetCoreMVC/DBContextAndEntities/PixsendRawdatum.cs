using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestAspDotNetCoreMVC.DBContextAndEntities
{
    [Table("pixsend_rawdata")]
    public partial class PixsendRawdatum
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
        [Column("personal_family_name")]
        [StringLength(50)]
        public string PersonalFamilyName { get; set; }
        [Required]
        [Column("personal_given_name")]
        [StringLength(50)]
        public string PersonalGivenName { get; set; }
        [Required]
        [Column("business_name")]
        [StringLength(50)]
        public string BusinessName { get; set; }
        [Required]
        [Column("title")]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [Column("mobilephone")]
        [StringLength(50)]
        public string Mobilephone { get; set; }
        [Required]
        [Column("pin_cd")]
        [StringLength(20)]
        public string PinCd { get; set; }
        [Required]
        [Column("name1_ecallp1")]
        [StringLength(50)]
        public string Name1Ecallp1 { get; set; }
        [Required]
        [Column("name2_ecallp1")]
        [StringLength(50)]
        public string Name2Ecallp1 { get; set; }
        [Required]
        [Column("phone_ecallp1")]
        [StringLength(50)]
        public string PhoneEcallp1 { get; set; }
        [Required]
        [Column("rels_ecallp1")]
        [StringLength(50)]
        public string RelsEcallp1 { get; set; }
        [Required]
        [Column("name1_ecallp2")]
        [StringLength(50)]
        public string Name1Ecallp2 { get; set; }
        [Required]
        [Column("name2_ecallp2")]
        [StringLength(50)]
        public string Name2Ecallp2 { get; set; }
        [Required]
        [Column("phone_ecallp2")]
        [StringLength(50)]
        public string PhoneEcallp2 { get; set; }
        [Required]
        [Column("rels_ecallp2")]
        [StringLength(50)]
        public string RelsEcallp2 { get; set; }
        [Required]
        [Column("name1_ecallp3")]
        [StringLength(50)]
        public string Name1Ecallp3 { get; set; }
        [Required]
        [Column("name2_ecallp3")]
        [StringLength(50)]
        public string Name2Ecallp3 { get; set; }
        [Required]
        [Column("phone_ecallp3")]
        [StringLength(50)]
        public string PhoneEcallp3 { get; set; }
        [Required]
        [Column("rels_ecallp3")]
        [StringLength(50)]
        public string RelsEcallp3 { get; set; }
        [Required]
        [Column("customer_identification")]
        [StringLength(50)]
        public string CustomerIdentification { get; set; }
        [Required]
        [Column("customer_identification_type")]
        [StringLength(50)]
        public string CustomerIdentificationType { get; set; }
        [Required]
        [Column("customer_consent_status")]
        [StringLength(50)]
        public string CustomerConsentStatus { get; set; }
    }
}
