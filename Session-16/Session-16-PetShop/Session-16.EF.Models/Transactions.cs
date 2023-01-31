using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.EF.Models
{
    public class Transactions
    {
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
       //==============================================================
        public Transactions()
        {

        }
        public Transactions(Guid TransID, DateTime date)
        {
            TransID = Guid.NewGuid();
           Date = date;
            // PetID = PetID;
            //_loaded = false;
           //CustomerID = customerID;
          // EmployeeID = employeeID;
            // PetFoodID = pfoodID;
        }

        







    }
}
