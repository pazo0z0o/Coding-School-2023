using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace PetShop.MVC.Models.Transactions
{
    public class CreateTransactionsDTO
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
      

        public List<SelectListItem> Customer { get; } = new List<SelectListItem>();
        public List<SelectListItem> Employee { get;} = new List<SelectListItem>();
        public List<SelectListItem> Pet { get; } = new List<SelectListItem>();
        public List<SelectListItem> PetFood { get; } = new List<SelectListItem>();

    }




}

