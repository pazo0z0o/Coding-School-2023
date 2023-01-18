using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class ActionResolver 
    {
        public MessageLogger? Logger { get; set; }
     
        public ActionResolver() { Logger = new MessageLogger(); }

        //Methods
        public ActionResponse Execute(ActionRequest request)
        {
            ActionResponse response = new ActionResponse();
            response.ResponseID = Guid.NewGuid();
            response.RequestID = request.RequestID;
            
            Actions acts ; //to handle calls from the actions class
            switch (request.Action)
            {
                //Log("EXECUTION START");

                case ActionEnum.Convert:
                    acts = new BinConverter();
                    //BinConverter act = new BinConverter();
                    if (acts.UserInput(request) != null) //tried a virtualisation for a decimal check method
                    {
                        response.Output = acts.Resolution(request.Input);
                    }
                    break;
                case ActionEnum.Uppercase:
                    acts = new UpperCase();
                    acts.Resolution(request.Input);

                    break;
                case ActionEnum.Reverse:
                    acts = new Reversal();
                    acts.Resolution(request.Input);
                    break;
            }
                      return response;
        }




       
    }
}
