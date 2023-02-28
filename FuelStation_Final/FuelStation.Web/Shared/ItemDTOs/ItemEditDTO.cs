using FuelStation.Model.Enums;
using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FuelStation.Web.Shared.ItemDTOs
{
   public class ItemEditDTO
    {
        public int ID { get; set; }
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "The Code field can only contain Latin letters and digits")]
        [Required]
        public string Code { get; set; }
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "The Description field can only contain Latin letters and digits")]
        [Required]
        public string Description { get; set; }
        public ItemType ItemType { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "The field can only contain numeric digits.")]
        [Required]
        public decimal Price { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "The field can only contain numeric digits.")]
        [Required]
        public decimal Cost { get; set; }
        //==========================

        //Relationships
        public List<TransactionLine> TransactionLines { get; set; } = new();
    }
}
