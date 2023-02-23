using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Bridge
{
    public class ShortMessageHandler : AbstractMessageHandler
    {
        public ShortMessageHandler(IMessageSender messageSender)
        {
            //Initialize the super class messageSender variable
            this.messageSender = messageSender;
        }
        public override void SendMessage(Message Message)
        {
            if (Message.Content.Length <= 10)
            {
                messageSender.SendMessage(Message);
            }
            else
            {
                Console.WriteLine("Unable to send the message as length > 10 characters");
            }
        }
    }
}
