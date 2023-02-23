﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Structural.Bridge
{
    public class SMSMessageSender : IMessageSender
    {
        public void SendMessage(Message message)
        {
            Console.WriteLine("SMSMessage Sender is sending Message: ");
            Console.WriteLine($"Title: {message.Title} | Content: {message.Content}");
            Console.WriteLine("Sending Complete!");
        }
    }
}
