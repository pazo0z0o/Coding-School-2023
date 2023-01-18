using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public enum ActionEnum
    {
        Convert,
        Uppercase,
        Reverse
    }
    public class ActionRequest : ActionInBetween
    {
        public Guid RequestID { get; set; }
        public string? Input { get; set; }
    
    public ActionEnum? Action { get; set; }

        public ActionRequest( ) //ActionEnum Action } played with the constructors, comment as a ref point
        {
           //reqID = Guid.NewGuid(); failed workaround to make arction response inherit ActionRequest,
           //while also keeping Guid.NewGuid() in 
            RequestID= Guid.NewGuid();
          
           // Action= actResolve;
        }
        //Methods
        



    }
}
