using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAB_Handin4_APP.Models
{
    public class Phone
    {
        [Key]
        [Required]
        public int PhoneID { get; set; }

        [Required]
        public int PhoneNumber { get; set; }
        
        [Required]
        public int CountryCode { get; set; }

        [Required]
        public string PhoneType { get; set; }

        [Required]
        public int PersonID { get; set; }
    }
}