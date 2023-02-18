using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
        public void Add(Customer customer)
        {
            using var context = new FuelStationDbContext();
            context.Add(customer);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new FuelStationDbContext();
            var CustomerDb = context.Customers
                .Where(customer => customer.ID == id)
                .Include(customer => customer.Transactions)
                .SingleOrDefault();
            if (CustomerDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");
            context.Remove(CustomerDb);
            context.SaveChanges();
        }

        public IList<Customer> GetAll()
        {
            using var context = new FuelStationDbContext();
            return context.Customers
                .Include(customer => customer.Transactions)
                .ToList();
        }

        public Customer? GetById(int id)
        {
            using var context = new FuelStationDbContext();
            return context.Customers
                .Where(customer => customer.ID == id)
                .Include(customer => customer.Transactions)
                .SingleOrDefault();
        }

        public void Update(int id, Customer customer)
        {
            using var context = new FuelStationDbContext();
            var CustomerDb = context.Customers
                .Where(customer => customer.ID == id)
                .Include(customer => customer.Transactions)
                .SingleOrDefault();
            if (CustomerDb is null) throw new KeyNotFoundException($"Given id '{id}' was not found");
            CustomerDb.Name = customer.Name;
            CustomerDb.Surname = customer.Surname;
            CustomerDb.CardNumber = customer.CardNumber;
            context.SaveChanges();
        }
    }
}
