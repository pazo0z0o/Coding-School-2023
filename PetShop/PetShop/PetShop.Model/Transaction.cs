using PetShop.Model.Enums;

namespace PetShop.Model
{
    public class Transaction
    {
        public Transaction(){}

        public Transaction( decimal totalPrice)
        {
            Date = DateTime.Now;
            TotalPrice = totalPrice;
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
       
        public decimal TotalPrice { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;


        public List<TransactionLine> TransactionLines { get; set; } = new();

    }
}
