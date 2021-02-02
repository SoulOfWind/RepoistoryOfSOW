using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestListenServiceBusAndEventhub.DBContextAndEntities
{
    [Table("WeatherForecast")]
    public partial class WeatherForecast
    {
        [Key]
        public int Id { get; set; }
        public DateTime ReportDate { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF { get; set; }
        [Required]
        [StringLength(1000)]
        public string Summary { get; set; }
    }
}
