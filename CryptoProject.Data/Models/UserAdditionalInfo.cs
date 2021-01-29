using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CryptoProject.Data.Models
{
    public class UserAdditionalInfo
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int Age { get; set; }

        public virtual User User { get; set; }
    }
}
