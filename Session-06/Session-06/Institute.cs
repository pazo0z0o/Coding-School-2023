using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Institute
    {
       public Guid ID { get; set; }
       public string Name { get; set; }
       public int YearsInService { get; set; }

        //could I make a connection to class Person and use these ones?
        public void GetName() { }
        public void SetName() { }

    }
}
