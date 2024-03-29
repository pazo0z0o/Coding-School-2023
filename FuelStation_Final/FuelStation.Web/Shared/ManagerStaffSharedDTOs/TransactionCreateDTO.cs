﻿using FuelStation.Model.Enums;
using FuelStation.Model;
using FuelStation.Web.Shared.ManagerOnlyDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared.ManagerStaffSharedDTOs
{
    public class TransactionCreateDTO
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalValue { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }

        public CustomerListDTO Customer { get; set; } = null;
        public EmployeeListDTO Employee { get; set; } = null;
        public List<TransactionLine> TransactionLines { get; set; }
    }
}
