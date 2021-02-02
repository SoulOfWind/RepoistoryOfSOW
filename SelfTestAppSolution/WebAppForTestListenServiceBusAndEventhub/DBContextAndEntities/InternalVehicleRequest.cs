using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestListenServiceBusAndEventhub.DBContextAndEntities
{
    [Table("InternalVehicle_Requests")]
    [Index(nameof(CreatedAt), Name = "IX_INTERNALVEHREQ_CREATEDAT")]
    [Index(nameof(Mobile), Name = "IX_INTERNALVEHREQ_MOBILE")]
    [Index(nameof(RoleName), Name = "IX_INTERNALVEHREQ_ROLENAME")]
    [Index(nameof(Vin), Name = "IX_INTERNALVEHREQ_VIN")]
    public partial class InternalVehicleRequest
    {
        [Key]
        public int Id { get; set; }
        public short VehicleGroup { get; set; }
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
        public short Gender { get; set; }
        [Required]
        [StringLength(50)]
        public string CustomerId { get; set; }
        public short SalesType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime HandoverDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TermServiceBeginDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TermServiceEndDate { get; set; }
        [Required]
        [StringLength(50)]
        public string Pin { get; set; }
        public short Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; }
        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [Required]
        [StringLength(50)]
        public string UpdatedBy { get; set; }
        [Required]
        [StringLength(50)]
        public string RoleName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
