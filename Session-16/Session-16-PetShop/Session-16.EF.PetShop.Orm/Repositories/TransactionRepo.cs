using Microsoft.EntityFrameworkCore;
using Session_16.EF.Models;
using Session_16.EF.PetShop.Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Session_16.EF.PetShop.Orm.Repositories
{
    public class TransactionRepo : IEntity<Transactions>
    {
        public void Add(Transactions entity)
        {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();

        }

        public void Delete(Guid id)
        {
            using var context = new AppDbContext();
            var dbTodo = context.Transact.Where(trans => trans.TransID == id).SingleOrDefault();
            if (dbTodo is null)
                return;
            context.Remove(dbTodo);
            context.SaveChanges();

        }

        public IList<Transactions> GetAll()
        {
            using var context = new AppDbContext();
            return context.Transact.Include(trans => trans.CustomerID).Include(trans => trans.EmployeeID).Include(trans => trans.PetFoodID).ToList();
        }

        public Transactions? GetById(Guid id)
        {

            using var context = new AppDbContext();
            return context.Transact.Where(trans => trans.TransID == id);
                
                //.Include(trans => trans.Customer)
                //.Include(trans => trans.EmployeeID)
                //.Include(trans => trans.PetFoodID).SingleOrDefault();
        }

        

        public void Update(Guid id, Transactions entity)
        {
           
        }

        Transactions? IEntity<Transactions>.GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

/*
public Guid? TransID { get; set; }
public DateTime Date { get; set; }
public Guid CustomerID { get; set; }
public Guid? EmployeeID { get; set; }
public Guid? PetID { get; set; }
public decimal? PetPrice { get; set; }
public Guid? PetFoodID { get; set; }
public decimal PetFoodQty { get; set; }
public decimal? PetFoodPrice { get; set; }
public decimal? TotalPrice { get; set; }
public bool loaded = false;
//=============Foreign Keys Emplo , Custom, Pet,PetFood  = ID 
public Customers Customer { get; set; }
public Employees Employee { get; set; }
public Pet Pets { get; set; }
public PetFood Pfood { get; set; }
//==============================================================*/
