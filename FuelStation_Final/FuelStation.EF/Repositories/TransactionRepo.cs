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
    public class TransactionRepo : IEntityRepo<TransactionListDTO>
    {
        public void Add(TransactionListDTO transaction)
        {
            using var context = new FuelStationDbContext();
            context.Add(transaction);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new FuelStationDbContext();
            var TransactionDb = context.Transactions
                .Where(transaction => transaction.ID == id)
                .Include(transaction => transaction.TransactionLines)
                .Include(transaction => transaction.Customer)
                .Include(transaction => transaction.Employee)
                .SingleOrDefault();
            if (TransactionDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");
            context.Remove(TransactionDb);
            context.SaveChanges();
        }

        public IList<TransactionListDTO> GetAll()
        {
            using var context = new FuelStationDbContext();
            return context.Transactions

                .Include(transaction => transaction.Customer)
                .Include(transaction => transaction.Employee)
                .Include(transaction => transaction.TransactionLines)
                    .ThenInclude(transactionLine => transactionLine.Item)
                .Include(transaction => transaction.TransactionLines)
                    .ThenInclude(transactionLine => transactionLine.Transaction)
                .ToList();
        }

        public TransactionListDTO? GetById(int id)
        {
            using var context = new FuelStationDbContext();
            return context.Transactions
                .Where(transaction => transaction.ID == id)

                .Include(transaction => transaction.Customer)
                .Include(transaction => transaction.Employee)
                .Include(transaction => transaction.TransactionLines)
                    .ThenInclude(transactionLine => transactionLine.Item)
                .Include(transaction => transaction.TransactionLines)
                    .ThenInclude(transactionLine => transactionLine.Transaction)
                .SingleOrDefault();
        }

        public void Update(int id, TransactionListDTO transaction)
        {
            using var context = new FuelStationDbContext();
            var TransactionDb = context.Transactions
                .Where(transaction => transaction.ID == id)
                .SingleOrDefault();
            if (TransactionDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");
            TransactionDb.Date = transaction.Date;
            TransactionDb.TotalValue = transaction.TotalValue;
            TransactionDb.PaymentMethod = transaction.PaymentMethod;
            TransactionDb.CustomerId = transaction.CustomerId;
            TransactionDb.EmployeeId = transaction.EmployeeId;
            context.SaveChanges();
        }
    }
}
