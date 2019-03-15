using Core;
using Infra;
using Facade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Infra
{
    public class SalesDbContext : DbContext
    {
        public SalesDbContext(DbContextOptions<SalesDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Employee>().ToTable("Employees");
        }

        public DbSet<Employee> Employees { get; set; }
    }
    public class Employees
    {
        public static List<Employee> Get()
        {
            var employees = new List<Employee>
            {
                new Employee("Jhon", "doe", 1400),
                new Employee("Michael", "Jacksn", 1600),
                new Employee("Robert", "Pattinson", 20000)
            };
            return employees;
        }
    }
}
