using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DAB_Handin4_APP.Models
{
    public class DAB_Handin4_APPContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public DAB_Handin4_APPContext() : base("name=DAB_Handin4_APPContext")
        {
        }

        public System.Data.Entity.DbSet<DAB_Handin4_APP.Models.Person> People { get; set; }
    }
}
