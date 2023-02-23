using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Bridge
{
    public class LongMessageHandler : AbstractMessageHandler
    {
        public LongMessageHandler(IMessageSender messageSendor)
        {
            this.messageSender = messageSendor;
        }
        public override void SendMessage(Message Message)
        {
            messageSender.SendMessage(Message);
        }
    }
}
