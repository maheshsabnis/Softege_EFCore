using CS_EFCore.Context;
using CS_EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CS_EFCore
{
    class Program
    {
        static CompnayDbContext ctx;
        static async Task Main(string[] args)
        {
            //ctx = new CompnayDbContext();

            //await AddRecord();
            //await GetAddRecords();

            PersonDbContext pCtx = new PersonDbContext();
            // ensure thatb the database is created if not exist
           // pCtx.Database.EnsureDeleted(); // if exist then delete
            pCtx.Database.EnsureCreated(); // create new database
            var per = new Person()
            {
                PersonName = "Mahesh"
            };
            per.SetEmail("abc@abc.com"); // define value for private member and it will be adding in COliumn
            per.SetContact("AAAAAAAAAAAAAAAAA");
            pCtx.Person.Add(per);
            pCtx.SaveChanges();

            var persons = pCtx.Person.ToList();

            Console.WriteLine($"Person Data {JsonSerializer.Serialize(persons)}");

            Console.ReadLine();
        }

        static async Task GetAddRecords()
        {
            var depts = await ctx.Department.ToListAsync();
            Console.WriteLine("List of Departments");

            foreach (var dept in depts)
            {
                Console.WriteLine($"DeptNo {dept.DeptNo} DeptName {dept.DeptName} Location {dept.Location}");
            }
            Console.WriteLine();
            Console.WriteLine("List of Employees");
            var emps = await ctx.Employee.ToListAsync();
            foreach (var emp in emps)
            {
                Console.WriteLine($"EmpNo {emp.EmpNo} EmpName" +
                    $" {emp.EmpName} Designation " +
                    $"{emp.Designation} Salary {emp.Salary}" +
                    $" DeptNo {emp.DeptNo}");
            }

        }

        static async Task AddRecord()
        {
            await ctx.Department.AddRangeAsync(
                  new Department[] { 
                     new Department() { DeptNo=10,DeptName="IT", Location="Pune" },
                     new Department() { DeptNo=20,DeptName="HR", Location="Pune" }
                  }
                );

            await ctx.Employee.AddRangeAsync(
                    new Employee[] { 
                      new Employee() {EmpNo=101,EmpName="A",Designation="Ds1",Salary=10000,DeptNo=10 },
                      new Employee() {EmpNo=102,EmpName="B",Designation="Ds2",Salary=11000,DeptNo=20 }
                    }
                );
            await ctx.SaveChangesAsync();

        }
    }
}
