using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories
{
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        public void Add(Employee emp)
        {
            using var context = new FuelStationDbContext();
            context.Add(emp);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new FuelStationDbContext();
            var EmployeeDb = context.Employees
                .Where(employee => employee.ID == id)
                .Include(employee => employee.Transactions)
                .SingleOrDefault();
            if (EmployeeDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");
            context.Remove(EmployeeDb);
            context.SaveChanges();
        }

        public IList<Employee> GetAll()
        {
            using var context = new FuelStationDbContext();
            return context.Employees
                .Include(employee => employee.Transactions)
                .ToList();
        }

        public Employee? GetById(int id)
        {
            using var context = new FuelStationDbContext();
            return context.Employees
                .Where(employee => employee.ID == id)
                .Include(employee => employee.Transactions)
                .SingleOrDefault();
        }

        public void Update(int id, Employee emp)
        {
            using var context = new FuelStationDbContext();
            var EmployeeDb = context.Employees
                .Where(emp => emp.ID == id)
                .Include(customer => customer.Transactions)
                .SingleOrDefault();
            if (EmployeeDb is null) throw new KeyNotFoundException($"Given id '{id}' was not found");
            EmployeeDb.Name = emp.Name;
            EmployeeDb.Surname = emp.Surname;
            EmployeeDb.HireDateStart = emp.HireDateStart;
            EmployeeDb.HireDateEnd = emp.HireDateEnd;
            EmployeeDb.SalaryPerMonth = emp.SalaryPerMonth;
            EmployeeDb.EmployeeType = emp.EmployeeType;
            context.SaveChanges();
        }
    }
}
