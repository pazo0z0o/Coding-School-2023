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
            switch (request.EnumChoice)
            {
                case ActionEnum.Convert:


                    break;
                case ActionEnum.Uppercase:



                    break;
                case ActionEnum.Reverse:


                    break;

                    return response.Output;

            }



        }

    }
}
