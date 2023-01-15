using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ExTwo
    {

        public int SumOrProd()
        {   
            bool uInput = false;
            bool uChoiceCalc = false;

            int num ;
            do {
                Console.WriteLine("Give me an integer : ", (Environment.NewLine));
                string strNUM = Console.ReadLine();
                if (int.TryParse(strNUM, out num))
                {
                    
                    uInput = true;
                }
                else Console.WriteLine("Wrong input, try again");               
            }while(!uInput);

            string input;
            do
            {
                Console.WriteLine("Pick (1) to get the product of each number of the integer or (2) to get the sum" + (Environment.NewLine) +
                             "1. Product" + (Environment.NewLine) + "2. Summation");
               
                input = (Console.ReadLine());
                if (input == "1")
                {
                    uChoiceCalc = true;
                    return Product(num);
                }
                else if (input == "2") 
                {
                    uChoiceCalc = true;
                    return Summation(num); 
                }
                else Console.WriteLine("Wrong option!Try again");
            }while (!uChoiceCalc);
                
                return 0;
        }

        public int Product(int num) 
        {
            int prod = 1;
            if (num == 0) { return prod = 0; }
            else
            {
                for (int i = 2; i <= num; i++)
                { prod *= i; }
            }
            Console.Write($"The product of each indinidual part of {num} : ");
            return prod;       
        }
        public int Summation(int num)
        { 
            int sum = 1;
            if(num == 0) { return sum = 0; }
            for(int i = 2; i <= num; i++)
            { sum += i; }
            Console.Write($"The sum of each individual part of {num} : ");
            return sum;
        }

        

    }












    }

