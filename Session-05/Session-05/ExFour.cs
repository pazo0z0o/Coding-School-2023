using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ExFour
    {
        int[] array1 = { 2, 4, 9, 12 };
        int[] array2 = { 1, 3, 7, 10 };
        int[,] result = new int[4, 4];
        public void tableXProd()
        {
            
        StringBuilder sb = new StringBuilder("The 2 tables that we are going to multiply are:" + (Environment.NewLine));
            Console.WriteLine(sb);
            foreach (int element in array1) { Console.Write($"{element}" + " "); }
            Console.WriteLine((Environment.NewLine));
            foreach (int element in array2) { Console.Write(($"{element}" + " ")); }
            Console.WriteLine((Environment.NewLine)+"--------------------" );
           
            //nested for loops for result calculation
            for (int i =0; i<array1.Length;i++)
            {
                for(int j=0;j<array2.Length;j++ )
                {
                    result[i,j] = array1[i] * array2[j];
                }
            }
           printArr(result);
        }
        public void printArr(int[,] result) 
        {
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    Console.Write(result[i,j]+ " ");
                }
            Console.WriteLine("");
            }


        }
    }
}
