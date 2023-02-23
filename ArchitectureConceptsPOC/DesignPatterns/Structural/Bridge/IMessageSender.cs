using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Bridge
{
    public interface IMessageSender
    {
        void SendMessage(Message message);
    }
}
