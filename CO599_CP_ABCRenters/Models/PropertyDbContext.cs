using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CO599_CP_ABCRenters.Models
{
    public class PropertyDbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PropertyDbContext() : base("name=PropertyDbContext")
        {
        }

        public System.Data.Entity.DbSet<CO599_CP_ABCRenters.Models.Address> Addresses { get; set; }

        public System.Data.Entity.DbSet<CO599_CP_ABCRenters.Models.Property> Properties { get; set; }

        public System.Data.Entity.DbSet<CO599_CP_ABCRenters.Models.Customer> Customers { get; set; }
    }
}
