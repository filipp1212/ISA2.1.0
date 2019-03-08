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
    //public class Employees
    //{
    //    public static List<Employee> Get(SalesDbContext db)
    //    {
    //        return db.Employees.ToList();
    //    }
    //}
}
