using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class Actions
    {
        public string Input { get; set; }
        public string Output { get; set; }

        public Actions() { } //empty constr
        public Actions(string input)
        { Input = input; }

        //method to be virtual
        public virtual string Action(string Input)
        {
            return Output;
        }
    }

        public class BinConverter : Actions
        {
            public BinConverter() { }
            public BinConverter(string input) : base(input) { }

            public override string Action(string input)
            {
                int n, i, outputBin = 0;
                int[] a = new int[10];

                if (int.TryParse(input, out n))
                {
                    for (i = 0; n > 0; i++)
                    {
                        a[i] = n % 2;
                        n = n / 2;
                    }
                    for (i = 0; i < a.Length; i++)
                    {
                        outputBin += a[i] * Convert.ToInt32(Math.Pow(10, a.Length - i - 1));
                    }

                }
                return outputBin.ToString();
            }

        }

        public class UpperCase : Actions
        {
            public UpperCase() { }
            public UpperCase(string input) : base(input) { }
            public override string Action(string input)
            {
                string[] words = input.Split(new[] { " " }, StringSplitOptions.None);
                string UpperStr = "";
                int ctr = 0;
                foreach (String s in words)
                {
                    if (s.Length > ctr)
                    {
                        UpperStr = s;
                        ctr = s.Length;
                    }

                }

                return UpperStr;
            }


        }

        public class Reversal : Actions
        {
            public Reversal() { }
            public Reversal(string input) : base(input) { }
            public override string Action(string input)
            {
                char[] arrRevrse = input.ToCharArray();
                string ans = " ";

                if (input is string)
                {
                    for (int i = arrRevrse.Length - 1; i >= 0; i--)
                    {
                        ans += arrRevrse[i];
                    }
                }
                return ans;

            }


        }


            
               











    
}
