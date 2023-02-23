using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Bridge
{
    public class EmailMessageSender : IMessageSender
    {
        public void SendMessage(Message message)
        {
            Console.WriteLine("EmailMessage Sender is sending Message: ");
            Console.WriteLine($"Title: {message.Title} | Content: {message.Content}");
            Console.WriteLine("Sending Complete!");
        }
    }
}
