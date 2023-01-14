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

            Console.WriteLine("Give me an integer : " ,(Environment.NewLine ));
            string strNUM = Console.ReadLine();
            int num = Convert.ToInt32(strNUM);

            string input;
            /*StringBuilder sb = new StringBuilder();
           
            sb.AppendLine("Choose the calculation you want..."),
            sb.AppendLine("1. Multiplication "),
            sb.AppendLine("2. Addition ")
                             */
            Console.WriteLine("Pick (1) to get the product of each number of the integer or (2) to get the sum" + (Environment.NewLine)+
                              "1. Product"+ (Environment.NewLine)+ "2. Summation");


            input =(Console.ReadLine());
            if (input == "1")
            {
                return Product(num);
            }
            else if (input == "2") { return Summation(num); }
            else
                Console.WriteLine("Wrong option!Try again");
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

