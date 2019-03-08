using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade;


namespace Facade
{
    //public class Class1
    //{
    //}
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class EmployeeViewModel
    {
        public EmployeeViewModel(Employee emp)
        {
            if (emp is null) return;
            setName(emp);
            setSalary(emp);
            setColor(emp);
        }
        public string EmployeeName { get; set; }
        public string Salary { get; set; } = 0.ToString("C");
        public string SalaryColor { get; private set; } = "red";

        internal void setName(Employee e)
        {
            EmployeeName = e.FirstName + " " + e.LastName;
        }
        internal void setColor(Employee e)
        {
            if (!ReferenceEquals(null, e))
                SalaryColor = e.Salary > 15000 ?
                       "yellow" : "green";
            else SalaryColor = "red";
        }
        internal void setSalary(Employee e)
        {
            Salary = e.Salary.ToString("C");
        }
        
    }
    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
        public string UserName { get; set; }
    }
}
