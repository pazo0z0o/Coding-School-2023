using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.SandBox.Shared
{
    public class CustomerListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        //TODO:  public List<TransactionListDto> Transactions { get; set; } = new();
    }
}
