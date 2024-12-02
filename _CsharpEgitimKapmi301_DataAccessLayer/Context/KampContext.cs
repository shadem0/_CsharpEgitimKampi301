using _CsharpEgitimKapmi301_EntityLayer;
using _CsharpEgitimKapmi301_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _CsharpEgitimKapmi301_DataAccessLayer.Context
{
    public class KampContext:DbContext  
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }
     
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Admin> Admins { get; set; }

    }
}
