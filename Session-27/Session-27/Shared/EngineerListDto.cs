﻿using Session_27.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_27.Shared {
    public class EngineerListDto {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int SalaryPerMonth { get; set; }
        public int ManagerId { get; set; }
        public ManagerListDto Manager { get; set; } = null!;
        public List<Session_27.Model.Transaction> Transactions { get; set; } = new List<Session_27.Model.Transaction>();
    }
}

