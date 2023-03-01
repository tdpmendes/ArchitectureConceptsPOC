using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureConceptsPOC.DesignPatterns.Behavioral.Observer
{
    public class SalvadorDeMensagem : ISubscriber<BaseMessage>
    {
        public void Update(BaseMessage context)
        {
            var v = context as Message;
            Console.WriteLine($"Salvador de mensagem salvando Nome: {v.Nome} | Idade {v.Idade}");
        }
    }
}
