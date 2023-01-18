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

        //Constructors
        public ActionResolver() { }
        public ActionResolver(MessageLogger? logger) { Logger = logger; }

       

        //Methods
        public ActionResponse Execute(ActionRequest request)
        {   
            switch (request.Action)
            {
                case Action.Convert:
                    BinConverter act = new BinConverter();
                   //act.Action(Input);
                    response = act.Action(Input);
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