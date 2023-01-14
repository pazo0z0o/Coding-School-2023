using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ExOne
    {
        public string strReversal()
        {

            string name = "Kosmas Stamos";
            char[] arrRevrse = name.ToCharArray();

            string ans = null;
    
            for(int i=arrRevrse.Length-1;i>=0; i--)
            {
                ans += arrRevrse[i];
            }

        return ans;
        }
    }
}
