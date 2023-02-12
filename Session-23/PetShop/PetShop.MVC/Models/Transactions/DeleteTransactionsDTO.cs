namespace PetShop.MVC.Models.Transactions
{
    public class DeleteTransactionsDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal PetPrice { get; set; }
        public int PetFoodQty { get; set; }
        public decimal PetFoodPrice { get; set; }
        public decimal TotalPrice { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public int PetId { get; set; }
        public int PetFoodId { get; set; }
        /*public PetShop.Model.PetFood PetFood { get; set; } = null!;
        public PetShop.Model.Pet Pet { get; set; } = null!;
        public PetShop.Model.Customer Customer { get; set; } = null!;
        public PetShop.Model.Employee Employee { get; set; } = null!;
*/
    }
}
