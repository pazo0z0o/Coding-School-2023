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

        public void Delete(int? id)
        {
            using var context = new PetShopDbContext();
            var dbPetShop = context.Employees.Where(emps => emps.Id == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            context.Remove(dbPetShop);
            context.SaveChanges();
        }

        public IEnumerable<Employee> GetAll()
        {
            using var context = new PetShopDbContext();
            return context.Employees;//.Include(emps => emps.Transactions).ToList();
        }

        public Employee? GetById(int? id)
        {
            using var context = new PetShopDbContext();
            return context.Employees.Where(emps => emps.Id == id).Include(emps => emps.Transactions).SingleOrDefault();
        }

        public void Update(int? id, Employee entity)
        {
            using var context = new PetShopDbContext();
            var dbPetShop = context.Employees.Where(emps => emps.Id == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            dbPetShop.Name = entity.Name;
            dbPetShop.Surname = entity.Surname;
            dbPetShop.SalaryPerMonth = entity.SalaryPerMonth;
            dbPetShop.EmployeeType = entity.EmployeeType;
            //dbPetShop.Transacts = entity.Transacts;
            context.SaveChanges();
        }
    }
}
