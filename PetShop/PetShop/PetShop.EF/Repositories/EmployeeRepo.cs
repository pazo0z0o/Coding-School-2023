using Microsoft.EntityFrameworkCore;
using PetShop.EF.Context;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{  
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        public void Add(Employee entity)
        {
            using var context = new PetShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PetShopDbContext();
            var dbEmployee = context.Employees.Where(empl => empl.Id == id).Include(empl => empl.Transactions).SingleOrDefault();
            if (dbEmployee is null)
                throw new KeyNotFoundException($"Given Employee Id was not found!");
            context.Remove(dbEmployee);
            context.SaveChanges();

        }

        public IList<Employee> GetAll()
        {
            using var context = new PetShopDbContext();
            return context.Employees.Include(empl=>empl.Transactions).ToList();
        }

        public Employee? GetById(int id)
        {
            using var context = new PetShopDbContext();
            return context.Employees.Where(empl=>empl.Id == id).Include(empl=>empl.Transactions).SingleOrDefault();
        }

        public void Update(int id, Employee entity)
        {
            using var context = new PetShopDbContext();
            var EmployeeDb = context.Employees
                .Where(employee => employee.Id == id)
                .Include(employee => employee.Transactions)
                .SingleOrDefault();
            if (EmployeeDb is null) throw new KeyNotFoundException($"Given id '{id}' was not found");
            EmployeeDb.Name = entity.Name;
            EmployeeDb.Surname = entity.Surname;
            EmployeeDb.SalaryPerMonth = entity.SalaryPerMonth;
            EmployeeDb.EmployeeType = entity.EmployeeType;
            EmployeeDb.EmployeePass = entity.EmployeePass;
            context.SaveChanges();
        }
    }
}
