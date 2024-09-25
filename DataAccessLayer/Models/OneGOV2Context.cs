using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    internal class OneGOV2Context : DbContext
    {
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<UserOder> UserOder { get; set; }

        public DbSet<Categories> Categories { get; set; }
       
    }
}
