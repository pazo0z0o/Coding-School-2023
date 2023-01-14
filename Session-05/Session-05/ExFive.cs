using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ExFive
    {
        public int[] InsertionSort()
        {
            int[] myArray = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
            
            for (int i = 1; i < myArray.Length; i++)
            {
                var key = myArray[i]; //key serves as a "bookmark" for our element to be sorted   
                var flag = 0;
                
                for (int j = i - 1; j >= 0 && flag != 1;)//flag as a stopping condition. 2 escape cpnditions
                {
                    if (key < myArray[j])
                    {
                        myArray[j + 1] = myArray[j];
                        j--;
                        myArray[j + 1] = key;
                    }
                    else flag = 1;
                }
            }
            return myArray;
        }

    }
}
