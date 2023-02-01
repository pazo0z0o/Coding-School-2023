using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.EF.Models
{
    public enum EmployeeType
    {
        Manager,
        Staff
    }
    public class Employees
    {  
        
        
        public Guid EmployeeID { get; set; }
        public string EmpName { get; set; }
        public string EmpSurname { get; set; }

        public EmployeeType EmpType { get; set; }
        public decimal SalaryPerMonth { get; set; }
        //==============================================
        public List<Transactions> Transacts { get; set; } //= null;



        public Employees()
        {
            EmployeeID = Guid.NewGuid();
        }

        public Employees(string name, string surname, EmployeeType employeeType, decimal salary)
        {
            EmployeeID = Guid.NewGuid();
            EmpName = name;
            EmpSurname = surname;
            EmpType = employeeType;
            SalaryPerMonth = salary;
        }
    }
}
