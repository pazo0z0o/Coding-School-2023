using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07_Test
{
    public enum ActionEnum {
    Convert,
    Uppercase,
    Reverse 
    }

    public class ActionRequest
    {
        public Guid RequestID { get; set; }
        public ActionEnum EnumChoice { get; set; }
        public string? Input { get; set; }

        public ActionRequest() { }
        public ActionRequest(string inp, ActionEnum enumChoi)
        {
            RequestID = Guid.NewGuid();
            Input = inp;
            EnumChoice = enumChoi;
        }

        public decimal UserInputConvert(ActionRequest request)
        {   
            decimal number;
            bool flag = false;
            do
            {
                if (Decimal.TryParse(request.EnumChoice.ToString(), out number))
                    flag = true;
                else
                    Console.WriteLine("Decimal number not given,try again!");

            } while (!true);


            return number;
        } 



































    
    
    }

}
