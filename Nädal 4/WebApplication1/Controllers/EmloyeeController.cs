using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core;
using Facade;
using Infra;


namespace Labor1.Controllers
{
    public class EmloyeeController : Controller
    {
        private readonly SalesDbContext db;
        public EmloyeeController(SalesDbContext db) { this.db = db; }

        public ActionResult Index()
        {
            var model = new EmployeeListViewModel();
            List<Employee> employees = Employees.Get(db);
            var list = new List<EmployeeViewModel>();
            foreach(var e in employees)
            {
                var employee = new EmployeeViewModel(e);
                list.Add(employee);
            }

            model.Employees = list;
            return View("Index", model);
        }

        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }
    }
}