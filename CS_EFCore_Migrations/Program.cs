using CS_EFCore_Migrations.Models;
using System;

namespace CS_EFCore_Migrations
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingDbContext ctx = new ShoppingDbContext();

            ctx.Categories.Add(new Category() 
            {CategoryId="Cat001",CategoeyName="C1",BasePrice=10 });

            ctx.Products.Add(new Product() 
            {ProductId="Prd001",ProductName="P1",Manufacturer="M1",Price=12,CategoryRowId=1 });

            ctx.SaveChanges();
            Console.ReadLine();
        }
    }
}
