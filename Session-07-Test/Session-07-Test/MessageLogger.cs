using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07_Test
{
    public class MessageLogger : Message
    {
        public Message[]? Messages { get; set; }

        public MessageLogger(){}
        public MessageLogger(Message[] msg) { Messages = msg; }

        public MessageLogger(DateTime timeSt,string actionMessage) :base(timeSt,actionMessage) { ID = ID; }

        //methods

        public void ReadAll() { }
        public void Clear() { }
        public void Write(string actMessage) { } // apo tin message
    }
}
