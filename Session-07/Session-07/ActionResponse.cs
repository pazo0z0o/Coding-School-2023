using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class ActionResponse : ActionRequest
    {
        public Guid ResquestID { get; set; }
        public Guid ResponseID { get; set; }
        public string? Output { get; set; }

        //Constructors
        public ActionResponse() { }
        public ActionResponse(Guid resquestId, Guid responseId, string? output)
        { 
            ResquestID = resquestId; 
            ResponseID= responseId;
            Output = output;
        }
       public ActionResponse(Guid requestId, string input, Action actionEnum) : base(requestId, input, actionEnum)
       { }   
        


        //Methods


    }
}
