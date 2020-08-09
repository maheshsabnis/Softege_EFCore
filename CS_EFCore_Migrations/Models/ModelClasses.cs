using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CS_EFCore_Migrations.Models
{

    public class Category
    {
        [Key]
        public int CategoryRowId { get; set; }
        [Required]
        [StringLength(20)]
        public string CategoryId { get; set; }
        [Required]
        [StringLength(200)]
        public string CategoeyName { get; set; }
        [Required]
        public int BasePrice { get; set; }
        // Expected one-to-many relationship
        public ICollection<Product> Products { get; set; }
    }

    public class Product
    {
        [Key] // Promary Identity Key
        public int ProductRowId { get; set; }
        [Required]
        [StringLength(20)]
        public string ProductId { get; set; }
        [Required]
        [StringLength(200)]
        public string ProductName { get; set; }
        [Required]
        [StringLength(20)]
        public string Manufacturer { get; set; }
        [Required]
        public int Price { get; set; }
        [ForeignKey("CategoryRowId")] // Foreign Key
        public int CategoryRowId { get; set; }
        // referential Integrity
        public Category Category { get; set; }

    }
}
