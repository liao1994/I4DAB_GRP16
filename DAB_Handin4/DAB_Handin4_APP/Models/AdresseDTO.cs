using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DAB_Handin4_APP.Models
{
    public class AdresseDTO
    {
        public int AdressID { get; set; }
        
        public string Country { get; set; }

        public string StreetName { get; set; }

        public int StreetNumber { get; set; }

        public string Town { get; set; }

        public int ZipCode { get; set; }
    }
}