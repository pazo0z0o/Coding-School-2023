﻿using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model
{
   public class Transaction
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalValue { get; set; }
         public PaymentMethod PaymentMethod { get; set; }
       
        // Relations
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        public int ManagerId { get; set; }
        public Employee Employee { get; set; } = null!;

        //============================================
        public Transaction(PaymentMethod payment)
        {
            PaymentMethod = payment;
            Date = DateTime.Now;
            TransactionLines = new List<TransactionLine>();
        }

        //Relationships
        public List<TransactionLine> TransactionLines { get; set; }

    }
}
