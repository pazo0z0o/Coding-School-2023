using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? CardNumber { get; set; }
        //=======================================
        public string FullName { get { return string.Format("{0} {1}", Name, Surname); } }


        public Customer() { }
        
        public Customer(string name, string surname,string cardNumber)
        {
            Name= name;
            Surname= surname;
            CardNumber = cardNumber;
            Transactions = new List<TransactionListDTO>();
        }
        //Relationships

        public List<TransactionListDTO> Transactions { get; set; }


    }
}
