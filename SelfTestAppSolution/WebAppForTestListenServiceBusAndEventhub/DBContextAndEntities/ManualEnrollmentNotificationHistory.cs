using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestListenServiceBusAndEventhub.DBContextAndEntities
{
    [Table("manual_enrollment_notification_history")]
    public partial class ManualEnrollmentNotificationHistory
    {
        [Key]
        public int Id { get; set; }
        public Guid Usid { get; set; }
        public int EnrollmentRequestsId { get; set; }
        [Required]
        [StringLength(4000)]
        public string NotificationContent { get; set; }
        public short NotificationStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime NotificationCreatedAt { get; set; }
    }
}
