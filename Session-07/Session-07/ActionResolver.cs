using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class ActionResolver : ActionResponse
    {
        public MessageLogger? Logger { get; set; }



        //Constructors
        public ActionResolver() { }
        public ActionResolver(MessageLogger? logger) { Logger = logger; }

        public ActionResolver(Guid requestId, Guid responseId,string output): base( requestId,responseId,output) { }



        //Methods
        public ActionResponse Execute(ActionRequest request)
        {








            return null;
        }




    }
}
