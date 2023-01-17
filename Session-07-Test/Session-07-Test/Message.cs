using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07_Test
{
    public class Message
    {
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? actMessage { get; set; }


        public Message() { }
        public Message(DateTime timeSt,string actionMessage) 
        {   ID = Guid.NewGuid();
            TimeStamp= timeSt;
            actMessage = actionMessage;
        }






















    }
}
