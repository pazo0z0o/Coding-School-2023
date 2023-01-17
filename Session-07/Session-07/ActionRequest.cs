using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public enum Action
    {
        Convert,
        Uppercase,
        Reverse
    }
    public class ActionRequest
    {
        public Guid RequestID { get; set; }
        public string? Input { get; set; }
    //public ActionEnum Action {get; set;}
    public Action ActionEnum { get; set; }
   
    public ActionRequest() { }
        public ActionRequest(Guid requestId, string input,Action actionEnum)
        {
            RequestID= requestId;
            Input= input;
            ActionEnum= actionEnum;
        }
        //Methods
        public Action RequestAction(Guid RequestId,string Input,Action actionEnum)
        {

            return actionEnum;
        }



    }
}
