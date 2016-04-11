using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAB_Handin4_APP.Models
{
    public class PersonDTO
    {
        public int PersonID { get; set; }
        public string ForNavn { get; set; }

        public string EfterNavn { get; set; }

        public string MellemNavn { get; set; }

        public string Relation { get; set; }

        public int AdresseID { get; set; }
    }
}