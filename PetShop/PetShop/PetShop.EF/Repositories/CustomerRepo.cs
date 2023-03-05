﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetShop.EF.Context;
using PetShop.Model;

namespace PetShop.EF.Repositories
{

    public class CustomerRepo : IEntityRepo<Customer>
    {
        public void Add(Customer entity)
        {
            using var context = new PetShopDbContext();
            context.Add(entity);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            using var ctx = new PetShopDbContext();
            var dbCustomer = ctx.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if (dbCustomer is null)
            {
                ctx.Remove(dbCustomer);
                ctx.SaveChanges();
            }
        }

        public IList<Customer> GetAll()
        {
            using var ctx = new PetShopDbContext();
            return ctx.Customers.Include(customer => customer.Transactions).ToList();

        }

        public Customer? GetById(int id)
        {
            using var context = new PetShopDbContext();
            return context.Customers.Include(customer => customer.Transactions)
                .ThenInclude(transaction => transaction.Employee)
                .Where(customer => customer.Id == id)
                .SingleOrDefault();

        }

        public void Update(int id, Customer entity)
        {
            using var ctx = new PetShopDbContext();
            var dbCustomer = ctx.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if (dbCustomer is null) return;
            dbCustomer.Phone = entity.Phone;
            dbCustomer.Name = entity.Name;
            dbCustomer.Surname = entity.Surname;
            dbCustomer.Tin = entity.Tin;
            try
            {
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
