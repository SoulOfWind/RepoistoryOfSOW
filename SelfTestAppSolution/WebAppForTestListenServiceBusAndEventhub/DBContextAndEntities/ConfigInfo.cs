using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestListenServiceBusAndEventhub.DBContextAndEntities
{
    [Table("ConfigInfo")]
    public partial class ConfigInfo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string ConfigKey { get; set; }
        [Required]
        [StringLength(4000)]
        public string ConfigValue { get; set; }
        public int RecordStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateAt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; }
    }
}
