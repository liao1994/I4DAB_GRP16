using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DAB_Handin4_APP.Models
{
    public class Adresse
    {
        [Key]
        [Required]
        public int AdressID { get; set; }
        
        [Required]
        public string Country { get; set; }

        [Required]
        public string StreetName { get; set; }

        [Required]
        public int StreetNumber { get; set; }

        [Required]
        public string Town { get; set; }

        [Required]
        public int ZipCode { get; set; }
    }
}