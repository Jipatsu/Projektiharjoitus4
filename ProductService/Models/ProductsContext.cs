using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductService.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext()
            : base("name=ProductsContext")
        {
        }
        public DbSet<Product> Products { get; set; }

        // New code:
        public DbSet<Supplier> Suppliers { get; set; }

        // New code:
        public DbSet<ProductRating> Ratings { get; set; }
    }
}