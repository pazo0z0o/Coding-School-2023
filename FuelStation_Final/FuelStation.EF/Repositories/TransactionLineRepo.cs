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
    public class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        public void Add(TransactionLine tline)
        {
            using var context = new FuelStationDbContext();
            context.Add(tline);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new FuelStationDbContext();
            var TransactionLineDb = context.TransactionLines.Where(transactionLine => transactionLine.ID == id)
                .Include(transactionLine => transactionLine.Transaction)
                .Include(transactionLine => transactionLine.Item)      
                .SingleOrDefault();
            if (TransactionLineDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");
            context.Remove(TransactionLineDb);
            context.SaveChanges();
        }

        public IList<TransactionLine> GetAll()
        {
            using var context = new FuelStationDbContext();
            return context.TransactionLines
            .Include(transactionLine => transactionLine.Transaction)
            .Include(transactionLine => transactionLine.Item)
            .ToList();
        }

        public TransactionLine? GetById(int id)
        {
            using var context = new FuelStationDbContext();
            return context.TransactionLines
                .Where(transactionLine => transactionLine.ID == id)
                .Include(transactionLine => transactionLine.Transaction)
                .Include(transactionLine => transactionLine.Item)
                .SingleOrDefault();
        }

        public void Update(int id, TransactionLine tline)
        {
            using var context = new FuelStationDbContext();
            var TransactionLineDb = context.TransactionLines.Where(transactionLine => transactionLine.ID == id)
                .Include(transactionLine => transactionLine.Transaction)
                .Include(transactionLine => transactionLine.Item)
                .SingleOrDefault();
            if (TransactionLineDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");
            TransactionLineDb.Quantity = tline.Quantity;
            TransactionLineDb.ItemPrice = tline.ItemPrice;
            TransactionLineDb.NetValue =  tline.NetValue;
            TransactionLineDb.DiscountPercent = tline.DiscountPercent;
            TransactionLineDb.DiscountValue = tline.DiscountValue;
            TransactionLineDb.TotalValue = tline.TotalValue;

            context.SaveChanges();
        }

        public IList<TransactionLine> GetAllWithTransactionID(int transactionId)
        {   //Isolation for just the Transaction  - Item parity
            using var context = new FuelStationDbContext();
            return context.TransactionLines.Where(t => t.TransactionID == transactionId)
                .ToList();
        }

    }
}
