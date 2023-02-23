using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Bridge
{
    public abstract class AbstractMessageHandler
    {
        protected IMessageSender messageSender;
        public abstract void SendMessage(Message Message);
    }
}
