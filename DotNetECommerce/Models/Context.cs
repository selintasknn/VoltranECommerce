using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DotNetECommerce.Models
{
    public class ECommerceDBContext : DbContext
    {
        public ECommerceDBContext()
        { }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Cart> Cart { get; set; }
    }
}