using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAB_Handin4_APP.Models
{
    public class Person
    {
        [Key]
        [Required]
        public int PersonID { get; set; }
        [Required]
        public string ForNavn { get; set; }

        [Required]
        public string EfterNavn { get; set; }

        public string MellemNavn { get; set; }

        [Required]
        public string Relation { get; set; }

        public int AdresseID { get; set; }
    }
}