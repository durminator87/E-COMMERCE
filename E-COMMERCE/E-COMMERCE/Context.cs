using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_COMMERCE.Model;

namespace E_COMMERCE
{
    public class Context : DbContext
    {
        public Context() : base("ConString") { }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<City> Cities { get; set; }
    }

}
