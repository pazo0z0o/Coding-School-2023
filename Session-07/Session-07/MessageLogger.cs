using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public  class MessageLogger : ActionResolver
    {
      public Message[]? Messages { get; set; }

        public MessageLogger() { }
        public MessageLogger(Message[] message) { Messages = message; }

        //
        //Constructors

        //Methods
        public void ReadAll() 
        {
            foreach  (Message mes in Messages )
            {
                Console.WriteLine(mes);
            }
        
        
        
        
        }


        public void Clear()
        {
            Console.Clear();
        
        }


        public void Write( string Message) 
        { 
        
        
        }



    }
}
