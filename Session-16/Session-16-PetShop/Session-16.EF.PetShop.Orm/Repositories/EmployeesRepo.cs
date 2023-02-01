using Microsoft.EntityFrameworkCore;
using Session_16.EF.Models;
using Session_16.EF.PetShop.Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.EF.PetShop.Orm.Repositories
{
    public class EmployeesRepo : IEntity<Employees>
    {

        public void Add(Employees entity)
        {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            using var context = new AppDbContext();
            var dbPetShop = context.Emps.Where(emps => emps.EmployeeID == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            context.Remove(dbPetShop);
            context.SaveChanges();

        }

        public IList<Employees> GetAll()
        {
            using var context = new AppDbContext();
            return context.Emps.Include(customs => customs.Transacts).ToList();
        }

        public Employees? GetById(Guid id)
        {
            using var context = new AppDbContext();
            return context.Emps.Where(emps => emps.EmployeeID == id).Include(customs => customs.Transacts).SingleOrDefault();

        }

        public void Update(Guid id, Employees entity)
        {
            using var context = new AppDbContext();
            var dbPetShop = context.Emps.Where(emps => emps.EmployeeID == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            dbPetShop.EmpName = entity.EmpName;
            dbPetShop.EmpSurname = entity.EmpSurname;
            dbPetShop.SalaryPerMonth = entity.SalaryPerMonth;
            dbPetShop.EmpType = entity.EmpType;
           //dbPetShop.Transacts = entity.Transacts;
            context.SaveChanges();
        }



    }
}
