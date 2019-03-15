using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using Facade;

namespace Infra
{
    public class Employees
    {
        public static List<Employee> Get(SalesDbContext db)
        {
            //var employees = new List<Employee>
            //{
            //    new Employee("Jhon", "Doe", 1400),
            //    new Employee("Michael", "Jackson", 1600),
            //    new Employee("Rober", "Pattsion", 20000)
            //};
            //return employees;
            return db.Employees.ToList();

        }
        //public static List<Employee> Get(SalesDbContext db)
        //{
        //    return db.Employees.ToList();
        //}

        //public Employee Save(Employee e,SalesDbContext db)
        //{
        //    db.Employees.Add(e);
        //    db.SaveChanges();
        //    return e;
        //}
    }
}