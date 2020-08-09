using CS_EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS_EFCore.Context
{
    public class PersonDbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }

        /// <summary>
        /// Method to define connection
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=PersonDb;Integrated Security=SSPI");
        }
        /// <summary>
        /// Method to define model mapping 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Property Email from Person Calss will be mapped with the Column Email from Person Table
            modelBuilder.Entity<Person>()
                    .Property<string>("Email").HasField("Email");

            modelBuilder.Entity<Person>()
                   .Property<string>("Contact").HasField("Contact");
        }
    }
}
