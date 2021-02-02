using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAppForTestAspDotNetCoreMVC.DBContextAndEntities
{
    [Table("User")]
    public partial class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        public bool Gender { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [StringLength(100)]
        public string NickName { get; set; }
    }
}
