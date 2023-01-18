using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07_Test
{
    public class ActionResolver
    {
        public MessageLogger? Logger { get; set; }
        // CTOR
        public ActionResolver(MessageLogger log) { Logger = log; }
        public ActionResolver() { }



        // METHODS
        public ActionResponse Execute(ActionRequest request) //
        {
            Actions act;
            ActionResponse resp = new ActionResponse();
            resp.ResponseID = Guid.NewGuid();
            resp.ResponseID = request.RequestID;
            
            //Message message = new Message();
            //message.Text = "Execution Start";
            //message.TimeStamp 
            //MessageLogger logger = new MessageLogger();
               // Logger.Messages[0] = message;
            //Logger logger.Write
            //

            switch (request.EnumChoice)
            {      case ActionEnum.Convert:
                    //UserInputConvert()
                    
                    act = new BinConverter(request.Input);
                    resp.Output = act.Action(act.Input);
                    break;
                case ActionEnum.Uppercase:
                    act = new UpperCase(request.Input);
                    resp.Output = act.Action(act.Input);
                    
                    break;
                case ActionEnum.Reverse:
                    act = new Reversal(request.Input);
                    resp.Output = act.Action(act.Input);
                    
                    break;
                default:
                    Console.WriteLine("No valid action to be taken");
                    break;

            }


            return resp;
        }

    }
}
