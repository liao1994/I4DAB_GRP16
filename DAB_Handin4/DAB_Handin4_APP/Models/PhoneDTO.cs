using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAB_Handin4_APP.Models
{
    public class PhoneDTO
    {
        public int PhoneID { get; set; }

        public int PhoneNumber { get; set; }
        
        public int CountryCode { get; set; }

        public string PhoneType { get; set; }

        public int PersonID { get; set; }
    }
}