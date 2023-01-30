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

        public Transactions()
        {

        }
        public Transactions(Guid TransID, DateTime date)
        {
            TransID = Guid.NewGuid();
           // PetID = PetID;
            //_loaded = false;
            Date = date;
            //CustomerID = customerID;
           // EmployeeID = employeeID;
            //PetFoodID = pfoodID;
        }

        //  Guid customerID, Guid employeeID, AnimalType animalType, decimal petFoodQty,Guid pfoodID







    }
}
