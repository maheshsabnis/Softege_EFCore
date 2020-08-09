using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CS_EFCore_Migrations.Models
{
    public class ShoppingDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=eShopping;Integrated Security=SSPI");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // define the one-to-many and many-to-one relationship
            // across the Category-to-Product tables

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category) // hasone category for each product
                .WithMany(c => c.Products) // one categoey contains multiple products
                .HasForeignKey(p => p.CategoryRowId); // Foreign Key Relationship 

        }
    }
}
