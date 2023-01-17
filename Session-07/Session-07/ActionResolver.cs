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

        Actions act = new Actions();

        //Methods
        public ActionResponse Execute(ActionRequest request)
        {
            switch (ActionEnum)
            {
                case Action.Convert:
                    act.Converter(Input);
                    break;
                case Action.Uppercase:
                    act.UpperCase(Input);

                    break;
                case Action.Reverse:
                    act.Reversal(Input);
                    break;
                default:
                   

                   return null;
            }




        }
    }
}