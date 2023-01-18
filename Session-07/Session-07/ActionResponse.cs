using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class ActionResponse : ActionInBetween
    {
        public Guid ResquestID { get; set; }
        public Guid ResponseID { get; set; }
        public string? Output { get; set; }

        //Constructors
        public ActionResponse() { }
        public ActionResponse( Guid responseId)
        { 
           // ResquestID = resquestId; 
            ResponseID= Guid.NewGuid();
            //Output = output;
        }
       
        //public ActionResponse(Guid requestId):base( reqID ) { }
        


        //Methods


    }
}
