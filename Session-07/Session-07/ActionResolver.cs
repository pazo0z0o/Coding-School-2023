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

            Actions acts; //to handle calls from the actions class

            Log("EXECUTION START");
            switch (request.Action)
            {  
                case ActionEnum.Convert:
                    Log("CONVERT");
                    acts = new BinConverter();
                    //BinConverter act = new BinConverter();
                    if (acts.UserInput(request) != null) //tried a virtualisation for a decimal check method
                    {
                        response.Output = acts.Resolution(request.Input);
                    }
                    break;
                case ActionEnum.Uppercase:
                    Log("UPPERCASE");
                    acts = new UpperCase();
                    acts.Resolution(request.Input);
                    break;
                case ActionEnum.Reverse:
                    Log("REVERSE");
                    acts = new Reversal();
                    acts.Resolution(request.Input);
                    break;
             default: 
                Log("Error ActionResolve Switch");
                break; 
            }
            Log("EXECUTION END");
            return response;
        }
        private void Log(string msg)
        {
            Logger.Write(new Message("------------"));
            Message message = new Message(msg);
            Logger.Write(message);
        }





    }
}
