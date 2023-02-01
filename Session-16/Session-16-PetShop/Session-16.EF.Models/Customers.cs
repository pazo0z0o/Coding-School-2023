using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.EF.Models
{
    public class Customers
    {   
      public Guid CustomerID { get; set; }
      public string Name { get; set; }
      public string Surname { get; set; }
      public string Phone { get; set; }
      public int TIN { get; set; }

        public List<Transactions> Transacts { get; set; } //= null;

        public Customers() { CustomerID = Guid.NewGuid(); }
        public Customers(string name, string surn, string phone, int tin)
        {
            CustomerID = Guid.NewGuid();
            Name = name;
            Surname = surn;
            Phone = phone;
            TIN = tin;
        }

        public Customers(string text)
        {
        }
    }
}
