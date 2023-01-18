using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Session_07_Test
{
    public class Actions
    {
        public string? Input { get; set; }
        public string? Output { get; set; }

        public Actions() { }
        public Actions(string actInput)
        {
            Input = actInput;
        }
        public virtual string Action(string Input)
        {
            Console.WriteLine("The input String is : " + Input);

            return Output;
        }

        public virtual decimal UserInput(ActionRequest request)
        {
            decimal num = 0;

            return num;
        }
    }
        public class BinConverter : Actions
        {
            public BinConverter() { }
            public BinConverter(string input) : base(input) { }

            public override decimal UserInput(ActionRequest request)
            {
                decimal number;
                bool flag = false;
                do
                {
                    if (Decimal.TryParse(request.EnumChoice.ToString(), out number)) flag = true;
                    else Console.WriteLine("Decimal number not given,try again!");
                } while (!true);
                return number;
            }

            public override string Action(string input)
            {

                return Convert.ToString(int.Parse(input), 2);
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

