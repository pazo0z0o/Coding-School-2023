using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.EF.Models.Populate_Classes
{
    internal class PopulateEmployee
    {  
            public List<Employees> Employees { get; set; }
            public PopulateEmployee() { }
            //functions

            public List<Employees> PopulateEmployees()
            {
                //Employee(ID, Name, Surname, EmployeeType (enum), SallaryPerMonth)

                Employees = new List<Employees>();
                Employees employee;


                employee = new Employees("Kwstantinos", "Dimitropoulos", EmployeeType.Manager, 1500);
                Employees.Add(employee);

                employee = new Employees("Giannis", "Dimitrakopoulopoulos", EmployeeType.Manager, 1300);
                Employees.Add(employee);

                employee = new Employees("George", "Paulidis", EmployeeType.Staff, 800);
                Employees.Add(employee);

                employee = new Employees("Panos", "Kamenos", EmployeeType.Staff, 900);
                Employees.Add(employee);

                employee = new Employees("Telis", "Praxitelis", EmployeeType.Staff, 600);
                Employees.Add(employee);

                employee = new Employees("Alexandros", "Alexandrou", EmployeeType.Staff, 900);
                Employees.Add(employee);
                //bsEmployees.DataSource = Employees;
                return Employees;

            }
        
    }
}



        

