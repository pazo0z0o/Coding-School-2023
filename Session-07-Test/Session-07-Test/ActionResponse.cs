using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07_Test
{
    public class ActionResponse
    {
        public Guid RequestID { get; set; }
        public Guid ResponseID { get; set; }
        public string Output { get; set; }  

        public ActionResponse() { }
        public ActionResponse(string outp)
        {
            RequestID = Guid.NewGuid();
            ResponseID = Guid.NewGuid();
            Output= outp;   
        }
        
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
