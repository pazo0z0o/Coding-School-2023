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

        public ActionResolver(Guid requestId, Guid responseId, string output) : base(requestId, responseId, output) { }

        //Actions act = new Actions();

        //Methods
        public ActionResponse Execute(ActionRequest request)
        {   ActionResponse response = null;
            switch (ActionEnum)
            {
                case Action.Convert:
                    BinConverter act = new BinConverter();
                   act.Action(Input);
                    break;
                case Action.Uppercase:
                    UpperCase act1= new UpperCase();
                    act1.Action(Input);

                    break;
                case Action.Reverse:
                    Reversal act2 = new Reversal();
                    act2.Action(Input);
                    break;
                
                   

                   return response;
            }




        }
    }
}