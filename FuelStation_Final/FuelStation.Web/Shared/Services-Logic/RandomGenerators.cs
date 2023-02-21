using FuelStation.EF.Repositories;
using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared.Services_Logic
{
    public class RandomGenerators
    {
        private readonly IEntityRepo<Customer> _customerRepo;

        public RandomGenerators(IEntityRepo<Customer> customerRepo)
        {
            _customerRepo= customerRepo;
        }


        public string CardNumberGenerator()
        {   int length = 9;
            string standard = "A";
            string CardNumber = string.Empty;
            var customerCheck = _customerRepo.GetAll(); //.Where(card => card.CardNumber).ToList(); 

        string validInputs = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] chars= new char[length];
            Random rndPick = new Random(); 

            for (int i = 0;i < length; i++)
            {
                chars[i] = validInputs[rndPick.Next(0,validInputs.Length)];
            }
            CardNumber = standard + chars.ToString();
            foreach(var customer in customerCheck)
            {
                if (CardNumber != customer.CardNumber) continue;
                else CardNumber = CardNumberGenerator(); 
            }
            
            return CardNumber;
        }

        public string PasswordGenerator()
        {
            string pass = string.Empty;

            int length = 9; 

            string validInputs = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!./+*-";
            char[] chars = new char[length];
            Random rndPick = new Random();

            for (int i = 0; i < length; i++)
            {
                chars[i] = validInputs[rndPick.Next(0, validInputs.Length)];
            }
           pass = chars.ToString();
            
            return pass;
        }



    }
}
