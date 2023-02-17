using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model
{
    public class Employee
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; } //Can be allowed to be null/empty in forms
        public decimal SallaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }
        //===============================================
        public string FullName { get { return string.Format("{0} {1}", Name, Surname); } }
       
           

        public Employee() { }

        public Employee(string name,string surname,DateTime startDate, decimal sallary, EmployeeType employeeType )
        {
            Name = name;
            Surname = surname;
            HireDateStart= startDate;
            SallaryPerMonth= sallary;
            EmployeeType = employeeType;
            Transactions = new List<Transaction>();
        }
        //Relationships
        public List<Transaction> Transactions { get; set; }
    }
}
